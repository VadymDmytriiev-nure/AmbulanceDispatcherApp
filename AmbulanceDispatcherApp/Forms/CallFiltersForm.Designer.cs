namespace AmbulanceDispatcherApp
{
    partial class CallFiltersForm
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
            label15 = new Label();
            label16 = new Label();
            spin_call_max = new NumericUpDown();
            spin_call_min = new NumericUpDown();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_call_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_call_min).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(151, 391);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 13;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._211861_16x161;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(277, 391);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 14;
            button_save.Text = "    Застосувати";
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
            datetime_time_created_from.Location = new Point(160, 44);
            datetime_time_created_from.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created_from.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            datetime_time_created_from.Name = "datetime_time_created_from";
            datetime_time_created_from.Size = new Size(167, 29);
            datetime_time_created_from.TabIndex = 1;
            datetime_time_created_from.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // combo_dispatcher
            // 
            combo_dispatcher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_dispatcher.FormattingEnabled = true;
            combo_dispatcher.Location = new Point(124, 77);
            combo_dispatcher.Margin = new Padding(1, 2, 1, 2);
            combo_dispatcher.Name = "combo_dispatcher";
            combo_dispatcher.Size = new Size(407, 29);
            combo_dispatcher.TabIndex = 3;
            // 
            // spin_callout_from
            // 
            spin_callout_from.Location = new Point(166, 110);
            spin_callout_from.Margin = new Padding(1, 2, 1, 2);
            spin_callout_from.Name = "spin_callout_from";
            spin_callout_from.Size = new Size(161, 29);
            spin_callout_from.TabIndex = 4;
            // 
            // textbox_reason
            // 
            textbox_reason.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_reason.Location = new Point(124, 308);
            textbox_reason.Margin = new Padding(1, 2, 1, 2);
            textbox_reason.Name = "textbox_reason";
            textbox_reason.Size = new Size(407, 29);
            textbox_reason.TabIndex = 11;
            // 
            // textbox_address
            // 
            textbox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_address.Location = new Point(124, 275);
            textbox_address.Margin = new Padding(1, 2, 1, 2);
            textbox_address.Name = "textbox_address";
            textbox_address.PlaceholderText = "м. Харків, вул. Сумська 42";
            textbox_address.Size = new Size(407, 29);
            textbox_address.TabIndex = 10;
            // 
            // textbox_channel
            // 
            textbox_channel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_channel.Location = new Point(124, 341);
            textbox_channel.Margin = new Padding(1, 2, 1, 2);
            textbox_channel.Name = "textbox_channel";
            textbox_channel.PlaceholderText = "103";
            textbox_channel.Size = new Size(407, 29);
            textbox_channel.TabIndex = 12;
            // 
            // textbox_tel
            // 
            textbox_tel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_tel.Location = new Point(124, 242);
            textbox_tel.Margin = new Padding(1, 2, 1, 2);
            textbox_tel.Name = "textbox_tel";
            textbox_tel.PlaceholderText = "+380XXXXXXXXX";
            textbox_tel.Size = new Size(407, 29);
            textbox_tel.TabIndex = 9;
            // 
            // textbox_patriarchic
            // 
            textbox_patriarchic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_patriarchic.Location = new Point(124, 209);
            textbox_patriarchic.Margin = new Padding(1, 2, 1, 2);
            textbox_patriarchic.Name = "textbox_patriarchic";
            textbox_patriarchic.Size = new Size(407, 29);
            textbox_patriarchic.TabIndex = 8;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_name.Location = new Point(124, 176);
            textbox_name.Margin = new Padding(1, 2, 1, 2);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(407, 29);
            textbox_name.TabIndex = 7;
            // 
            // textbox_surname
            // 
            textbox_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_surname.Location = new Point(124, 143);
            textbox_surname.Margin = new Padding(1, 2, 1, 2);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(407, 29);
            textbox_surname.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 344);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 21);
            label10.TabIndex = 31;
            label10.Text = "Канал зв'язку";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 311);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 30;
            label9.Text = "Привід";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 278);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 29;
            label8.Text = "Адреса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 112);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 28;
            label7.Text = "№ виклику";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 146);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 27;
            label6.Text = "Прізвище";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 26;
            label5.Text = "Ім'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 25;
            label4.Text = "По батькові";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 24;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 23;
            label2.Text = "Диспетчер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 22;
            label1.Text = "Час дзвінку";
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
            datetime_time_created_to.Location = new Point(366, 44);
            datetime_time_created_to.Margin = new Padding(1, 2, 1, 2);
            datetime_time_created_to.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            datetime_time_created_to.Name = "datetime_time_created_to";
            datetime_time_created_to.Size = new Size(165, 29);
            datetime_time_created_to.TabIndex = 2;
            datetime_time_created_to.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // spin_callout_to
            // 
            spin_callout_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout_to.Location = new Point(367, 110);
            spin_callout_to.Margin = new Padding(1, 2, 1, 2);
            spin_callout_to.Name = "spin_callout_to";
            spin_callout_to.Size = new Size(164, 29);
            spin_callout_to.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 112);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(31, 21);
            label11.TabIndex = 46;
            label11.Text = "від";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(334, 110);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 47;
            label12.Text = "до";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(127, 48);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 21);
            label13.TabIndex = 48;
            label13.Text = "від";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(333, 48);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 49;
            label14.Text = "до";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(334, 13);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(28, 21);
            label15.TabIndex = 54;
            label15.Text = "до";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(127, 13);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(31, 21);
            label16.TabIndex = 53;
            label16.Text = "від";
            // 
            // spin_call_max
            // 
            spin_call_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_call_max.Location = new Point(367, 11);
            spin_call_max.Margin = new Padding(1, 2, 1, 2);
            spin_call_max.Name = "spin_call_max";
            spin_call_max.Size = new Size(164, 29);
            spin_call_max.TabIndex = 51;
            // 
            // spin_call_min
            // 
            spin_call_min.Location = new Point(166, 11);
            spin_call_min.Margin = new Padding(1, 2, 1, 2);
            spin_call_min.Name = "spin_call_min";
            spin_call_min.Size = new Size(161, 29);
            spin_call_min.TabIndex = 50;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(34, 13);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(85, 21);
            label17.TabIndex = 52;
            label17.Text = "№ дзвінку";
            // 
            // CallFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 426);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(spin_call_max);
            Controls.Add(spin_call_min);
            Controls.Add(label17);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "CallFiltersForm";
            Text = "Дзвінки - Фільтри";
            ((System.ComponentModel.ISupportInitialize)spin_callout_from).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_to).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_call_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_call_min).EndInit();
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
        private Label label15;
        private Label label16;
        private NumericUpDown spin_call_max;
        private NumericUpDown spin_call_min;
        private Label label17;
    }
}