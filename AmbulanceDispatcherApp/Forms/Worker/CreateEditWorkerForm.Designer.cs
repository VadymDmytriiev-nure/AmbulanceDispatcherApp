namespace AmbulanceDispatcherApp.Forms.Workers
{
    partial class CreateEditWorkerForm
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
            datetime_dob = new DateTimePicker();
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
            textbox_kpp = new TextBox();
            label7 = new Label();
            textbox_role = new TextBox();
            textbox_license = new TextBox();
            label8 = new Label();
            label9 = new Label();
            combo_brigade = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // datetime_dob
            // 
            datetime_dob.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_dob.CalendarForeColor = Color.Black;
            datetime_dob.CalendarMonthBackground = Color.Black;
            datetime_dob.CalendarTitleBackColor = Color.Black;
            datetime_dob.CalendarTitleForeColor = Color.Black;
            datetime_dob.CalendarTrailingForeColor = Color.Black;
            datetime_dob.CustomFormat = "yyyy-MM-dd";
            datetime_dob.Format = DateTimePickerFormat.Custom;
            datetime_dob.Location = new Point(145, 143);
            datetime_dob.Margin = new Padding(1, 2, 1, 2);
            datetime_dob.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dob.Name = "datetime_dob";
            datetime_dob.Size = new Size(256, 29);
            datetime_dob.TabIndex = 88;
            datetime_dob.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radio_sex_female
            // 
            radio_sex_female.AutoSize = true;
            radio_sex_female.Location = new Point(188, 177);
            radio_sex_female.Name = "radio_sex_female";
            radio_sex_female.Size = new Size(42, 25);
            radio_sex_female.TabIndex = 87;
            radio_sex_female.Text = "Ж";
            radio_sex_female.UseVisualStyleBackColor = true;
            // 
            // radio_sex_male
            // 
            radio_sex_male.AutoSize = true;
            radio_sex_male.Location = new Point(147, 177);
            radio_sex_male.Name = "radio_sex_male";
            radio_sex_male.Size = new Size(39, 25);
            radio_sex_male.TabIndex = 86;
            radio_sex_male.Text = "Ч";
            radio_sex_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 177);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 85;
            label6.Text = "Стать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 84;
            label5.Text = "Дата народження";
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(145, 110);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.Size = new Size(256, 29);
            textbox_tel.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 83;
            label3.Text = "Телефон";
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(145, 77);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(256, 29);
            textbox_patriarchic.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 81;
            label2.Text = "По батькові";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(144, 44);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(256, 29);
            textbox_surname.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 79;
            label1.Text = "Прізвище";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(80, 349);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 75;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(206, 349);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 76;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(145, 11);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(256, 29);
            textbox_name.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 77;
            label4.Text = "Ім'я";
            // 
            // textbox_kpp
            // 
            textbox_kpp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_kpp.Location = new Point(144, 207);
            textbox_kpp.Margin = new Padding(1, 2, 1, 2);
            textbox_kpp.Name = "textbox_kpp";
            textbox_kpp.Size = new Size(256, 29);
            textbox_kpp.TabIndex = 89;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 210);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 90;
            label7.Text = "ІНПН";
            // 
            // textbox_role
            // 
            textbox_role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_role.Location = new Point(144, 240);
            textbox_role.Margin = new Padding(1, 2, 1, 2);
            textbox_role.Name = "textbox_role";
            textbox_role.Size = new Size(256, 29);
            textbox_role.TabIndex = 91;
            // 
            // textbox_license
            // 
            textbox_license.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_license.Location = new Point(144, 273);
            textbox_license.Margin = new Padding(1, 2, 1, 2);
            textbox_license.Name = "textbox_license";
            textbox_license.Size = new Size(256, 29);
            textbox_license.TabIndex = 92;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 243);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 93;
            label8.Text = "Роль";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 276);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 94;
            label9.Text = "Ліцензія";
            // 
            // combo_brigade
            // 
            combo_brigade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_brigade.FormattingEnabled = true;
            combo_brigade.Location = new Point(144, 307);
            combo_brigade.Name = "combo_brigade";
            combo_brigade.Size = new Size(255, 29);
            combo_brigade.TabIndex = 95;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 310);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 21);
            label10.TabIndex = 96;
            label10.Text = "Бригада";
            // 
            // CreateEditWorkerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 388);
            Controls.Add(label10);
            Controls.Add(combo_brigade);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textbox_license);
            Controls.Add(textbox_role);
            Controls.Add(textbox_kpp);
            Controls.Add(label7);
            Controls.Add(datetime_dob);
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
            Name = "CreateEditWorkerForm";
            Text = "CreateEditWorkerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox textbox_kpp;
        private Label label7;
        private TextBox textbox_role;
        private TextBox textbox_license;
        private Label label8;
        private Label label9;
        private ComboBox combo_brigade;
        private Label label10;
    }
}