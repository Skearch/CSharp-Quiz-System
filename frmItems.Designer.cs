namespace CSharp_Quiz_System
{
    partial class frmItems
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblTitle = new Label();
            btnSubmit = new Button();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(601, 510);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnSubmit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 504);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(9, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Mode";
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.Location = new Point(9, 39);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(146, 52);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 510);
            Controls.Add(tableLayoutPanel1);
            Name = "frmItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += frmItems_FormClosing;
            Load += frmItems_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnSubmit;
        private System.Windows.Forms.Timer tmrQuiz;
        private Label lblTitle;
    }
}