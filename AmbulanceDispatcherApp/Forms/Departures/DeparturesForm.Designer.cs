namespace AmbulanceDispatcherApp.Forms.Departures
{
    partial class DeparturesForm
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
            checkbox_auto_resize_columns = new CheckBox();
            datagridview_main = new DataGridView();
            button_filters_reset = new Button();
            button_crud_create = new Button();
            button_crud_delete = new Button();
            button_crud_edit = new Button();
            button_filters = new Button();
            panel_crud = new Panel();
            textbox_search = new TextBox();
            panel_filters = new Panel();
            label_search = new Label();
            column_callout_id = new DataGridViewTextBoxColumn();
            column_departure_time_departed = new DataGridViewTextBoxColumn();
            column_departure_time_arrived = new DataGridViewTextBoxColumn();
            column_departure_mileage_km = new DataGridViewTextBoxColumn();
            column_departure_from_address = new DataGridViewTextBoxColumn();
            column_departure_to_address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagridview_main).BeginInit();
            panel_crud.SuspendLayout();
            panel_filters.SuspendLayout();
            SuspendLayout();
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_refresh.Location = new Point(586, 58);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(190, 46);
            button_refresh.TabIndex = 45;
            button_refresh.Text = "Оновити";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // checkbox_auto_resize_columns
            // 
            checkbox_auto_resize_columns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkbox_auto_resize_columns.AutoSize = true;
            checkbox_auto_resize_columns.Checked = true;
            checkbox_auto_resize_columns.CheckState = CheckState.Checked;
            checkbox_auto_resize_columns.Location = new Point(594, 17);
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
            datagridview_main.Columns.AddRange(new DataGridViewColumn[] { column_callout_id, column_departure_time_departed, column_departure_time_arrived, column_departure_mileage_km, column_departure_from_address, column_departure_to_address });
            datagridview_main.Location = new Point(8, 58);
            datagridview_main.MultiSelect = false;
            datagridview_main.Name = "datagridview_main";
            datagridview_main.ReadOnly = true;
            datagridview_main.RowHeadersVisible = false;
            datagridview_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_main.Size = new Size(564, 367);
            datagridview_main.TabIndex = 39;
            datagridview_main.SelectionChanged += datagridview_main_SelectionChanged;
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
            // button_crud_create
            // 
            button_crud_create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_crud_create.Location = new Point(3, 3);
            button_crud_create.Name = "button_crud_create";
            button_crud_create.Size = new Size(182, 46);
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
            button_crud_delete.Size = new Size(182, 46);
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
            button_crud_edit.Size = new Size(182, 46);
            button_crud_edit.TabIndex = 11;
            button_crud_edit.Text = "Редагувати";
            button_crud_edit.UseVisualStyleBackColor = true;
            button_crud_edit.Click += button_crud_edit_Click;
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
            // panel_crud
            // 
            panel_crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_crud.BorderStyle = BorderStyle.Fixed3D;
            panel_crud.Controls.Add(button_crud_create);
            panel_crud.Controls.Add(button_crud_delete);
            panel_crud.Controls.Add(button_crud_edit);
            panel_crud.Location = new Point(586, 264);
            panel_crud.Name = "panel_crud";
            panel_crud.Size = new Size(192, 160);
            panel_crud.TabIndex = 43;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_search.Location = new Point(76, 15);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(248, 29);
            textbox_search.TabIndex = 40;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panel_filters
            // 
            panel_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_filters.Controls.Add(button_filters_reset);
            panel_filters.Controls.Add(button_filters);
            panel_filters.Location = new Point(330, 9);
            panel_filters.Name = "panel_filters";
            panel_filters.Size = new Size(242, 43);
            panel_filters.TabIndex = 42;
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
            // column_callout_id
            // 
            column_callout_id.DataPropertyName = "callout_id";
            column_callout_id.HeaderText = "№ виклику";
            column_callout_id.Name = "column_callout_id";
            column_callout_id.ReadOnly = true;
            column_callout_id.Width = 113;
            // 
            // column_departure_time_departed
            // 
            column_departure_time_departed.DataPropertyName = "departure_time_departed";
            column_departure_time_departed.HeaderText = "Час виїзду";
            column_departure_time_departed.Name = "column_departure_time_departed";
            column_departure_time_departed.ReadOnly = true;
            column_departure_time_departed.Width = 108;
            // 
            // column_departure_time_arrived
            // 
            column_departure_time_arrived.DataPropertyName = "departure_time_arrived";
            column_departure_time_arrived.HeaderText = "Час приїзду";
            column_departure_time_arrived.Name = "column_departure_time_arrived";
            column_departure_time_arrived.ReadOnly = true;
            column_departure_time_arrived.Width = 118;
            // 
            // column_departure_mileage_km
            // 
            column_departure_mileage_km.DataPropertyName = "departure_mileage_km";
            column_departure_mileage_km.HeaderText = "Кілометраж";
            column_departure_mileage_km.Name = "column_departure_mileage_km";
            column_departure_mileage_km.ReadOnly = true;
            column_departure_mileage_km.Width = 118;
            // 
            // column_departure_from_address
            // 
            column_departure_from_address.DataPropertyName = "departure_from_address";
            column_departure_from_address.HeaderText = "Початкова адреса";
            column_departure_from_address.Name = "column_departure_from_address";
            column_departure_from_address.ReadOnly = true;
            column_departure_from_address.Width = 149;
            // 
            // column_departure_to_address
            // 
            column_departure_to_address.DataPropertyName = "departure_to_address";
            column_departure_to_address.HeaderText = "Кінцева адреса";
            column_departure_to_address.Name = "column_departure_to_address";
            column_departure_to_address.ReadOnly = true;
            column_departure_to_address.Width = 130;
            // 
            // DeparturesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 434);
            Controls.Add(button_refresh);
            Controls.Add(checkbox_auto_resize_columns);
            Controls.Add(datagridview_main);
            Controls.Add(panel_crud);
            Controls.Add(textbox_search);
            Controls.Add(panel_filters);
            Controls.Add(label_search);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DeparturesForm";
            Text = "Виїзди";
            ((System.ComponentModel.ISupportInitialize)datagridview_main).EndInit();
            panel_crud.ResumeLayout(false);
            panel_filters.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_refresh;
        private CheckBox checkbox_auto_resize_columns;
        private DataGridView datagridview_main;
        private Button button_filters_reset;
        private Button button_crud_create;
        private Button button_crud_delete;
        private Button button_crud_edit;
        private Button button_filters;
        private Panel panel_crud;
        private TextBox textbox_search;
        private Panel panel_filters;
        private Label label_search;
        private DataGridViewTextBoxColumn column_callout_id;
        private DataGridViewTextBoxColumn column_departure_time_departed;
        private DataGridViewTextBoxColumn column_departure_time_arrived;
        private DataGridViewTextBoxColumn column_departure_mileage_km;
        private DataGridViewTextBoxColumn column_departure_from_address;
        private DataGridViewTextBoxColumn column_departure_to_address;
    }
}