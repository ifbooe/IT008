namespace BT10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDraw.Location = new System.Drawing.Point(250, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(520, 426);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.Location = new System.Drawing.Point(108, 20);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(112, 21);
            this.cboDashStyle.TabIndex = 5;
            // 
            // cboWidth
            // 
            this.cboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWidth.Location = new System.Drawing.Point(108, 60);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(112, 21);
            this.cboWidth.TabIndex = 4;
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineJoin.Location = new System.Drawing.Point(108, 100);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(112, 21);
            this.cboLineJoin.TabIndex = 3;
            // 
            // cboDashCap
            // 
            this.cboDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashCap.Location = new System.Drawing.Point(108, 140);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(112, 21);
            this.cboDashCap.TabIndex = 2;
            // 
            // cboStartCap
            // 
            this.cboStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartCap.Location = new System.Drawing.Point(108, 180);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(112, 21);
            this.cboStartCap.TabIndex = 1;
            // 
            // cboEndCap
            // 
            this.cboEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndCap.Location = new System.Drawing.Point(108, 220);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(112, 21);
            this.cboEndCap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dark Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Line Join:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dash Cap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Cap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Cap:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEndCap);
            this.Controls.Add(this.cboStartCap);
            this.Controls.Add(this.cboDashCap);
            this.Controls.Add(this.cboLineJoin);
            this.Controls.Add(this.cboWidth);
            this.Controls.Add(this.cboDashStyle);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
