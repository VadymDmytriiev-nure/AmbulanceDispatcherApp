namespace AmbulanceDispatcherApp.Forms.Departures
{
    partial class CreateEditDepartureForm
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
            datetime_departed = new DateTimePicker();
            textbox_to_address = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_from_address = new TextBox();
            label4 = new Label();
            datetime_arrived = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            spin_mileage = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            spin_callout = new NumericUpDown();
            group_personnel = new GroupBox();
            button_personnel_from_brigade = new Button();
            button_personnel_remove = new Button();
            button_personnel_add = new Button();
            datagridview_personnel = new DataGridView();
            column_worker_brigade = new DataGridViewTextBoxColumn();
            column_worker_fullname = new DataGridViewTextBoxColumn();
            column_worker_role = new DataGridViewTextBoxColumn();
            group_patients = new GroupBox();
            button_patients_from_callout = new Button();
            datagridview_patient = new DataGridView();
            column_patient_fullname = new DataGridViewTextBoxColumn();
            column_patient_tel = new DataGridViewTextBoxColumn();
            column_patient_dob = new DataGridViewTextBoxColumn();
            column_patient_sex = new DataGridViewTextBoxColumn();
            button_patient_remove = new Button();
            button_patient_add = new Button();
            splitbox = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)spin_mileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout).BeginInit();
            group_personnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_personnel).BeginInit();
            group_patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitbox).BeginInit();
            splitbox.Panel1.SuspendLayout();
            splitbox.Panel2.SuspendLayout();
            splitbox.SuspendLayout();
            SuspendLayout();
            // 
            // datetime_departed
            // 
            datetime_departed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_departed.CalendarForeColor = Color.Black;
            datetime_departed.CalendarMonthBackground = Color.Black;
            datetime_departed.CalendarTitleBackColor = Color.Black;
            datetime_departed.CalendarTitleForeColor = Color.Black;
            datetime_departed.CalendarTrailingForeColor = Color.Black;
            datetime_departed.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetime_departed.Format = DateTimePickerFormat.Custom;
            datetime_departed.Location = new Point(143, 112);
            datetime_departed.Margin = new Padding(1, 2, 1, 2);
            datetime_departed.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_departed.Name = "datetime_departed";
            datetime_departed.Size = new Size(463, 29);
            datetime_departed.TabIndex = 88;
            datetime_departed.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textbox_to_address
            // 
            textbox_to_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_to_address.Location = new Point(143, 79);
            textbox_to_address.Margin = new Padding(1, 2, 1, 2);
            textbox_to_address.Name = "textbox_to_address";
            textbox_to_address.Size = new Size(463, 29);
            textbox_to_address.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 79;
            label1.Text = "Кінцева адреса";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(188, 785);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 75;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(314, 785);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 76;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_from_address
            // 
            textbox_from_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_from_address.Location = new Point(144, 46);
            textbox_from_address.Margin = new Padding(1, 2, 1, 2);
            textbox_from_address.Name = "textbox_from_address";
            textbox_from_address.Size = new Size(463, 29);
            textbox_from_address.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 77;
            label4.Text = "Початкова адреса";
            // 
            // datetime_arrived
            // 
            datetime_arrived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_arrived.CalendarForeColor = Color.Black;
            datetime_arrived.CalendarMonthBackground = Color.Black;
            datetime_arrived.CalendarTitleBackColor = Color.Black;
            datetime_arrived.CalendarTitleForeColor = Color.Black;
            datetime_arrived.CalendarTrailingForeColor = Color.Black;
            datetime_arrived.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetime_arrived.Format = DateTimePickerFormat.Custom;
            datetime_arrived.Location = new Point(143, 145);
            datetime_arrived.Margin = new Padding(1, 2, 1, 2);
            datetime_arrived.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_arrived.Name = "datetime_arrived";
            datetime_arrived.Size = new Size(463, 29);
            datetime_arrived.TabIndex = 89;
            datetime_arrived.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 90;
            label2.Text = "Час відбуття";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 91;
            label3.Text = "Час прибуття";
            // 
            // spin_mileage
            // 
            spin_mileage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_mileage.DecimalPlaces = 3;
            spin_mileage.Location = new Point(143, 179);
            spin_mileage.Name = "spin_mileage";
            spin_mileage.Size = new Size(420, 29);
            spin_mileage.TabIndex = 92;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(570, 181);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 93;
            label5.Text = "км";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 181);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 94;
            label6.Text = "Кілометраж";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 14);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 95;
            label7.Text = "№ Виклику";
            // 
            // spin_callout
            // 
            spin_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout.Location = new Point(143, 12);
            spin_callout.Name = "spin_callout";
            spin_callout.Size = new Size(463, 29);
            spin_callout.TabIndex = 96;
            // 
            // group_personnel
            // 
            group_personnel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_personnel.Controls.Add(button_personnel_from_brigade);
            group_personnel.Controls.Add(button_personnel_remove);
            group_personnel.Controls.Add(button_personnel_add);
            group_personnel.Controls.Add(datagridview_personnel);
            group_personnel.Location = new Point(7, 3);
            group_personnel.Name = "group_personnel";
            group_personnel.Size = new Size(585, 280);
            group_personnel.TabIndex = 97;
            group_personnel.TabStop = false;
            group_personnel.Text = "Особовий склад";
            // 
            // button_personnel_from_brigade
            // 
            button_personnel_from_brigade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_personnel_from_brigade.Image = Properties.Resources._212240_32x32;
            button_personnel_from_brigade.Location = new Point(526, 27);
            button_personnel_from_brigade.Margin = new Padding(1, 2, 1, 2);
            button_personnel_from_brigade.Name = "button_personnel_from_brigade";
            button_personnel_from_brigade.Size = new Size(52, 61);
            button_personnel_from_brigade.TabIndex = 100;
            button_personnel_from_brigade.UseVisualStyleBackColor = true;
            button_personnel_from_brigade.Click += button_personnel_from_brigade_Click;
            // 
            // button_personnel_remove
            // 
            button_personnel_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_personnel_remove.Image = Properties.Resources._212377_32x32;
            button_personnel_remove.Location = new Point(526, 157);
            button_personnel_remove.Margin = new Padding(1, 2, 1, 2);
            button_personnel_remove.Name = "button_personnel_remove";
            button_personnel_remove.Size = new Size(52, 61);
            button_personnel_remove.TabIndex = 99;
            button_personnel_remove.UseVisualStyleBackColor = true;
            button_personnel_remove.Click += button_personnel_remove_Click;
            // 
            // button_personnel_add
            // 
            button_personnel_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_personnel_add.Image = Properties.Resources._212376_32x32;
            button_personnel_add.Location = new Point(526, 92);
            button_personnel_add.Margin = new Padding(1, 2, 1, 2);
            button_personnel_add.Name = "button_personnel_add";
            button_personnel_add.Size = new Size(52, 61);
            button_personnel_add.TabIndex = 98;
            button_personnel_add.UseVisualStyleBackColor = true;
            button_personnel_add.Click += button_personnel_add_Click;
            // 
            // datagridview_personnel
            // 
            datagridview_personnel.AllowUserToAddRows = false;
            datagridview_personnel.AllowUserToDeleteRows = false;
            datagridview_personnel.AllowUserToResizeRows = false;
            datagridview_personnel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_personnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_personnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_personnel.Columns.AddRange(new DataGridViewColumn[] { column_worker_brigade, column_worker_fullname, column_worker_role });
            datagridview_personnel.Location = new Point(7, 28);
            datagridview_personnel.MultiSelect = false;
            datagridview_personnel.Name = "datagridview_personnel";
            datagridview_personnel.ReadOnly = true;
            datagridview_personnel.RowHeadersVisible = false;
            datagridview_personnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_personnel.Size = new Size(515, 246);
            datagridview_personnel.TabIndex = 40;
            // 
            // column_worker_brigade
            // 
            column_worker_brigade.DataPropertyName = "brigade_code";
            column_worker_brigade.HeaderText = "Бригада";
            column_worker_brigade.Name = "column_worker_brigade";
            column_worker_brigade.ReadOnly = true;
            column_worker_brigade.Width = 91;
            // 
            // column_worker_fullname
            // 
            column_worker_fullname.DataPropertyName = "worker_fullname";
            column_worker_fullname.HeaderText = "ПІБ";
            column_worker_fullname.Name = "column_worker_fullname";
            column_worker_fullname.ReadOnly = true;
            column_worker_fullname.Width = 57;
            // 
            // column_worker_role
            // 
            column_worker_role.DataPropertyName = "worker_role";
            column_worker_role.HeaderText = "Роль";
            column_worker_role.Name = "column_worker_role";
            column_worker_role.ReadOnly = true;
            column_worker_role.Width = 67;
            // 
            // group_patients
            // 
            group_patients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_patients.Controls.Add(button_patients_from_callout);
            group_patients.Controls.Add(datagridview_patient);
            group_patients.Controls.Add(button_patient_remove);
            group_patients.Controls.Add(button_patient_add);
            group_patients.Location = new Point(7, 11);
            group_patients.Name = "group_patients";
            group_patients.Size = new Size(585, 262);
            group_patients.TabIndex = 101;
            group_patients.TabStop = false;
            group_patients.Text = "Пацієнти";
            // 
            // button_patients_from_callout
            // 
            button_patients_from_callout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patients_from_callout.Image = Properties.Resources._212240_32x32;
            button_patients_from_callout.Location = new Point(526, 28);
            button_patients_from_callout.Margin = new Padding(1, 2, 1, 2);
            button_patients_from_callout.Name = "button_patients_from_callout";
            button_patients_from_callout.Size = new Size(52, 61);
            button_patients_from_callout.TabIndex = 101;
            button_patients_from_callout.UseVisualStyleBackColor = true;
            button_patients_from_callout.Click += button_patients_from_callout_Click;
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
            datagridview_patient.Size = new Size(515, 228);
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
            button_patient_remove.Location = new Point(526, 158);
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
            button_patient_add.Location = new Point(526, 93);
            button_patient_add.Margin = new Padding(1, 2, 1, 2);
            button_patient_add.Name = "button_patient_add";
            button_patient_add.Size = new Size(52, 61);
            button_patient_add.TabIndex = 98;
            button_patient_add.UseVisualStyleBackColor = true;
            button_patient_add.Click += button_patient_add_Click;
            // 
            // splitbox
            // 
            splitbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitbox.Location = new Point(12, 214);
            splitbox.Name = "splitbox";
            splitbox.Orientation = Orientation.Horizontal;
            // 
            // splitbox.Panel1
            // 
            splitbox.Panel1.Controls.Add(group_personnel);
            splitbox.Panel1MinSize = 230;
            // 
            // splitbox.Panel2
            // 
            splitbox.Panel2.Controls.Add(group_patients);
            splitbox.Panel2MinSize = 200;
            splitbox.Size = new Size(595, 566);
            splitbox.SplitterDistance = 286;
            splitbox.TabIndex = 102;
            // 
            // CreateEditDepartureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 824);
            Controls.Add(splitbox);
            Controls.Add(spin_callout);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(spin_mileage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(datetime_arrived);
            Controls.Add(datetime_departed);
            Controls.Add(textbox_to_address);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_from_address);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateEditDepartureForm";
            Text = "CreateEditDepartureForm";
            ((System.ComponentModel.ISupportInitialize)spin_mileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout).EndInit();
            group_personnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_personnel).EndInit();
            group_patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).EndInit();
            splitbox.Panel1.ResumeLayout(false);
            splitbox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitbox).EndInit();
            splitbox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datetime_departed;
        private TextBox textbox_to_address;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_from_address;
        private Label label4;
        private DateTimePicker datetime_arrived;
        private Label label2;
        private Label label3;
        private NumericUpDown spin_mileage;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown spin_callout;
        private GroupBox group_personnel;
        private DataGridView datagridview_personnel;
        private DataGridViewTextBoxColumn column_worker_brigade;
        private DataGridViewTextBoxColumn column_worker_fullname;
        private DataGridViewTextBoxColumn column_worker_role;
        private Button button_personnel_from_brigade;
        private Button button_personnel_remove;
        private Button button_personnel_add;
        private GroupBox group_patients;
        private Button button_patient_remove;
        private Button button_patient_add;
        private SplitContainer splitbox;
        private DataGridView datagridview_patient;
        private DataGridViewTextBoxColumn column_patient_fullname;
        private DataGridViewTextBoxColumn column_patient_tel;
        private DataGridViewTextBoxColumn column_patient_dob;
        private DataGridViewTextBoxColumn column_patient_sex;
        private Button button_patients_from_callout;
    }
}