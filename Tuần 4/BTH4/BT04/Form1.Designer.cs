using System.Windows.Forms;
namespace BT04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuExit;

        private ToolStripMenuItem menuDinhDang;
        private ToolStripMenuItem menuFont;

        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripButton btnSave;

        private ToolStripComboBox cbFont;
        private ToolStripComboBox cbSize;

        private ToolStripButton btnB;
        private ToolStripButton btnI;
        private ToolStripButton btnU;

        private RichTextBox rtb;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.cbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnB = new System.Windows.Forms.ToolStripButton();
            this.btnI = new System.Windows.Forms.ToolStripButton();
            this.btnU = new System.Windows.Forms.ToolStripButton();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuExit});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(69, 20);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuNew
            // 
            this.menuNew.Image = global::BT04.Properties.Resources.blank_page;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(208, 22);
            this.menuNew.Text = "Tạo văn bản mới Ctrl + N";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::BT04.Properties.Resources.open;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(208, 22);
            this.menuOpen.Text = "Mở tập tin";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::BT04.Properties.Resources.diskette;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(208, 22);
            this.menuSave.Text = "Lưu nội dung Ctrl + S";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(208, 22);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuDinhDang
            // 
            this.menuDinhDang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont});
            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size = new System.Drawing.Size(74, 20);
            this.menuDinhDang.Text = "Định dạng";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(107, 22);
            this.menuFont.Text = "Font...";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.cbFont,
            this.cbSize,
            this.btnB,
            this.btnI,
            this.btnU});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::BT04.Properties.Resources.blank_page;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BT04.Properties.Resources.diskette;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbFont
            // 
            this.cbFont.DropDownWidth = 150;
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 25);
            // 
            // cbSize
            // 
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 25);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(23, 22);
            this.btnB.Text = "B";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(23, 22);
            this.btnI.Text = "I";
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnU.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(23, 22);
            this.btnU.Text = "U";
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // rtb
            // 
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(0, 49);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(884, 512);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
