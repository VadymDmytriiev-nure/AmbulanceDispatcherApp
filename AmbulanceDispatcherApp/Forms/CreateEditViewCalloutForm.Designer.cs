namespace AmbulanceDispatcherApp.Forms
{
    partial class CreateEditViewCalloutForm
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
            datetime_time_created = new DateTimePicker();
            label5 = new Label();
            textbox_comment = new TextBox();
            label2 = new Label();
            textbox_reason = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_address = new TextBox();
            label4 = new Label();
            checkbox_canceled = new CheckBox();
            label3 = new Label();
            button_ok = new Button();
            group_patients = new GroupBox();
            datagridview_patient = new DataGridView();
            column_patient_fullname = new DataGridViewTextBoxColumn();
            column_patient_tel = new DataGridViewTextBoxColumn();
            column_patient_dob = new DataGridViewTextBoxColumn();
            column_patient_sex = new DataGridViewTextBoxColumn();
            button_patient_remove = new Button();
            button_patient_add = new Button();
            group_patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).BeginInit();
            SuspendLayout();
            // 
            // datetime_time_created
            // 
            datetime_time_created.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created.CalendarForeColor = Color.Black;
            datetime_time_created.CalendarMonthBackground = Color.Black;
            datetime_time_created.CalendarTitleBackColor = Color.Black;
            datetime_time_created.CalendarTitleForeColor = Color.Black;
            datetime_time_created.CalendarTrailingForeColor = Color.Black;
            datetime_time_created.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetime_time_created.Format = DateTimePickerFormat.Custom;
            datetime_time_created.Location = new Point(149, 110);
            datetime_time_created.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_time_created.Name = "datetime_time_created";
            datetime_time_created.Size = new Size(370, 29);
            datetime_time_created.TabIndex = 4;
            datetime_time_created.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 84;
            label5.Text = "Дата створення";
            // 
            // textbox_comment
            // 
            textbox_comment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_comment.Location = new Point(149, 77);
            textbox_comment.Margin = new Padding(1, 2, 1, 2);
            textbox_comment.Name = "textbox_comment";
            textbox_comment.Size = new Size(370, 29);
            textbox_comment.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 81;
            label2.Text = "Коментар";
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(148, 44);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(370, 29);
            textbox_reason.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 79;
            label1.Text = "Привід";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(141, 556);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(267, 556);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 6;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(149, 11);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(370, 29);
            textbox_address.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 77;
            label4.Text = "Адреса";
            // 
            // checkbox_canceled
            // 
            checkbox_canceled.AutoSize = true;
            checkbox_canceled.Location = new Point(148, 149);
            checkbox_canceled.Name = "checkbox_canceled";
            checkbox_canceled.Size = new Size(44, 25);
            checkbox_canceled.TabIndex = 5;
            checkbox_canceled.Text = "Ні";
            checkbox_canceled.TextAlign = ContentAlignment.MiddleCenter;
            checkbox_canceled.UseVisualStyleBackColor = true;
            checkbox_canceled.CheckedChanged += checkbox_canceled_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 90;
            label3.Text = "Виклик відмінено";
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom;
            button_ok.Image = Properties.Resources._212394_16x16;
            button_ok.ImageAlign = ContentAlignment.MiddleLeft;
            button_ok.Location = new Point(202, 556);
            button_ok.Margin = new Padding(1, 2, 1, 2);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(124, 28);
            button_ok.TabIndex = 8;
            button_ok.Text = "    OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Visible = false;
            button_ok.Click += button_ok_Click;
            // 
            // group_patients
            // 
            group_patients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_patients.Controls.Add(datagridview_patient);
            group_patients.Controls.Add(button_patient_remove);
            group_patients.Controls.Add(button_patient_add);
            group_patients.Location = new Point(12, 180);
            group_patients.Name = "group_patients";
            group_patients.Size = new Size(501, 371);
            group_patients.TabIndex = 104;
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
            datagridview_patient.Size = new Size(427, 337);
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
            button_patient_remove.Location = new Point(442, 93);
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
            button_patient_add.Location = new Point(442, 28);
            button_patient_add.Margin = new Padding(1, 2, 1, 2);
            button_patient_add.Name = "button_patient_add";
            button_patient_add.Size = new Size(52, 61);
            button_patient_add.TabIndex = 98;
            button_patient_add.UseVisualStyleBackColor = true;
            button_patient_add.Click += button_patient_add_Click;
            // 
            // CreateEditViewCalloutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 595);
            Controls.Add(group_patients);
            Controls.Add(button_ok);
            Controls.Add(label3);
            Controls.Add(checkbox_canceled);
            Controls.Add(datetime_time_created);
            Controls.Add(label5);
            Controls.Add(textbox_comment);
            Controls.Add(label2);
            Controls.Add(textbox_reason);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_address);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateEditViewCalloutForm";
            Text = "CreateEditCallForm";
            group_patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datetime_time_created;
        private Label label5;
        private TextBox textbox_tel;
        private TextBox textbox_comment;
        private Label label2;
        private TextBox textbox_reason;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_address;
        private Label label4;
        private CheckBox checkbox_canceled;
        private Label label3;
        private Button button_ok;
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