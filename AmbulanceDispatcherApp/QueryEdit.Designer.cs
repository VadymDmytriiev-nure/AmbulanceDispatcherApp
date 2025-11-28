namespace AmbulanceDispatcherApp
{
    partial class QueryEdit
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
            splitContainer1 = new SplitContainer();
            button_exit = new Button();
            button_clear = new Button();
            button_doSQL = new Button();
            richtextbox = new RichTextBox();
            datagridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(31, 29);
            splitContainer1.Margin = new Padding(8, 7, 8, 7);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button_exit);
            splitContainer1.Panel1.Controls.Add(button_clear);
            splitContainer1.Panel1.Controls.Add(button_doSQL);
            splitContainer1.Panel1.Controls.Add(richtextbox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(datagridview);
            splitContainer1.Size = new Size(1028, 780);
            splitContainer1.SplitterDistance = 389;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 1;
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_exit.ForeColor = Color.MintCream;
            button_exit.Location = new Point(846, 105);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(175, 43);
            button_exit.TabIndex = 3;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_clear.ForeColor = Color.MintCream;
            button_clear.Location = new Point(846, 56);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(175, 43);
            button_clear.TabIndex = 2;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_doSQL
            // 
            button_doSQL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_doSQL.Location = new Point(846, 7);
            button_doSQL.Name = "button_doSQL";
            button_doSQL.Size = new Size(175, 43);
            button_doSQL.TabIndex = 1;
            button_doSQL.Text = "Do SQL";
            button_doSQL.UseVisualStyleBackColor = true;
            button_doSQL.Click += button_doSQL_Click;
            // 
            // richtextbox
            // 
            richtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richtextbox.Location = new Point(8, 7);
            richtextbox.Margin = new Padding(8, 7, 8, 7);
            richtextbox.Name = "richtextbox";
            richtextbox.Size = new Size(827, 375);
            richtextbox.TabIndex = 0;
            richtextbox.Text = "";
            // 
            // datagridview
            // 
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToDeleteRows = false;
            datagridview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(8, 7);
            datagridview.Margin = new Padding(8, 7, 8, 7);
            datagridview.Name = "datagridview";
            datagridview.ReadOnly = true;
            datagridview.Size = new Size(1013, 361);
            datagridview.TabIndex = 0;
            // 
            // QueryEdit
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 837);
            Controls.Add(splitContainer1);
            Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(8, 7, 8, 7);
            Name = "QueryEdit";
            Text = "QueryEdit";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button_doSQL;
        private RichTextBox richtextbox;
        private DataGridView datagridview;
        private Button button_exit;
        private Button button_clear;
    }
}