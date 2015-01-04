namespace SourcePro.Csharp.Lab.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CtrlMenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.CtrlMenuStripItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlMenuStripItem_Recently = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlMenuStripItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlMenuStripItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Build = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_ClearRecently = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_Github = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlMenuStripItem_CodePlex = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlStatusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.CtrlStatusLabel_Copyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.CtrlStatusLabel_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.CtrlPropertyGrid_Main = new System.Windows.Forms.PropertyGrid();
            this.CtrlSaveFileDialog_SaveProject = new System.Windows.Forms.SaveFileDialog();
            this.CtrlOpenFileDialog_OpenProject = new System.Windows.Forms.OpenFileDialog();
            this.CtrlMenuStrip_Main.SuspendLayout();
            this.CtrlStatusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlMenuStrip_Main
            // 
            this.CtrlMenuStrip_Main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CtrlMenuStrip_Main.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlMenuStripItem_File,
            this.CtrlMenuStripItem_Build,
            this.CtrlMenuStripItem_Tool,
            this.CtrlMenuStripItem_Help});
            this.CtrlMenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.CtrlMenuStrip_Main.Name = "CtrlMenuStrip_Main";
            this.CtrlMenuStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CtrlMenuStrip_Main.Size = new System.Drawing.Size(784, 24);
            this.CtrlMenuStrip_Main.TabIndex = 0;
            this.CtrlMenuStrip_Main.Text = "Main MenuStrip";
            // 
            // CtrlMenuStripItem_File
            // 
            this.CtrlMenuStripItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlMenuStripItem_CreateNew,
            this.CtrlMenuStripItem_Open,
            this.toolStripSeparator1,
            this.CtrlMenuStripItem_Recently,
            this.toolStripSeparator2,
            this.CtrlMenuStripItem_Save,
            this.CtrlMenuStripItem_SaveAs,
            this.toolStripSeparator3,
            this.CtrlMenuStripItem_Exit});
            this.CtrlMenuStripItem_File.Name = "CtrlMenuStripItem_File";
            this.CtrlMenuStripItem_File.ShowShortcutKeys = false;
            this.CtrlMenuStripItem_File.Size = new System.Drawing.Size(39, 20);
            this.CtrlMenuStripItem_File.Text = "&File";
            // 
            // CtrlMenuStripItem_CreateNew
            // 
            this.CtrlMenuStripItem_CreateNew.Name = "CtrlMenuStripItem_CreateNew";
            this.CtrlMenuStripItem_CreateNew.ShortcutKeyDisplayString = "(Ctrl + N)";
            this.CtrlMenuStripItem_CreateNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CtrlMenuStripItem_CreateNew.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_CreateNew.Text = "&New Project";
            // 
            // CtrlMenuStripItem_Open
            // 
            this.CtrlMenuStripItem_Open.Name = "CtrlMenuStripItem_Open";
            this.CtrlMenuStripItem_Open.ShortcutKeyDisplayString = "(Ctrl + O)";
            this.CtrlMenuStripItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.CtrlMenuStripItem_Open.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_Open.Text = "&Open Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // CtrlMenuStripItem_Recently
            // 
            this.CtrlMenuStripItem_Recently.Image = ((System.Drawing.Image)(resources.GetObject("CtrlMenuStripItem_Recently.Image")));
            this.CtrlMenuStripItem_Recently.Name = "CtrlMenuStripItem_Recently";
            this.CtrlMenuStripItem_Recently.ShowShortcutKeys = false;
            this.CtrlMenuStripItem_Recently.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_Recently.Text = "&Recently";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // CtrlMenuStripItem_Save
            // 
            this.CtrlMenuStripItem_Save.Name = "CtrlMenuStripItem_Save";
            this.CtrlMenuStripItem_Save.ShortcutKeyDisplayString = "(Ctrl + S)";
            this.CtrlMenuStripItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.CtrlMenuStripItem_Save.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_Save.Text = "&Save";
            // 
            // CtrlMenuStripItem_SaveAs
            // 
            this.CtrlMenuStripItem_SaveAs.Name = "CtrlMenuStripItem_SaveAs";
            this.CtrlMenuStripItem_SaveAs.ShortcutKeyDisplayString = "(Ctrl + Shift + S)";
            this.CtrlMenuStripItem_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.CtrlMenuStripItem_SaveAs.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_SaveAs.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // CtrlMenuStripItem_Exit
            // 
            this.CtrlMenuStripItem_Exit.Name = "CtrlMenuStripItem_Exit";
            this.CtrlMenuStripItem_Exit.Size = new System.Drawing.Size(209, 22);
            this.CtrlMenuStripItem_Exit.Text = "E&xit";
            // 
            // CtrlMenuStripItem_Build
            // 
            this.CtrlMenuStripItem_Build.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlMenuStripItem_Start});
            this.CtrlMenuStripItem_Build.Name = "CtrlMenuStripItem_Build";
            this.CtrlMenuStripItem_Build.Size = new System.Drawing.Size(56, 20);
            this.CtrlMenuStripItem_Build.Text = "&Debug";
            // 
            // CtrlMenuStripItem_Start
            // 
            this.CtrlMenuStripItem_Start.Image = ((System.Drawing.Image)(resources.GetObject("CtrlMenuStripItem_Start.Image")));
            this.CtrlMenuStripItem_Start.Name = "CtrlMenuStripItem_Start";
            this.CtrlMenuStripItem_Start.ShortcutKeyDisplayString = "(Ctrl + F5)";
            this.CtrlMenuStripItem_Start.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.CtrlMenuStripItem_Start.Size = new System.Drawing.Size(160, 22);
            this.CtrlMenuStripItem_Start.Text = "&Start";
            // 
            // CtrlMenuStripItem_Tool
            // 
            this.CtrlMenuStripItem_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlMenuStripItem_ClearRecently});
            this.CtrlMenuStripItem_Tool.Name = "CtrlMenuStripItem_Tool";
            this.CtrlMenuStripItem_Tool.Size = new System.Drawing.Size(42, 20);
            this.CtrlMenuStripItem_Tool.Text = "&Tool";
            // 
            // CtrlMenuStripItem_ClearRecently
            // 
            this.CtrlMenuStripItem_ClearRecently.Image = ((System.Drawing.Image)(resources.GetObject("CtrlMenuStripItem_ClearRecently.Image")));
            this.CtrlMenuStripItem_ClearRecently.Name = "CtrlMenuStripItem_ClearRecently";
            this.CtrlMenuStripItem_ClearRecently.Size = new System.Drawing.Size(183, 22);
            this.CtrlMenuStripItem_ClearRecently.Text = "&Clear Recently Data";
            // 
            // CtrlMenuStripItem_Help
            // 
            this.CtrlMenuStripItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlMenuStripItem_Github,
            this.CtrlMenuStripItem_CodePlex});
            this.CtrlMenuStripItem_Help.Name = "CtrlMenuStripItem_Help";
            this.CtrlMenuStripItem_Help.Size = new System.Drawing.Size(45, 20);
            this.CtrlMenuStripItem_Help.Text = "&Help";
            // 
            // CtrlMenuStripItem_Github
            // 
            this.CtrlMenuStripItem_Github.Image = ((System.Drawing.Image)(resources.GetObject("CtrlMenuStripItem_Github.Image")));
            this.CtrlMenuStripItem_Github.Name = "CtrlMenuStripItem_Github";
            this.CtrlMenuStripItem_Github.Size = new System.Drawing.Size(152, 22);
            this.CtrlMenuStripItem_Github.Text = "&Github";
            // 
            // CtrlMenuStripItem_CodePlex
            // 
            this.CtrlMenuStripItem_CodePlex.Image = ((System.Drawing.Image)(resources.GetObject("CtrlMenuStripItem_CodePlex.Image")));
            this.CtrlMenuStripItem_CodePlex.Name = "CtrlMenuStripItem_CodePlex";
            this.CtrlMenuStripItem_CodePlex.Size = new System.Drawing.Size(152, 22);
            this.CtrlMenuStripItem_CodePlex.Text = "Code&Plex";
            // 
            // CtrlStatusStrip_Main
            // 
            this.CtrlStatusStrip_Main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CtrlStatusStrip_Main.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlStatusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlStatusLabel_Copyright,
            this.CtrlStatusLabel_Version});
            this.CtrlStatusStrip_Main.Location = new System.Drawing.Point(0, 540);
            this.CtrlStatusStrip_Main.Name = "CtrlStatusStrip_Main";
            this.CtrlStatusStrip_Main.Size = new System.Drawing.Size(784, 22);
            this.CtrlStatusStrip_Main.TabIndex = 1;
            this.CtrlStatusStrip_Main.Text = ".NET Status Strip";
            // 
            // CtrlStatusLabel_Copyright
            // 
            this.CtrlStatusLabel_Copyright.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlStatusLabel_Copyright.ForeColor = System.Drawing.Color.Gray;
            this.CtrlStatusLabel_Copyright.Name = "CtrlStatusLabel_Copyright";
            this.CtrlStatusLabel_Copyright.Size = new System.Drawing.Size(130, 17);
            this.CtrlStatusLabel_Copyright.Text = "toolStripStatusLabel1";
            // 
            // CtrlStatusLabel_Version
            // 
            this.CtrlStatusLabel_Version.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlStatusLabel_Version.ForeColor = System.Drawing.Color.Gray;
            this.CtrlStatusLabel_Version.Image = ((System.Drawing.Image)(resources.GetObject("CtrlStatusLabel_Version.Image")));
            this.CtrlStatusLabel_Version.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CtrlStatusLabel_Version.Name = "CtrlStatusLabel_Version";
            this.CtrlStatusLabel_Version.Size = new System.Drawing.Size(639, 17);
            this.CtrlStatusLabel_Version.Spring = true;
            this.CtrlStatusLabel_Version.Text = "toolStripStatusLabel1";
            this.CtrlStatusLabel_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CtrlStatusLabel_Version.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // CtrlPropertyGrid_Main
            // 
            this.CtrlPropertyGrid_Main.BackColor = System.Drawing.Color.White;
            this.CtrlPropertyGrid_Main.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlPropertyGrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlPropertyGrid_Main.HelpBackColor = System.Drawing.Color.White;
            this.CtrlPropertyGrid_Main.HelpForeColor = System.Drawing.Color.Teal;
            this.CtrlPropertyGrid_Main.Location = new System.Drawing.Point(0, 24);
            this.CtrlPropertyGrid_Main.Name = "CtrlPropertyGrid_Main";
            this.CtrlPropertyGrid_Main.Size = new System.Drawing.Size(784, 516);
            this.CtrlPropertyGrid_Main.TabIndex = 2;
            // 
            // CtrlSaveFileDialog_SaveProject
            // 
            this.CtrlSaveFileDialog_SaveProject.DefaultExt = "aieproj";
            this.CtrlSaveFileDialog_SaveProject.FileName = "MyProject.aieproj";
            this.CtrlSaveFileDialog_SaveProject.Filter = ".NET AssemblyInfo Editor Project|*.aieproj";
            this.CtrlSaveFileDialog_SaveProject.Title = "Save Project";
            // 
            // CtrlOpenFileDialog_OpenProject
            // 
            this.CtrlOpenFileDialog_OpenProject.DefaultExt = "aieproj";
            this.CtrlOpenFileDialog_OpenProject.Filter = ".NET AssemblyInfo Editor Project|*.aieproj";
            this.CtrlOpenFileDialog_OpenProject.Title = "Open a project";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CtrlPropertyGrid_Main);
            this.Controls.Add(this.CtrlStatusStrip_Main);
            this.Controls.Add(this.CtrlMenuStrip_Main);
            this.MainMenuStrip = this.CtrlMenuStrip_Main;
            this.Name = "MainForm";
            this.ShowInTaskbar = true;
            this.Text = ".NET AssemblyInfo Editor";
            this.CtrlMenuStrip_Main.ResumeLayout(false);
            this.CtrlMenuStrip_Main.PerformLayout();
            this.CtrlStatusStrip_Main.ResumeLayout(false);
            this.CtrlStatusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CtrlMenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_File;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_CreateNew;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Recently;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Save;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Tool;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_ClearRecently;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Help;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Github;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_CodePlex;
        private System.Windows.Forms.StatusStrip CtrlStatusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel CtrlStatusLabel_Copyright;
        private System.Windows.Forms.ToolStripStatusLabel CtrlStatusLabel_Version;
        private System.Windows.Forms.PropertyGrid CtrlPropertyGrid_Main;
        private System.Windows.Forms.SaveFileDialog CtrlSaveFileDialog_SaveProject;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Build;
        private System.Windows.Forms.ToolStripMenuItem CtrlMenuStripItem_Start;
        private System.Windows.Forms.OpenFileDialog CtrlOpenFileDialog_OpenProject;
    }
}