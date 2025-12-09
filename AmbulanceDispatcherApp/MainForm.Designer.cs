namespace AmbulanceDispatcherApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datagrid_callout = new DataGridView();
            column_callout_id = new DataGridViewTextBoxColumn();
            column_callout_address = new DataGridViewTextBoxColumn();
            column_callout_reason = new DataGridViewTextBoxColumn();
            column_callout_time = new DataGridViewTextBoxColumn();
            column_callout_comment = new DataGridViewTextBoxColumn();
            column_callout_canceled = new DataGridViewCheckBoxColumn();
            tabControl1 = new TabControl();
            tab_callout = new TabPage();
            tab_call = new TabPage();
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
            tab_dispatcher = new TabPage();
            datagrid_dispatcher = new DataGridView();
            column_dispatcher_surname = new DataGridViewTextBoxColumn();
            column_dispatcher_name = new DataGridViewTextBoxColumn();
            column_dispatcher_patriarchic = new DataGridViewTextBoxColumn();
            column_dispatcher_tel = new DataGridViewTextBoxColumn();
            button_save = new Button();
            button_view_callout = new Button();
            button_view_dispatcher = new Button();
            menuStrip1 = new MenuStrip();
            queryEditToolStripMenuItem = new ToolStripMenuItem();
            дзвінкиToolStripMenuItem = new ToolStripMenuItem();
            створитиToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            пошукToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)datagrid_callout).BeginInit();
            tabControl1.SuspendLayout();
            tab_callout.SuspendLayout();
            tab_call.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_call).BeginInit();
            tab_dispatcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_dispatcher).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // datagrid_callout
            // 
            datagrid_callout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_callout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrid_callout.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_callout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_callout.Columns.AddRange(new DataGridViewColumn[] { column_callout_id, column_callout_address, column_callout_reason, column_callout_time, column_callout_comment, column_callout_canceled });
            datagrid_callout.Location = new Point(6, 6);
            datagrid_callout.MultiSelect = false;
            datagrid_callout.Name = "datagrid_callout";
            datagrid_callout.RowHeadersVisible = false;
            datagrid_callout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_callout.Size = new Size(1268, 573);
            datagrid_callout.TabIndex = 0;
            datagrid_callout.SelectionChanged += datagrid_callout_SelectionChanged;
            // 
            // column_callout_id
            // 
            column_callout_id.DataPropertyName = "callout_id";
            column_callout_id.HeaderText = "№";
            column_callout_id.Name = "column_callout_id";
            column_callout_id.ReadOnly = true;
            column_callout_id.Width = 77;
            // 
            // column_callout_address
            // 
            column_callout_address.DataPropertyName = "callout_address";
            column_callout_address.HeaderText = "Адреса";
            column_callout_address.Name = "column_callout_address";
            column_callout_address.Width = 144;
            // 
            // column_callout_reason
            // 
            column_callout_reason.DataPropertyName = "callout_reason";
            column_callout_reason.HeaderText = "Привід";
            column_callout_reason.Name = "column_callout_reason";
            column_callout_reason.Width = 140;
            // 
            // column_callout_time
            // 
            column_callout_time.DataPropertyName = "callout_time_created";
            column_callout_time.HeaderText = "Час створення";
            column_callout_time.Name = "column_callout_time";
            column_callout_time.Width = 254;
            // 
            // column_callout_comment
            // 
            column_callout_comment.DataPropertyName = "callout_comment";
            column_callout_comment.HeaderText = "Коментар";
            column_callout_comment.Name = "column_callout_comment";
            column_callout_comment.Width = 181;
            // 
            // column_callout_canceled
            // 
            column_callout_canceled.DataPropertyName = "callout_canceled";
            column_callout_canceled.HeaderText = "Скасовано";
            column_callout_canceled.Name = "column_callout_canceled";
            column_callout_canceled.Width = 174;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tab_callout);
            tabControl1.Controls.Add(tab_call);
            tabControl1.Controls.Add(tab_dispatcher);
            tabControl1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(12, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1288, 637);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tab_callout
            // 
            tab_callout.Controls.Add(datagrid_callout);
            tab_callout.Location = new Point(4, 48);
            tab_callout.Name = "tab_callout";
            tab_callout.Padding = new Padding(3);
            tab_callout.Size = new Size(1280, 585);
            tab_callout.TabIndex = 0;
            tab_callout.Text = "Виклики";
            tab_callout.UseVisualStyleBackColor = true;
            // 
            // tab_call
            // 
            tab_call.Controls.Add(datagrid_call);
            tab_call.Location = new Point(4, 48);
            tab_call.Name = "tab_call";
            tab_call.Padding = new Padding(3);
            tab_call.Size = new Size(1280, 585);
            tab_call.TabIndex = 1;
            tab_call.Text = "Дзвінки";
            tab_call.UseVisualStyleBackColor = true;
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
            datagrid_call.Location = new Point(6, 6);
            datagrid_call.MultiSelect = false;
            datagrid_call.Name = "datagrid_call";
            datagrid_call.ReadOnly = true;
            datagrid_call.RowHeadersVisible = false;
            datagrid_call.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_call.Size = new Size(1268, 573);
            datagrid_call.TabIndex = 1;
            datagrid_call.CellDoubleClick += datagrid_call_CellDoubleClick;
            // 
            // column_call_time_created
            // 
            column_call_time_created.DataPropertyName = "call_time_created";
            column_call_time_created.HeaderText = "Час дзвінка";
            column_call_time_created.Name = "column_call_time_created";
            column_call_time_created.ReadOnly = true;
            column_call_time_created.Width = 210;
            // 
            // column_call_dispatcher
            // 
            column_call_dispatcher.DataPropertyName = "dispatcher_fullname";
            column_call_dispatcher.HeaderText = "Диспетчер";
            column_call_dispatcher.Name = "column_call_dispatcher";
            column_call_dispatcher.ReadOnly = true;
            column_call_dispatcher.Width = 197;
            // 
            // column_call_callout
            // 
            column_call_callout.DataPropertyName = "callout_id";
            column_call_callout.HeaderText = "№ Виклику";
            column_call_callout.Name = "column_call_callout";
            column_call_callout.ReadOnly = true;
            column_call_callout.Width = 208;
            // 
            // column_call_surname
            // 
            column_call_surname.DataPropertyName = "call_caller_surname";
            column_call_surname.HeaderText = "Прізвище";
            column_call_surname.Name = "column_call_surname";
            column_call_surname.ReadOnly = true;
            column_call_surname.Width = 179;
            // 
            // column_call_name
            // 
            column_call_name.DataPropertyName = "call_caller_name";
            column_call_name.HeaderText = "Ім'я";
            column_call_name.Name = "column_call_name";
            column_call_name.ReadOnly = true;
            column_call_name.Width = 96;
            // 
            // column_call_patriarchic
            // 
            column_call_patriarchic.DataPropertyName = "call_caller_patriarchic";
            column_call_patriarchic.HeaderText = "По батькові";
            column_call_patriarchic.Name = "column_call_patriarchic";
            column_call_patriarchic.ReadOnly = true;
            column_call_patriarchic.Width = 212;
            // 
            // column_call_tel
            // 
            column_call_tel.DataPropertyName = "call_caller_tel";
            column_call_tel.HeaderText = "Телефон";
            column_call_tel.Name = "column_call_tel";
            column_call_tel.ReadOnly = true;
            column_call_tel.Width = 170;
            // 
            // column_call_address
            // 
            column_call_address.DataPropertyName = "call_address";
            column_call_address.HeaderText = "Адреса";
            column_call_address.Name = "column_call_address";
            column_call_address.ReadOnly = true;
            column_call_address.Width = 144;
            // 
            // column_call_reason
            // 
            column_call_reason.DataPropertyName = "call_reason";
            column_call_reason.HeaderText = "Привід";
            column_call_reason.Name = "column_call_reason";
            column_call_reason.ReadOnly = true;
            column_call_reason.Width = 140;
            // 
            // column_call_channel
            // 
            column_call_channel.DataPropertyName = "call_channel";
            column_call_channel.HeaderText = "Канал зв'язку";
            column_call_channel.Name = "column_call_channel";
            column_call_channel.ReadOnly = true;
            column_call_channel.Width = 242;
            // 
            // tab_dispatcher
            // 
            tab_dispatcher.Controls.Add(datagrid_dispatcher);
            tab_dispatcher.Location = new Point(4, 48);
            tab_dispatcher.Name = "tab_dispatcher";
            tab_dispatcher.Padding = new Padding(3);
            tab_dispatcher.Size = new Size(1280, 585);
            tab_dispatcher.TabIndex = 2;
            tab_dispatcher.Text = "Диспетчери";
            tab_dispatcher.UseVisualStyleBackColor = true;
            // 
            // datagrid_dispatcher
            // 
            datagrid_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_dispatcher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrid_dispatcher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_dispatcher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_dispatcher.Columns.AddRange(new DataGridViewColumn[] { column_dispatcher_surname, column_dispatcher_name, column_dispatcher_patriarchic, column_dispatcher_tel });
            datagrid_dispatcher.Location = new Point(6, 6);
            datagrid_dispatcher.MultiSelect = false;
            datagrid_dispatcher.Name = "datagrid_dispatcher";
            datagrid_dispatcher.RowHeadersVisible = false;
            datagrid_dispatcher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_dispatcher.Size = new Size(1268, 573);
            datagrid_dispatcher.TabIndex = 1;
            datagrid_dispatcher.SelectionChanged += datagrid_dispatcher_SelectionChanged;
            // 
            // column_dispatcher_surname
            // 
            column_dispatcher_surname.DataPropertyName = "dispatcher_surname";
            column_dispatcher_surname.HeaderText = "Прізвище";
            column_dispatcher_surname.Name = "column_dispatcher_surname";
            column_dispatcher_surname.Width = 179;
            // 
            // column_dispatcher_name
            // 
            column_dispatcher_name.DataPropertyName = "dispatcher_name";
            column_dispatcher_name.HeaderText = "Ім'я";
            column_dispatcher_name.Name = "column_dispatcher_name";
            column_dispatcher_name.Width = 96;
            // 
            // column_dispatcher_patriarchic
            // 
            column_dispatcher_patriarchic.DataPropertyName = "dispatcher_patriarchic";
            column_dispatcher_patriarchic.HeaderText = "По батькові";
            column_dispatcher_patriarchic.Name = "column_dispatcher_patriarchic";
            column_dispatcher_patriarchic.Width = 212;
            // 
            // column_dispatcher_tel
            // 
            column_dispatcher_tel.DataPropertyName = "dispatcher_tel";
            column_dispatcher_tel.HeaderText = "Телефон";
            column_dispatcher_tel.Name = "column_dispatcher_tel";
            column_dispatcher_tel.Width = 170;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Font = new Font("Tahoma", 20.25F);
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(1145, 679);
            button_save.Name = "button_save";
            button_save.Size = new Size(151, 49);
            button_save.TabIndex = 3;
            button_save.Text = "  Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_view_callout
            // 
            button_view_callout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_view_callout.Enabled = false;
            button_view_callout.Font = new Font("Tahoma", 20.25F);
            button_view_callout.Image = Properties.Resources._211861_16x16;
            button_view_callout.ImageAlign = ContentAlignment.MiddleLeft;
            button_view_callout.Location = new Point(12, 679);
            button_view_callout.Name = "button_view_callout";
            button_view_callout.Size = new Size(231, 49);
            button_view_callout.TabIndex = 7;
            button_view_callout.Text = "   Знайти виклик";
            button_view_callout.UseVisualStyleBackColor = true;
            button_view_callout.Click += button_view_callout_Click;
            // 
            // button_view_dispatcher
            // 
            button_view_dispatcher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_view_dispatcher.Enabled = false;
            button_view_dispatcher.Font = new Font("Tahoma", 20.25F);
            button_view_dispatcher.Image = Properties.Resources._211861_16x16;
            button_view_dispatcher.ImageAlign = ContentAlignment.MiddleLeft;
            button_view_dispatcher.Location = new Point(249, 679);
            button_view_dispatcher.Name = "button_view_dispatcher";
            button_view_dispatcher.Size = new Size(289, 49);
            button_view_dispatcher.TabIndex = 8;
            button_view_dispatcher.Text = "   Знайти диспетчера";
            button_view_dispatcher.UseVisualStyleBackColor = true;
            button_view_dispatcher.Click += button_view_dispatcher_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { queryEditToolStripMenuItem, дзвінкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // queryEditToolStripMenuItem
            // 
            queryEditToolStripMenuItem.Name = "queryEditToolStripMenuItem";
            queryEditToolStripMenuItem.Size = new Size(116, 29);
            queryEditToolStripMenuItem.Text = "QueryEdit";
            queryEditToolStripMenuItem.Click += queryEditToolStripMenuItem_Click;
            // 
            // дзвінкиToolStripMenuItem
            // 
            дзвінкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиToolStripMenuItem, редагуватиToolStripMenuItem, видалитиToolStripMenuItem, пошукToolStripMenuItem });
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
            // пошукToolStripMenuItem
            // 
            пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            пошукToolStripMenuItem.Size = new Size(193, 30);
            пошукToolStripMenuItem.Text = "Пошук";
            пошукToolStripMenuItem.Click += пошукToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 740);
            Controls.Add(button_view_dispatcher);
            Controls.Add(button_view_callout);
            Controls.Add(button_save);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Диспетчер Викликів";
            ((System.ComponentModel.ISupportInitialize)datagrid_callout).EndInit();
            tabControl1.ResumeLayout(false);
            tab_callout.ResumeLayout(false);
            tab_call.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid_call).EndInit();
            tab_dispatcher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid_dispatcher).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagrid_callout;
        private TabControl tabControl1;
        private TabPage tab_callout;
        private TabPage tab_call;
        private Button button_save;
        private TabPage tab_dispatcher;
        private DataGridView datagrid_call;
        private DataGridView datagrid_dispatcher;
        private DataGridViewTextBoxColumn column_dispatcher_surname;
        private DataGridViewTextBoxColumn column_dispatcher_name;
        private DataGridViewTextBoxColumn column_dispatcher_patriarchic;
        private DataGridViewTextBoxColumn column_dispatcher_tel;
        private Button button_view_callout;
        private Button button_view_dispatcher;
        private DataGridViewTextBoxColumn column_callout_id;
        private DataGridViewTextBoxColumn column_callout_address;
        private DataGridViewTextBoxColumn column_callout_reason;
        private DataGridViewTextBoxColumn column_callout_time;
        private DataGridViewTextBoxColumn column_callout_comment;
        private DataGridViewCheckBoxColumn column_callout_canceled;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem queryEditToolStripMenuItem;
        private ToolStripMenuItem дзвінкиToolStripMenuItem;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
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
        private ToolStripMenuItem пошукToolStripMenuItem;
    }
}
