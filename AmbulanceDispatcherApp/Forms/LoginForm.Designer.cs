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
            panel1 = new Panel();
            textbox_password = new TextBox();
            textbox_login = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_login = new Button();
            button_cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(textbox_login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 128);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 111);
            panel1.TabIndex = 0;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(83, 55);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(237, 29);
            textbox_password.TabIndex = 3;
            // 
            // textbox_login
            // 
            textbox_login.Location = new Point(83, 20);
            textbox_login.Name = "textbox_login";
            textbox_login.Size = new Size(237, 29);
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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(29, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 1;
            label1.Text = "Авторизуйтесь, будь ласка.";
            // 
            // button_login
            // 
            button_login.Location = new Point(183, 287);
            button_login.Name = "button_login";
            button_login.Size = new Size(152, 42);
            button_login.TabIndex = 2;
            button_login.Text = "Авторизуватись";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_cancel
            // 
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(26, 287);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(152, 42);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "Закрити";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 341);
            Controls.Add(button_cancel);
            Controls.Add(button_login);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Диспетчер Викликів";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_login;
        private TextBox textbox_password;
        private TextBox textbox_login;
        private Button button_cancel;
    }
}