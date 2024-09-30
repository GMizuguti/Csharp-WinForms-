namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPremier = new ListBox();
            picPremier = new PictureBox();
            lblName = new Label();
            lblLife = new Label();
            lblTerm = new Label();
            ((System.ComponentModel.ISupportInitialize)picPremier).BeginInit();
            SuspendLayout();
            // 
            // lstPremier
            // 
            lstPremier.FormattingEnabled = true;
            lstPremier.ItemHeight = 15;
            lstPremier.Location = new Point(215, 9);
            lstPremier.Name = "lstPremier";
            lstPremier.Size = new Size(121, 214);
            lstPremier.TabIndex = 0;
            lstPremier.SelectedValueChanged += lstPremier_SelectedValueChanged;
            // 
            // picPremier
            // 
            picPremier.Location = new Point(12, 30);
            picPremier.Name = "picPremier";
            picPremier.Size = new Size(113, 133);
            picPremier.SizeMode = PictureBoxSizeMode.AutoSize;
            picPremier.TabIndex = 1;
            picPremier.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 2;
            lblName.Text = "label1";
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.Location = new Point(12, 166);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(38, 15);
            lblLife.TabIndex = 3;
            lblLife.Text = "label2";
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(12, 181);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(38, 15);
            lblTerm.TabIndex = 4;
            lblTerm.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 234);
            Controls.Add(lblTerm);
            Controls.Add(lblLife);
            Controls.Add(lblName);
            Controls.Add(picPremier);
            Controls.Add(lstPremier);
            Name = "Form1";
            Text = "Ontario's Premiers";
            ((System.ComponentModel.ISupportInitialize)picPremier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPremier;
        private PictureBox picPremier;
        private Label lblName;
        private Label lblLife;
        private Label lblTerm;
    }
}