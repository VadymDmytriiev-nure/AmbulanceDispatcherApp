namespace AmbulanceDispatcherApp.Forms.Brigade
{
    partial class CreateEditBrigadeForm
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
            combo_substation = new ComboBox();
            textbox_type = new TextBox();
            textbox_code = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(71, 130);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 32);
            button_cancel.TabIndex = 19;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(197, 130);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 32);
            button_save.TabIndex = 20;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // combo_substation
            // 
            combo_substation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_substation.FormattingEnabled = true;
            combo_substation.Location = new Point(116, 15);
            combo_substation.Margin = new Padding(1, 2, 1, 2);
            combo_substation.Name = "combo_substation";
            combo_substation.Size = new Size(255, 29);
            combo_substation.TabIndex = 14;
            // 
            // textbox_type
            // 
            textbox_type.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_type.Location = new Point(116, 81);
            textbox_type.Margin = new Padding(1, 2, 1, 2);
            textbox_type.Name = "textbox_type";
            textbox_type.PlaceholderText = "Звичайна";
            textbox_type.Size = new Size(255, 29);
            textbox_type.TabIndex = 17;
            // 
            // textbox_code
            // 
            textbox_code.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_code.Location = new Point(116, 48);
            textbox_code.Margin = new Padding(1, 2, 1, 2);
            textbox_code.Name = "textbox_code";
            textbox_code.PlaceholderText = "ХА-1-1";
            textbox_code.Size = new Size(255, 29);
            textbox_code.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 51);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 21);
            label6.TabIndex = 18;
            label6.Text = "Код";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 84);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 16;
            label5.Text = "Тип";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 13;
            label2.Text = "Підстанція";
            // 
            // CreateEditBrigadeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 173);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(combo_substation);
            Controls.Add(textbox_type);
            Controls.Add(textbox_code);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(408, 212);
            Name = "CreateEditBrigadeForm";
            Text = "CreateEditBrigadeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        public ComboBox combo_substation;
        private TextBox textbox_type;
        private TextBox textbox_code;
        private Label label6;
        private Label label5;
        private Label label2;
    }
}