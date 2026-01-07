namespace AmbulanceDispatcherApp
{
    partial class LoginForm
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
            panel_credentials = new Panel();
            textbox_password = new TextBox();
            textbox_login = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_login = new Button();
            button_cancel = new Button();
            button_options = new Button();
            panel_credentials.SuspendLayout();
            SuspendLayout();
            // 
            // panel_credentials
            // 
            panel_credentials.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_credentials.BorderStyle = BorderStyle.Fixed3D;
            panel_credentials.Controls.Add(textbox_password);
            panel_credentials.Controls.Add(textbox_login);
            panel_credentials.Controls.Add(label3);
            panel_credentials.Controls.Add(label2);
            panel_credentials.Location = new Point(13, 128);
            panel_credentials.Margin = new Padding(4);
            panel_credentials.Name = "panel_credentials";
            panel_credentials.Size = new Size(357, 111);
            panel_credentials.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_password.Location = new Point(83, 55);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(256, 29);
            textbox_password.TabIndex = 3;
            // 
            // textbox_login
            // 
            textbox_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_login.Location = new Point(83, 20);
            textbox_login.Name = "textbox_login";
            textbox_login.Size = new Size(256, 29);
            textbox_login.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 58);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 23);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 0;
            label2.Text = "Логін";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(35, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 1;
            label1.Text = "Авторизуйтесь, будь ласка.";
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Bottom;
            button_login.Location = new Point(192, 286);
            button_login.Name = "button_login";
            button_login.Size = new Size(152, 42);
            button_login.TabIndex = 2;
            button_login.Text = "Авторизуватись";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(35, 286);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(152, 42);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Закрити";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_options
            // 
            button_options.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_options.DialogResult = DialogResult.Cancel;
            button_options.Image = Properties.Resources._211811_16x16;
            button_options.Location = new Point(335, 12);
            button_options.Name = "button_options";
            button_options.Size = new Size(36, 36);
            button_options.TabIndex = 4;
            button_options.UseVisualStyleBackColor = true;
            button_options.Click += button_options_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 340);
            Controls.Add(button_options);
            Controls.Add(button_cancel);
            Controls.Add(button_login);
            Controls.Add(label1);
            Controls.Add(panel_credentials);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(345, 356);
            Name = "LoginForm";
            Text = "Диспетчер Викликів";
            panel_credentials.ResumeLayout(false);
            panel_credentials.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_credentials;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_login;
        private TextBox textbox_password;
        private TextBox textbox_login;
        private Button button_cancel;
        private Button button_options;
    }
}