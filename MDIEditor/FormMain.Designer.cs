namespace MDIEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.mntWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mniVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMdiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntFile,
            this.mntWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mntWindows;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntFile
            // 
            this.mntFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNew,
            this.mniOpen,
            this.mniClose,
            this.mniSave,
            this.toolStripSeparator1,
            this.mniEnd});
            this.mntFile.Name = "mntFile";
            this.mntFile.Size = new System.Drawing.Size(37, 20);
            this.mntFile.Text = "&File";
            this.mntFile.DropDownOpening += new System.EventHandler(this.MntFile_DropDownOpening);
            // 
            // mniNew
            // 
            this.mniNew.Name = "mniNew";
            this.mniNew.Size = new System.Drawing.Size(103, 22);
            this.mniNew.Text = "&New";
            this.mniNew.Click += new System.EventHandler(this.MniNew_Click);
            // 
            // mniOpen
            // 
            this.mniOpen.Name = "mniOpen";
            this.mniOpen.Size = new System.Drawing.Size(103, 22);
            this.mniOpen.Text = "&Open";
            this.mniOpen.Click += new System.EventHandler(this.MniOpen_Click);
            // 
            // mniClose
            // 
            this.mniClose.Name = "mniClose";
            this.mniClose.Size = new System.Drawing.Size(103, 22);
            this.mniClose.Text = "&Close";
            this.mniClose.Click += new System.EventHandler(this.MniClose_Click);
            // 
            // mniSave
            // 
            this.mniSave.Name = "mniSave";
            this.mniSave.Size = new System.Drawing.Size(103, 22);
            this.mniSave.Text = "&Save";
            this.mniSave.Click += new System.EventHandler(this.MniSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // mniEnd
            // 
            this.mniEnd.Name = "mniEnd";
            this.mniEnd.Size = new System.Drawing.Size(103, 22);
            this.mniEnd.Text = "&End";
            this.mniEnd.Click += new System.EventHandler(this.MniEnd_Click);
            // 
            // mntWindows
            // 
            this.mntWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHorizontal,
            this.mniVertical,
            this.mniCascade,
            this.mniMdiSeparator});
            this.mntWindows.Name = "mntWindows";
            this.mntWindows.Size = new System.Drawing.Size(68, 20);
            this.mntWindows.Text = "&Windows";
            this.mntWindows.DropDownOpening += new System.EventHandler(this.MntWindows_DropDownOpening);
            // 
            // mniHorizontal
            // 
            this.mniHorizontal.Name = "mniHorizontal";
            this.mniHorizontal.Size = new System.Drawing.Size(129, 22);
            this.mniHorizontal.Text = "&Horizontal";
            this.mniHorizontal.Click += new System.EventHandler(this.MniHorizontal_Click);
            // 
            // mniVertical
            // 
            this.mniVertical.Name = "mniVertical";
            this.mniVertical.Size = new System.Drawing.Size(129, 22);
            this.mniVertical.Text = "&Vertical";
            this.mniVertical.Click += new System.EventHandler(this.MniVertical_Click);
            // 
            // mniCascade
            // 
            this.mniCascade.Name = "mniCascade";
            this.mniCascade.Size = new System.Drawing.Size(129, 22);
            this.mniCascade.Text = "&Cascaded";
            this.mniCascade.Click += new System.EventHandler(this.MniCascade_Click);
            // 
            // mniMdiSeparator
            // 
            this.mniMdiSeparator.Name = "mniMdiSeparator";
            this.mniMdiSeparator.Size = new System.Drawing.Size(126, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntFile;
        private System.Windows.Forms.ToolStripMenuItem mniNew;
        private System.Windows.Forms.ToolStripMenuItem mniOpen;
        private System.Windows.Forms.ToolStripMenuItem mniClose;
        private System.Windows.Forms.ToolStripMenuItem mniSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniEnd;
        private System.Windows.Forms.ToolStripMenuItem mntWindows;
        private System.Windows.Forms.ToolStripMenuItem mniHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mniVertical;
        private System.Windows.Forms.ToolStripMenuItem mniCascade;
        private System.Windows.Forms.ToolStripSeparator mniMdiSeparator;
    }
}

