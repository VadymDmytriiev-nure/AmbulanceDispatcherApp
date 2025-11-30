namespace AmbulanceDispatcherApp
{
    partial class CallsForm
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
            button_save = new Button();
            menuStrip1 = new MenuStrip();
            дзвінкиToolStripMenuItem = new ToolStripMenuItem();
            створитиToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            datagrid_call = new DataGridView();
            column_call_time_created = new DataGridViewTextBoxColumn();
            column_call_dispatcher = new DataGridViewTextBoxColumn();
            column_call_callout = new DataGridViewTextBoxColumn();
            column_call_surname = new DataGridViewTextBoxColumn();
            column_call_name = new DataGridViewTextBoxColumn();
            column_call_patriarchic = new DataGridViewTextBoxColumn();
            column_call_tel = new DataGridViewTextBoxColumn();
            column_call_address = new DataGridViewTextBoxColumn();
            column_call_reason = new DataGridViewTextBoxColumn();
            column_call_channel = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_call).BeginInit();
            SuspendLayout();
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(778, 566);
            button_save.Margin = new Padding(6);
            button_save.Name = "button_save";
            button_save.Size = new Size(313, 55);
            button_save.TabIndex = 4;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { дзвінкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1103, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // дзвінкиToolStripMenuItem
            // 
            дзвінкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиToolStripMenuItem, редагуватиToolStripMenuItem, видалитиToolStripMenuItem });
            дзвінкиToolStripMenuItem.Name = "дзвінкиToolStripMenuItem";
            дзвінкиToolStripMenuItem.Size = new Size(98, 29);
            дзвінкиToolStripMenuItem.Text = "Дзвінки";
            // 
            // створитиToolStripMenuItem
            // 
            створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            створитиToolStripMenuItem.Size = new Size(193, 30);
            створитиToolStripMenuItem.Text = "Створити";
            створитиToolStripMenuItem.Click += створитиToolStripMenuItem_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(193, 30);
            редагуватиToolStripMenuItem.Text = "Редагувати";
            редагуватиToolStripMenuItem.Click += редагуватиToolStripMenuItem_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(193, 30);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // datagrid_call
            // 
            datagrid_call.AllowUserToAddRows = false;
            datagrid_call.AllowUserToDeleteRows = false;
            datagrid_call.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_call.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrid_call.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_call.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_call.Columns.AddRange(new DataGridViewColumn[] { column_call_time_created, column_call_dispatcher, column_call_callout, column_call_surname, column_call_name, column_call_patriarchic, column_call_tel, column_call_address, column_call_reason, column_call_channel });
            datagrid_call.Location = new Point(12, 37);
            datagrid_call.MultiSelect = false;
            datagrid_call.Name = "datagrid_call";
            datagrid_call.ReadOnly = true;
            datagrid_call.RowHeadersVisible = false;
            datagrid_call.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_call.Size = new Size(1079, 520);
            datagrid_call.TabIndex = 6;
            // 
            // column_call_time_created
            // 
            column_call_time_created.DataPropertyName = "call_time_created";
            column_call_time_created.HeaderText = "Час дзвінка";
            column_call_time_created.Name = "column_call_time_created";
            column_call_time_created.ReadOnly = true;
            column_call_time_created.Width = 178;
            // 
            // column_call_dispatcher
            // 
            column_call_dispatcher.DataPropertyName = "dispatcher_fullname";
            column_call_dispatcher.HeaderText = "Диспетчер";
            column_call_dispatcher.Name = "column_call_dispatcher";
            column_call_dispatcher.ReadOnly = true;
            column_call_dispatcher.Width = 169;
            // 
            // column_call_callout
            // 
            column_call_callout.DataPropertyName = "callout_id";
            column_call_callout.HeaderText = "№ Виклику";
            column_call_callout.Name = "column_call_callout";
            column_call_callout.ReadOnly = true;
            column_call_callout.Width = 177;
            // 
            // column_call_surname
            // 
            column_call_surname.DataPropertyName = "call_caller_surname";
            column_call_surname.HeaderText = "Прізвище";
            column_call_surname.Name = "column_call_surname";
            column_call_surname.ReadOnly = true;
            column_call_surname.Width = 153;
            // 
            // column_call_name
            // 
            column_call_name.DataPropertyName = "call_caller_name";
            column_call_name.HeaderText = "Ім'я";
            column_call_name.Name = "column_call_name";
            column_call_name.ReadOnly = true;
            column_call_name.Width = 85;
            // 
            // column_call_patriarchic
            // 
            column_call_patriarchic.DataPropertyName = "call_caller_patriarchic";
            column_call_patriarchic.HeaderText = "По батькові";
            column_call_patriarchic.Name = "column_call_patriarchic";
            column_call_patriarchic.ReadOnly = true;
            column_call_patriarchic.Width = 183;
            // 
            // column_call_tel
            // 
            column_call_tel.DataPropertyName = "call_caller_tel";
            column_call_tel.HeaderText = "Телефон";
            column_call_tel.Name = "column_call_tel";
            column_call_tel.ReadOnly = true;
            column_call_tel.Width = 148;
            // 
            // column_call_address
            // 
            column_call_address.DataPropertyName = "call_address";
            column_call_address.HeaderText = "Адреса";
            column_call_address.Name = "column_call_address";
            column_call_address.ReadOnly = true;
            column_call_address.Width = 124;
            // 
            // column_call_reason
            // 
            column_call_reason.DataPropertyName = "call_reason";
            column_call_reason.HeaderText = "Привід";
            column_call_reason.Name = "column_call_reason";
            column_call_reason.ReadOnly = true;
            column_call_reason.Width = 121;
            // 
            // column_call_channel
            // 
            column_call_channel.DataPropertyName = "call_channel";
            column_call_channel.HeaderText = "Канал зв'язку";
            column_call_channel.Name = "column_call_channel";
            column_call_channel.ReadOnly = true;
            column_call_channel.Width = 204;
            // 
            // CallsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 636);
            Controls.Add(datagrid_call);
            Controls.Add(button_save);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "CallsForm";
            Text = "Дзвінки";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_call).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_save;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem дзвінкиToolStripMenuItem;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private DataGridView datagrid_call;
        private DataGridViewTextBoxColumn column_call_time_created;
        private DataGridViewTextBoxColumn column_call_dispatcher;
        private DataGridViewTextBoxColumn column_call_callout;
        private DataGridViewTextBoxColumn column_call_surname;
        private DataGridViewTextBoxColumn column_call_name;
        private DataGridViewTextBoxColumn column_call_patriarchic;
        private DataGridViewTextBoxColumn column_call_tel;
        private DataGridViewTextBoxColumn column_call_address;
        private DataGridViewTextBoxColumn column_call_reason;
        private DataGridViewTextBoxColumn column_call_channel;
    }
}