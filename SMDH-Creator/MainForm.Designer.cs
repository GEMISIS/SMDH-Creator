namespace SMDH_Creator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIcon = new System.Windows.Forms.PictureBox();
            this.bigIcon = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.shortDescription = new System.Windows.Forms.TextBox();
            this.longDescription = new System.Windows.Forms.TextBox();
            this.titleNumber = new System.Windows.Forms.ComboBox();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // smallIcon
            // 
            this.smallIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.smallIcon.Location = new System.Drawing.Point(223, 27);
            this.smallIcon.Name = "smallIcon";
            this.smallIcon.Size = new System.Drawing.Size(100, 100);
            this.smallIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smallIcon.TabIndex = 1;
            this.smallIcon.TabStop = false;
            // 
            // bigIcon
            // 
            this.bigIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bigIcon.Location = new System.Drawing.Point(12, 27);
            this.bigIcon.Name = "bigIcon";
            this.bigIcon.Size = new System.Drawing.Size(205, 205);
            this.bigIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigIcon.TabIndex = 2;
            this.bigIcon.TabStop = false;
            // 
            // version
            // 
            this.version.Enabled = false;
            this.version.Location = new System.Drawing.Point(223, 133);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(99, 20);
            this.version.TabIndex = 3;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(223, 185);
            this.publisher.MaxLength = 64;
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(100, 20);
            this.publisher.TabIndex = 4;
            this.publisher.TextChanged += new System.EventHandler(this.publisher_TextChanged);
            // 
            // shortDescription
            // 
            this.shortDescription.Location = new System.Drawing.Point(329, 185);
            this.shortDescription.MaxLength = 64;
            this.shortDescription.Name = "shortDescription";
            this.shortDescription.Size = new System.Drawing.Size(118, 20);
            this.shortDescription.TabIndex = 5;
            this.shortDescription.TextChanged += new System.EventHandler(this.shortDescription_TextChanged);
            // 
            // longDescription
            // 
            this.longDescription.Location = new System.Drawing.Point(223, 211);
            this.longDescription.MaxLength = 128;
            this.longDescription.Name = "longDescription";
            this.longDescription.Size = new System.Drawing.Size(224, 20);
            this.longDescription.TabIndex = 6;
            this.longDescription.TextChanged += new System.EventHandler(this.longDescription_TextChanged);
            // 
            // titleNumber
            // 
            this.titleNumber.DisplayMember = "1";
            this.titleNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleNumber.FormatString = "N1";
            this.titleNumber.FormattingEnabled = true;
            this.titleNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.titleNumber.Location = new System.Drawing.Point(223, 159);
            this.titleNumber.Name = "titleNumber";
            this.titleNumber.Size = new System.Drawing.Size(99, 21);
            this.titleNumber.TabIndex = 7;
            this.titleNumber.ValueMember = "1";
            this.titleNumber.SelectedIndexChanged += new System.EventHandler(this.titleNumber_SelectedIndexChanged);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIconToolStripMenuItem,
            this.bigIconToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // bigIconToolStripMenuItem
            // 
            this.bigIconToolStripMenuItem.Name = "bigIconToolStripMenuItem";
            this.bigIconToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bigIconToolStripMenuItem.Text = "Big Icon";
            this.bigIconToolStripMenuItem.Click += new System.EventHandler(this.bigIconToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 275);
            this.Controls.Add(this.titleNumber);
            this.Controls.Add(this.longDescription);
            this.Controls.Add(this.shortDescription);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.version);
            this.Controls.Add(this.bigIcon);
            this.Controls.Add(this.smallIcon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox smallIcon;
        private System.Windows.Forms.PictureBox bigIcon;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox shortDescription;
        private System.Windows.Forms.TextBox longDescription;
        private System.Windows.Forms.ComboBox titleNumber;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigIconToolStripMenuItem;
    }
}

