namespace AmbulanceDispatcherApp.Forms.Workers
{
    partial class WorkerFiltersForm
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
            label10 = new Label();
            combo_brigade = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            textbox_license = new TextBox();
            textbox_role = new TextBox();
            textbox_kpp = new TextBox();
            label7 = new Label();
            datetime_dob_from = new DateTimePicker();
            radio_sex_female = new RadioButton();
            radio_sex_male = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            textbox_tel = new TextBox();
            label3 = new Label();
            textbox_patriarchic = new TextBox();
            label2 = new Label();
            textbox_surname = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_name = new TextBox();
            label4 = new Label();
            radio_sex_unknown = new RadioButton();
            label11 = new Label();
            label12 = new Label();
            datetime_dob_to = new DateTimePicker();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 310);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 21);
            label10.TabIndex = 119;
            label10.Text = "Бригада";
            // 
            // combo_brigade
            // 
            combo_brigade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_brigade.FormattingEnabled = true;
            combo_brigade.Location = new Point(148, 307);
            combo_brigade.Name = "combo_brigade";
            combo_brigade.Size = new Size(311, 29);
            combo_brigade.TabIndex = 118;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 276);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 117;
            label9.Text = "Ліцензія";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(99, 243);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 116;
            label8.Text = "Роль";
            // 
            // textbox_license
            // 
            textbox_license.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_license.Location = new Point(148, 273);
            textbox_license.Margin = new Padding(1, 2, 1, 2);
            textbox_license.Name = "textbox_license";
            textbox_license.Size = new Size(311, 29);
            textbox_license.TabIndex = 115;
            // 
            // textbox_role
            // 
            textbox_role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_role.Location = new Point(148, 240);
            textbox_role.Margin = new Padding(1, 2, 1, 2);
            textbox_role.Name = "textbox_role";
            textbox_role.Size = new Size(311, 29);
            textbox_role.TabIndex = 114;
            // 
            // textbox_kpp
            // 
            textbox_kpp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_kpp.Location = new Point(148, 207);
            textbox_kpp.Margin = new Padding(1, 2, 1, 2);
            textbox_kpp.Name = "textbox_kpp";
            textbox_kpp.Size = new Size(311, 29);
            textbox_kpp.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 210);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 113;
            label7.Text = "ІНПН";
            // 
            // datetime_dob_from
            // 
            datetime_dob_from.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_dob_from.CalendarForeColor = Color.Black;
            datetime_dob_from.CalendarMonthBackground = Color.Black;
            datetime_dob_from.CalendarTitleBackColor = Color.Black;
            datetime_dob_from.CalendarTitleForeColor = Color.Black;
            datetime_dob_from.CalendarTrailingForeColor = Color.Black;
            datetime_dob_from.CustomFormat = "yyyy-MM-dd";
            datetime_dob_from.Format = DateTimePickerFormat.Custom;
            datetime_dob_from.Location = new Point(181, 143);
            datetime_dob_from.Margin = new Padding(1, 2, 1, 2);
            datetime_dob_from.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dob_from.Name = "datetime_dob_from";
            datetime_dob_from.Size = new Size(122, 29);
            datetime_dob_from.TabIndex = 111;
            datetime_dob_from.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // radio_sex_female
            // 
            radio_sex_female.AutoSize = true;
            radio_sex_female.Location = new Point(238, 177);
            radio_sex_female.Name = "radio_sex_female";
            radio_sex_female.Size = new Size(42, 25);
            radio_sex_female.TabIndex = 110;
            radio_sex_female.Text = "Ж";
            radio_sex_female.UseVisualStyleBackColor = true;
            // 
            // radio_sex_male
            // 
            radio_sex_male.AutoSize = true;
            radio_sex_male.Location = new Point(197, 177);
            radio_sex_male.Name = "radio_sex_male";
            radio_sex_male.Size = new Size(39, 25);
            radio_sex_male.TabIndex = 109;
            radio_sex_male.Text = "Ч";
            radio_sex_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 177);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 108;
            label6.Text = "Стать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 107;
            label5.Text = "Дата народження";
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(149, 110);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.Size = new Size(311, 29);
            textbox_tel.TabIndex = 105;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 106;
            label3.Text = "Телефон";
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(149, 77);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(311, 29);
            textbox_patriarchic.TabIndex = 103;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 104;
            label2.Text = "По батькові";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(148, 44);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(311, 29);
            textbox_surname.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 102;
            label1.Text = "Прізвище";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(112, 349);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 98;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(238, 349);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 99;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(149, 11);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(311, 29);
            textbox_name.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 100;
            label4.Text = "Ім'я";
            // 
            // radio_sex_unknown
            // 
            radio_sex_unknown.AutoSize = true;
            radio_sex_unknown.Checked = true;
            radio_sex_unknown.Location = new Point(149, 177);
            radio_sex_unknown.Name = "radio_sex_unknown";
            radio_sex_unknown.Size = new Size(35, 25);
            radio_sex_unknown.TabIndex = 120;
            radio_sex_unknown.TabStop = true;
            radio_sex_unknown.Text = "?";
            radio_sex_unknown.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 146);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(31, 21);
            label11.TabIndex = 121;
            label11.Text = "від";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(308, 146);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 122;
            label12.Text = "до";
            // 
            // datetime_dob_to
            // 
            datetime_dob_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_dob_to.CalendarForeColor = Color.Black;
            datetime_dob_to.CalendarMonthBackground = Color.Black;
            datetime_dob_to.CalendarTitleBackColor = Color.Black;
            datetime_dob_to.CalendarTitleForeColor = Color.Black;
            datetime_dob_to.CalendarTrailingForeColor = Color.Black;
            datetime_dob_to.CustomFormat = "yyyy-MM-dd";
            datetime_dob_to.Format = DateTimePickerFormat.Custom;
            datetime_dob_to.Location = new Point(337, 143);
            datetime_dob_to.Margin = new Padding(1, 2, 1, 2);
            datetime_dob_to.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dob_to.Name = "datetime_dob_to";
            datetime_dob_to.Size = new Size(122, 29);
            datetime_dob_to.TabIndex = 123;
            datetime_dob_to.Value = new DateTime(9988, 1, 1, 0, 0, 0, 0);
            // 
            // WorkerFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 388);
            Controls.Add(datetime_dob_to);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(radio_sex_unknown);
            Controls.Add(label10);
            Controls.Add(combo_brigade);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textbox_license);
            Controls.Add(textbox_role);
            Controls.Add(textbox_kpp);
            Controls.Add(label7);
            Controls.Add(datetime_dob_from);
            Controls.Add(radio_sex_female);
            Controls.Add(radio_sex_male);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textbox_tel);
            Controls.Add(label3);
            Controls.Add(textbox_patriarchic);
            Controls.Add(label2);
            Controls.Add(textbox_surname);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_name);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "WorkerFiltersForm";
            Text = "Працівники - Фільтри";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private ComboBox combo_brigade;
        private Label label9;
        private Label label8;
        private TextBox textbox_license;
        private TextBox textbox_role;
        private TextBox textbox_kpp;
        private Label label7;
        private DateTimePicker datetime_dob;
        private RadioButton radio_sex_female;
        private RadioButton radio_sex_male;
        private Label label6;
        private Label label5;
        private TextBox textbox_tel;
        private Label label3;
        private TextBox textbox_patriarchic;
        private Label label2;
        private TextBox textbox_surname;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_name;
        private Label label4;
        private DateTimePicker datetime_dob_from;
        private RadioButton radio_sex_unknown;
        private Label label11;
        private Label label12;
        private DateTimePicker datetime_dob_to;
    }
}