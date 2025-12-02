namespace BT06
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_dest = new System.Windows.Forms.Button();
            this.textBox_dest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_source = new System.Windows.Forms.Button();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.progressBar_copy = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_copy);
            this.groupBox1.Controls.Add(this.button_dest);
            this.groupBox1.Controls.Add(this.textBox_dest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_source);
            this.groupBox1.Controls.Add(this.textBox_source);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // button_copy
            // 
            this.button_copy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_copy.Location = new System.Drawing.Point(324, 110);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(164, 41);
            this.button_copy.TabIndex = 6;
            this.button_copy.Text = "Sao chép";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_dest
            // 
            this.button_dest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dest.Location = new System.Drawing.Point(727, 61);
            this.button_dest.Name = "button_dest";
            this.button_dest.Size = new System.Drawing.Size(43, 23);
            this.button_dest.TabIndex = 5;
            this.button_dest.Text = "...";
            this.button_dest.UseVisualStyleBackColor = true;
            this.button_dest.Click += new System.EventHandler(this.button_dest_Click);
            // 
            // textBox_dest
            // 
            this.textBox_dest.Location = new System.Drawing.Point(232, 64);
            this.textBox_dest.Name = "textBox_dest";
            this.textBox_dest.ReadOnly = true;
            this.textBox_dest.Size = new System.Drawing.Size(489, 25);
            this.textBox_dest.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đường dẫn thư mục đích";
            // 
            // button_source
            // 
            this.button_source.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_source.Location = new System.Drawing.Point(727, 25);
            this.button_source.Name = "button_source";
            this.button_source.Size = new System.Drawing.Size(43, 23);
            this.button_source.TabIndex = 2;
            this.button_source.Text = "...";
            this.button_source.UseVisualStyleBackColor = true;
            this.button_source.Click += new System.EventHandler(this.button_source_Click);
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(232, 28);
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.ReadOnly = true;
            this.textBox_source.Size = new System.Drawing.Size(489, 25);
            this.textBox_source.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar_copy);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(36, 348);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(42, 17);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "status";
            // 
            // progressBar_copy
            // 
            this.progressBar_copy.Location = new System.Drawing.Point(27, 44);
            this.progressBar_copy.Name = "progressBar_copy";
            this.progressBar_copy.Size = new System.Drawing.Size(726, 23);
            this.progressBar_copy.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_dest;
        private System.Windows.Forms.TextBox textBox_dest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_source;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_copy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_status;
    }
}

