namespace AmbulanceDispatcherApp.Forms
{
    partial class CreateEditViewCallForm
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
            datetime_time_created = new DateTimePicker();
            label5 = new Label();
            textbox_comment = new TextBox();
            label2 = new Label();
            textbox_reason = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_address = new TextBox();
            label4 = new Label();
            checkbox_canceled = new CheckBox();
            label3 = new Label();
            button_ok = new Button();
            SuspendLayout();
            // 
            // datetime_time_created
            // 
            datetime_time_created.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created.CalendarForeColor = Color.Black;
            datetime_time_created.CalendarMonthBackground = Color.Black;
            datetime_time_created.CalendarTitleBackColor = Color.Black;
            datetime_time_created.CalendarTitleForeColor = Color.Black;
            datetime_time_created.CalendarTrailingForeColor = Color.Black;
            datetime_time_created.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            datetime_time_created.Format = DateTimePickerFormat.Custom;
            datetime_time_created.Location = new Point(149, 110);
            datetime_time_created.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_time_created.Name = "datetime_time_created";
            datetime_time_created.Size = new Size(256, 29);
            datetime_time_created.TabIndex = 88;
            datetime_time_created.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 84;
            label5.Text = "Дата створення";
            // 
            // textbox_comment
            // 
            textbox_comment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_comment.Location = new Point(149, 77);
            textbox_comment.Margin = new Padding(1, 2, 1, 2);
            textbox_comment.Name = "textbox_comment";
            textbox_comment.Size = new Size(256, 29);
            textbox_comment.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 81;
            label2.Text = "Коментар";
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(148, 44);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(256, 29);
            textbox_reason.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 79;
            label1.Text = "Привід";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(84, 239);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 75;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(210, 239);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 76;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(149, 11);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(256, 29);
            textbox_address.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 14);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 77;
            label4.Text = "Адреса";
            // 
            // checkbox_canceled
            // 
            checkbox_canceled.AutoSize = true;
            checkbox_canceled.Location = new Point(148, 149);
            checkbox_canceled.Name = "checkbox_canceled";
            checkbox_canceled.Size = new Size(44, 25);
            checkbox_canceled.TabIndex = 89;
            checkbox_canceled.Text = "Ні";
            checkbox_canceled.TextAlign = ContentAlignment.MiddleCenter;
            checkbox_canceled.UseVisualStyleBackColor = true;
            checkbox_canceled.CheckedChanged += checkbox_canceled_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 90;
            label3.Text = "Виклик відмінено";
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom;
            button_ok.Image = Properties.Resources._212394_16x16;
            button_ok.ImageAlign = ContentAlignment.MiddleLeft;
            button_ok.Location = new Point(145, 239);
            button_ok.Margin = new Padding(1, 2, 1, 2);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(124, 28);
            button_ok.TabIndex = 91;
            button_ok.Text = "    OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Visible = false;
            // 
            // CreateEditViewCallForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 278);
            Controls.Add(button_ok);
            Controls.Add(label3);
            Controls.Add(checkbox_canceled);
            Controls.Add(datetime_time_created);
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
            Name = "CreateEditViewCallForm";
            Text = "CreateEditCallForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datetime_time_created;
        private Label label5;
        private TextBox textbox_tel;
        private TextBox textbox_comment;
        private Label label2;
        private TextBox textbox_reason;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_address;
        private Label label4;
        private CheckBox checkbox_canceled;
        private Label label3;
        private Button button_ok;
    }
}