namespace AmbulanceDispatcherApp.Forms.Departures
{
    partial class CreateEditDepartureForm
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
            datetime_departed = new DateTimePicker();
            textbox_to_address = new TextBox();
            label1 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            textbox_from_address = new TextBox();
            label4 = new Label();
            datetime_arrived = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            spin_mileage = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            spin_callout = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)spin_mileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout).BeginInit();
            SuspendLayout();
            // 
            // datetime_departed
            // 
            datetime_departed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_departed.CalendarForeColor = Color.Black;
            datetime_departed.CalendarMonthBackground = Color.Black;
            datetime_departed.CalendarTitleBackColor = Color.Black;
            datetime_departed.CalendarTitleForeColor = Color.Black;
            datetime_departed.CalendarTrailingForeColor = Color.Black;
            datetime_departed.CustomFormat = "yyyy-MM-dd";
            datetime_departed.Format = DateTimePickerFormat.Custom;
            datetime_departed.Location = new Point(143, 112);
            datetime_departed.Margin = new Padding(1, 2, 1, 2);
            datetime_departed.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_departed.Name = "datetime_departed";
            datetime_departed.Size = new Size(256, 29);
            datetime_departed.TabIndex = 88;
            datetime_departed.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textbox_to_address
            // 
            textbox_to_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_to_address.Location = new Point(143, 79);
            textbox_to_address.Margin = new Padding(1, 2, 1, 2);
            textbox_to_address.Name = "textbox_to_address";
            textbox_to_address.Size = new Size(256, 29);
            textbox_to_address.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 79;
            label1.Text = "Кінцева адреса";
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Bottom;
            button_cancel.CausesValidation = false;
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Image = Properties.Resources._212384_16x16;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(84, 236);
            button_cancel.Margin = new Padding(1, 2, 1, 2);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(124, 28);
            button_cancel.TabIndex = 75;
            button_cancel.Text = "Скасувати";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom;
            button_save.Image = Properties.Resources._212394_16x16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(210, 236);
            button_save.Margin = new Padding(1, 2, 1, 2);
            button_save.Name = "button_save";
            button_save.Size = new Size(124, 28);
            button_save.TabIndex = 76;
            button_save.Text = "    Зберегти";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textbox_from_address
            // 
            textbox_from_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_from_address.Location = new Point(144, 46);
            textbox_from_address.Margin = new Padding(1, 2, 1, 2);
            textbox_from_address.Name = "textbox_from_address";
            textbox_from_address.Size = new Size(256, 29);
            textbox_from_address.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 77;
            label4.Text = "Початкова адреса";
            // 
            // datetime_arrived
            // 
            datetime_arrived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime_arrived.CalendarForeColor = Color.Black;
            datetime_arrived.CalendarMonthBackground = Color.Black;
            datetime_arrived.CalendarTitleBackColor = Color.Black;
            datetime_arrived.CalendarTitleForeColor = Color.Black;
            datetime_arrived.CalendarTrailingForeColor = Color.Black;
            datetime_arrived.CustomFormat = "yyyy-MM-dd";
            datetime_arrived.Format = DateTimePickerFormat.Custom;
            datetime_arrived.Location = new Point(143, 145);
            datetime_arrived.Margin = new Padding(1, 2, 1, 2);
            datetime_arrived.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datetime_arrived.Name = "datetime_arrived";
            datetime_arrived.Size = new Size(256, 29);
            datetime_arrived.TabIndex = 89;
            datetime_arrived.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 90;
            label2.Text = "Час відбуття";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 91;
            label3.Text = "Час прибуття";
            // 
            // spin_mileage
            // 
            spin_mileage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_mileage.DecimalPlaces = 3;
            spin_mileage.Location = new Point(143, 179);
            spin_mileage.Name = "spin_mileage";
            spin_mileage.Size = new Size(213, 29);
            spin_mileage.TabIndex = 92;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(363, 181);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 93;
            label5.Text = "км";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 181);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 94;
            label6.Text = "Кілометраж";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 14);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 95;
            label7.Text = "№ Виклику";
            // 
            // spin_callout
            // 
            spin_callout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spin_callout.Location = new Point(143, 12);
            spin_callout.Name = "spin_callout";
            spin_callout.Size = new Size(256, 29);
            spin_callout.TabIndex = 96;
            // 
            // CreateEditDepartureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 275);
            Controls.Add(spin_callout);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(spin_mileage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(datetime_arrived);
            Controls.Add(datetime_departed);
            Controls.Add(textbox_to_address);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textbox_from_address);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateEditDepartureForm";
            Text = "CreateEditDepartureForm";
            ((System.ComponentModel.ISupportInitialize)spin_mileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)spin_callout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datetime_departed;
        private TextBox textbox_to_address;
        private Label label1;
        private Button button_cancel;
        private Button button_save;
        private TextBox textbox_from_address;
        private Label label4;
        private DateTimePicker datetime_arrived;
        private Label label2;
        private Label label3;
        private NumericUpDown spin_mileage;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown spin_callout;
    }
}