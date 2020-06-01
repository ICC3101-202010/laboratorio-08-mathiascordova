namespace Lab_08
{
    partial class Form2
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
            this.btShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtF2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(12, 84);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(75, 23);
            this.btShowAll.TabIndex = 0;
            this.btShowAll.Text = "Show";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Todos los locales";
            // 
            // rtF2
            // 
            this.rtF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtF2.Location = new System.Drawing.Point(12, 113);
            this.rtF2.Name = "rtF2";
            this.rtF2.Size = new System.Drawing.Size(330, 390);
            this.rtF2.TabIndex = 2;
            this.rtF2.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 526);
            this.Controls.Add(this.rtF2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btShowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los locales";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtF2;
    }
}