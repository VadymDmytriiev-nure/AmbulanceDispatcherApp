namespace AmbulanceDispatcherApp.Forms.Brigade
{
    partial class BrigadeFiltersForm
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
            textbox_type = new TextBox();
            textbox_code = new TextBox();
            label_type = new Label();
            label4 = new Label();
            combo_substation = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(71, 132);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 38;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._211861_16x161;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(197, 132);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 39;
            button_save.Text = "    Застосувати";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_type
            // 
            textbox_type.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_type.Location = new Point(103, 86);
            textbox_type.Margin = new Padding(1, 2, 1, 2);
            textbox_type.Name = "textbox_type";
            textbox_type.PlaceholderText = "Звичайна";
            textbox_type.Size = new Size(279, 29);
            textbox_type.TabIndex = 37;
            // 
            // textbox_code
            // 
            textbox_code.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_code.Location = new Point(103, 53);
            textbox_code.Margin = new Padding(1, 2, 1, 2);
            textbox_code.Name = "textbox_code";
            textbox_code.PlaceholderText = "ХА-1-1";
            textbox_code.Size = new Size(279, 29);
            textbox_code.TabIndex = 36;
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new Point(62, 89);
            label_type.Margin = new Padding(4, 0, 4, 0);
            label_type.Name = "label_type";
            label_type.Size = new Size(36, 21);
            label_type.TabIndex = 41;
            label_type.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 56);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 40;
            label4.Text = "Код";
            // 
            // combo_substation
            // 
            combo_substation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_substation.FormattingEnabled = true;
            combo_substation.Location = new Point(103, 20);
            combo_substation.Margin = new Padding(1, 2, 1, 2);
            combo_substation.Name = "combo_substation";
            combo_substation.Size = new Size(279, 29);
            combo_substation.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 42;
            label2.Text = "Підстанція";
            // 
            // BrigadeFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 171);
            Controls.Add(combo_substation);
            Controls.Add(label2);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_type);
            Controls.Add(textbox_code);
            Controls.Add(label_type);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(330, 210);
            Name = "BrigadeFiltersForm";
            Text = "Бригади - Фільтри";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_type;
        private TextBox textbox_code;
        private Label label_type;
        private Label label4;
        public ComboBox combo_substation;
        private Label label2;
    }
}