using System.Data;
using AmbulanceDispatcherApp.Forms.Patient;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms
{
    public partial class CreateReportForm : Form
    {
        int? SelectedCalloutID;
        int? SelectedPatientID;

        public CreateReportForm()
        {
            InitializeComponent();

            foreach (var dt in tab_dispatcher_stats.Controls.OfType<DateTimePicker>())
                dt.MaxDate = DateTime.Now;

            datetime_dispatcher_stats_to.Value = datetime_dispatcher_stats_to.MaxDate;

            combo_report_type.SelectedIndex = 0;
            tabControl1.SelectedTab = tab_callout;
        }

        private void spin_callout_ValueChanged(object sender, EventArgs e)
        {
            string? ret = new MySqlCommand($"SELECT (CASE WHEN Count(`callout_id`) = 1 THEN CONCAT('Виклик №', `callout_id`, ' о ', `callout_time_created`, ' по адресі ', `callout_address`, ' за причиною \"', `callout_reason`, '\"') ELSE 'none' END) AS `short_info` FROM `callout` WHERE `callout_id` = {(int)spin_callout.Value}", Program.SqlConnection).ExecuteScalar() as string;
            if (ret == "none")
            {
                SelectedCalloutID = -1;
                label_selected_callout.Text = $"<виклику №{(int)spin_callout.Value} не існує>";
                button_ok.Enabled = false;
            }
            else
            {
                SelectedCalloutID = (int)spin_callout.Value;
                label_selected_callout.Text = ret;
                button_ok.Enabled = true;
            }
        }

        private void button_select_patient_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm(FormMode.Select);
            if (patientsForm.ShowDialog() != DialogResult.OK)
                return;

            SelectedPatientID = patientsForm.SelectedPatientID;

            if (SelectedPatientID == -1 || SelectedPatientID == null)
                label_patient_short_info.Text = "<не обрано жодного пацієнта>";
            else
            {
                var cmd = new MySqlCommand($"SELECT CONCAT(`patient`.`patient_surname`, ' ', `patient`.`patient_name`, ' ', `patient`.`patient_patriarchic`, '\\n','Кількість дзвінків: ', (select COUNT(`call_id`) from `patient` left join `patientcall` on `patient`.`patient_id`=`patientcall`.`patient_id` WHERE `patient`.`patient_id` = @pid), '\\n','Кількість викликів: ', ((select COUNT(`callout_id`) from `patient` left join `patientcallout` on `patient`.`patient_id`=`patientcallout`.`patient_id` WHERE `patient`.`patient_id` = @pid))) FROM `patient` WHERE `patient`.`patient_id` = @pid", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@pid", SelectedPatientID);
                var ret = (cmd.ExecuteScalar() as string)!.Split("\n", StringSplitOptions.TrimEntries);

                textbox_selected_patient.Text = ret[0];
                label_patient_short_info.Text = String.Join("\n", ret[1], ret[2]);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_dispatcher_stats)
            {
                DataTable dispatcherStats = new DataTable();
                var cmd = new MySqlCommand("SELECT CONCAT( d.`dispatcher_surname`, ' ', d.`dispatcher_name`, ' ', d.`dispatcher_patriarchic`) as dispatcher_fullname, count(c.`call_id`) as calls_processed, c.`call_channel` FROM `dispatcher` d left join `call` c on d.`dispatcher_id`=c.`dispatcher_id` and c.`call_time_created` between @ctc_min and @ctc_max group by d.`dispatcher_id`, c.`call_channel` union select CONCAT( d.`dispatcher_surname`, ' ', d.`dispatcher_name`, ' ', d.`dispatcher_patriarchic` ) as dispatcher_fullname, count(c.`call_id`) as calls_processed, 'Total' as call_channel from `dispatcher` d left join `call` c on d.`dispatcher_id`=c.`dispatcher_id` and c.`call_time_created` between @ctc_min and @ctc_max group by d.`dispatcher_id`", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@ctc_min", datetime_dispatcher_stats_from.Value);
                cmd.Parameters.AddWithValue("@ctc_max", datetime_dispatcher_stats_to.Value);
                new MySqlDataAdapter(cmd).Fill(dispatcherStats);
                var groupedDispatcherStats = dispatcherStats.AsEnumerable()
                    .GroupBy(r => r.Field<string>("dispatcher_fullname"));

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Звіт по диспетчерах.pdf";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                var distinctChannels = new List<string>();
                foreach (DataRow row in dispatcherStats.Rows)
                    if (!distinctChannels.Contains((row["call_channel"] as string)!))
                        distinctChannels.Add((row["call_channel"] as string)!);

                var channels = distinctChannels.Where(c => !string.IsNullOrEmpty(c)).ToList();

                using (PdfWriter writer = new PdfWriter(sfd.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);
                        var font = PdfFontFactory.CreateFont(
                            @"C:\Windows\Fonts\times.ttf",
                            PdfEncodings.IDENTITY_H,
                            PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED
                        );
                        document.SetFont(font);
                        document.SetFontSize(14);
                        document.Add(new iText.Layout.Element.Paragraph("Виписка по диспетчерах").SimulateBold().SetTextAlignment(TextAlignment.CENTER));
                        document.Add(new iText.Layout.Element.Paragraph("Нижче наведено таблицю з диспетчерами та їх відповідними дзвінками"));
                        document.Add(new iText.Layout.Element.Paragraph("Обраний часовий період:"));
                        document.Add(new iText.Layout.Element.Paragraph($"з {datetime_dispatcher_stats_from.Value.ToString()}"));
                        document.Add(new iText.Layout.Element.Paragraph($"по {datetime_dispatcher_stats_to.Value.ToString()}"));
                        var col_widths = new List<float>();
                        for (int i = 0; i < channels.Count + 1; ++i)
                            col_widths.Add(1.0f);

                        var pdftable = new iText.Layout.Element.Table(col_widths.ToArray(), false);

                        pdftable.AddHeaderCell(new iText.Layout.Element.Cell().Add(
                                new iText.Layout.Element.Paragraph("Диспетчер")
                                ));
                        foreach (string distinctChannel in channels)
                        {
                            if (distinctChannel != null)
                                pdftable.AddHeaderCell(new iText.Layout.Element.Cell().Add(
                                    new iText.Layout.Element.Paragraph(distinctChannel == "Total" ? "Всього" : distinctChannel)
                                ));
                        }

                        foreach (var dispatcherGroup in groupedDispatcherStats)
                        {
                            pdftable.AddCell(new Cell().Add(new Paragraph(dispatcherGroup.Key)));

                            var channelMap = dispatcherGroup
                                .Where(r => !r.IsNull("call_channel"))
                                .ToDictionary(
                                r => r.Field<string>("call_channel"),
                                r => r.Field<Int64>("calls_processed")
                            );

                            foreach (var channel in channels)
                            {
                                int value = (int)(channelMap.TryGetValue(channel, out var v) ? v : 0);
                                pdftable.AddCell(new Cell()
                                    .Add(new Paragraph(value.ToString())));
                            }
                        }

                        document.Add(pdftable);
                        document.Add(new iText.Layout.Element.Paragraph($"Створено програмно {DateTime.Today.ToString()}"));
                        document.Close();
                    }
                }
            }
            else if (tabControl1.SelectedTab == tab_callout)
            {
                DataTable calloutInfo = new DataTable();
                var cmd = new MySqlCommand(
                        @"SELECT c.callout_id, c.callout_address, c.callout_reason, c.callout_time_created,
                        CONCAT(p.patient_surname,' ',p.patient_name,' ',p.patient_patriarchic) AS patient_fullname
                        FROM callout c
                        LEFT JOIN patientcallout pc ON pc.callout_id = c.callout_id
                        LEFT JOIN patient p ON p.patient_id = pc.patient_id
                        WHERE c.callout_id = @id",
                    Program.SqlConnection);

                cmd.Parameters.AddWithValue("@id", SelectedCalloutID);
                new MySqlDataAdapter(cmd).Fill(calloutInfo);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = $"Звіт по виклику №{SelectedCalloutID}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using var writer = new PdfWriter(sfd.FileName);
                using var pdf = new PdfDocument(writer);
                var document = new Document(pdf);

                var font = PdfFontFactory.CreateFont(
                    @"C:\Windows\Fonts\times.ttf",
                    PdfEncodings.IDENTITY_H,
                    PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
                document.SetFont(font);

                var firstRow = calloutInfo.Rows[0];

                document.Add(new Paragraph("Інформація про виклик")
                    .SimulateBold()
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph($"Номер виклику: {firstRow["callout_id"]}"));
                document.Add(new Paragraph($"Адреса: {firstRow["callout_address"]}"));
                document.Add(new Paragraph($"Причина: {firstRow["callout_reason"]}"));
                document.Add(new Paragraph($"Час створення: {firstRow["callout_time_created"]}"));

                document.Add(new Paragraph("Пацієнти:")
                    .SimulateBold());

                var patients = calloutInfo.AsEnumerable()
                    .Where(r => !r.IsNull("patient_fullname"))
                    .Select(r => r.Field<string>("patient_fullname"))
                    .Distinct()
                    .ToList();

                if (patients.Count == 0)
                {
                    document.Add(new Paragraph("— пацієнтів не зафіксовано —"));
                }
                else
                {
                    foreach (var p in patients)
                        document.Add(new Paragraph($"• {p}"));
                }

                document.Add(new Paragraph($"Створено програмно {DateTime.Now:d}"));
                document.Close();

            }
            else if (tabControl1.SelectedTab == tab_patient)
            {
                DataTable patientInfo = new DataTable();
                var cmd = new MySqlCommand(
                    @"SELECT 
                        p.patient_id,
                        p.patient_surname,
                        p.patient_name,
                        p.patient_patriarchic,
                        p.patient_tel,
                        p.patient_dob,
                        p.patient_sex,
                        c.call_id,
                        c.call_time_created,
                        c.call_channel,
                        c.call_reason as call_reason,
                        co.callout_id,
                        co.callout_address,
                        co.callout_reason AS callout_reason,
                        co.callout_time_created
                    FROM patient p
                    LEFT JOIN patientcall pc ON pc.patient_id = p.patient_id
                    LEFT JOIN `call` c ON c.call_id = pc.call_id
                    LEFT JOIN callout co ON co.callout_id = c.callout_id
                    WHERE p.patient_id = @pid
                    ORDER BY c.call_time_created, co.callout_time_created",
                    Program.SqlConnection);

                cmd.Parameters.AddWithValue("@pid", SelectedPatientID);
                new MySqlDataAdapter(cmd).Fill(patientInfo);
                var firstRow = patientInfo.Rows[0];

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = $"Звіт по пацієнту {firstRow["patient_surname"] as string} {firstRow["patient_name"] as string} {firstRow["patient_patriarchic"] as string}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using var writer = new PdfWriter(sfd.FileName);
                using var pdf = new PdfDocument(writer);
                var document = new Document(pdf);

                var font = PdfFontFactory.CreateFont(
                    @"C:\Windows\Fonts\times.ttf",
                    PdfEncodings.IDENTITY_H,
                    PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                document.SetFont(font);

                document.Add(new Paragraph("Звіт по пацієнту").SimulateBold().SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph($"ПІБ: {firstRow["patient_surname"]} {firstRow["patient_name"]} {firstRow["patient_patriarchic"]}"));
                document.Add(new Paragraph($"Телефон: {firstRow["patient_tel"]}"));
                document.Add(new Paragraph($"Дата народження: {(firstRow["patient_dob"] as DateTime?)!.Value.ToString("dd/MM/yyyy")}"));
                document.Add(new Paragraph($"Стать: {firstRow["patient_sex"]}"));

                document.Add(new Paragraph("Пов'язані дзвінки")
                    .SimulateBold());

                var calls = patientInfo.AsEnumerable()
                    .Where(r => !r.IsNull("call_id"))
                    .Select(r => new
                    {
                        ID = r.Field<int>("call_id"),
                        Time = r.Field<string>("call_time_created"),
                        Channel = r.Field<string>("call_channel"),
                        Reason = r.Field<string>("call_reason")
                    })
                    .Distinct()
                    .ToList();

                if (calls.Count == 0)
                    document.Add(new Paragraph("<дзвінків не зафіксовано>"));
                else
                {
                    foreach (var c in calls)
                        document.Add(new Paragraph($"№{c.ID}: {c.Time}, Канал: {c.Channel}, Причина: {c.Reason}"));
                }

                document.Add(new Paragraph("Пов'язані виклики (callouts)")
                    .SimulateBold());

                var callouts = patientInfo.AsEnumerable()
                    .Where(r => !r.IsNull("callout_id"))
                    .Select(r => new
                    {
                        ID = r.Field<int>("callout_id"),
                        Address = r.Field<string>("callout_address"),
                        Reason = r.Field<string>("callout_reason"),
                        Time = r.Field<DateTime>("callout_time_created")
                    })
                    .Distinct()
                    .ToList();

                if (callouts.Count == 0)
                    document.Add(new Paragraph("<викликів не зафіксовано>"));
                else
                {
                    foreach (var co in callouts)
                        document.Add(new Paragraph($"№{co.ID}: {co.Time}, Адреса: {co.Address}, Причина: {co.Reason}"));
                }

                document.Add(new Paragraph($"Створено програмно {DateTime.Now:d}"));
                document.Close();
            }
        }

        private void combo_report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_report_type.Text.ToLower() == "виписка про виклик")
            {
                tabControl1.SelectedTab = tab_callout;
            }
            else if(combo_report_type.Text.ToLower() == "виписка по пацієнту")
            {
                tabControl1.SelectedTab = tab_patient;
            }
            else if(combo_report_type.Text.ToLower() == "статистика диспетчерів")
            {
                tabControl1.SelectedTab = tab_dispatcher_stats;
            }
        }
    }
}
