namespace AmbulanceDispatcherApp
{
    partial class EditCall
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textbox_surname = new TextBox();
            textbox_name = new TextBox();
            textbox_patriarchic = new TextBox();
            textbox_tel = new TextBox();
            textbox_channel = new TextBox();
            textbox_address = new TextBox();
            textbox_reason = new TextBox();
            spin_callout = new NumericUpDown();
            combo_dispatcher = new ComboBox();
            datetime_time_created = new DateTimePicker();
            button_save = new Button();
            button_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)spin_callout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 44);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 36);
            label1.TabIndex = 0;
            label1.Text = "Час дзвінка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 97);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 1;
            label2.Text = "Диспетчер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 347);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 36);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 297);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 3;
            label4.Text = "По батькові";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 247);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 36);
            label5.TabIndex = 4;
            label5.Text = "Ім'я";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 197);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 36);
            label6.TabIndex = 5;
            label6.Text = "Прізвище";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 146);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 36);
            label7.TabIndex = 6;
            label7.Text = "№ виклику";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 397);
            label8.Margin = new Padding(8, 0, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 36);
            label8.TabIndex = 7;
            label8.Text = "Адреса";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(109, 447);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 36);
            label9.TabIndex = 8;
            label9.Text = "Привід";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 497);
            label10.Margin = new Padding(8, 0, 8, 0);
            label10.Name = "label10";
            label10.Size = new Size(197, 36);
            label10.TabIndex = 9;
            label10.Text = "Канал зв'язку";
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(231, 194);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(506, 44);
            textbox_surname.TabIndex = 10;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(231, 244);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(506, 44);
            textbox_name.TabIndex = 11;
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(231, 294);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(506, 44);
            textbox_patriarchic.TabIndex = 12;
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(231, 344);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.PlaceholderText = "+380XXXXXXXXX";
            textbox_tel.Size = new Size(506, 44);
            textbox_tel.TabIndex = 13;
            // 
            // textbox_channel
            // 
            textbox_channel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_channel.Location = new Point(231, 494);
            textbox_channel.Name = "textbox_channel";
            textbox_channel.PlaceholderText = "103";
            textbox_channel.Size = new Size(506, 44);
            textbox_channel.TabIndex = 14;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(231, 394);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.Size = new Size(506, 44);
            textbox_address.TabIndex = 15;
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(231, 444);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(506, 44);
            textbox_reason.TabIndex = 16;
            // 
            // spin_callout
            // 
            spin_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout.Location = new Point(231, 144);
            spin_callout.Name = "spin_callout";
            spin_callout.Size = new Size(506, 44);
            spin_callout.TabIndex = 17;
            // 
            // combo_dispatcher
            // 
            combo_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_dispatcher.FormattingEnabled = true;
            combo_dispatcher.Location = new Point(231, 94);
            combo_dispatcher.Name = "combo_dispatcher";
            combo_dispatcher.Size = new Size(506, 44);
            combo_dispatcher.TabIndex = 18;
            // 
            // datetime_time_created
            // 
            datetime_time_created.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created.CalendarForeColor = Color.Black;
            datetime_time_created.CalendarMonthBackground = Color.Black;
            datetime_time_created.CalendarTitleBackColor = Color.Black;
            datetime_time_created.CalendarTitleForeColor = Color.Black;
            datetime_time_created.CalendarTrailingForeColor = Color.Black;
            datetime_time_created.CustomFormat = "yyyy-MM-dd HH:mm:ss\n";
            datetime_time_created.Format = DateTimePickerFormat.Custom;
            datetime_time_created.Location = new Point(231, 38);
            datetime_time_created.Name = "datetime_time_created";
            datetime_time_created.Size = new Size(506, 44);
            datetime_time_created.TabIndex = 19;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(395, 576);
            button_save.Name = "button_save";
            button_save.Size = new Size(247, 54);
            button_save.TabIndex = 20;
            button_save.Text = "Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(142, 576);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(247, 54);
            button_cancel.TabIndex = 21;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // EditCall
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 642);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(datetime_time_created);
            Controls.Add(combo_dispatcher);
            Controls.Add(spin_callout);
            Controls.Add(textbox_reason);
            Controls.Add(textbox_address);
            Controls.Add(textbox_channel);
            Controls.Add(textbox_tel);
            Controls.Add(textbox_patriarchic);
            Controls.Add(textbox_name);
            Controls.Add(textbox_surname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(8, 7, 8, 7);
            Name = "EditCall";
            Text = "Редагувати дзвінок";
            ((System.ComponentModel.ISupportInitialize)spin_callout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textbox_surname;
        private TextBox textbox_name;
        private TextBox textbox_patriarchic;
        private TextBox textbox_tel;
        private TextBox textbox_channel;
        private TextBox textbox_address;
        private TextBox textbox_reason;
        private NumericUpDown spin_callout;
        private ComboBox combo_dispatcher;
        private DateTimePicker datetime_time_created;
        private Button button_save;
        private Button button_cancel;
    }
}