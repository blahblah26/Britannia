﻿
namespace Britannia
{
    partial class AddShip
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
            this.btnAddShip = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbxShip = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddShip
            // 
            this.btnAddShip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddShip.Location = new System.Drawing.Point(85, 216);
            this.btnAddShip.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(115, 35);
            this.btnAddShip.TabIndex = 0;
            this.btnAddShip.Text = "Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.cbxShip);
            this.pnlMain.Controls.Add(this.btnAddShip);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(284, 261);
            this.pnlMain.TabIndex = 1;
            // 
            // cbxShip
            // 
            this.cbxShip.FormattingEnabled = true;
            this.cbxShip.Location = new System.Drawing.Point(10, 178);
            this.cbxShip.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.cbxShip.Name = "cbxShip";
            this.cbxShip.Size = new System.Drawing.Size(264, 28);
            this.cbxShip.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "AddShip";
            this.Text = "Add Ship";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cbxShip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}