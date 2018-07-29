namespace MDIEditor
{
    partial class FormEditor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbxEditor = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPos
            // 
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(34, 17);
            this.lblPos.Text = "{Pos}";
            // 
            // tbxEditor
            // 
            this.tbxEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEditor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEditor.Location = new System.Drawing.Point(0, 0);
            this.tbxEditor.Multiline = true;
            this.tbxEditor.Name = "tbxEditor";
            this.tbxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxEditor.Size = new System.Drawing.Size(644, 407);
            this.tbxEditor.TabIndex = 1;
            this.tbxEditor.WordWrap = false;
            this.tbxEditor.TextChanged += new System.EventHandler(this.TbxEditor_TextChanged);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 429);
            this.Controls.Add(this.tbxEditor);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormEditor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditor_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbxEditor;
        private System.Windows.Forms.ToolStripStatusLabel lblPos;
    }
}