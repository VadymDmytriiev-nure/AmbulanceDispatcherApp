namespace AmbulanceDispatcherApp.Forms.Substation
{
    partial class CreateEditSubstationForm
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
            textbox_address = new TextBox();
            textbox_code = new TextBox();
            label8 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(57, 135);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 32);
            button_cancel.TabIndex = 17;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(183, 135);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 32);
            button_save.TabIndex = 18;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(96, 62);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.Size = new Size(242, 29);
            textbox_address.TabIndex = 16;
            // 
            // textbox_code
            // 
            textbox_code.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_code.Location = new Point(96, 29);
            textbox_code.Margin = new Padding(1, 2, 1, 2);
            textbox_code.Name = "textbox_code";
            textbox_code.PlaceholderText = "ХА-1";
            textbox_code.Size = new Size(242, 29);
            textbox_code.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 65);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 15;
            label8.Text = "Адреса";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 13;
            label4.Text = "Код";
            // 
            // CreateEditSubstationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 178);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_address);
            Controls.Add(textbox_code);
            Controls.Add(label8);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(380, 217);
            Name = "CreateEditSubstationForm";
            Text = "CreateEditSubstationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_address;
        private TextBox textbox_code;
        private Label label8;
        private Label label4;
    }
}