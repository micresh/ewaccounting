namespace Energywateraccoubting
{
    partial class mainform
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
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flatsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ecountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWcountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hWcountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempcountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountingToolStripMenuItem,
            this.vocabularyToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.enterToolStripMenuItem.Text = "Вход";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountingToolStripMenuItem
            // 
            this.accountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingsToolStripMenuItem,
            this.flatsToolStripMenuItem});
            this.accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            this.accountingToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.accountingToolStripMenuItem.Text = "Учет";
            // 
            // buildingsToolStripMenuItem
            // 
            this.buildingsToolStripMenuItem.Name = "buildingsToolStripMenuItem";
            this.buildingsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.buildingsToolStripMenuItem.Text = "Здания";
            // 
            // flatsToolStripMenuItem
            // 
            this.flatsToolStripMenuItem.Name = "flatsToolStripMenuItem";
            this.flatsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.flatsToolStripMenuItem.Text = "Квартиры";
            this.flatsToolStripMenuItem.Click += new System.EventHandler(this.flatsToolStripMenuItem_Click);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingsToolStripMenuItem1,
            this.flatsToolStripMenuItem1,
            this.ecountersToolStripMenuItem,
            this.cWcountersToolStripMenuItem,
            this.hWcountersToolStripMenuItem,
            this.tempcountersToolStripMenuItem});
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.vocabularyToolStripMenuItem.Text = "Справочники";
            // 
            // buildingsToolStripMenuItem1
            // 
            this.buildingsToolStripMenuItem1.Name = "buildingsToolStripMenuItem1";
            this.buildingsToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.buildingsToolStripMenuItem1.Text = "Дома";
            this.buildingsToolStripMenuItem1.Click += new System.EventHandler(this.buildingsToolStripMenuItem1_Click);
            // 
            // flatsToolStripMenuItem1
            // 
            this.flatsToolStripMenuItem1.Name = "flatsToolStripMenuItem1";
            this.flatsToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.flatsToolStripMenuItem1.Text = "Квартиры";
            this.flatsToolStripMenuItem1.Click += new System.EventHandler(this.flatsToolStripMenuItem1_Click);
            // 
            // ecountersToolStripMenuItem
            // 
            this.ecountersToolStripMenuItem.Name = "ecountersToolStripMenuItem";
            this.ecountersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ecountersToolStripMenuItem.Text = "Электросчетчики";
            this.ecountersToolStripMenuItem.Click += new System.EventHandler(this.ecountersToolStripMenuItem_Click);
            // 
            // cWcountersToolStripMenuItem
            // 
            this.cWcountersToolStripMenuItem.Name = "cWcountersToolStripMenuItem";
            this.cWcountersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cWcountersToolStripMenuItem.Text = "Счетчики холодной воды";
            this.cWcountersToolStripMenuItem.Click += new System.EventHandler(this.cWcountersToolStripMenuItem_Click);
            // 
            // hWcountersToolStripMenuItem
            // 
            this.hWcountersToolStripMenuItem.Name = "hWcountersToolStripMenuItem";
            this.hWcountersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.hWcountersToolStripMenuItem.Text = "Счетчики горячей воды";
            this.hWcountersToolStripMenuItem.Click += new System.EventHandler(this.hWcountersToolStripMenuItem_Click);
            // 
            // tempcountersToolStripMenuItem
            // 
            this.tempcountersToolStripMenuItem.Name = "tempcountersToolStripMenuItem";
            this.tempcountersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tempcountersToolStripMenuItem.Text = "Термодатчики";
            this.tempcountersToolStripMenuItem.Click += new System.EventHandler(this.tempcountersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.windowsToolStripMenuItem.Text = "&Окна";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 454);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "Система учета энерго и водоресурсов в ЖКХ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flatsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ecountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cWcountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hWcountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempcountersToolStripMenuItem;
    }
}

