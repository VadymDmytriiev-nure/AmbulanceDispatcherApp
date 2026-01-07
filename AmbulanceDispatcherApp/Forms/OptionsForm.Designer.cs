namespace AmbulanceDispatcherApp.Forms
{
    partial class OptionsForm
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
            button_cancel = new Button();
            button_login = new Button();
            panel_credentials = new Panel();
            textbox_sql_database = new TextBox();
            textbox_sql_host = new TextBox();
            label3 = new Label();
            label2 = new Label();
            spin_sql_port = new NumericUpDown();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            spin_max_rows = new NumericUpDown();
            spin_max_rows_filtered = new NumericUpDown();
            panel_credentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spin_sql_port).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_max_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_max_rows_filtered).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(115, 244);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(152, 42);
            button_cancel.TabIndex = 6;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Bottom;
            button_login.Image = Properties.Resources._212394_16x16;
            button_login.ImageAlign = ContentAlignment.MiddleLeft;
            button_login.Location = new Point(272, 244);
            button_login.Name = "button_login";
            button_login.Size = new Size(152, 42);
            button_login.TabIndex = 5;
            button_login.Text = "Зберегти";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // panel_credentials
            // 
            panel_credentials.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_credentials.BorderStyle = BorderStyle.Fixed3D;
            panel_credentials.Controls.Add(spin_max_rows_filtered);
            panel_credentials.Controls.Add(spin_max_rows);
            panel_credentials.Controls.Add(label5);
            panel_credentials.Controls.Add(label4);
            panel_credentials.Controls.Add(label1);
            panel_credentials.Controls.Add(spin_sql_port);
            panel_credentials.Controls.Add(textbox_sql_database);
            panel_credentials.Controls.Add(textbox_sql_host);
            panel_credentials.Controls.Add(label3);
            panel_credentials.Controls.Add(label2);
            panel_credentials.Location = new Point(13, 13);
            panel_credentials.Margin = new Padding(4);
            panel_credentials.Name = "panel_credentials";
            panel_credentials.Size = new Size(517, 200);
            panel_credentials.TabIndex = 4;
            // 
            // textbox_sql_database
            // 
            textbox_sql_database.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_sql_database.Location = new Point(224, 89);
            textbox_sql_database.Name = "textbox_sql_database";
            textbox_sql_database.PlaceholderText = "emergencyhealthcare";
            textbox_sql_database.Size = new Size(268, 29);
            textbox_sql_database.TabIndex = 3;
            textbox_sql_database.Text = "emergencyhealthcare";
            // 
            // textbox_sql_host
            // 
            textbox_sql_host.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_sql_host.Location = new Point(224, 20);
            textbox_sql_host.Name = "textbox_sql_host";
            textbox_sql_host.PlaceholderText = "localhost";
            textbox_sql_host.Size = new Size(268, 29);
            textbox_sql_host.TabIndex = 2;
            textbox_sql_host.Text = "localhost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 56);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 1;
            label3.Text = "Порт БД";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 23);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Хост БД";
            // 
            // spin_sql_port
            // 
            spin_sql_port.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_sql_port.Location = new Point(224, 54);
            spin_sql_port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            spin_sql_port.Name = "spin_sql_port";
            spin_sql_port.Size = new Size(268, 29);
            spin_sql_port.TabIndex = 4;
            spin_sql_port.Value = new decimal(new int[] { 3306, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 92);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 5;
            label1.Text = "Назва БД";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 126);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 6;
            label4.Text = "Макс. рядків";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 161);
            label5.Name = "label5";
            label5.Size = new Size(200, 21);
            label5.TabIndex = 7;
            label5.Text = "Макс. рядків (з фільтрами)";
            // 
            // spin_max_rows
            // 
            spin_max_rows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_max_rows.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            spin_max_rows.Location = new Point(224, 124);
            spin_max_rows.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            spin_max_rows.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            spin_max_rows.Name = "spin_max_rows";
            spin_max_rows.Size = new Size(268, 29);
            spin_max_rows.TabIndex = 8;
            spin_max_rows.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // spin_max_rows_filtered
            // 
            spin_max_rows_filtered.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_max_rows_filtered.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            spin_max_rows_filtered.Location = new Point(224, 159);
            spin_max_rows_filtered.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            spin_max_rows_filtered.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            spin_max_rows_filtered.Name = "spin_max_rows_filtered";
            spin_max_rows_filtered.Size = new Size(268, 29);
            spin_max_rows_filtered.TabIndex = 9;
            spin_max_rows_filtered.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 307);
            Controls.Add(button_cancel);
            Controls.Add(button_login);
            Controls.Add(panel_credentials);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "OptionsForm";
            Text = "Налаштування";
            panel_credentials.ResumeLayout(false);
            panel_credentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spin_sql_port).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_max_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_max_rows_filtered).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_cancel;
        private Button button_login;
        private Panel panel_credentials;
        private NumericUpDown spin_sql_port;
        private TextBox textbox_sql_database;
        private TextBox textbox_sql_host;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown spin_max_rows_filtered;
        private NumericUpDown spin_max_rows;
        private Label label5;
        private Label label4;
    }
}