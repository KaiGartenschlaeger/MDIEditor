using System;
using System.IO;
using System.Windows.Forms;

namespace MDIEditor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MntFile_DropDownOpening(object sender, EventArgs e)
        {
            mniSave.Enabled = ActiveMdiChild != null;
            mniClose.Enabled = ActiveMdiChild != null;
        }

        private void MniNew_Click(object sender, EventArgs e)
        {
            var document = new Document();

            var editDialog = new FormEditor(document);
            editDialog.MdiParent = this;
            editDialog.Show();
        }

        private void MniOpen_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open file";
                openFileDialog.Filter = "Text files|*.txt|All files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var document = new Document();
                    document.FilePath = openFileDialog.FileName;
                    document.Text = File.ReadAllText(openFileDialog.FileName);

                    var editDialog = new FormEditor(document);
                    editDialog.MdiParent = this;
                    editDialog.Show();
                }
            }
        }

        private void MniClose_Click(object sender, EventArgs e)
        {
            var editDialog = ActiveMdiChild as FormEditor;
            if (editDialog == null)
                return;

        }

        private void MniSave_Click(object sender, EventArgs e)
        {
            var editDialog = ActiveMdiChild as FormEditor;
            if (editDialog == null)
                return;

        }

        private void MniEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MntWindows_DropDownOpening(object sender, EventArgs e)
        {
            mniHorizontal.Enabled = (MdiChildren.Length > 0);
            mniVertical.Enabled = (MdiChildren.Length > 0);
            mniCascade.Enabled = (MdiChildren.Length > 0);
            mniMdiSeparator.Available = (MdiChildren.Length > 0);
        }

        private void MniHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MniVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MniCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}