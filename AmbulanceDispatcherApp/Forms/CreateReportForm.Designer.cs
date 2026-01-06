namespace AmbulanceDispatcherApp.Forms
{
    partial class CreateReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            combo_report_type = new ComboBox();
            tabControl1 = new TabControl();
            tab_callout = new TabPage();
            label_selected_callout = new Label();
            label11 = new Label();
            spin_callout = new NumericUpDown();
            label7 = new Label();
            tab_patient = new TabPage();
            label_patient_short_info = new Label();
            textbox_selected_patient = new TextBox();
            button_select_patient = new Button();
            label2 = new Label();
            tab_dispatcher_stats = new TabPage();
            label4 = new Label();
            datetime_dispatcher_stats_to = new DateTimePicker();
            label12 = new Label();
            label3 = new Label();
            datetime_dispatcher_stats_from = new DateTimePicker();
            button_ok = new Button();
            button_cancel = new Button();
            tabControl1.SuspendLayout();
            tab_callout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spin_callout).BeginInit();
            tab_patient.SuspendLayout();
            tab_dispatcher_stats.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Тип звіту";
            // 
            // combo_report_type
            // 
            combo_report_type.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_report_type.FormattingEnabled = true;
            combo_report_type.Items.AddRange(new object[] { "Виписка про виклик", "Виписка по пацієнту", "Статистика диспетчерів" });
            combo_report_type.Location = new Point(92, 12);
            combo_report_type.Name = "combo_report_type";
            combo_report_type.Size = new Size(296, 29);
            combo_report_type.TabIndex = 1;
            combo_report_type.SelectedIndexChanged += combo_report_type_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_callout);
            tabControl1.Controls.Add(tab_patient);
            tabControl1.Controls.Add(tab_dispatcher_stats);
            tabControl1.ItemSize = new Size(1, 1);
            tabControl1.Location = new Point(12, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(376, 215);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tab_callout
            // 
            tab_callout.Controls.Add(label_selected_callout);
            tab_callout.Controls.Add(label11);
            tab_callout.Controls.Add(spin_callout);
            tab_callout.Controls.Add(label7);
            tab_callout.Location = new Point(4, 5);
            tab_callout.Name = "tab_callout";
            tab_callout.Padding = new Padding(3);
            tab_callout.Size = new Size(368, 206);
            tab_callout.TabIndex = 0;
            tab_callout.Text = "tabPage1";
            tab_callout.UseVisualStyleBackColor = true;
            // 
            // label_selected_callout
            // 
            label_selected_callout.AutoSize = true;
            label_selected_callout.Location = new Point(8, 87);
            label_selected_callout.MaximumSize = new Size(350, 0);
            label_selected_callout.Name = "label_selected_callout";
            label_selected_callout.Size = new Size(235, 21);
            label_selected_callout.TabIndex = 100;
            label_selected_callout.Text = "<не обрано жодного виклику>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 12);
            label11.Name = "label11";
            label11.Size = new Size(210, 21);
            label11.TabIndex = 99;
            label11.Text = "Оберіть необхідний виклик:";
            // 
            // spin_callout
            // 
            spin_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout.Location = new Point(106, 45);
            spin_callout.Name = "spin_callout";
            spin_callout.Size = new Size(256, 29);
            spin_callout.TabIndex = 98;
            spin_callout.ValueChanged += spin_callout_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 47);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 97;
            label7.Text = "№ Виклику";
            // 
            // tab_patient
            // 
            tab_patient.Controls.Add(label_patient_short_info);
            tab_patient.Controls.Add(textbox_selected_patient);
            tab_patient.Controls.Add(button_select_patient);
            tab_patient.Controls.Add(label2);
            tab_patient.Location = new Point(4, 5);
            tab_patient.Name = "tab_patient";
            tab_patient.Padding = new Padding(3);
            tab_patient.Size = new Size(368, 206);
            tab_patient.TabIndex = 1;
            tab_patient.Text = "tabPage2";
            tab_patient.UseVisualStyleBackColor = true;
            // 
            // label_patient_short_info
            // 
            label_patient_short_info.AutoSize = true;
            label_patient_short_info.Location = new Point(8, 87);
            label_patient_short_info.MaximumSize = new Size(350, 0);
            label_patient_short_info.Name = "label_patient_short_info";
            label_patient_short_info.Size = new Size(239, 21);
            label_patient_short_info.TabIndex = 103;
            label_patient_short_info.Text = "<не обрано жодного пацієнта>";
            // 
            // textbox_selected_patient
            // 
            textbox_selected_patient.Location = new Point(8, 37);
            textbox_selected_patient.Name = "textbox_selected_patient";
            textbox_selected_patient.ReadOnly = true;
            textbox_selected_patient.Size = new Size(228, 29);
            textbox_selected_patient.TabIndex = 102;
            // 
            // button_select_patient
            // 
            button_select_patient.Image = Properties.Resources._211861_16x16;
            button_select_patient.ImageAlign = ContentAlignment.MiddleLeft;
            button_select_patient.Location = new Point(242, 36);
            button_select_patient.Name = "button_select_patient";
            button_select_patient.Size = new Size(120, 29);
            button_select_patient.TabIndex = 101;
            button_select_patient.Text = "Обрати";
            button_select_patient.UseVisualStyleBackColor = true;
            button_select_patient.Click += button_select_patient_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(228, 21);
            label2.TabIndex = 100;
            label2.Text = "Оберіть необхідного пацієнта:";
            // 
            // tab_dispatcher_stats
            // 
            tab_dispatcher_stats.Controls.Add(label4);
            tab_dispatcher_stats.Controls.Add(datetime_dispatcher_stats_to);
            tab_dispatcher_stats.Controls.Add(label12);
            tab_dispatcher_stats.Controls.Add(label3);
            tab_dispatcher_stats.Controls.Add(datetime_dispatcher_stats_from);
            tab_dispatcher_stats.Location = new Point(4, 5);
            tab_dispatcher_stats.Name = "tab_dispatcher_stats";
            tab_dispatcher_stats.Size = new Size(368, 206);
            tab_dispatcher_stats.TabIndex = 2;
            tab_dispatcher_stats.Text = "tabPage1";
            tab_dispatcher_stats.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 128;
            label4.Text = "Рахувати дзвінки";
            // 
            // datetime_dispatcher_stats_to
            // 
            datetime_dispatcher_stats_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_dispatcher_stats_to.CalendarForeColor = Color.Black;
            datetime_dispatcher_stats_to.CalendarMonthBackground = Color.Black;
            datetime_dispatcher_stats_to.CalendarTitleBackColor = Color.Black;
            datetime_dispatcher_stats_to.CalendarTitleForeColor = Color.Black;
            datetime_dispatcher_stats_to.CalendarTrailingForeColor = Color.Black;
            datetime_dispatcher_stats_to.CustomFormat = "yyyy-MM-dd";
            datetime_dispatcher_stats_to.Format = DateTimePickerFormat.Custom;
            datetime_dispatcher_stats_to.Location = new Point(51, 79);
            datetime_dispatcher_stats_to.Margin = new Padding(1, 2, 1, 2);
            datetime_dispatcher_stats_to.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dispatcher_stats_to.Name = "datetime_dispatcher_stats_to";
            datetime_dispatcher_stats_to.Size = new Size(290, 29);
            datetime_dispatcher_stats_to.TabIndex = 127;
            datetime_dispatcher_stats_to.Value = new DateTime(9988, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 82);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 126;
            label12.Text = "до";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 125;
            label3.Text = "від";
            // 
            // datetime_dispatcher_stats_from
            // 
            datetime_dispatcher_stats_from.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_dispatcher_stats_from.CalendarForeColor = Color.Black;
            datetime_dispatcher_stats_from.CalendarMonthBackground = Color.Black;
            datetime_dispatcher_stats_from.CalendarTitleBackColor = Color.Black;
            datetime_dispatcher_stats_from.CalendarTitleForeColor = Color.Black;
            datetime_dispatcher_stats_from.CalendarTrailingForeColor = Color.Black;
            datetime_dispatcher_stats_from.CustomFormat = "yyyy-MM-dd";
            datetime_dispatcher_stats_from.Format = DateTimePickerFormat.Custom;
            datetime_dispatcher_stats_from.Location = new Point(51, 46);
            datetime_dispatcher_stats_from.Margin = new Padding(1, 2, 1, 2);
            datetime_dispatcher_stats_from.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dispatcher_stats_from.Name = "datetime_dispatcher_stats_from";
            datetime_dispatcher_stats_from.Size = new Size(290, 29);
            datetime_dispatcher_stats_from.TabIndex = 124;
            datetime_dispatcher_stats_from.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom;
            button_ok.Image = Properties.Resources._212394_16x16;
            button_ok.ImageAlign = ContentAlignment.MiddleLeft;
            button_ok.Location = new Point(203, 281);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(139, 41);
            button_ok.TabIndex = 3;
            button_ok.Text = "    Створити звіт";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(58, 281);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(139, 41);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "    Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // CreateReportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 334);
            Controls.Add(button_cancel);
            Controls.Add(button_ok);
            Controls.Add(tabControl1);
            Controls.Add(combo_report_type);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateReportForm";
            Text = "Створити звіт";
            tabControl1.ResumeLayout(false);
            tab_callout.ResumeLayout(false);
            tab_callout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spin_callout).EndInit();
            tab_patient.ResumeLayout(false);
            tab_patient.PerformLayout();
            tab_dispatcher_stats.ResumeLayout(false);
            tab_dispatcher_stats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox combo_report_type;
        private TabControl tabControl1;
        private TabPage tab_callout;
        private TabPage tab_patient;
        private Button button_ok;
        private Button button_cancel;
        private Label label_selected_callout;
        private Label label11;
        private NumericUpDown spin_callout;
        private Label label7;
        private TextBox textbox_selected_patient;
        private Button button_select_patient;
        private Label label2;
        private Label label_patient_short_info;
        private TabPage tab_dispatcher_stats;
        private Label label4;
        private DateTimePicker datetime_dispatcher_stats_to;
        private Label label12;
        private Label label3;
        private DateTimePicker datetime_dispatcher_stats_from;
    }
}