namespace BT06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstFont = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFont
            // 
            this.lstFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstFont.FormattingEnabled = true;
            this.lstFont.ItemHeight = 30;
            this.lstFont.Location = new System.Drawing.Point(11, 10);
            this.lstFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstFont.Name = "lstFont";
            this.lstFont.Size = new System.Drawing.Size(409, 424);
            this.lstFont.TabIndex = 0;
            this.lstFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFont_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 436);
            this.Controls.Add(this.lstFont);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Fonts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFont;
    }
}
