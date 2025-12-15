namespace BT11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEllipse = new System.Windows.Forms.RadioButton();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoLine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoGradient = new System.Windows.Forms.RadioButton();
            this.rdoTexture = new System.Windows.Forms.RadioButton();
            this.rdoHatch = new System.Windows.Forms.RadioButton();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDraw.Location = new System.Drawing.Point(200, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(580, 426);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            this.picDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseDown);
            this.picDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseMove);
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEllipse);
            this.groupBox1.Controls.Add(this.rdoRectangle);
            this.groupBox1.Controls.Add(this.rdoLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rdoEllipse
            // 
            this.rdoEllipse.AutoSize = true;
            this.rdoEllipse.Location = new System.Drawing.Point(15, 68);
            this.rdoEllipse.Name = "rdoEllipse";
            this.rdoEllipse.Size = new System.Drawing.Size(55, 17);
            this.rdoEllipse.TabIndex = 2;
            this.rdoEllipse.Text = "Ellipse";
            this.rdoEllipse.UseVisualStyleBackColor = true;
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(15, 44);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 1;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            // 
            // rdoLine
            // 
            this.rdoLine.AutoSize = true;
            this.rdoLine.Checked = true;
            this.rdoLine.Location = new System.Drawing.Point(15, 20);
            this.rdoLine.Name = "rdoLine";
            this.rdoLine.Size = new System.Drawing.Size(45, 17);
            this.rdoLine.TabIndex = 0;
            this.rdoLine.TabStop = true;
            this.rdoLine.Text = "Line";
            this.rdoLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(15, 22);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(50, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "2";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(15, 48);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoGradient);
            this.groupBox3.Controls.Add(this.rdoTexture);
            this.groupBox3.Controls.Add(this.rdoHatch);
            this.groupBox3.Controls.Add(this.rdoSolid);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rdoGradient
            // 
            this.rdoGradient.AutoSize = true;
            this.rdoGradient.Location = new System.Drawing.Point(15, 91);
            this.rdoGradient.Name = "rdoGradient";
            this.rdoGradient.Size = new System.Drawing.Size(113, 17);
            this.rdoGradient.TabIndex = 3;
            this.rdoGradient.Text = "LinearGradient";
            this.rdoGradient.UseVisualStyleBackColor = true;
            // 
            // rdoTexture
            // 
            this.rdoTexture.AutoSize = true;
            this.rdoTexture.Location = new System.Drawing.Point(15, 68);
            this.rdoTexture.Name = "rdoTexture";
            this.rdoTexture.Size = new System.Drawing.Size(91, 17);
            this.rdoTexture.TabIndex = 2;
            this.rdoTexture.Text = "TextureBrush";
            this.rdoTexture.UseVisualStyleBackColor = true;
            // 
            // rdoHatch
            // 
            this.rdoHatch.AutoSize = true;
            this.rdoHatch.Location = new System.Drawing.Point(15, 44);
            this.rdoHatch.Name = "rdoHatch";
            this.rdoHatch.Size = new System.Drawing.Size(82, 17);
            this.rdoHatch.TabIndex = 1;
            this.rdoHatch.Text = "HatchBrush";
            this.rdoHatch.UseVisualStyleBackColor = true;
            // 
            // rdoSolid
            // 
            this.rdoSolid.AutoSize = true;
            this.rdoSolid.Checked = true;
            this.rdoSolid.Location = new System.Drawing.Point(15, 20);
            this.rdoSolid.Name = "rdoSolid";
            this.rdoSolid.Size = new System.Drawing.Size(75, 17);
            this.rdoSolid.TabIndex = 0;
            this.rdoSolid.TabStop = true;
            this.rdoSolid.Text = "SolidBrush";
            this.rdoSolid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Bài 11 - Vẽ hình cơ bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEllipse;
        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoGradient;
        private System.Windows.Forms.RadioButton rdoTexture;
        private System.Windows.Forms.RadioButton rdoHatch;
        private System.Windows.Forms.RadioButton rdoSolid;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
