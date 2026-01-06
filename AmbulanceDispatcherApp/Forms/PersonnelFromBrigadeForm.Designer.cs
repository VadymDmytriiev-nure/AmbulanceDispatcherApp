namespace AmbulanceDispatcherApp.Forms
{
    partial class PersonnelFromBrigadeForm
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
            button_ok = new Button();
            splitContainer1 = new SplitContainer();
            label_selected_brigade = new Label();
            label1 = new Label();
            datagridview_brigade = new DataGridView();
            column_brigade_code = new DataGridViewTextBoxColumn();
            column_brigade_type = new DataGridViewTextBoxColumn();
            column_brigade_worker_count = new DataGridViewTextBoxColumn();
            column_substation_code = new DataGridViewTextBoxColumn();
            column_substation_address = new DataGridViewTextBoxColumn();
            textbox_search = new TextBox();
            panel_filters = new Panel();
            button_filters_reset = new Button();
            button_filters = new Button();
            label_search = new Label();
            datagridview_worker = new DataGridView();
            column_worker_brigade = new DataGridViewTextBoxColumn();
            column_worker_role = new DataGridViewTextBoxColumn();
            column_worker_fullname = new DataGridViewTextBoxColumn();
            column_worker_tel = new DataGridViewTextBoxColumn();
            column_worker_dob = new DataGridViewTextBoxColumn();
            column_worker_sex = new DataGridViewTextBoxColumn();
            button_cancel = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_brigade).BeginInit();
            panel_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_worker).BeginInit();
            SuspendLayout();
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_ok.DialogResult = DialogResult.OK;
            button_ok.Enabled = false;
            button_ok.Image = Properties.Resources._212394_32x32;
            button_ok.ImageAlign = ContentAlignment.MiddleLeft;
            button_ok.Location = new Point(307, 421);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(248, 46);
            button_ok.TabIndex = 0;
            button_ok.Text = "Підтвердити";
            button_ok.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label_selected_brigade);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(datagridview_brigade);
            splitContainer1.Panel1.Controls.Add(textbox_search);
            splitContainer1.Panel1.Controls.Add(panel_filters);
            splitContainer1.Panel1.Controls.Add(label_search);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(datagridview_worker);
            splitContainer1.Panel2.Controls.Add(button_cancel);
            splitContainer1.Panel2.Controls.Add(button_ok);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1134, 470);
            splitContainer1.SplitterDistance = 560;
            splitContainer1.TabIndex = 1;
            // 
            // label_selected_brigade
            // 
            label_selected_brigade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_selected_brigade.AutoSize = true;
            label_selected_brigade.Location = new Point(18, 429);
            label_selected_brigade.Name = "label_selected_brigade";
            label_selected_brigade.Size = new Size(193, 21);
            label_selected_brigade.TabIndex = 46;
            label_selected_brigade.Text = "Обрана бригада: <ніяка>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 45;
            label1.Text = "1. Оберіть бригаду";
            // 
            // datagridview_brigade
            // 
            datagridview_brigade.AllowUserToAddRows = false;
            datagridview_brigade.AllowUserToDeleteRows = false;
            datagridview_brigade.AllowUserToResizeRows = false;
            datagridview_brigade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_brigade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_brigade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_brigade.Columns.AddRange(new DataGridViewColumn[] { column_brigade_code, column_brigade_type, column_brigade_worker_count, column_substation_code, column_substation_address });
            datagridview_brigade.Location = new Point(3, 87);
            datagridview_brigade.MultiSelect = false;
            datagridview_brigade.Name = "datagridview_brigade";
            datagridview_brigade.ReadOnly = true;
            datagridview_brigade.RowHeadersVisible = false;
            datagridview_brigade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_brigade.Size = new Size(545, 320);
            datagridview_brigade.TabIndex = 41;
            datagridview_brigade.SelectionChanged += datagridview_main_SelectionChanged;
            // 
            // column_brigade_code
            // 
            column_brigade_code.DataPropertyName = "brigade_code";
            column_brigade_code.HeaderText = "Код/назва";
            column_brigade_code.Name = "column_brigade_code";
            column_brigade_code.ReadOnly = true;
            column_brigade_code.Width = 106;
            // 
            // column_brigade_type
            // 
            column_brigade_type.DataPropertyName = "brigade_type";
            column_brigade_type.HeaderText = "Тип";
            column_brigade_type.Name = "column_brigade_type";
            column_brigade_type.ReadOnly = true;
            column_brigade_type.Width = 59;
            // 
            // column_brigade_worker_count
            // 
            column_brigade_worker_count.DataPropertyName = "brigade_worker_count";
            column_brigade_worker_count.HeaderText = "Кількість працівників";
            column_brigade_worker_count.Name = "column_brigade_worker_count";
            column_brigade_worker_count.ReadOnly = true;
            column_brigade_worker_count.Width = 169;
            // 
            // column_substation_code
            // 
            column_substation_code.DataPropertyName = "substation_code";
            column_substation_code.HeaderText = "Підстанція";
            column_substation_code.Name = "column_substation_code";
            column_substation_code.ReadOnly = true;
            column_substation_code.Width = 110;
            // 
            // column_substation_address
            // 
            column_substation_address.DataPropertyName = "substation_address";
            column_substation_address.HeaderText = "Адреса підстанції";
            column_substation_address.Name = "column_substation_address";
            column_substation_address.ReadOnly = true;
            column_substation_address.Width = 145;
            // 
            // textbox_search
            // 
            textbox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_search.Location = new Point(65, 46);
            textbox_search.Name = "textbox_search";
            textbox_search.Size = new Size(235, 29);
            textbox_search.TabIndex = 42;
            textbox_search.TextChanged += textbox_search_TextChanged;
            // 
            // panel_filters
            // 
            panel_filters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_filters.BorderStyle = BorderStyle.Fixed3D;
            panel_filters.Controls.Add(button_filters_reset);
            panel_filters.Controls.Add(button_filters);
            panel_filters.Location = new Point(306, 38);
            panel_filters.Name = "panel_filters";
            panel_filters.Size = new Size(242, 43);
            panel_filters.TabIndex = 44;
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
            // label_search
            // 
            label_search.AutoSize = true;
            label_search.Location = new Point(3, 47);
            label_search.Name = "label_search";
            label_search.Size = new Size(59, 21);
            label_search.TabIndex = 43;
            label_search.Text = "Пошук";
            // 
            // datagridview_worker
            // 
            datagridview_worker.AllowUserToAddRows = false;
            datagridview_worker.AllowUserToDeleteRows = false;
            datagridview_worker.AllowUserToResizeRows = false;
            datagridview_worker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview_worker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview_worker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_worker.Columns.AddRange(new DataGridViewColumn[] { column_worker_brigade, column_worker_role, column_worker_fullname, column_worker_tel, column_worker_dob, column_worker_sex });
            datagridview_worker.Location = new Point(3, 47);
            datagridview_worker.MultiSelect = false;
            datagridview_worker.Name = "datagridview_worker";
            datagridview_worker.ReadOnly = true;
            datagridview_worker.RowHeadersVisible = false;
            datagridview_worker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_worker.Size = new Size(564, 368);
            datagridview_worker.TabIndex = 48;
            // 
            // column_worker_brigade
            // 
            column_worker_brigade.DataPropertyName = "brigade_code";
            column_worker_brigade.HeaderText = "Бригада";
            column_worker_brigade.Name = "column_worker_brigade";
            column_worker_brigade.ReadOnly = true;
            column_worker_brigade.Width = 91;
            // 
            // column_worker_role
            // 
            column_worker_role.DataPropertyName = "worker_role";
            column_worker_role.HeaderText = "Роль";
            column_worker_role.Name = "column_worker_role";
            column_worker_role.ReadOnly = true;
            column_worker_role.Width = 67;
            // 
            // column_worker_fullname
            // 
            column_worker_fullname.DataPropertyName = "worker_fullname";
            column_worker_fullname.HeaderText = "ПІБ";
            column_worker_fullname.Name = "column_worker_fullname";
            column_worker_fullname.ReadOnly = true;
            column_worker_fullname.Width = 57;
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
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_32x32;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(11, 421);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(290, 46);
            button_cancel.TabIndex = 47;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(543, 37);
            label2.TabIndex = 46;
            label2.Text = "2. Підтвердіть необхідний особовий склад";
            // 
            // PersonnelFromBrigadeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 533);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "PersonnelFromBrigadeForm";
            Text = "Створення особового складу з бригади";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_brigade).EndInit();
            panel_filters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview_worker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_ok;
        private SplitContainer splitContainer1;
        private Label label1;
        private DataGridView datagridview_brigade;
        private DataGridViewTextBoxColumn column_brigade_code;
        private DataGridViewTextBoxColumn column_brigade_type;
        private DataGridViewTextBoxColumn column_brigade_worker_count;
        private DataGridViewTextBoxColumn column_substation_code;
        private DataGridViewTextBoxColumn column_substation_address;
        private TextBox textbox_search;
        private Panel panel_filters;
        private Button button_filters_reset;
        private Button button_filters;
        private Label label_search;
        private Label label2;
        private Label label_selected_brigade;
        private Button button_cancel;
        private DataGridView datagridview_worker;
        private DataGridViewTextBoxColumn column_worker_brigade;
        private DataGridViewTextBoxColumn column_worker_role;
        private DataGridViewTextBoxColumn column_worker_fullname;
        private DataGridViewTextBoxColumn column_worker_tel;
        private DataGridViewTextBoxColumn column_worker_dob;
        private DataGridViewTextBoxColumn column_worker_sex;
    }
}