namespace AmbulanceDispatcherApp.Forms.Dispatcher
{
    partial class DispatchersForm
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
            checkbox_auto_resize_columns = new CheckBox();
            panel_crud = new Panel();
            button_crud_create = new Button();
            button_crud_delete = new Button();
            button_crud_edit = new Button();
            textbox_search = new TextBox();
            panel_filters = new Panel();
            button_filters_reset = new Button();
            button_filters = new Button();
            datagridview_main = new DataGridView();
            label_search = new Label();
            button_refresh = new Button();
            column_dispatcher_name = new DataGridViewTextBoxColumn();
            column_dispatcher_surname = new DataGridViewTextBoxColumn();
            column_dispatcher_patriarchic = new DataGridViewTextBoxColumn();
            column_dispatcher_tel = new DataGridViewTextBoxColumn();
            panel_crud.SuspendLayout();
            panel_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_main).BeginInit();
            SuspendLayout();
            // 
            // checkbox_auto_resize_columns
            // 
            checkbox_auto_resize_columns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkbox_auto_resize_columns.AutoSize = true;
            checkbox_auto_resize_columns.Checked = true;
            checkbox_auto_resize_columns.CheckState = CheckState.Checked;
            checkbox_auto_resize_columns.Location = new Point(614, 17);
            checkbox_auto_resize_columns.Name = "checkbox_auto_resize_columns";
            checkbox_auto_resize_columns.Size = new Size(184, 25);
            checkbox_auto_resize_columns.TabIndex = 60;
            checkbox_auto_resize_columns.Text = "Авто-розмір стовпців";
            checkbox_auto_resize_columns.UseVisualStyleBackColor = true;
            checkbox_auto_resize_columns.CheckedChanged += checkbox_auto_resize_columns_CheckedChanged;
            // 
            // panel_crud
            // 
            panel_crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_crud.BorderStyle = BorderStyle.Fixed3D;
            panel_crud.Controls.Add(button_crud_create);
            panel_crud.Controls.Add(button_crud_delete);
            panel_crud.Controls.Add(button_crud_edit);
            panel_crud.Location = new Point(606, 267);
            panel_crud.Name = "panel_crud";
            panel_crud.Size = new Size(192, 160);
            panel_crud.TabIndex = 59;
            // 
            // button_crud_create
            // 
            button_crud_create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_crud_create.Location = new Point(2, 3);
            button_crud_create.Name = "button_crud_create";
            button_crud_create.Size = new Size(183, 46);
            button_crud_create.TabIndex = 6;
            button_crud_create.Text = "Створити";
            button_crud_create.UseVisualStyleBackColor = true;
            button_crud_create.Click += button_crud_create_Click;
            // 
            // button_crud_delete
            // 
            button_crud_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_crud_delete.Location = new Point(2, 107);
            button_crud_delete.Name = "button_crud_delete";
            button_crud_delete.Size = new Size(183, 46);
            button_crud_delete.TabIndex = 12;
            button_crud_delete.Text = "Видалити";
            button_crud_delete.UseVisualStyleBackColor = true;
            button_crud_delete.Click += button_crud_delete_Click;
            // 
            // button_crud_edit
            // 
            button_crud_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_crud_edit.Location = new Point(2, 55);
            button_crud_edit.Name = "button_crud_edit";
            button_crud_edit.Size = new Size(183, 46);
            button_crud_edit.TabIndex = 11;
            button_crud_edit.Text = "Редагувати";
            button_crud_edit.UseVisualStyleBackColor = true;
            button_crud_edit.Click += button_crud_edit_Click;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_search.Location = new Point(76, 15);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(268, 29);
            textbox_search.TabIndex = 56;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panel_filters
            // 
            panel_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_filters.Controls.Add(button_filters_reset);
            panel_filters.Controls.Add(button_filters);
            panel_filters.Location = new Point(350, 9);
            panel_filters.Name = "panel_filters";
            panel_filters.Size = new Size(242, 43);
            panel_filters.TabIndex = 58;
            // 
            // button_filters_reset
            // 
            button_filters_reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_filters_reset.Location = new Point(3, 3);
            button_filters_reset.Name = "button_filters_reset";
            button_filters_reset.Size = new Size(112, 33);
            button_filters_reset.TabIndex = 10;
            button_filters_reset.Text = "Скинути";
            button_filters_reset.UseVisualStyleBackColor = true;
            button_filters_reset.Click += button_filters_reset_Click;
            // 
            // button_filters
            // 
            button_filters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_filters.Location = new Point(117, 3);
            button_filters.Name = "button_filters";
            button_filters.Size = new Size(118, 33);
            button_filters.TabIndex = 9;
            button_filters.Text = "Фільтри";
            button_filters.UseVisualStyleBackColor = true;
            button_filters.Click += button_filters_Click;
            // 
            // datagridview_main
            // 
            datagridview_main.AllowUserToAddRows = false;
            datagridview_main.AllowUserToDeleteRows = false;
            datagridview_main.AllowUserToResizeRows = false;
            datagridview_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_main.Columns.AddRange(new DataGridViewColumn[] { column_dispatcher_name, column_dispatcher_surname, column_dispatcher_patriarchic, column_dispatcher_tel });
            datagridview_main.Location = new Point(8, 58);
            datagridview_main.MultiSelect = false;
            datagridview_main.Name = "datagridview_main";
            datagridview_main.ReadOnly = true;
            datagridview_main.RowHeadersVisible = false;
            datagridview_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_main.Size = new Size(584, 370);
            datagridview_main.TabIndex = 55;
            datagridview_main.SelectionChanged += datagridview_main_SelectionChanged;
            // 
            // label_search
            // 
            label_search.AutoSize = true;
            label_search.Location = new Point(11, 18);
            label_search.Name = "label_search";
            label_search.Size = new Size(59, 21);
            label_search.TabIndex = 57;
            label_search.Text = "Пошук";
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_refresh.Location = new Point(606, 58);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(190, 46);
            button_refresh.TabIndex = 61;
            button_refresh.Text = "Оновити";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // column_dispatcher_name
            // 
            column_dispatcher_name.DataPropertyName = "dispatcher_name";
            column_dispatcher_name.HeaderText = "Ім'я";
            column_dispatcher_name.Name = "column_dispatcher_name";
            column_dispatcher_name.ReadOnly = true;
            column_dispatcher_name.Width = 60;
            // 
            // column_dispatcher_surname
            // 
            column_dispatcher_surname.DataPropertyName = "dispatcher_surname";
            column_dispatcher_surname.HeaderText = "Прізвище";
            column_dispatcher_surname.Name = "column_dispatcher_surname";
            column_dispatcher_surname.ReadOnly = true;
            column_dispatcher_surname.Width = 102;
            // 
            // column_dispatcher_patriarchic
            // 
            column_dispatcher_patriarchic.DataPropertyName = "dispatcher_patriarchic";
            column_dispatcher_patriarchic.HeaderText = "По батькові";
            column_dispatcher_patriarchic.Name = "column_dispatcher_patriarchic";
            column_dispatcher_patriarchic.ReadOnly = true;
            column_dispatcher_patriarchic.Width = 118;
            // 
            // column_dispatcher_tel
            // 
            column_dispatcher_tel.DataPropertyName = "dispatcher_tel";
            column_dispatcher_tel.HeaderText = "Телефон";
            column_dispatcher_tel.Name = "column_dispatcher_tel";
            column_dispatcher_tel.ReadOnly = true;
            column_dispatcher_tel.Width = 94;
            // 
            // DispatchersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 437);
            Controls.Add(checkbox_auto_resize_columns);
            Controls.Add(panel_crud);
            Controls.Add(textbox_search);
            Controls.Add(panel_filters);
            Controls.Add(datagridview_main);
            Controls.Add(label_search);
            Controls.Add(button_refresh);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DispatchersForm";
            Text = "Диспетчери";
            panel_crud.ResumeLayout(false);
            panel_filters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkbox_auto_resize_columns;
        private Panel panel_crud;
        private Button button_crud_create;
        private Button button_crud_delete;
        private Button button_crud_edit;
        private TextBox textbox_search;
        private Panel panel_filters;
        private Button button_filters_reset;
        private Button button_filters;
        private DataGridView datagridview_main;
        private Label label_search;
        private Button button_refresh;
        private DataGridViewTextBoxColumn column_dispatcher_name;
        private DataGridViewTextBoxColumn column_dispatcher_surname;
        private DataGridViewTextBoxColumn column_dispatcher_patriarchic;
        private DataGridViewTextBoxColumn column_dispatcher_tel;
    }
}