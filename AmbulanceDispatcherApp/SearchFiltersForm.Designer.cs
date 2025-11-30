namespace AmbulanceDispatcherApp
{
    partial class SearchFiltersForm
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
            datetime_time_created_from = new DateTimePicker();
            combo_dispatcher = new ComboBox();
            spin_callout_from = new NumericUpDown();
            textbox_reason = new TextBox();
            textbox_address = new TextBox();
            textbox_channel = new TextBox();
            textbox_tel = new TextBox();
            textbox_patriarchic = new TextBox();
            textbox_name = new TextBox();
            textbox_surname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datetime_time_created_to = new DateTimePicker();
            spin_callout_to = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(251, 522);
            button_cancel.Margin = new Padding(2, 3, 2, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(206, 50);
            button_cancel.TabIndex = 13;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._211861_16x161;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(462, 522);
            button_save.Margin = new Padding(2, 3, 2, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(206, 50);
            button_save.TabIndex = 14;
            button_save.Text = "Шукати";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // datetime_time_created_from
            // 
            datetime_time_created_from.CalendarForeColor = Color.Black;
            datetime_time_created_from.CalendarMonthBackground = Color.Black;
            datetime_time_created_from.CalendarTitleBackColor = Color.Black;
            datetime_time_created_from.CalendarTitleForeColor = Color.Black;
            datetime_time_created_from.CalendarTrailingForeColor = Color.Black;
            datetime_time_created_from.CustomFormat = "yyyy-MM-dd HH:mm:ss\n";
            datetime_time_created_from.Format = DateTimePickerFormat.Custom;
            datetime_time_created_from.Location = new Point(265, 35);
            datetime_time_created_from.Margin = new Padding(2, 3, 2, 3);
            datetime_time_created_from.Name = "datetime_time_created_from";
            datetime_time_created_from.Size = new Size(269, 43);
            datetime_time_created_from.TabIndex = 1;
            datetime_time_created_from.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // combo_dispatcher
            // 
            combo_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_dispatcher.FormattingEnabled = true;
            combo_dispatcher.Location = new Point(198, 84);
            combo_dispatcher.Margin = new Padding(2, 3, 2, 3);
            combo_dispatcher.Name = "combo_dispatcher";
            combo_dispatcher.Size = new Size(675, 45);
            combo_dispatcher.TabIndex = 3;
            // 
            // spin_callout_from
            // 
            spin_callout_from.Location = new Point(265, 135);
            spin_callout_from.Margin = new Padding(2, 3, 2, 3);
            spin_callout_from.Name = "spin_callout_from";
            spin_callout_from.Size = new Size(269, 43);
            spin_callout_from.TabIndex = 4;
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(198, 410);
            textbox_reason.Margin = new Padding(2, 3, 2, 3);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(675, 43);
            textbox_reason.TabIndex = 11;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(198, 364);
            textbox_address.Margin = new Padding(2, 3, 2, 3);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.Size = new Size(675, 43);
            textbox_address.TabIndex = 10;
            // 
            // textbox_channel
            // 
            textbox_channel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_channel.Location = new Point(198, 456);
            textbox_channel.Margin = new Padding(2, 3, 2, 3);
            textbox_channel.Name = "textbox_channel";
            textbox_channel.PlaceholderText = "103";
            textbox_channel.Size = new Size(675, 43);
            textbox_channel.TabIndex = 12;
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(198, 318);
            textbox_tel.Margin = new Padding(2, 3, 2, 3);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.PlaceholderText = "+380XXXXXXXXX";
            textbox_tel.Size = new Size(675, 43);
            textbox_tel.TabIndex = 9;
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(198, 273);
            textbox_patriarchic.Margin = new Padding(2, 3, 2, 3);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(675, 43);
            textbox_patriarchic.TabIndex = 8;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(198, 227);
            textbox_name.Margin = new Padding(2, 3, 2, 3);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(675, 43);
            textbox_name.TabIndex = 7;
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(198, 181);
            textbox_surname.Margin = new Padding(2, 3, 2, 3);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(675, 43);
            textbox_surname.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 459);
            label10.Margin = new Padding(7, 0, 7, 0);
            label10.Name = "label10";
            label10.Size = new Size(182, 37);
            label10.TabIndex = 31;
            label10.Text = "Канал зв'язку";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 413);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 37);
            label9.TabIndex = 30;
            label9.Text = "Привід";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 367);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 37);
            label8.TabIndex = 29;
            label8.Text = "Адреса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 137);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(153, 37);
            label7.TabIndex = 28;
            label7.Text = "№ виклику";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 184);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 37);
            label6.TabIndex = 27;
            label6.Text = "Прізвище";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 229);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 37);
            label5.TabIndex = 26;
            label5.Text = "Ім'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 273);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 25;
            label4.Text = "По батькові";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 321);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 24;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 37);
            label2.TabIndex = 23;
            label2.Text = "Диспетчер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 22;
            label1.Text = "Час дзвінка";
            // 
            // datetime_time_created_to
            // 
            datetime_time_created_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_time_created_to.CalendarForeColor = Color.Black;
            datetime_time_created_to.CalendarMonthBackground = Color.Black;
            datetime_time_created_to.CalendarTitleBackColor = Color.Black;
            datetime_time_created_to.CalendarTitleForeColor = Color.Black;
            datetime_time_created_to.CalendarTrailingForeColor = Color.Black;
            datetime_time_created_to.CustomFormat = "yyyy-MM-dd HH:mm:ss\n";
            datetime_time_created_to.Format = DateTimePickerFormat.Custom;
            datetime_time_created_to.Location = new Point(600, 35);
            datetime_time_created_to.Margin = new Padding(2, 3, 2, 3);
            datetime_time_created_to.Name = "datetime_time_created_to";
            datetime_time_created_to.Size = new Size(273, 43);
            datetime_time_created_to.TabIndex = 2;
            datetime_time_created_to.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // spin_callout_to
            // 
            spin_callout_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout_to.Location = new Point(600, 135);
            spin_callout_to.Margin = new Padding(2, 3, 2, 3);
            spin_callout_to.Name = "spin_callout_to";
            spin_callout_to.Size = new Size(273, 43);
            spin_callout_to.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(203, 137);
            label11.Margin = new Padding(7, 0, 7, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 37);
            label11.TabIndex = 46;
            label11.Text = "від";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(543, 137);
            label12.Margin = new Padding(7, 0, 7, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 37);
            label12.TabIndex = 47;
            label12.Text = "до";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(203, 39);
            label13.Margin = new Padding(7, 0, 7, 0);
            label13.Name = "label13";
            label13.Size = new Size(53, 37);
            label13.TabIndex = 48;
            label13.Text = "від";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(543, 39);
            label14.Margin = new Padding(7, 0, 7, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 37);
            label14.TabIndex = 49;
            label14.Text = "до";
            // 
            // SearchFiltersForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 584);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(spin_callout_to);
            Controls.Add(datetime_time_created_to);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(datetime_time_created_from);
            Controls.Add(combo_dispatcher);
            Controls.Add(spin_callout_from);
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
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6, 7, 6, 7);
            Name = "SearchFiltersForm";
            Text = "Пошук";
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private DateTimePicker datetime_time_created_from;
        private ComboBox combo_dispatcher;
        private NumericUpDown spin_callout_from;
        private TextBox textbox_reason;
        private TextBox textbox_address;
        private TextBox textbox_channel;
        private TextBox textbox_tel;
        private TextBox textbox_patriarchic;
        private TextBox textbox_name;
        private TextBox textbox_surname;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker datetime_time_created_to;
        private NumericUpDown spin_callout_to;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}