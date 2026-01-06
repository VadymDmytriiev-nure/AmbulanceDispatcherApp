namespace AmbulanceDispatcherApp.Forms
{
    partial class CalloutFiltersForm
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
            label3 = new Label();
            datetime_time_created_from = new DateTimePicker();
            label5 = new Label();
            textbox_comment = new TextBox();
            label2 = new Label();
            textbox_reason = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_address = new TextBox();
            label4 = new Label();
            label12 = new Label();
            label11 = new Label();
            spin_callout_to = new NumericUpDown();
            spin_callout_from = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            datetime_time_created_to = new DateTimePicker();
            radio_canceled_unknown = new RadioButton();
            radio_canceled_true = new RadioButton();
            radio_canceled_false = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 103;
            label3.Text = "Виклик відмінено";
            // 
            // datetime_time_created_from
            // 
            datetime_time_created_from.CalendarForeColor = Color.Black;
            datetime_time_created_from.CalendarMonthBackground = Color.Black;
            datetime_time_created_from.CalendarTitleBackColor = Color.Black;
            datetime_time_created_from.CalendarTitleForeColor = Color.Black;
            datetime_time_created_from.CalendarTrailingForeColor = Color.Black;
            datetime_time_created_from.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetime_time_created_from.Format = DateTimePickerFormat.Custom;
            datetime_time_created_from.Location = new Point(179, 143);
            datetime_time_created_from.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created_from.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_time_created_from.Name = "datetime_time_created_from";
            datetime_time_created_from.Size = new Size(184, 29);
            datetime_time_created_from.TabIndex = 101;
            datetime_time_created_from.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 100;
            label5.Text = "Дата створення";
            // 
            // textbox_comment
            // 
            textbox_comment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_comment.Location = new Point(144, 110);
            textbox_comment.Margin = new Padding(1, 2, 1, 2);
            textbox_comment.Name = "textbox_comment";
            textbox_comment.Size = new Size(448, 29);
            textbox_comment.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 99;
            label2.Text = "Коментар";
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(143, 77);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(448, 29);
            textbox_reason.TabIndex = 96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 97;
            label1.Text = "Привід";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(179, 269);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 93;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(305, 269);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 94;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(144, 44);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(448, 29);
            textbox_address.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 95;
            label4.Text = "Адреса";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(332, 14);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 108;
            label12.Text = "до";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(143, 14);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(31, 21);
            label11.TabIndex = 107;
            label11.Text = "від";
            // 
            // spin_callout_to
            // 
            spin_callout_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout_to.Location = new Point(365, 11);
            spin_callout_to.Margin = new Padding(1, 2, 1, 2);
            spin_callout_to.Name = "spin_callout_to";
            spin_callout_to.Size = new Size(226, 29);
            spin_callout_to.TabIndex = 105;
            // 
            // spin_callout_from
            // 
            spin_callout_from.Location = new Point(179, 11);
            spin_callout_from.Margin = new Padding(1, 2, 1, 2);
            spin_callout_from.Name = "spin_callout_from";
            spin_callout_from.Size = new Size(148, 29);
            spin_callout_from.TabIndex = 104;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 106;
            label7.Text = "№ виклику";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 149);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 110;
            label6.Text = "до";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 149);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 109;
            label8.Text = "від";
            // 
            // datetime_time_created_to
            // 
            datetime_time_created_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created_to.CalendarForeColor = Color.Black;
            datetime_time_created_to.CalendarMonthBackground = Color.Black;
            datetime_time_created_to.CalendarTitleBackColor = Color.Black;
            datetime_time_created_to.CalendarTitleForeColor = Color.Black;
            datetime_time_created_to.CalendarTrailingForeColor = Color.Black;
            datetime_time_created_to.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetime_time_created_to.Format = DateTimePickerFormat.Custom;
            datetime_time_created_to.Location = new Point(398, 143);
            datetime_time_created_to.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created_to.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_time_created_to.Name = "datetime_time_created_to";
            datetime_time_created_to.Size = new Size(195, 29);
            datetime_time_created_to.TabIndex = 111;
            datetime_time_created_to.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radio_canceled_unknown
            // 
            radio_canceled_unknown.AutoSize = true;
            radio_canceled_unknown.Checked = true;
            radio_canceled_unknown.Location = new Point(143, 179);
            radio_canceled_unknown.Name = "radio_canceled_unknown";
            radio_canceled_unknown.Size = new Size(35, 25);
            radio_canceled_unknown.TabIndex = 112;
            radio_canceled_unknown.TabStop = true;
            radio_canceled_unknown.Text = "?";
            radio_canceled_unknown.UseVisualStyleBackColor = true;
            // 
            // radio_canceled_true
            // 
            radio_canceled_true.AutoSize = true;
            radio_canceled_true.Location = new Point(184, 179);
            radio_canceled_true.Name = "radio_canceled_true";
            radio_canceled_true.Size = new Size(52, 25);
            radio_canceled_true.TabIndex = 113;
            radio_canceled_true.TabStop = true;
            radio_canceled_true.Text = "Так";
            radio_canceled_true.UseVisualStyleBackColor = true;
            // 
            // radio_canceled_false
            // 
            radio_canceled_false.AutoSize = true;
            radio_canceled_false.Location = new Point(242, 180);
            radio_canceled_false.Name = "radio_canceled_false";
            radio_canceled_false.Size = new Size(43, 25);
            radio_canceled_false.TabIndex = 114;
            radio_canceled_false.TabStop = true;
            radio_canceled_false.Text = "Ні";
            radio_canceled_false.UseVisualStyleBackColor = true;
            // 
            // CalloutFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 308);
            Controls.Add(radio_canceled_false);
            Controls.Add(radio_canceled_true);
            Controls.Add(radio_canceled_unknown);
            Controls.Add(datetime_time_created_to);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(spin_callout_to);
            Controls.Add(spin_callout_from);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(datetime_time_created_from);
            Controls.Add(label5);
            Controls.Add(textbox_comment);
            Controls.Add(label2);
            Controls.Add(textbox_reason);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_address);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CalloutFiltersForm";
            Text = "Виклики - Фільтри";
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker datetime_time_created_from;
        private Label label5;
        private TextBox textbox_comment;
        private Label label2;
        private TextBox textbox_reason;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_address;
        private Label label4;
        private Label label12;
        private Label label11;
        private NumericUpDown spin_callout_to;
        private NumericUpDown spin_callout_from;
        private Label label7;
        private Label label6;
        private Label label8;
        private DateTimePicker datetime_time_created_to;
        private RadioButton radio_canceled_unknown;
        private RadioButton radio_canceled_true;
        private RadioButton radio_canceled_false;
    }
}