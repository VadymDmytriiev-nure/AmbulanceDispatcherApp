namespace AmbulanceDispatcherApp.Forms.Patient
{
    partial class CreateEditPatientForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            label4 = new Label();
            textbox_tel = new TextBox();
            textbox_patriarchic = new TextBox();
            textbox_surname = new TextBox();
            textbox_name = new TextBox();
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
            datetime_dob.TabIndex = 73;
            datetime_dob.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radio_sex_female
            // 
            radio_sex_female.AutoSize = true;
            radio_sex_female.Location = new Point(188, 177);
            radio_sex_female.Name = "radio_sex_female";
            radio_sex_female.Size = new Size(42, 25);
            radio_sex_female.TabIndex = 72;
            radio_sex_female.Text = "Ж";
            radio_sex_female.UseVisualStyleBackColor = true;
            // 
            // radio_sex_male
            // 
            radio_sex_male.AutoSize = true;
            radio_sex_male.Location = new Point(147, 177);
            radio_sex_male.Name = "radio_sex_male";
            radio_sex_male.Size = new Size(39, 25);
            radio_sex_male.TabIndex = 71;
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
            label6.TabIndex = 69;
            label6.Text = "Стать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 68;
            label5.Text = "Дата народження";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 67;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 65;
            label2.Text = "По батькові";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 63;
            label1.Text = "Прізвище";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(80, 239);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 59;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(206, 239);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 60;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 61;
            label4.Text = "Ім'я";
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(145, 110);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.Size = new Size(256, 29);
            textbox_tel.TabIndex = 66;
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(145, 77);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(256, 29);
            textbox_patriarchic.TabIndex = 64;
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(144, 44);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(256, 29);
            textbox_surname.TabIndex = 62;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(145, 11);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(256, 29);
            textbox_name.TabIndex = 58;
            // 
            // CreateEditPatientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 278);
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
            Name = "CreateEditPatientForm";
            Text = "CreateEditPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datetime_dob;
        private RadioButton radio_sex_female;
        private RadioButton radio_sex_male;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private Label label4;
        private TextBox textbox_tel;
        private TextBox textbox_patriarchic;
        private TextBox textbox_surname;
        private TextBox textbox_name;
    }
}