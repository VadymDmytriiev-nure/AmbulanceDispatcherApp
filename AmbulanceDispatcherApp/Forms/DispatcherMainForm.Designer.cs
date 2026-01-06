namespace AmbulanceDispatcherApp
{
    partial class DispatcherMainForm
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
            splitbox = new SplitContainer();
            group_calls = new GroupBox();
            checkbox_call_resize_columns = new CheckBox();
            datagridview_call = new DataGridView();
            column_call_id = new DataGridViewTextBoxColumn();
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
            panel_call_crud = new Panel();
            button_call_view = new Button();
            button_call_create = new Button();
            button_call_delete = new Button();
            button_call_edit = new Button();
            textbox_call_search = new TextBox();
            panel_call_filters = new Panel();
            button_call_filters_reset = new Button();
            button_call_filters = new Button();
            label1 = new Label();
            group_callouts = new GroupBox();
            checkbox_callout_resize_columns = new CheckBox();
            panel_callout_filters = new Panel();
            button_callout_filters_reset = new Button();
            button_callout_filters = new Button();
            panel_callout_crud = new Panel();
            button_callout_from_call = new Button();
            button_callout_view = new Button();
            button_callout_create = new Button();
            button_callout_delete = new Button();
            button_callout_edit = new Button();
            label2 = new Label();
            textbox_callout_search = new TextBox();
            datagridview_callout = new DataGridView();
            column_callout_id = new DataGridViewTextBoxColumn();
            column_callout_time_created = new DataGridViewTextBoxColumn();
            column_callout_address = new DataGridViewTextBoxColumn();
            column_callout_reason = new DataGridViewTextBoxColumn();
            column_callout_comment = new DataGridViewTextBoxColumn();
            column_callout_canceled = new DataGridViewCheckBoxColumn();
            button_refresh = new Button();
            button_logout = new Button();
            label_max_rows = new Label();
            label_authorized_as = new Label();
            panel_refresh = new Panel();
            panel_otherdata = new Panel();
            button_view_dispatchers = new Button();
            button_view_substations = new Button();
            button_view_brigades = new Button();
            button_view_departures = new Button();
            button_view_hospitals = new Button();
            button_view_workers = new Button();
            button_view_patients = new Button();
            ((System.ComponentModel.ISupportInitialize)splitbox).BeginInit();
            splitbox.Panel1.SuspendLayout();
            splitbox.Panel2.SuspendLayout();
            splitbox.SuspendLayout();
            group_calls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_call).BeginInit();
            panel_call_crud.SuspendLayout();
            panel_call_filters.SuspendLayout();
            group_callouts.SuspendLayout();
            panel_callout_filters.SuspendLayout();
            panel_callout_crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_callout).BeginInit();
            panel_refresh.SuspendLayout();
            panel_otherdata.SuspendLayout();
            SuspendLayout();
            // 
            // splitbox
            // 
            splitbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitbox.Location = new Point(12, 0);
            splitbox.Name = "splitbox";
            splitbox.Orientation = Orientation.Horizontal;
            // 
            // splitbox.Panel1
            // 
            splitbox.Panel1.Controls.Add(group_calls);
            splitbox.Panel1MinSize = 310;
            // 
            // splitbox.Panel2
            // 
            splitbox.Panel2.Controls.Add(group_callouts);
            splitbox.Panel2MinSize = 310;
            splitbox.Size = new Size(948, 752);
            splitbox.SplitterDistance = 353;
            splitbox.TabIndex = 1;
            // 
            // group_calls
            // 
            group_calls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_calls.Controls.Add(checkbox_call_resize_columns);
            group_calls.Controls.Add(datagridview_call);
            group_calls.Controls.Add(panel_call_crud);
            group_calls.Controls.Add(textbox_call_search);
            group_calls.Controls.Add(panel_call_filters);
            group_calls.Controls.Add(label1);
            group_calls.Location = new Point(3, 3);
            group_calls.Name = "group_calls";
            group_calls.Size = new Size(942, 350);
            group_calls.TabIndex = 6;
            group_calls.TabStop = false;
            group_calls.Text = "Дзвінки";
            // 
            // checkbox_call_resize_columns
            // 
            checkbox_call_resize_columns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkbox_call_resize_columns.AutoSize = true;
            checkbox_call_resize_columns.Checked = true;
            checkbox_call_resize_columns.CheckState = CheckState.Checked;
            checkbox_call_resize_columns.Location = new Point(755, 22);
            checkbox_call_resize_columns.Name = "checkbox_call_resize_columns";
            checkbox_call_resize_columns.Size = new Size(184, 25);
            checkbox_call_resize_columns.TabIndex = 24;
            checkbox_call_resize_columns.Text = "Авто-розмір стовпців";
            checkbox_call_resize_columns.UseVisualStyleBackColor = true;
            checkbox_call_resize_columns.CheckedChanged += checkbox_call_resize_columns_CheckedChanged;
            // 
            // datagridview_call
            // 
            datagridview_call.AllowUserToAddRows = false;
            datagridview_call.AllowUserToDeleteRows = false;
            datagridview_call.AllowUserToResizeRows = false;
            datagridview_call.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_call.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_call.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_call.Columns.AddRange(new DataGridViewColumn[] { column_call_id, column_call_time_created, column_call_dispatcher, column_call_callout, column_call_surname, column_call_name, column_call_patriarchic, column_call_tel, column_call_address, column_call_reason, column_call_channel });
            datagridview_call.Location = new Point(6, 63);
            datagridview_call.MultiSelect = false;
            datagridview_call.Name = "datagridview_call";
            datagridview_call.ReadOnly = true;
            datagridview_call.RowHeadersVisible = false;
            datagridview_call.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_call.Size = new Size(732, 281);
            datagridview_call.TabIndex = 0;
            datagridview_call.SelectionChanged += datagridview_call_SelectionChanged;
            // 
            // column_call_id
            // 
            column_call_id.DataPropertyName = "call_id";
            column_call_id.HeaderText = "№";
            column_call_id.Name = "column_call_id";
            column_call_id.ReadOnly = true;
            column_call_id.Width = 51;
            // 
            // column_call_time_created
            // 
            column_call_time_created.DataPropertyName = "call_time_created";
            column_call_time_created.HeaderText = "Час дзвінка";
            column_call_time_created.Name = "column_call_time_created";
            column_call_time_created.ReadOnly = true;
            column_call_time_created.Width = 116;
            // 
            // column_call_dispatcher
            // 
            column_call_dispatcher.DataPropertyName = "dispatcher_fullname";
            column_call_dispatcher.HeaderText = "Диспетчер";
            column_call_dispatcher.Name = "column_call_dispatcher";
            column_call_dispatcher.ReadOnly = true;
            column_call_dispatcher.Width = 110;
            // 
            // column_call_callout
            // 
            column_call_callout.DataPropertyName = "callout_id";
            column_call_callout.HeaderText = "№ Виклику";
            column_call_callout.Name = "column_call_callout";
            column_call_callout.ReadOnly = true;
            column_call_callout.Width = 114;
            // 
            // column_call_surname
            // 
            column_call_surname.DataPropertyName = "call_caller_surname";
            column_call_surname.HeaderText = "Прізвище";
            column_call_surname.Name = "column_call_surname";
            column_call_surname.ReadOnly = true;
            column_call_surname.Width = 102;
            // 
            // column_call_name
            // 
            column_call_name.DataPropertyName = "call_caller_name";
            column_call_name.HeaderText = "Ім'я";
            column_call_name.Name = "column_call_name";
            column_call_name.ReadOnly = true;
            column_call_name.Width = 60;
            // 
            // column_call_patriarchic
            // 
            column_call_patriarchic.DataPropertyName = "call_caller_patriarchic";
            column_call_patriarchic.HeaderText = "По батькові";
            column_call_patriarchic.Name = "column_call_patriarchic";
            column_call_patriarchic.ReadOnly = true;
            column_call_patriarchic.Width = 118;
            // 
            // column_call_tel
            // 
            column_call_tel.DataPropertyName = "call_caller_tel";
            column_call_tel.HeaderText = "Телефон";
            column_call_tel.Name = "column_call_tel";
            column_call_tel.ReadOnly = true;
            column_call_tel.Width = 94;
            // 
            // column_call_address
            // 
            column_call_address.DataPropertyName = "call_address";
            column_call_address.HeaderText = "Адреса";
            column_call_address.Name = "column_call_address";
            column_call_address.ReadOnly = true;
            column_call_address.Width = 84;
            // 
            // column_call_reason
            // 
            column_call_reason.DataPropertyName = "call_reason";
            column_call_reason.HeaderText = "Привід";
            column_call_reason.Name = "column_call_reason";
            column_call_reason.ReadOnly = true;
            column_call_reason.Width = 83;
            // 
            // column_call_channel
            // 
            column_call_channel.DataPropertyName = "call_channel";
            column_call_channel.HeaderText = "Канал зв'язку";
            column_call_channel.Name = "column_call_channel";
            column_call_channel.ReadOnly = true;
            column_call_channel.Width = 129;
            // 
            // panel_call_crud
            // 
            panel_call_crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_call_crud.BorderStyle = BorderStyle.Fixed3D;
            panel_call_crud.Controls.Add(button_call_view);
            panel_call_crud.Controls.Add(button_call_create);
            panel_call_crud.Controls.Add(button_call_delete);
            panel_call_crud.Controls.Add(button_call_edit);
            panel_call_crud.Location = new Point(744, 130);
            panel_call_crud.Name = "panel_call_crud";
            panel_call_crud.Size = new Size(192, 214);
            panel_call_crud.TabIndex = 15;
            // 
            // button_call_view
            // 
            button_call_view.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_call_view.Location = new Point(3, 5);
            button_call_view.Name = "button_call_view";
            button_call_view.Size = new Size(183, 46);
            button_call_view.TabIndex = 5;
            button_call_view.Text = "Переглянути";
            button_call_view.UseVisualStyleBackColor = true;
            button_call_view.Click += button_call_view_Click;
            // 
            // button_call_create
            // 
            button_call_create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_call_create.Location = new Point(3, 57);
            button_call_create.Name = "button_call_create";
            button_call_create.Size = new Size(183, 46);
            button_call_create.TabIndex = 6;
            button_call_create.Text = "Створити";
            button_call_create.UseVisualStyleBackColor = true;
            button_call_create.Click += button_call_create_Click;
            // 
            // button_call_delete
            // 
            button_call_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_call_delete.Location = new Point(3, 161);
            button_call_delete.Name = "button_call_delete";
            button_call_delete.Size = new Size(183, 46);
            button_call_delete.TabIndex = 12;
            button_call_delete.Text = "Видалити";
            button_call_delete.UseVisualStyleBackColor = true;
            button_call_delete.Click += button_call_delete_Click;
            // 
            // button_call_edit
            // 
            button_call_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_call_edit.Location = new Point(3, 109);
            button_call_edit.Name = "button_call_edit";
            button_call_edit.Size = new Size(183, 46);
            button_call_edit.TabIndex = 11;
            button_call_edit.Text = "Редагувати";
            button_call_edit.UseVisualStyleBackColor = true;
            button_call_edit.Click += button_call_edit_Click;
            // 
            // textbox_call_search
            // 
            textbox_call_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_call_search.Location = new Point(71, 22);
            textbox_call_search.Name = "textbox_call_search";
            textbox_call_search.Size = new Size(419, 29);
            textbox_call_search.TabIndex = 7;
            // 
            // panel_call_filters
            // 
            panel_call_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_call_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_call_filters.Controls.Add(button_call_filters_reset);
            panel_call_filters.Controls.Add(button_call_filters);
            panel_call_filters.Location = new Point(496, 14);
            panel_call_filters.Name = "panel_call_filters";
            panel_call_filters.Size = new Size(242, 43);
            panel_call_filters.TabIndex = 14;
            // 
            // button_call_filters_reset
            // 
            button_call_filters_reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_call_filters_reset.Location = new Point(3, 3);
            button_call_filters_reset.Name = "button_call_filters_reset";
            button_call_filters_reset.Size = new Size(112, 34);
            button_call_filters_reset.TabIndex = 10;
            button_call_filters_reset.Text = "Скинути";
            button_call_filters_reset.UseVisualStyleBackColor = true;
            button_call_filters_reset.Click += button_call_filters_reset_Click;
            // 
            // button_call_filters
            // 
            button_call_filters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_call_filters.Location = new Point(117, 3);
            button_call_filters.Name = "button_call_filters";
            button_call_filters.Size = new Size(118, 34);
            button_call_filters.TabIndex = 9;
            button_call_filters.Text = "Фільтри";
            button_call_filters.UseVisualStyleBackColor = true;
            button_call_filters.Click += button_call_filters_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 8;
            label1.Text = "Пошук";
            // 
            // group_callouts
            // 
            group_callouts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            group_callouts.Controls.Add(checkbox_callout_resize_columns);
            group_callouts.Controls.Add(panel_callout_filters);
            group_callouts.Controls.Add(panel_callout_crud);
            group_callouts.Controls.Add(label2);
            group_callouts.Controls.Add(textbox_callout_search);
            group_callouts.Controls.Add(datagridview_callout);
            group_callouts.FlatStyle = FlatStyle.Flat;
            group_callouts.Location = new Point(3, 3);
            group_callouts.Name = "group_callouts";
            group_callouts.Size = new Size(942, 389);
            group_callouts.TabIndex = 0;
            group_callouts.TabStop = false;
            group_callouts.Text = "Виклики";
            // 
            // checkbox_callout_resize_columns
            // 
            checkbox_callout_resize_columns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkbox_callout_resize_columns.AutoSize = true;
            checkbox_callout_resize_columns.Checked = true;
            checkbox_callout_resize_columns.CheckState = CheckState.Checked;
            checkbox_callout_resize_columns.Location = new Point(755, 26);
            checkbox_callout_resize_columns.Name = "checkbox_callout_resize_columns";
            checkbox_callout_resize_columns.Size = new Size(184, 25);
            checkbox_callout_resize_columns.TabIndex = 25;
            checkbox_callout_resize_columns.Text = "Авто-розмір стовпців";
            checkbox_callout_resize_columns.UseVisualStyleBackColor = true;
            checkbox_callout_resize_columns.CheckedChanged += checkbox_callout_resize_columns_CheckedChanged;
            // 
            // panel_callout_filters
            // 
            panel_callout_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_callout_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_callout_filters.Controls.Add(button_callout_filters_reset);
            panel_callout_filters.Controls.Add(button_callout_filters);
            panel_callout_filters.Location = new Point(496, 15);
            panel_callout_filters.Name = "panel_callout_filters";
            panel_callout_filters.Size = new Size(242, 43);
            panel_callout_filters.TabIndex = 15;
            // 
            // button_callout_filters_reset
            // 
            button_callout_filters_reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_callout_filters_reset.Location = new Point(3, 3);
            button_callout_filters_reset.Name = "button_callout_filters_reset";
            button_callout_filters_reset.Size = new Size(112, 34);
            button_callout_filters_reset.TabIndex = 12;
            button_callout_filters_reset.Text = "Скинути";
            button_callout_filters_reset.UseVisualStyleBackColor = true;
            button_callout_filters_reset.Click += button_callout_filters_reset_Click;
            // 
            // button_callout_filters
            // 
            button_callout_filters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_callout_filters.Location = new Point(117, 3);
            button_callout_filters.Name = "button_callout_filters";
            button_callout_filters.Size = new Size(118, 34);
            button_callout_filters.TabIndex = 11;
            button_callout_filters.Text = "Фільтри";
            button_callout_filters.UseVisualStyleBackColor = true;
            button_callout_filters.Click += button_callout_filters_Click;
            // 
            // panel_callout_crud
            // 
            panel_callout_crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_callout_crud.BackColor = SystemColors.Control;
            panel_callout_crud.BorderStyle = BorderStyle.Fixed3D;
            panel_callout_crud.Controls.Add(button_callout_from_call);
            panel_callout_crud.Controls.Add(button_callout_view);
            panel_callout_crud.Controls.Add(button_callout_create);
            panel_callout_crud.Controls.Add(button_callout_delete);
            panel_callout_crud.Controls.Add(button_callout_edit);
            panel_callout_crud.Location = new Point(744, 164);
            panel_callout_crud.Name = "panel_callout_crud";
            panel_callout_crud.Size = new Size(192, 216);
            panel_callout_crud.TabIndex = 21;
            // 
            // button_callout_from_call
            // 
            button_callout_from_call.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_callout_from_call.Image = Properties.Resources._212240_32x32;
            button_callout_from_call.Location = new Point(134, 58);
            button_callout_from_call.Name = "button_callout_from_call";
            button_callout_from_call.Size = new Size(51, 46);
            button_callout_from_call.TabIndex = 26;
            button_callout_from_call.UseVisualStyleBackColor = true;
            button_callout_from_call.Click += button_callout_from_call_Click;
            // 
            // button_callout_view
            // 
            button_callout_view.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_callout_view.Location = new Point(3, 6);
            button_callout_view.Name = "button_callout_view";
            button_callout_view.Size = new Size(183, 46);
            button_callout_view.TabIndex = 5;
            button_callout_view.Text = "Переглянути";
            button_callout_view.UseVisualStyleBackColor = true;
            button_callout_view.Click += button_callout_view_Click;
            // 
            // button_callout_create
            // 
            button_callout_create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_callout_create.Location = new Point(3, 58);
            button_callout_create.Name = "button_callout_create";
            button_callout_create.Size = new Size(125, 46);
            button_callout_create.TabIndex = 6;
            button_callout_create.Text = "Створити";
            button_callout_create.UseVisualStyleBackColor = true;
            button_callout_create.Click += button_callout_create_Click;
            // 
            // button_callout_delete
            // 
            button_callout_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_callout_delete.Location = new Point(3, 161);
            button_callout_delete.Name = "button_callout_delete";
            button_callout_delete.Size = new Size(183, 46);
            button_callout_delete.TabIndex = 12;
            button_callout_delete.Text = "Видалити";
            button_callout_delete.UseVisualStyleBackColor = true;
            button_callout_delete.Click += button_callout_delete_Click;
            // 
            // button_callout_edit
            // 
            button_callout_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_callout_edit.Location = new Point(3, 110);
            button_callout_edit.Name = "button_callout_edit";
            button_callout_edit.Size = new Size(183, 46);
            button_callout_edit.TabIndex = 11;
            button_callout_edit.Text = "Редагувати";
            button_callout_edit.UseVisualStyleBackColor = true;
            button_callout_edit.Click += button_callout_edit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 18;
            label2.Text = "Пошук";
            // 
            // textbox_callout_search
            // 
            textbox_callout_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_callout_search.Location = new Point(71, 24);
            textbox_callout_search.Name = "textbox_callout_search";
            textbox_callout_search.Size = new Size(419, 29);
            textbox_callout_search.TabIndex = 17;
            // 
            // datagridview_callout
            // 
            datagridview_callout.AllowUserToAddRows = false;
            datagridview_callout.AllowUserToDeleteRows = false;
            datagridview_callout.AllowUserToResizeRows = false;
            datagridview_callout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_callout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_callout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_callout.Columns.AddRange(new DataGridViewColumn[] { column_callout_id, column_callout_time_created, column_callout_address, column_callout_reason, column_callout_comment, column_callout_canceled });
            datagridview_callout.Location = new Point(6, 64);
            datagridview_callout.MultiSelect = false;
            datagridview_callout.Name = "datagridview_callout";
            datagridview_callout.ReadOnly = true;
            datagridview_callout.RowHeadersVisible = false;
            datagridview_callout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_callout.Size = new Size(732, 316);
            datagridview_callout.TabIndex = 16;
            datagridview_callout.SelectionChanged += datagridview_callout_SelectionChanged;
            // 
            // column_callout_id
            // 
            column_callout_id.DataPropertyName = "callout_id";
            column_callout_id.HeaderText = "№";
            column_callout_id.Name = "column_callout_id";
            column_callout_id.ReadOnly = true;
            column_callout_id.Width = 51;
            // 
            // column_callout_time_created
            // 
            column_callout_time_created.DataPropertyName = "callout_time_created";
            column_callout_time_created.HeaderText = "Час створення";
            column_callout_time_created.Name = "column_callout_time_created";
            column_callout_time_created.ReadOnly = true;
            column_callout_time_created.Width = 137;
            // 
            // column_callout_address
            // 
            column_callout_address.DataPropertyName = "callout_address";
            column_callout_address.HeaderText = "Адреса";
            column_callout_address.Name = "column_callout_address";
            column_callout_address.ReadOnly = true;
            column_callout_address.Width = 84;
            // 
            // column_callout_reason
            // 
            column_callout_reason.DataPropertyName = "callout_reason";
            column_callout_reason.HeaderText = "Привід";
            column_callout_reason.Name = "column_callout_reason";
            column_callout_reason.ReadOnly = true;
            column_callout_reason.Width = 83;
            // 
            // column_callout_comment
            // 
            column_callout_comment.DataPropertyName = "callout_comment";
            column_callout_comment.HeaderText = "Коментар";
            column_callout_comment.Name = "column_callout_comment";
            column_callout_comment.ReadOnly = true;
            column_callout_comment.Width = 103;
            // 
            // column_callout_canceled
            // 
            column_callout_canceled.DataPropertyName = "callout_canceled";
            column_callout_canceled.HeaderText = "Скасовано";
            column_callout_canceled.Name = "column_callout_canceled";
            column_callout_canceled.ReadOnly = true;
            column_callout_canceled.Width = 90;
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_refresh.Location = new Point(3, 3);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(190, 46);
            button_refresh.TabIndex = 13;
            button_refresh.Text = "Оновити";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // button_logout
            // 
            button_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_logout.ImageAlign = ContentAlignment.MiddleLeft;
            button_logout.Location = new Point(966, 696);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(201, 46);
            button_logout.TabIndex = 4;
            button_logout.Text = "Вийти";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // label_max_rows
            // 
            label_max_rows.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_max_rows.AutoSize = true;
            label_max_rows.Location = new Point(966, 661);
            label_max_rows.Name = "label_max_rows";
            label_max_rows.Size = new Size(207, 21);
            label_max_rows.TabIndex = 24;
            label_max_rows.Text = "Макс. кількість рядків - 500";
            // 
            // label_authorized_as
            // 
            label_authorized_as.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_authorized_as.AutoSize = true;
            label_authorized_as.Location = new Point(966, 616);
            label_authorized_as.MaximumSize = new Size(200, 0);
            label_authorized_as.Name = "label_authorized_as";
            label_authorized_as.Size = new Size(150, 42);
            label_authorized_as.TabIndex = 25;
            label_authorized_as.Text = "Ви авторизовані як:\r\n<user>";
            label_authorized_as.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel_refresh
            // 
            panel_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_refresh.BorderStyle = BorderStyle.Fixed3D;
            panel_refresh.Controls.Add(button_refresh);
            panel_refresh.Location = new Point(966, 12);
            panel_refresh.Name = "panel_refresh";
            panel_refresh.Size = new Size(200, 57);
            panel_refresh.TabIndex = 26;
            // 
            // panel_otherdata
            // 
            panel_otherdata.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_otherdata.BorderStyle = BorderStyle.Fixed3D;
            panel_otherdata.Controls.Add(button_view_dispatchers);
            panel_otherdata.Controls.Add(button_view_substations);
            panel_otherdata.Controls.Add(button_view_brigades);
            panel_otherdata.Controls.Add(button_view_departures);
            panel_otherdata.Controls.Add(button_view_hospitals);
            panel_otherdata.Controls.Add(button_view_workers);
            panel_otherdata.Controls.Add(button_view_patients);
            panel_otherdata.Location = new Point(966, 75);
            panel_otherdata.Name = "panel_otherdata";
            panel_otherdata.Size = new Size(200, 370);
            panel_otherdata.TabIndex = 27;
            // 
            // button_view_dispatchers
            // 
            button_view_dispatchers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_dispatchers.Enabled = false;
            button_view_dispatchers.Location = new Point(3, 315);
            button_view_dispatchers.Name = "button_view_dispatchers";
            button_view_dispatchers.Size = new Size(190, 46);
            button_view_dispatchers.TabIndex = 13;
            button_view_dispatchers.Text = "Диспетчери";
            button_view_dispatchers.UseVisualStyleBackColor = true;
            button_view_dispatchers.Click += button_view_dispatchers_Click;
            // 
            // button_view_substations
            // 
            button_view_substations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_substations.Location = new Point(3, 263);
            button_view_substations.Name = "button_view_substations";
            button_view_substations.Size = new Size(190, 46);
            button_view_substations.TabIndex = 12;
            button_view_substations.Text = "Підстанції";
            button_view_substations.UseVisualStyleBackColor = true;
            button_view_substations.Click += button_view_substations_Click;
            // 
            // button_view_brigades
            // 
            button_view_brigades.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_brigades.Location = new Point(3, 211);
            button_view_brigades.Name = "button_view_brigades";
            button_view_brigades.Size = new Size(190, 46);
            button_view_brigades.TabIndex = 11;
            button_view_brigades.Text = "Бригади";
            button_view_brigades.UseVisualStyleBackColor = true;
            button_view_brigades.Click += button_view_brigades_Click;
            // 
            // button_view_departures
            // 
            button_view_departures.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_departures.Location = new Point(3, 55);
            button_view_departures.Name = "button_view_departures";
            button_view_departures.Size = new Size(190, 46);
            button_view_departures.TabIndex = 10;
            button_view_departures.Text = "Виїзди";
            button_view_departures.UseVisualStyleBackColor = true;
            button_view_departures.Click += button_view_departures_Click;
            // 
            // button_view_hospitals
            // 
            button_view_hospitals.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_hospitals.Location = new Point(3, 107);
            button_view_hospitals.Name = "button_view_hospitals";
            button_view_hospitals.Size = new Size(190, 46);
            button_view_hospitals.TabIndex = 8;
            button_view_hospitals.Text = "Лікарні";
            button_view_hospitals.UseVisualStyleBackColor = true;
            button_view_hospitals.Click += button_view_hospitals_Click;
            // 
            // button_view_workers
            // 
            button_view_workers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_workers.Location = new Point(3, 159);
            button_view_workers.Name = "button_view_workers";
            button_view_workers.Size = new Size(190, 46);
            button_view_workers.TabIndex = 7;
            button_view_workers.Text = "Працівники";
            button_view_workers.UseVisualStyleBackColor = true;
            button_view_workers.Click += button_view_workers_Click;
            // 
            // button_view_patients
            // 
            button_view_patients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_view_patients.Location = new Point(3, 3);
            button_view_patients.Name = "button_view_patients";
            button_view_patients.Size = new Size(190, 46);
            button_view_patients.TabIndex = 6;
            button_view_patients.Text = "Пацієнти";
            button_view_patients.UseVisualStyleBackColor = true;
            button_view_patients.Click += button_view_patients_Click;
            // 
            // DispatcherMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 754);
            Controls.Add(panel_otherdata);
            Controls.Add(panel_refresh);
            Controls.Add(label_authorized_as);
            Controls.Add(label_max_rows);
            Controls.Add(button_logout);
            Controls.Add(splitbox);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(840, 670);
            Name = "DispatcherMainForm";
            Text = "Диспетчер викликів";
            FormClosed += DispatcherMainForm_FormClosed;
            Load += DispatcherMainForm_Load;
            splitbox.Panel1.ResumeLayout(false);
            splitbox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitbox).EndInit();
            splitbox.ResumeLayout(false);
            group_calls.ResumeLayout(false);
            group_calls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_call).EndInit();
            panel_call_crud.ResumeLayout(false);
            panel_call_filters.ResumeLayout(false);
            group_callouts.ResumeLayout(false);
            group_callouts.PerformLayout();
            panel_callout_filters.ResumeLayout(false);
            panel_callout_crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_callout).EndInit();
            panel_refresh.ResumeLayout(false);
            panel_otherdata.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitbox;
        private DataGridView datagridview_call;
        private Button button_call_filters_reset;
        private Button button_call_filters;
        private Label label1;
        private TextBox textbox_call_search;
        private Button button_call_create;
        private Button button_call_view;
        private Button button_logout;
        private Button button_refresh;
        private Button button_call_delete;
        private Button button_call_edit;
        private Panel panel_call_filters;
        private Panel panel_call_crud;
        private Panel panel_callout_crud;
        private Button button_callout_view;
        private Button button_callout_create;
        private Button button_callout_delete;
        private Button button_callout_edit;
        private Label label2;
        private TextBox textbox_callout_search;
        private DataGridView datagridview_callout;
        private Panel panel_callout_filters;
        private Button button_callout_filters_reset;
        private Button button_callout_filters;
        private GroupBox group_callouts;
        private GroupBox group_calls;
        private DataGridViewTextBoxColumn column_call_id;
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
        private Label label_max_rows;
        private Label label_authorized_as;
        private Panel panel_refresh;
        private Panel panel_otherdata;
        private Button button3;
        private Button button_view_hospitals;
        private Button button_view_workers;
        private Button button_view_patients;
        private Button button_view_brigades;
        private Button button_view_departures;
        private CheckBox checkbox_call_resize_columns;
        private CheckBox checkbox_callout_resize_columns;
        private Button button_view_substations;
        private DataGridViewTextBoxColumn column_callout_id;
        private DataGridViewTextBoxColumn column_callout_time_created;
        private DataGridViewTextBoxColumn column_callout_address;
        private DataGridViewTextBoxColumn column_callout_reason;
        private DataGridViewTextBoxColumn column_callout_comment;
        private DataGridViewCheckBoxColumn column_callout_canceled;
        private Button button_callout_from_call;
        public Button button_view_dispatchers;
    }
}