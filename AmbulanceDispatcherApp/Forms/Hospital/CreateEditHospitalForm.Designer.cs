namespace AmbulanceDispatcherApp.Forms.Hospital
{
    partial class CreateEditHospitalForm
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
            button_save = new Button();
            textbox_specialization = new TextBox();
            textbox_address = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textbox_name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(70, 128);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 32);
            button_cancel.TabIndex = 27;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(196, 128);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 32);
            button_save.TabIndex = 28;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_specialization
            // 
            textbox_specialization.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_specialization.Location = new Point(115, 79);
            textbox_specialization.Margin = new Padding(1, 2, 1, 2);
            textbox_specialization.Name = "textbox_specialization";
            textbox_specialization.Size = new Size(255, 29);
            textbox_specialization.TabIndex = 25;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(115, 46);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(255, 29);
            textbox_address.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 49);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 26;
            label6.Text = "Адреса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 82);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 24;
            label5.Text = "Спеціалізація";
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(115, 13);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(255, 29);
            textbox_name.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 30;
            label1.Text = "Назва";
            // 
            // HospitalCreateEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 173);
            Controls.Add(textbox_name);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_specialization);
            Controls.Add(textbox_address);
            Controls.Add(label6);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "HospitalCreateEditForm";
            Text = "HospitalCreateEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_specialization;
        private TextBox textbox_address;
        private Label label6;
        private Label label5;
        private TextBox textbox_name;
        private Label label1;
    }
}