namespace AmbulanceDispatcherApp
{
    partial class CreateCallForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textbox_surname = new TextBox();
            textbox_name = new TextBox();
            textbox_patriarchic = new TextBox();
            textbox_tel = new TextBox();
            textbox_channel = new TextBox();
            textbox_address = new TextBox();
            textbox_reason = new TextBox();
            spin_callout = new NumericUpDown();
            combo_dispatcher = new ComboBox();
            datetime_time_created = new DateTimePicker();
            button_save = new Button();
            button_cancel = new Button();
            group_patients = new GroupBox();
            datagridview_patient = new DataGridView();
            column_patient_fullname = new DataGridViewTextBoxColumn();
            column_patient_tel = new DataGridViewTextBoxColumn();
            column_patient_dob = new DataGridViewTextBoxColumn();
            column_patient_sex = new DataGridViewTextBoxColumn();
            button_patient_remove = new Button();
            button_patient_add = new Button();
            ((System.ComponentModel.ISupportInitialize)spin_callout).BeginInit();
            group_patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Час дзвінка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Диспетчер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 3;
            label4.Text = "По батькові";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 158);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 4;
            label5.Text = "Ім'я";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 126);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 5;
            label6.Text = "Прізвище";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 92);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 6;
            label7.Text = "№ виклику";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 258);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 7;
            label8.Text = "Адреса";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 291);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 8;
            label9.Text = "Привід";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1, 324);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 21);
            label10.TabIndex = 9;
            label10.Text = "Канал зв'язку";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(115, 124);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(622, 29);
            textbox_surname.TabIndex = 4;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(115, 157);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(622, 29);
            textbox_name.TabIndex = 5;
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(115, 190);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(622, 29);
            textbox_patriarchic.TabIndex = 6;
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(115, 223);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.PlaceholderText = "+380XXXXXXXXX";
            textbox_tel.Size = new Size(622, 29);
            textbox_tel.TabIndex = 7;
            // 
            // textbox_channel
            // 
            textbox_channel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_channel.Location = new Point(115, 322);
            textbox_channel.Margin = new Padding(1, 2, 1, 2);
            textbox_channel.Name = "textbox_channel";
            textbox_channel.PlaceholderText = "103";
            textbox_channel.Size = new Size(622, 29);
            textbox_channel.TabIndex = 10;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(115, 256);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.Size = new Size(622, 29);
            textbox_address.TabIndex = 8;
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(115, 289);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(622, 29);
            textbox_reason.TabIndex = 9;
            // 
            // spin_callout
            // 
            spin_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout.Location = new Point(115, 91);
            spin_callout.Margin = new Padding(1, 2, 1, 2);
            spin_callout.Name = "spin_callout";
            spin_callout.Size = new Size(620, 29);
            spin_callout.TabIndex = 3;
            // 
            // combo_dispatcher
            // 
            combo_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_dispatcher.FormattingEnabled = true;
            combo_dispatcher.Location = new Point(115, 58);
            combo_dispatcher.Margin = new Padding(1, 2, 1, 2);
            combo_dispatcher.Name = "combo_dispatcher";
            combo_dispatcher.Size = new Size(622, 29);
            combo_dispatcher.TabIndex = 2;
            // 
            // datetime_time_created
            // 
            datetime_time_created.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created.CalendarForeColor = Color.Black;
            datetime_time_created.CalendarMonthBackground = Color.Black;
            datetime_time_created.CalendarTitleBackColor = Color.Black;
            datetime_time_created.CalendarTitleForeColor = Color.Black;
            datetime_time_created.CalendarTrailingForeColor = Color.Black;
            datetime_time_created.CustomFormat = "yyyy-MM-dd HH:mm:ss\n";
            datetime_time_created.Format = DateTimePickerFormat.Custom;
            datetime_time_created.Location = new Point(115, 25);
            datetime_time_created.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            datetime_time_created.Name = "datetime_time_created";
            datetime_time_created.Size = new Size(622, 29);
            datetime_time_created.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(380, 697);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 32);
            button_save.TabIndex = 12;
            button_save.Text = "Створити";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(254, 697);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 32);
            button_cancel.TabIndex = 11;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // group_patients
            // 
            group_patients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_patients.Controls.Add(datagridview_patient);
            group_patients.Controls.Add(button_patient_remove);
            group_patients.Controls.Add(button_patient_add);
            group_patients.Location = new Point(12, 371);
            group_patients.Name = "group_patients";
            group_patients.Size = new Size(735, 306);
            group_patients.TabIndex = 102;
            group_patients.TabStop = false;
            group_patients.Text = "Пацієнти";
            // 
            // datagridview_patient
            // 
            datagridview_patient.AllowUserToAddRows = false;
            datagridview_patient.AllowUserToDeleteRows = false;
            datagridview_patient.AllowUserToResizeRows = false;
            datagridview_patient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_patient.Columns.AddRange(new DataGridViewColumn[] { column_patient_fullname, column_patient_tel, column_patient_dob, column_patient_sex });
            datagridview_patient.Location = new Point(7, 28);
            datagridview_patient.MultiSelect = false;
            datagridview_patient.Name = "datagridview_patient";
            datagridview_patient.ReadOnly = true;
            datagridview_patient.RowHeadersVisible = false;
            datagridview_patient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_patient.Size = new Size(660, 272);
            datagridview_patient.TabIndex = 100;
            // 
            // column_patient_fullname
            // 
            column_patient_fullname.DataPropertyName = "patient_fullname";
            column_patient_fullname.HeaderText = "ПІБ";
            column_patient_fullname.Name = "column_patient_fullname";
            column_patient_fullname.ReadOnly = true;
            column_patient_fullname.Width = 57;
            // 
            // column_patient_tel
            // 
            column_patient_tel.DataPropertyName = "patient_tel";
            column_patient_tel.HeaderText = "Телефон";
            column_patient_tel.Name = "column_patient_tel";
            column_patient_tel.ReadOnly = true;
            column_patient_tel.Width = 94;
            // 
            // column_patient_dob
            // 
            column_patient_dob.DataPropertyName = "patient_dob";
            column_patient_dob.HeaderText = "Дата народження";
            column_patient_dob.Name = "column_patient_dob";
            column_patient_dob.ReadOnly = true;
            column_patient_dob.Width = 147;
            // 
            // column_patient_sex
            // 
            column_patient_sex.DataPropertyName = "patient_sex";
            column_patient_sex.HeaderText = "Стать";
            column_patient_sex.Name = "column_patient_sex";
            column_patient_sex.ReadOnly = true;
            column_patient_sex.Width = 73;
            // 
            // button_patient_remove
            // 
            button_patient_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patient_remove.Image = Properties.Resources._212377_32x32;
            button_patient_remove.Location = new Point(676, 93);
            button_patient_remove.Margin = new Padding(1, 2, 1, 2);
            button_patient_remove.Name = "button_patient_remove";
            button_patient_remove.Size = new Size(52, 61);
            button_patient_remove.TabIndex = 99;
            button_patient_remove.UseVisualStyleBackColor = true;
            button_patient_remove.Click += button_patient_remove_Click;
            // 
            // button_patient_add
            // 
            button_patient_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patient_add.Image = Properties.Resources._212376_32x32;
            button_patient_add.Location = new Point(676, 28);
            button_patient_add.Margin = new Padding(1, 2, 1, 2);
            button_patient_add.Name = "button_patient_add";
            button_patient_add.Size = new Size(52, 61);
            button_patient_add.TabIndex = 98;
            button_patient_add.UseVisualStyleBackColor = true;
            button_patient_add.Click += button_patient_add_Click;
            // 
            // CreateCallForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 735);
            Controls.Add(group_patients);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(datetime_time_created);
            Controls.Add(combo_dispatcher);
            Controls.Add(spin_callout);
            Controls.Add(textbox_reason);
            Controls.Add(textbox_address);
            Controls.Add(textbox_channel);
            Controls.Add(textbox_tel);
            Controls.Add(textbox_patriarchic);
            Controls.Add(textbox_name);
            Controls.Add(textbox_surname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CreateCallForm";
            Text = "Створення виклику";
            FormClosed += CreateCallForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)spin_callout).EndInit();
            group_patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textbox_surname;
        private TextBox textbox_name;
        private TextBox textbox_patriarchic;
        private TextBox textbox_tel;
        private TextBox textbox_channel;
        private TextBox textbox_address;
        private TextBox textbox_reason;
        private DateTimePicker datetime_time_created;
        private Button button_save;
        private Button button_cancel;
        public NumericUpDown spin_callout;
        public ComboBox combo_dispatcher;
        private GroupBox group_patients;
        private DataGridView datagridview_patient;
        private DataGridViewTextBoxColumn column_patient_fullname;
        private DataGridViewTextBoxColumn column_patient_tel;
        private DataGridViewTextBoxColumn column_patient_dob;
        private DataGridViewTextBoxColumn column_patient_sex;
        private Button button_patient_remove;
        private Button button_patient_add;
    }
}