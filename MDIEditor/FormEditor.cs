using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MDIEditor
{
    public partial class FormEditor : Form
    {
        #region Fields

        private readonly Document _document;

        #endregion

        #region Constructor

        public FormEditor(Document document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            _document = document;

            InitializeComponent();

            InitializeGui();
            RefreshGui();
        }

        #endregion

        #region Helper

        private void InitializeGui()
        {
            tbxEditor.Text = _document.Text;
        }

        private Point GetPos()
        {
            return new Point(
                tbxEditor.GetLineFromCharIndex(tbxEditor.SelectionStart) + 1,
                tbxEditor.SelectionStart - tbxEditor.GetFirstCharIndexOfCurrentLine() + 1);
        }

        private void RefreshGui()
        {
            if (_document.FilePath != null)
            {
                Text = Path.GetFileName(_document.FilePath);
            }
            else
            {
                Text = "Neue Datei";
            }

            if (HasChanges)
                Text += "*";

            var pos = GetPos();
            lblPos.Text = $"{pos.X}, {pos.Y}";
        }

        #endregion

        #region Methods

        public void Save()
        {
            if (_document.FilePath == null)
            {
                // new file
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Title = "Save file";
                    saveDialog.Filter = "Text file|*.txt|All files|*.*";
                    saveDialog.FilterIndex = 1;
                    saveDialog.AddExtension = true;

                    if (saveDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        File.WriteAllText(saveDialog.FileName, EditorText);

                        _document.FilePath = saveDialog.FileName;
                        _document.Text = EditorText;

                        RefreshGui();
                    }
                }
            }
            else
            {
                // opened file
                File.WriteAllText(_document.FilePath, EditorText);

                _document.Text = EditorText;

                RefreshGui();
            }
        }

        #endregion

        #region Form events

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            if (HasChanges)
            {
                var dialogText = "Save new file?";
                if (_document.FilePath != null)
                    dialogText = $"Save file {Path.GetFileName(_document.FilePath)}?";

                var result = MessageBox.Show(dialogText, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        #endregion

        #region Control events

        private void TbxEditor_TextChanged(object sender, EventArgs e)
        {
            RefreshGui();
        }

        #endregion

        #region Properties

        public string EditorText
        {
            get { return tbxEditor.Text; }
            set { tbxEditor.Text = value; }
        }

        public bool HasChanges
        {
            get
            {
                if (_document.FilePath == null && string.IsNullOrEmpty(EditorText))
                    return false;

                return EditorText != _document.Text;
            }
        }

        public Document Document
        {
            get { return _document; }
        }

        #endregion
    }
}