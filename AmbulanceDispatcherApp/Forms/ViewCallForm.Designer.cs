namespace AmbulanceDispatcherApp
{
    partial class ViewCallForm
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textbox_fullname = new TextBox();
            textbox_tel = new TextBox();
            textbox_channel = new TextBox();
            textbox_address = new TextBox();
            textbox_reason = new TextBox();
            button_ok = new Button();
            textbox_dispatcher = new TextBox();
            textbox_time_created = new TextBox();
            textbox_callout = new TextBox();
            group_patients = new GroupBox();
            datagridview_patient = new DataGridView();
            column_patient_fullname = new DataGridViewTextBoxColumn();
            column_patient_tel = new DataGridViewTextBoxColumn();
            column_patient_dob = new DataGridViewTextBoxColumn();
            column_patient_sex = new DataGridViewTextBoxColumn();
            group_patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_patient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Час дзвінка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Диспетчер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 5;
            label6.Text = "ПІБ Абонента";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 79);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 6;
            label7.Text = "№ Виклику";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 179);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 7;
            label8.Text = "Адреса";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 212);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 8;
            label9.Text = "Привід";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 245);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 21);
            label10.TabIndex = 9;
            label10.Text = "Канал зв'язку";
            // 
            // textbox_fullname
            // 
            textbox_fullname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_fullname.Location = new Point(140, 110);
            textbox_fullname.Margin = new Padding(1, 2, 1, 2);
            textbox_fullname.Name = "textbox_fullname";
            textbox_fullname.ReadOnly = true;
            textbox_fullname.Size = new Size(439, 29);
            textbox_fullname.TabIndex = 4;
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(140, 143);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.PlaceholderText = "+380XXXXXXXXX";
            textbox_tel.ReadOnly = true;
            textbox_tel.Size = new Size(439, 29);
            textbox_tel.TabIndex = 7;
            // 
            // textbox_channel
            // 
            textbox_channel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_channel.Location = new Point(140, 242);
            textbox_channel.Margin = new Padding(1, 2, 1, 2);
            textbox_channel.Name = "textbox_channel";
            textbox_channel.PlaceholderText = "103";
            textbox_channel.ReadOnly = true;
            textbox_channel.Size = new Size(439, 29);
            textbox_channel.TabIndex = 10;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(140, 176);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.ReadOnly = true;
            textbox_address.Size = new Size(439, 29);
            textbox_address.TabIndex = 8;
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(140, 209);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.ReadOnly = true;
            textbox_reason.Size = new Size(439, 29);
            textbox_reason.TabIndex = 9;
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom;
            button_ok.Image = Properties.Resources._212394_16x16;
            button_ok.ImageAlign = ContentAlignment.MiddleLeft;
            button_ok.Location = new Point(236, 648);
            button_ok.Margin = new Padding(1, 2, 1, 2);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(124, 32);
            button_ok.TabIndex = 12;
            button_ok.Text = "ОК";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_save_Click;
            // 
            // textbox_dispatcher
            // 
            textbox_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_dispatcher.Location = new Point(140, 44);
            textbox_dispatcher.Margin = new Padding(1, 2, 1, 2);
            textbox_dispatcher.Name = "textbox_dispatcher";
            textbox_dispatcher.ReadOnly = true;
            textbox_dispatcher.Size = new Size(439, 29);
            textbox_dispatcher.TabIndex = 13;
            // 
            // textbox_time_created
            // 
            textbox_time_created.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_time_created.Location = new Point(140, 11);
            textbox_time_created.Margin = new Padding(1, 2, 1, 2);
            textbox_time_created.Name = "textbox_time_created";
            textbox_time_created.ReadOnly = true;
            textbox_time_created.Size = new Size(439, 29);
            textbox_time_created.TabIndex = 14;
            // 
            // textbox_callout
            // 
            textbox_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_callout.Location = new Point(140, 76);
            textbox_callout.Margin = new Padding(1, 2, 1, 2);
            textbox_callout.Name = "textbox_callout";
            textbox_callout.ReadOnly = true;
            textbox_callout.Size = new Size(439, 29);
            textbox_callout.TabIndex = 15;
            // 
            // group_patients
            // 
            group_patients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_patients.Controls.Add(datagridview_patient);
            group_patients.Location = new Point(12, 276);
            group_patients.Name = "group_patients";
            group_patients.Size = new Size(576, 354);
            group_patients.TabIndex = 103;
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
            datagridview_patient.Size = new Size(560, 320);
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
            // ViewCallForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 684);
            Controls.Add(group_patients);
            Controls.Add(textbox_callout);
            Controls.Add(textbox_time_created);
            Controls.Add(textbox_dispatcher);
            Controls.Add(button_ok);
            Controls.Add(textbox_reason);
            Controls.Add(textbox_address);
            Controls.Add(textbox_channel);
            Controls.Add(textbox_tel);
            Controls.Add(textbox_fullname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ViewCallForm";
            Text = "Дзвінок";
            FormClosed += CreateCallForm_FormClosed;
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
        private TextBox textbox_fullname;
        private TextBox textbox_name;
        private TextBox textbox_patriarchic;
        private TextBox textbox_tel;
        private TextBox textbox_channel;
        private TextBox textbox_address;
        private TextBox textbox_reason;
        private DateTimePicker datetime_time_created;
        private Button button_ok;
        private Button button_cancel;
        public NumericUpDown spin_callout;
        private TextBox textbox_dispatcher;
        private TextBox textbox_time_created;
        public ComboBox combo_dispatcher;
        private TextBox textbox_callout;
        private GroupBox group_patients;
        private DataGridView datagridview_patient;
        private DataGridViewTextBoxColumn column_patient_fullname;
        private DataGridViewTextBoxColumn column_patient_tel;
        private DataGridViewTextBoxColumn column_patient_dob;
        private DataGridViewTextBoxColumn column_patient_sex;
    }
}