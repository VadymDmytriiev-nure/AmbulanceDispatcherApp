namespace AmbulanceDispatcherApp.Forms.Patient
{
    partial class PatientFiltersForm
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
            button_cancel = new Button();
            button_save = new Button();
            textbox_name = new TextBox();
            label4 = new Label();
            textbox_surname = new TextBox();
            label1 = new Label();
            textbox_patriarchic = new TextBox();
            label2 = new Label();
            textbox_tel = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            radio_sex_unknown = new RadioButton();
            radio_sex_male = new RadioButton();
            radio_sex_female = new RadioButton();
            label14 = new Label();
            label13 = new Label();
            datetime_dob_to = new DateTimePicker();
            datetime_dob_from = new DateTimePicker();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(107, 240);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 38;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._211861_16x161;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(233, 240);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 39;
            button_save.Text = "    Застосувати";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(152, 11);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(301, 29);
            textbox_name.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 40;
            label4.Text = "Ім'я";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(151, 44);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(301, 29);
            textbox_surname.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 42;
            label1.Text = "Прізвище";
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(152, 77);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(301, 29);
            textbox_patriarchic.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 44;
            label2.Text = "По батькові";
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(152, 110);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.Size = new Size(301, 29);
            textbox_tel.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 46;
            label3.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 48;
            label5.Text = "Дата народження";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 177);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 50;
            label6.Text = "Стать";
            // 
            // radio_sex_unknown
            // 
            radio_sex_unknown.AutoSize = true;
            radio_sex_unknown.Checked = true;
            radio_sex_unknown.Location = new Point(152, 177);
            radio_sex_unknown.Name = "radio_sex_unknown";
            radio_sex_unknown.Size = new Size(35, 25);
            radio_sex_unknown.TabIndex = 51;
            radio_sex_unknown.TabStop = true;
            radio_sex_unknown.Text = "?";
            radio_sex_unknown.UseVisualStyleBackColor = true;
            // 
            // radio_sex_male
            // 
            radio_sex_male.AutoSize = true;
            radio_sex_male.Location = new Point(193, 177);
            radio_sex_male.Name = "radio_sex_male";
            radio_sex_male.Size = new Size(39, 25);
            radio_sex_male.TabIndex = 52;
            radio_sex_male.Text = "Ч";
            radio_sex_male.UseVisualStyleBackColor = true;
            // 
            // radio_sex_female
            // 
            radio_sex_female.AutoSize = true;
            radio_sex_female.Location = new Point(234, 177);
            radio_sex_female.Name = "radio_sex_female";
            radio_sex_female.Size = new Size(42, 25);
            radio_sex_female.TabIndex = 53;
            radio_sex_female.Text = "Ж";
            radio_sex_female.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(305, 146);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 57;
            label14.Text = "до";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(151, 146);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 21);
            label13.TabIndex = 56;
            label13.Text = "від";
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
            datetime_dob_to.Size = new Size(115, 29);
            datetime_dob_to.TabIndex = 55;
            datetime_dob_to.Value = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            // 
            // datetime_dob_from
            // 
            datetime_dob_from.CalendarForeColor = Color.Black;
            datetime_dob_from.CalendarMonthBackground = Color.Black;
            datetime_dob_from.CalendarTitleBackColor = Color.Black;
            datetime_dob_from.CalendarTitleForeColor = Color.Black;
            datetime_dob_from.CalendarTrailingForeColor = Color.Black;
            datetime_dob_from.CustomFormat = "yyyy-MM-dd";
            datetime_dob_from.Format = DateTimePickerFormat.Custom;
            datetime_dob_from.Location = new Point(183, 143);
            datetime_dob_from.Margin = new Padding(1, 2, 1, 2);
            datetime_dob_from.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            datetime_dob_from.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_dob_from.Name = "datetime_dob_from";
            datetime_dob_from.Size = new Size(117, 29);
            datetime_dob_from.TabIndex = 54;
            datetime_dob_from.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // PatientFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 279);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(datetime_dob_to);
            Controls.Add(datetime_dob_from);
            Controls.Add(radio_sex_female);
            Controls.Add(radio_sex_male);
            Controls.Add(radio_sex_unknown);
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
            Name = "PatientFiltersForm";
            Text = "Пацієнти - Фільтри";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_name;
        private Label label4;
        private TextBox textbox_surname;
        private Label label1;
        private TextBox textbox_patriarchic;
        private Label label2;
        private TextBox textbox_tel;
        private Label label3;
        private Label label5;
        private Label label6;
        private RadioButton radio_sex_unknown;
        private RadioButton radio_sex_male;
        private RadioButton radio_sex_female;
        private Label label14;
        private Label label13;
        private DateTimePicker datetime_dob_to;
        private DateTimePicker datetime_dob_from;
    }
}