namespace AmbulanceDispatcherApp.Forms.Workers
{
    partial class WorkersForm
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
            button_refresh = new Button();
            label_search = new Label();
            button_filters_reset = new Button();
            button_filters = new Button();
            textbox_search = new TextBox();
            button_crud_create = new Button();
            button_crud_delete = new Button();
            button_crud_edit = new Button();
            checkbox_auto_resize_columns = new CheckBox();
            datagridview_main = new DataGridView();
            panel_crud = new Panel();
            panel_filters = new Panel();
            column_worker_brigade = new DataGridViewTextBoxColumn();
            column_worker_name = new DataGridViewTextBoxColumn();
            column_worker_surname = new DataGridViewTextBoxColumn();
            column_worker_patriarchic = new DataGridViewTextBoxColumn();
            column_worker_tel = new DataGridViewTextBoxColumn();
            column_worker_dob = new DataGridViewTextBoxColumn();
            column_worker_sex = new DataGridViewTextBoxColumn();
            column_worker_kpp = new DataGridViewTextBoxColumn();
            column_worker_role = new DataGridViewTextBoxColumn();
            column_worker_license = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagridview_main).BeginInit();
            panel_crud.SuspendLayout();
            panel_filters.SuspendLayout();
            SuspendLayout();
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_refresh.Location = new Point(610, 58);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(190, 46);
            button_refresh.TabIndex = 45;
            button_refresh.Text = "Оновити";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // label_search
            // 
            label_search.AutoSize = true;
            label_search.Location = new Point(11, 18);
            label_search.Name = "label_search";
            label_search.Size = new Size(59, 21);
            label_search.TabIndex = 41;
            label_search.Text = "Пошук";
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
            button_filters.Location = new Point(117, 4);
            button_filters.Name = "button_filters";
            button_filters.Size = new Size(118, 32);
            button_filters.TabIndex = 9;
            button_filters.Text = "Фільтри";
            button_filters.UseVisualStyleBackColor = true;
            button_filters.Click += button_filters_Click;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_search.Location = new Point(76, 15);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(280, 29);
            textbox_search.TabIndex = 40;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // button_crud_create
            // 
            button_crud_create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_crud_create.Location = new Point(3, 3);
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
            button_crud_delete.Location = new Point(3, 107);
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
            button_crud_edit.Location = new Point(3, 55);
            button_crud_edit.Name = "button_crud_edit";
            button_crud_edit.Size = new Size(183, 46);
            button_crud_edit.TabIndex = 11;
            button_crud_edit.Text = "Редагувати";
            button_crud_edit.UseVisualStyleBackColor = true;
            button_crud_edit.Click += button_crud_edit_Click;
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
            checkbox_auto_resize_columns.TabIndex = 44;
            checkbox_auto_resize_columns.Text = "Авто-розмір стовпців";
            checkbox_auto_resize_columns.UseVisualStyleBackColor = true;
            checkbox_auto_resize_columns.CheckedChanged += checkbox_auto_resize_columns_CheckedChanged;
            // 
            // datagridview_main
            // 
            datagridview_main.AllowUserToAddRows = false;
            datagridview_main.AllowUserToDeleteRows = false;
            datagridview_main.AllowUserToResizeRows = false;
            datagridview_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_main.Columns.AddRange(new DataGridViewColumn[] { column_worker_brigade, column_worker_name, column_worker_surname, column_worker_patriarchic, column_worker_tel, column_worker_dob, column_worker_sex, column_worker_kpp, column_worker_role, column_worker_license });
            datagridview_main.Location = new Point(12, 58);
            datagridview_main.MultiSelect = false;
            datagridview_main.Name = "datagridview_main";
            datagridview_main.ReadOnly = true;
            datagridview_main.RowHeadersVisible = false;
            datagridview_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_main.Size = new Size(592, 370);
            datagridview_main.TabIndex = 39;
            datagridview_main.SelectionChanged += datagridview_main_SelectionChanged;
            // 
            // panel_crud
            // 
            panel_crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_crud.BorderStyle = BorderStyle.Fixed3D;
            panel_crud.Controls.Add(button_crud_create);
            panel_crud.Controls.Add(button_crud_delete);
            panel_crud.Controls.Add(button_crud_edit);
            panel_crud.Location = new Point(610, 268);
            panel_crud.Name = "panel_crud";
            panel_crud.Size = new Size(192, 160);
            panel_crud.TabIndex = 43;
            // 
            // panel_filters
            // 
            panel_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_filters.Controls.Add(button_filters_reset);
            panel_filters.Controls.Add(button_filters);
            panel_filters.Location = new Point(362, 9);
            panel_filters.Name = "panel_filters";
            panel_filters.Size = new Size(242, 43);
            panel_filters.TabIndex = 42;
            // 
            // column_worker_brigade
            // 
            column_worker_brigade.DataPropertyName = "brigade_code";
            column_worker_brigade.HeaderText = "Бригада";
            column_worker_brigade.Name = "column_worker_brigade";
            column_worker_brigade.ReadOnly = true;
            column_worker_brigade.Width = 91;
            // 
            // column_worker_name
            // 
            column_worker_name.DataPropertyName = "worker_name";
            column_worker_name.HeaderText = "Ім'я";
            column_worker_name.Name = "column_worker_name";
            column_worker_name.ReadOnly = true;
            column_worker_name.Width = 60;
            // 
            // column_worker_surname
            // 
            column_worker_surname.DataPropertyName = "worker_surname";
            column_worker_surname.HeaderText = "Прізвище";
            column_worker_surname.Name = "column_worker_surname";
            column_worker_surname.ReadOnly = true;
            column_worker_surname.Width = 102;
            // 
            // column_worker_patriarchic
            // 
            column_worker_patriarchic.DataPropertyName = "worker_patriarchic";
            column_worker_patriarchic.HeaderText = "По батькові";
            column_worker_patriarchic.Name = "column_worker_patriarchic";
            column_worker_patriarchic.ReadOnly = true;
            column_worker_patriarchic.Width = 118;
            // 
            // column_worker_tel
            // 
            column_worker_tel.DataPropertyName = "worker_tel";
            column_worker_tel.HeaderText = "Телефон";
            column_worker_tel.Name = "column_worker_tel";
            column_worker_tel.ReadOnly = true;
            column_worker_tel.Width = 94;
            // 
            // column_worker_dob
            // 
            column_worker_dob.DataPropertyName = "worker_dob";
            column_worker_dob.HeaderText = "Дата народження";
            column_worker_dob.Name = "column_worker_dob";
            column_worker_dob.ReadOnly = true;
            column_worker_dob.Width = 147;
            // 
            // column_worker_sex
            // 
            column_worker_sex.DataPropertyName = "worker_sex";
            column_worker_sex.HeaderText = "Стать";
            column_worker_sex.Name = "column_worker_sex";
            column_worker_sex.ReadOnly = true;
            column_worker_sex.Width = 73;
            // 
            // column_worker_kpp
            // 
            column_worker_kpp.DataPropertyName = "worker_kpp";
            column_worker_kpp.HeaderText = "ІНПН";
            column_worker_kpp.Name = "column_worker_kpp";
            column_worker_kpp.ReadOnly = true;
            column_worker_kpp.Width = 70;
            // 
            // column_worker_role
            // 
            column_worker_role.DataPropertyName = "worker_role";
            column_worker_role.HeaderText = "Роль";
            column_worker_role.Name = "column_worker_role";
            column_worker_role.ReadOnly = true;
            column_worker_role.Width = 67;
            // 
            // column_worker_license
            // 
            column_worker_license.DataPropertyName = "worker_license";
            column_worker_license.HeaderText = "Номер ліцензції";
            column_worker_license.Name = "column_worker_license";
            column_worker_license.ReadOnly = true;
            column_worker_license.Width = 136;
            // 
            // WorkersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 437);
            Controls.Add(button_refresh);
            Controls.Add(label_search);
            Controls.Add(textbox_search);
            Controls.Add(checkbox_auto_resize_columns);
            Controls.Add(datagridview_main);
            Controls.Add(panel_crud);
            Controls.Add(panel_filters);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "WorkersForm";
            Text = "Працівники";
            ((System.ComponentModel.ISupportInitialize)datagridview_main).EndInit();
            panel_crud.ResumeLayout(false);
            panel_filters.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_refresh;
        private Label label_search;
        private Button button_filters_reset;
        private Button button_filters;
        private TextBox textbox_search;
        private Button button_crud_create;
        private Button button_crud_delete;
        private Button button_crud_edit;
        private CheckBox checkbox_auto_resize_columns;
        private DataGridView datagridview_main;
        private Panel panel_crud;
        private Panel panel_filters;
        private DataGridViewTextBoxColumn column_worker_brigade;
        private DataGridViewTextBoxColumn column_worker_name;
        private DataGridViewTextBoxColumn column_worker_surname;
        private DataGridViewTextBoxColumn column_worker_patriarchic;
        private DataGridViewTextBoxColumn column_worker_tel;
        private DataGridViewTextBoxColumn column_worker_dob;
        private DataGridViewTextBoxColumn column_worker_sex;
        private DataGridViewTextBoxColumn column_worker_kpp;
        private DataGridViewTextBoxColumn column_worker_role;
        private DataGridViewTextBoxColumn column_worker_license;
    }
}