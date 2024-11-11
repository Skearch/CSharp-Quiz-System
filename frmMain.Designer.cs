namespace CSharp_Quiz_System
{
    partial class frmMain
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
            btnEasy = new Button();
            btnHard = new Button();
            btnMedium = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(114, 106);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(144, 52);
            btnEasy.TabIndex = 0;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnHard
            // 
            btnHard.Location = new Point(114, 222);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(144, 51);
            btnHard.TabIndex = 1;
            btnHard.Text = "Hard";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(114, 164);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(144, 52);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(100, 39);
            lbl.Name = "lbl";
            lbl.Size = new Size(182, 30);
            lbl.TabIndex = 3;
            lbl.Text = "Take a short quiz!";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 321);
            Controls.Add(lbl);
            Controls.Add(btnMedium);
            Controls.Add(btnHard);
            Controls.Add(btnEasy);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrainyBits";
            FormClosing += frmMain_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEasy;
        private Button btnHard;
        private Button btnMedium;
        private Label lbl;
    }
}