namespace SourcePro.Csharp.Lab.Windows
{
    partial class MainWindow
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
            this.CtrlMenu = new System.Windows.Forms.MenuStrip();
            this.CtrlFeaturesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlCreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlRecentlyTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlClearTemplatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlSaveAsTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlUpdateAssemblyInfoFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlCopyVersionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlLanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlChineseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlEnglishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlProgressPanel = new System.Windows.Forms.Panel();
            this.CtrlRunningLog = new System.Windows.Forms.RichTextBox();
            this.CtrlAssemblyInfoPropertiesGrid = new System.Windows.Forms.PropertyGrid();
            this.CtrlOpenAssemblyInfo = new System.Windows.Forms.OpenFileDialog();
            this.CtrlFoldersBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CtrlMenu.SuspendLayout();
            this.CtrlProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlMenu
            // 
            this.CtrlMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlFeaturesMenuItem,
            this.CtrlLanguageMenuItem});
            this.CtrlMenu.Location = new System.Drawing.Point(0, 0);
            this.CtrlMenu.Name = "CtrlMenu";
            this.CtrlMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CtrlMenu.Size = new System.Drawing.Size(584, 25);
            this.CtrlMenu.TabIndex = 0;
            // 
            // CtrlFeaturesMenuItem
            // 
            this.CtrlFeaturesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlCreateMenuItem,
            this.toolStripSeparator1,
            this.CtrlRecentlyTemplateMenuItem,
            this.CtrlClearTemplatesMenuItem,
            this.toolStripSeparator2,
            this.CtrlSaveAsTemplateMenuItem,
            this.toolStripSeparator4,
            this.CtrlUpdateAssemblyInfoFileMenuItem,
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem,
            this.toolStripSeparator5,
            this.CtrlCopyVersionMenuItem,
            this.toolStripSeparator3,
            this.CtrlExitMenuItem});
            this.CtrlFeaturesMenuItem.Name = "CtrlFeaturesMenuItem";
            this.CtrlFeaturesMenuItem.Size = new System.Drawing.Size(58, 21);
            this.CtrlFeaturesMenuItem.Text = "功能(&F)";
            // 
            // CtrlCreateMenuItem
            // 
            this.CtrlCreateMenuItem.Name = "CtrlCreateMenuItem";
            this.CtrlCreateMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlCreateMenuItem.Text = "新建(&N)";
            this.CtrlCreateMenuItem.Click += new System.EventHandler(this.CtrlCreateMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(331, 6);
            // 
            // CtrlRecentlyTemplateMenuItem
            // 
            this.CtrlRecentlyTemplateMenuItem.Name = "CtrlRecentlyTemplateMenuItem";
            this.CtrlRecentlyTemplateMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlRecentlyTemplateMenuItem.Text = "最近的模板(&R)";
            // 
            // CtrlClearTemplatesMenuItem
            // 
            this.CtrlClearTemplatesMenuItem.Enabled = false;
            this.CtrlClearTemplatesMenuItem.Name = "CtrlClearTemplatesMenuItem";
            this.CtrlClearTemplatesMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlClearTemplatesMenuItem.Text = "清空所有模板(&C)";
            this.CtrlClearTemplatesMenuItem.Click += new System.EventHandler(this.CtrlClearTemplatesMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(331, 6);
            // 
            // CtrlSaveAsTemplateMenuItem
            // 
            this.CtrlSaveAsTemplateMenuItem.Name = "CtrlSaveAsTemplateMenuItem";
            this.CtrlSaveAsTemplateMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlSaveAsTemplateMenuItem.Text = "保存为模板(&S)";
            this.CtrlSaveAsTemplateMenuItem.Click += new System.EventHandler(this.CtrlSaveAsTemplateMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(331, 6);
            // 
            // CtrlUpdateAssemblyInfoFileMenuItem
            // 
            this.CtrlUpdateAssemblyInfoFileMenuItem.Name = "CtrlUpdateAssemblyInfoFileMenuItem";
            this.CtrlUpdateAssemblyInfoFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.CtrlUpdateAssemblyInfoFileMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlUpdateAssemblyInfoFileMenuItem.Text = "更新程序集信息到文件";
            this.CtrlUpdateAssemblyInfoFileMenuItem.Click += new System.EventHandler(this.CtrlUpdateAssemblyInfoFileMenuItem_Click);
            // 
            // CtrlUpdateAssemblyInfoDirectoryMenuItem
            // 
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Name = "CtrlUpdateAssemblyInfoDirectoryMenuItem";
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Text = "更新指定目录下的所有程序集信息";
            this.CtrlUpdateAssemblyInfoDirectoryMenuItem.Click += new System.EventHandler(this.CtrlUpdateAssemblyInfoDirectoryMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(331, 6);
            // 
            // CtrlCopyVersionMenuItem
            // 
            this.CtrlCopyVersionMenuItem.Name = "CtrlCopyVersionMenuItem";
            this.CtrlCopyVersionMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CtrlCopyVersionMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlCopyVersionMenuItem.Text = "复制版本号";
            this.CtrlCopyVersionMenuItem.Click += new System.EventHandler(this.CtrlCopyVersionMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(331, 6);
            // 
            // CtrlExitMenuItem
            // 
            this.CtrlExitMenuItem.Name = "CtrlExitMenuItem";
            this.CtrlExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.CtrlExitMenuItem.Size = new System.Drawing.Size(334, 22);
            this.CtrlExitMenuItem.Text = "退出";
            this.CtrlExitMenuItem.Click += new System.EventHandler(this.CtrlExitMenuItem_Click);
            // 
            // CtrlLanguageMenuItem
            // 
            this.CtrlLanguageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlChineseMenuItem,
            this.CtrlEnglishMenuItem});
            this.CtrlLanguageMenuItem.Name = "CtrlLanguageMenuItem";
            this.CtrlLanguageMenuItem.Size = new System.Drawing.Size(58, 21);
            this.CtrlLanguageMenuItem.Text = "语言(&L)";
            // 
            // CtrlChineseMenuItem
            // 
            this.CtrlChineseMenuItem.Name = "CtrlChineseMenuItem";
            this.CtrlChineseMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CtrlChineseMenuItem.Text = "简体中文(&C)";
            this.CtrlChineseMenuItem.Click += new System.EventHandler(this.CtrlChineseMenuItem_Click);
            // 
            // CtrlEnglishMenuItem
            // 
            this.CtrlEnglishMenuItem.Name = "CtrlEnglishMenuItem";
            this.CtrlEnglishMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CtrlEnglishMenuItem.Text = "英语(&E)";
            this.CtrlEnglishMenuItem.Click += new System.EventHandler(this.CtrlEnglishMenuItem_Click);
            // 
            // CtrlProgressPanel
            // 
            this.CtrlProgressPanel.Controls.Add(this.CtrlRunningLog);
            this.CtrlProgressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtrlProgressPanel.Location = new System.Drawing.Point(0, 362);
            this.CtrlProgressPanel.Name = "CtrlProgressPanel";
            this.CtrlProgressPanel.Size = new System.Drawing.Size(584, 200);
            this.CtrlProgressPanel.TabIndex = 1;
            // 
            // CtrlRunningLog
            // 
            this.CtrlRunningLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlRunningLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CtrlRunningLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlRunningLog.Location = new System.Drawing.Point(0, 0);
            this.CtrlRunningLog.Name = "CtrlRunningLog";
            this.CtrlRunningLog.Size = new System.Drawing.Size(584, 200);
            this.CtrlRunningLog.TabIndex = 0;
            this.CtrlRunningLog.Text = "";
            // 
            // CtrlAssemblyInfoPropertiesGrid
            // 
            this.CtrlAssemblyInfoPropertiesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlAssemblyInfoPropertiesGrid.Location = new System.Drawing.Point(0, 25);
            this.CtrlAssemblyInfoPropertiesGrid.Name = "CtrlAssemblyInfoPropertiesGrid";
            this.CtrlAssemblyInfoPropertiesGrid.Size = new System.Drawing.Size(584, 337);
            this.CtrlAssemblyInfoPropertiesGrid.TabIndex = 2;
            // 
            // CtrlOpenAssemblyInfo
            // 
            this.CtrlOpenAssemblyInfo.DefaultExt = "cs";
            this.CtrlOpenAssemblyInfo.FileName = "AssemblyInfo";
            this.CtrlOpenAssemblyInfo.Filter = "C# File|*.cs";
            // 
            // CtrlFoldersBrowser
            // 
            this.CtrlFoldersBrowser.ShowNewFolderButton = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.CtrlAssemblyInfoPropertiesGrid);
            this.Controls.Add(this.CtrlProgressPanel);
            this.Controls.Add(this.CtrlMenu);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.CtrlMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Net程序集信息编辑器";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.CtrlMenu.ResumeLayout(false);
            this.CtrlMenu.PerformLayout();
            this.CtrlProgressPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CtrlMenu;
        private System.Windows.Forms.ToolStripMenuItem CtrlFeaturesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlCreateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CtrlRecentlyTemplateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CtrlExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlLanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlChineseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlEnglishMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CtrlSaveAsTemplateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem CtrlUpdateAssemblyInfoFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlUpdateAssemblyInfoDirectoryMenuItem;
        private System.Windows.Forms.Panel CtrlProgressPanel;
        private System.Windows.Forms.PropertyGrid CtrlAssemblyInfoPropertiesGrid;
        private System.Windows.Forms.OpenFileDialog CtrlOpenAssemblyInfo;
        private System.Windows.Forms.RichTextBox CtrlRunningLog;
        private System.Windows.Forms.FolderBrowserDialog CtrlFoldersBrowser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem CtrlCopyVersionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CtrlClearTemplatesMenuItem;
    }
}