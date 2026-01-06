namespace AmbulanceDispatcherApp.Forms.Dispatcher
{
    partial class CreateEditDispatcherForm
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
            textbox_tel = new TextBox();
            label3 = new Label();
            textbox_patriarchic = new TextBox();
            label2 = new Label();
            textbox_surname = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_name = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(127, 110);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.Size = new Size(256, 29);
            textbox_tel.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 77;
            label3.Text = "Телефон";
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(127, 77);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(256, 29);
            textbox_patriarchic.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 75;
            label2.Text = "По батькові";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(126, 44);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(256, 29);
            textbox_surname.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 73;
            label1.Text = "Прізвище";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(73, 162);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 69;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(199, 162);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 70;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(127, 11);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(256, 29);
            textbox_name.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 71;
            label4.Text = "Ім'я";
            // 
            // CreateEditDispatcherForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 201);
            Controls.Add(textbox_tel);
            Controls.Add(label3);
            Controls.Add(textbox_patriarchic);
            Controls.Add(label2);
            Controls.Add(textbox_surname);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_name);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateEditDispatcherForm";
            Text = "Диспетчер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_tel;
        private Label label3;
        private TextBox textbox_patriarchic;
        private Label label2;
        private TextBox textbox_surname;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_name;
        private Label label4;
    }
}