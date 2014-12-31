namespace SourcePro.Csharp.Lab.Forms
{
    partial class BuildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildForm));
            this.CtrlRichTextBox_Progress = new System.Windows.Forms.RichTextBox();
            this.CtrlPanel_Title = new System.Windows.Forms.Panel();
            this.CtrlLabel_Title = new System.Windows.Forms.Label();
            this.CtrlPanel_Buttons = new System.Windows.Forms.Panel();
            this.CtrlPictureBox_Progress = new System.Windows.Forms.PictureBox();
            this.CtrlButton_Cancel = new System.Windows.Forms.Button();
            this.CtrlButton_Close = new System.Windows.Forms.Button();
            this.CtrlPanel_Title.SuspendLayout();
            this.CtrlPanel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPictureBox_Progress)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlRichTextBox_Progress
            // 
            this.CtrlRichTextBox_Progress.BackColor = System.Drawing.Color.White;
            this.CtrlRichTextBox_Progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CtrlRichTextBox_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlRichTextBox_Progress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlRichTextBox_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlRichTextBox_Progress.Location = new System.Drawing.Point(0, 40);
            this.CtrlRichTextBox_Progress.Name = "CtrlRichTextBox_Progress";
            this.CtrlRichTextBox_Progress.ReadOnly = true;
            this.CtrlRichTextBox_Progress.Size = new System.Drawing.Size(800, 520);
            this.CtrlRichTextBox_Progress.TabIndex = 2;
            this.CtrlRichTextBox_Progress.Text = "";
            // 
            // CtrlPanel_Title
            // 
            this.CtrlPanel_Title.Controls.Add(this.CtrlLabel_Title);
            this.CtrlPanel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.CtrlPanel_Title.Location = new System.Drawing.Point(0, 0);
            this.CtrlPanel_Title.Name = "CtrlPanel_Title";
            this.CtrlPanel_Title.Size = new System.Drawing.Size(800, 40);
            this.CtrlPanel_Title.TabIndex = 1;
            // 
            // CtrlLabel_Title
            // 
            this.CtrlLabel_Title.AutoSize = true;
            this.CtrlLabel_Title.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlLabel_Title.ForeColor = System.Drawing.Color.Teal;
            this.CtrlLabel_Title.Location = new System.Drawing.Point(8, 13);
            this.CtrlLabel_Title.Name = "CtrlLabel_Title";
            this.CtrlLabel_Title.Size = new System.Drawing.Size(113, 16);
            this.CtrlLabel_Title.TabIndex = 0;
            this.CtrlLabel_Title.Text = "Job\'s Progress";
            // 
            // CtrlPanel_Buttons
            // 
            this.CtrlPanel_Buttons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CtrlPanel_Buttons.Controls.Add(this.CtrlPictureBox_Progress);
            this.CtrlPanel_Buttons.Controls.Add(this.CtrlButton_Cancel);
            this.CtrlPanel_Buttons.Controls.Add(this.CtrlButton_Close);
            this.CtrlPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtrlPanel_Buttons.Location = new System.Drawing.Point(0, 560);
            this.CtrlPanel_Buttons.Name = "CtrlPanel_Buttons";
            this.CtrlPanel_Buttons.Size = new System.Drawing.Size(800, 40);
            this.CtrlPanel_Buttons.TabIndex = 0;
            // 
            // CtrlPictureBox_Progress
            // 
            this.CtrlPictureBox_Progress.Image = ((System.Drawing.Image)(resources.GetObject("CtrlPictureBox_Progress.Image")));
            this.CtrlPictureBox_Progress.InitialImage = ((System.Drawing.Image)(resources.GetObject("CtrlPictureBox_Progress.InitialImage")));
            this.CtrlPictureBox_Progress.Location = new System.Drawing.Point(8, 5);
            this.CtrlPictureBox_Progress.Name = "CtrlPictureBox_Progress";
            this.CtrlPictureBox_Progress.Size = new System.Drawing.Size(30, 30);
            this.CtrlPictureBox_Progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CtrlPictureBox_Progress.TabIndex = 1;
            this.CtrlPictureBox_Progress.TabStop = false;
            this.CtrlPictureBox_Progress.Visible = false;
            // 
            // CtrlButton_Cancel
            // 
            this.CtrlButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlButton_Cancel.FlatAppearance.BorderSize = 0;
            this.CtrlButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButton_Cancel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlButton_Cancel.ForeColor = System.Drawing.Color.Maroon;
            this.CtrlButton_Cancel.Location = new System.Drawing.Point(733, 5);
            this.CtrlButton_Cancel.Name = "CtrlButton_Cancel";
            this.CtrlButton_Cancel.Size = new System.Drawing.Size(55, 30);
            this.CtrlButton_Cancel.TabIndex = 0;
            this.CtrlButton_Cancel.Text = "Cancel";
            this.CtrlButton_Cancel.UseVisualStyleBackColor = true;
            // 
            // CtrlButton_Close
            // 
            this.CtrlButton_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlButton_Close.Enabled = false;
            this.CtrlButton_Close.FlatAppearance.BorderSize = 0;
            this.CtrlButton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButton_Close.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlButton_Close.ForeColor = System.Drawing.Color.Teal;
            this.CtrlButton_Close.Location = new System.Drawing.Point(666, 5);
            this.CtrlButton_Close.Name = "CtrlButton_Close";
            this.CtrlButton_Close.Size = new System.Drawing.Size(50, 30);
            this.CtrlButton_Close.TabIndex = 0;
            this.CtrlButton_Close.Text = "Close";
            this.CtrlButton_Close.UseVisualStyleBackColor = true;
            // 
            // BuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.CtrlRichTextBox_Progress);
            this.Controls.Add(this.CtrlPanel_Title);
            this.Controls.Add(this.CtrlPanel_Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BuildForm";
            this.Opacity = 0.9D;
            this.Text = "BuildForm";
            this.CtrlPanel_Title.ResumeLayout(false);
            this.CtrlPanel_Title.PerformLayout();
            this.CtrlPanel_Buttons.ResumeLayout(false);
            this.CtrlPanel_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPictureBox_Progress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CtrlPanel_Buttons;
        private System.Windows.Forms.Button CtrlButton_Cancel;
        private System.Windows.Forms.PictureBox CtrlPictureBox_Progress;
        private System.Windows.Forms.Panel CtrlPanel_Title;
        private System.Windows.Forms.Label CtrlLabel_Title;
        private System.Windows.Forms.RichTextBox CtrlRichTextBox_Progress;
        private System.Windows.Forms.Button CtrlButton_Close;
    }
}