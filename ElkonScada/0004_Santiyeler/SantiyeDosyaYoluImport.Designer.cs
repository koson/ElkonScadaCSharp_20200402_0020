﻿namespace ElkonScada._0004_Santiyeler
{
    partial class SantiyeDosyaYoluImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SantiyeDosyaYoluImport));
            this.ES386_1 = new System.Windows.Forms.Button();
            this.dosyaaditxt = new System.Windows.Forms.TextBox();
            this.ES3019_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(610, 93);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 60;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
            this.ES386_1.Click += new System.EventHandler(this.ES386_1_Click);
            // 
            // dosyaaditxt
            // 
            this.dosyaaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dosyaaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.dosyaaditxt.Location = new System.Drawing.Point(186, 10);
            this.dosyaaditxt.Name = "dosyaaditxt";
            this.dosyaaditxt.Size = new System.Drawing.Size(536, 30);
            this.dosyaaditxt.TabIndex = 59;
            // 
            // ES3019_1
            // 
            this.ES3019_1.AutoSize = true;
            this.ES3019_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES3019_1.Location = new System.Drawing.Point(12, 10);
            this.ES3019_1.Name = "ES3019_1";
            this.ES3019_1.Size = new System.Drawing.Size(122, 25);
            this.ES3019_1.TabIndex = 58;
            this.ES3019_1.Text = "Dosya Yolu";
            // 
            // SantiyeDosyaYoluImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 161);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.dosyaaditxt);
            this.Controls.Add(this.ES3019_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SantiyeDosyaYoluImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosyaYoluSantiyeImport";
            this.Load += new System.EventHandler(this.DosyaYoluSantiyeImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ES386_1;
        private System.Windows.Forms.TextBox dosyaaditxt;
        private System.Windows.Forms.Label ES3019_1;
    }
}