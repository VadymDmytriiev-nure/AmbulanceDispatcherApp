namespace AmbulanceDispatcherApp
{
    partial class Calls
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
            datagrid_call = new DataGridView();
            column_call_time_created = new DataGridViewTextBoxColumn();
            column_call_surname = new DataGridViewTextBoxColumn();
            column_call_name = new DataGridViewTextBoxColumn();
            column_call_patriarchic = new DataGridViewTextBoxColumn();
            column_call_tel = new DataGridViewTextBoxColumn();
            column_call_address = new DataGridViewTextBoxColumn();
            column_call_reason = new DataGridViewTextBoxColumn();
            column_call_channel = new DataGridViewTextBoxColumn();
            button_save = new Button();
            ((System.ComponentModel.ISupportInitialize)datagrid_call).BeginInit();
            SuspendLayout();
            // 
            // datagrid_call
            // 
            datagrid_call.AllowUserToAddRows = false;
            datagrid_call.AllowUserToDeleteRows = false;
            datagrid_call.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_call.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrid_call.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_call.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_call.Columns.AddRange(new DataGridViewColumn[] { column_call_time_created, column_call_surname, column_call_name, column_call_patriarchic, column_call_tel, column_call_address, column_call_reason, column_call_channel });
            datagrid_call.Location = new Point(31, 29);
            datagrid_call.Margin = new Padding(7);
            datagrid_call.MultiSelect = false;
            datagrid_call.Name = "datagrid_call";
            datagrid_call.ReadOnly = true;
            datagrid_call.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_call.Size = new Size(1270, 541);
            datagrid_call.TabIndex = 2;
            // 
            // column_call_time_created
            // 
            column_call_time_created.DataPropertyName = "call_time_created";
            column_call_time_created.HeaderText = "Час дзвінка";
            column_call_time_created.Name = "column_call_time_created";
            column_call_time_created.ReadOnly = true;
            column_call_time_created.Width = 195;
            // 
            // column_call_surname
            // 
            column_call_surname.DataPropertyName = "call_caller_surname";
            column_call_surname.HeaderText = "Прізвище";
            column_call_surname.Name = "column_call_surname";
            column_call_surname.ReadOnly = true;
            column_call_surname.Width = 170;
            // 
            // column_call_name
            // 
            column_call_name.DataPropertyName = "call_caller_name";
            column_call_name.HeaderText = "Ім'я";
            column_call_name.Name = "column_call_name";
            column_call_name.ReadOnly = true;
            column_call_name.Width = 89;
            // 
            // column_call_patriarchic
            // 
            column_call_patriarchic.DataPropertyName = "call_caller_patriarchic";
            column_call_patriarchic.HeaderText = "По батькові";
            column_call_patriarchic.Name = "column_call_patriarchic";
            column_call_patriarchic.ReadOnly = true;
            column_call_patriarchic.Width = 197;
            // 
            // column_call_tel
            // 
            column_call_tel.DataPropertyName = "call_caller_tel";
            column_call_tel.HeaderText = "Телефон";
            column_call_tel.Name = "column_call_tel";
            column_call_tel.ReadOnly = true;
            column_call_tel.Width = 154;
            // 
            // column_call_address
            // 
            column_call_address.DataPropertyName = "call_address";
            column_call_address.HeaderText = "Адреса";
            column_call_address.Name = "column_call_address";
            column_call_address.ReadOnly = true;
            column_call_address.Width = 135;
            // 
            // column_call_reason
            // 
            column_call_reason.DataPropertyName = "call_reason";
            column_call_reason.HeaderText = "Привід";
            column_call_reason.Name = "column_call_reason";
            column_call_reason.ReadOnly = true;
            column_call_reason.Width = 134;
            // 
            // column_call_channel
            // 
            column_call_channel.DataPropertyName = "call_channel";
            column_call_channel.HeaderText = "Канал зв'язку";
            column_call_channel.Name = "column_call_channel";
            column_call_channel.ReadOnly = true;
            column_call_channel.Width = 220;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_save.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(31, 584);
            button_save.Margin = new Padding(7);
            button_save.Name = "button_save";
            button_save.Size = new Size(376, 53);
            button_save.TabIndex = 4;
            button_save.Text = "Зберегти зміни";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // Calls
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 660);
            Controls.Add(button_save);
            Controls.Add(datagrid_call);
            Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(7);
            Name = "Calls";
            Text = "Дзвінки";
            ((System.ComponentModel.ISupportInitialize)datagrid_call).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_call;
        private DataGridViewTextBoxColumn column_call_time_created;
        private DataGridViewTextBoxColumn column_call_surname;
        private DataGridViewTextBoxColumn column_call_name;
        private DataGridViewTextBoxColumn column_call_patriarchic;
        private DataGridViewTextBoxColumn column_call_tel;
        private DataGridViewTextBoxColumn column_call_address;
        private DataGridViewTextBoxColumn column_call_reason;
        private DataGridViewTextBoxColumn column_call_channel;
        private Button button_save;
    }
}