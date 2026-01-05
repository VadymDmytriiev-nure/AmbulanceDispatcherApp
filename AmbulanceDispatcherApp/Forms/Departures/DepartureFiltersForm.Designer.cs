namespace AmbulanceDispatcherApp.Forms.Departures
{
    partial class DepartureFiltersForm
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
            spin_callout_min = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            spin_mileage_min = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            datetime_arrived_min = new DateTimePicker();
            datetime_departed_min = new DateTimePicker();
            textbox_to_address = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_from_address = new TextBox();
            label4 = new Label();
            label14 = new Label();
            label13 = new Label();
            datetime_departed_max = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            datetime_arrived_max = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            spin_mileage_max = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            spin_callout_max = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)spin_callout_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_mileage_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_mileage_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_max).BeginInit();
            SuspendLayout();
            // 
            // spin_callout_min
            // 
            spin_callout_min.Location = new Point(185, 11);
            spin_callout_min.Name = "spin_callout_min";
            spin_callout_min.Size = new Size(178, 29);
            spin_callout_min.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 13);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 110;
            label7.Text = "№ Виклику";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 180);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 109;
            label6.Text = "Кілометраж";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 180);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 108;
            label5.Text = "км";
            // 
            // spin_mileage_min
            // 
            spin_mileage_min.DecimalPlaces = 3;
            spin_mileage_min.Location = new Point(185, 178);
            spin_mileage_min.Name = "spin_mileage_min";
            spin_mileage_min.Size = new Size(145, 29);
            spin_mileage_min.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 106;
            label3.Text = "Час прибуття";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 105;
            label2.Text = "Час відбуття";
            // 
            // datetime_arrived_min
            // 
            datetime_arrived_min.CalendarForeColor = Color.Black;
            datetime_arrived_min.CalendarMonthBackground = Color.Black;
            datetime_arrived_min.CalendarTitleBackColor = Color.Black;
            datetime_arrived_min.CalendarTitleForeColor = Color.Black;
            datetime_arrived_min.CalendarTrailingForeColor = Color.Black;
            datetime_arrived_min.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            datetime_arrived_min.Format = DateTimePickerFormat.Custom;
            datetime_arrived_min.Location = new Point(185, 144);
            datetime_arrived_min.Margin = new Padding(1, 2, 1, 2);
            datetime_arrived_min.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_arrived_min.Name = "datetime_arrived_min";
            datetime_arrived_min.Size = new Size(178, 29);
            datetime_arrived_min.TabIndex = 104;
            datetime_arrived_min.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // datetime_departed_min
            // 
            datetime_departed_min.CalendarForeColor = Color.Black;
            datetime_departed_min.CalendarMonthBackground = Color.Black;
            datetime_departed_min.CalendarTitleBackColor = Color.Black;
            datetime_departed_min.CalendarTitleForeColor = Color.Black;
            datetime_departed_min.CalendarTrailingForeColor = Color.Black;
            datetime_departed_min.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            datetime_departed_min.Format = DateTimePickerFormat.Custom;
            datetime_departed_min.Location = new Point(185, 111);
            datetime_departed_min.Margin = new Padding(1, 2, 1, 2);
            datetime_departed_min.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_departed_min.Name = "datetime_departed_min";
            datetime_departed_min.Size = new Size(178, 29);
            datetime_departed_min.TabIndex = 103;
            datetime_departed_min.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textbox_to_address
            // 
            textbox_to_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_to_address.Location = new Point(149, 78);
            textbox_to_address.Margin = new Padding(1, 2, 1, 2);
            textbox_to_address.Name = "textbox_to_address";
            textbox_to_address.Size = new Size(445, 29);
            textbox_to_address.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 102;
            label1.Text = "Кінцева адреса";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(173, 236);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 98;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._211861_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(299, 236);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 99;
            button_save.Text = "    Застосувати";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_from_address
            // 
            textbox_from_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_from_address.Location = new Point(150, 45);
            textbox_from_address.Margin = new Padding(1, 2, 1, 2);
            textbox_from_address.Name = "textbox_from_address";
            textbox_from_address.Size = new Size(445, 29);
            textbox_from_address.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 100;
            label4.Text = "Початкова адреса";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(368, 115);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 113;
            label14.Text = "до";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(149, 115);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 21);
            label13.TabIndex = 112;
            label13.Text = "від";
            // 
            // datetime_departed_max
            // 
            datetime_departed_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_departed_max.CalendarForeColor = Color.Black;
            datetime_departed_max.CalendarMonthBackground = Color.Black;
            datetime_departed_max.CalendarTitleBackColor = Color.Black;
            datetime_departed_max.CalendarTitleForeColor = Color.Black;
            datetime_departed_max.CalendarTrailingForeColor = Color.Black;
            datetime_departed_max.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            datetime_departed_max.Format = DateTimePickerFormat.Custom;
            datetime_departed_max.Location = new Point(401, 111);
            datetime_departed_max.Margin = new Padding(1, 2, 1, 2);
            datetime_departed_max.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_departed_max.Name = "datetime_departed_max";
            datetime_departed_max.Size = new Size(193, 29);
            datetime_departed_max.TabIndex = 114;
            datetime_departed_max.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 147);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 115;
            label8.Text = "від";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 147);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 21);
            label9.TabIndex = 116;
            label9.Text = "до";
            // 
            // datetime_arrived_max
            // 
            datetime_arrived_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_arrived_max.CalendarForeColor = Color.Black;
            datetime_arrived_max.CalendarMonthBackground = Color.Black;
            datetime_arrived_max.CalendarTitleBackColor = Color.Black;
            datetime_arrived_max.CalendarTitleForeColor = Color.Black;
            datetime_arrived_max.CalendarTrailingForeColor = Color.Black;
            datetime_arrived_max.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            datetime_arrived_max.Format = DateTimePickerFormat.Custom;
            datetime_arrived_max.Location = new Point(400, 144);
            datetime_arrived_max.Margin = new Padding(1, 2, 1, 2);
            datetime_arrived_max.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_arrived_max.Name = "datetime_arrived_max";
            datetime_arrived_max.Size = new Size(194, 29);
            datetime_arrived_max.TabIndex = 117;
            datetime_arrived_max.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(368, 180);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 119;
            label10.Text = "до";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(149, 180);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(31, 21);
            label11.TabIndex = 118;
            label11.Text = "від";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(565, 182);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(29, 21);
            label12.TabIndex = 121;
            label12.Text = "км";
            // 
            // spin_mileage_max
            // 
            spin_mileage_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_mileage_max.DecimalPlaces = 3;
            spin_mileage_max.Location = new Point(400, 180);
            spin_mileage_max.Name = "spin_mileage_max";
            spin_mileage_max.Size = new Size(158, 29);
            spin_mileage_max.TabIndex = 120;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(147, 13);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(31, 21);
            label15.TabIndex = 122;
            label15.Text = "від";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(368, 13);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(28, 21);
            label16.TabIndex = 123;
            label16.Text = "до";
            // 
            // spin_callout_max
            // 
            spin_callout_max.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout_max.Location = new Point(403, 11);
            spin_callout_max.Name = "spin_callout_max";
            spin_callout_max.Size = new Size(191, 29);
            spin_callout_max.TabIndex = 124;
            // 
            // DepartureFiltersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 275);
            Controls.Add(spin_callout_max);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(spin_mileage_max);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(datetime_arrived_max);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(datetime_departed_max);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(spin_callout_min);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(spin_mileage_min);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(datetime_arrived_min);
            Controls.Add(datetime_departed_min);
            Controls.Add(textbox_to_address);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_from_address);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DepartureFiltersForm";
            Text = "DepartureFiltersForm";
            ((System.ComponentModel.ISupportInitialize)spin_callout_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_mileage_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_mileage_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout_max).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown spin_callout_min;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown spin_mileage_min;
        private Label label3;
        private Label label2;
        private DateTimePicker datetime_arrived_min;
        private DateTimePicker datetime_departed_min;
        private TextBox textbox_to_address;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_from_address;
        private Label label4;
        private Label label14;
        private Label label13;
        private DateTimePicker datetime_departed_max;
        private Label label8;
        private Label label9;
        private DateTimePicker datetime_arrived_max;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown spin_mileage_max;
        private Label label15;
        private Label label16;
        private NumericUpDown spin_callout_max;
    }
}