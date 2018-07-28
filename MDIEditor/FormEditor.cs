using System;
using System.IO;
using System.Windows.Forms;

namespace MDIEditor
{
    public partial class FormEditor : Form
    {
        private readonly Document _document;

        public FormEditor(Document document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            _document = document;

            InitializeComponent();
            InitializeGui();
            RefreshGui();
        }

        private void InitializeGui()
        {
            tbxEditor.Text = _document.Text;
        }

        private void RefreshGui()
        {
            if (_document.FilePath != null)
            {
                Text = Path.GetFileName(_document.FilePath);

                if (HasChanges)
                    Text += "*";
            }
            else
            {
                Text = "Neue Datei";
            }
        }

        private void TbxEditor_TextChanged(object sender, EventArgs e)
        {
            RefreshGui();
        }

        public string EditorText
        {
            get { return tbxEditor.Text; }
            set { tbxEditor.Text = value; }
        }

        public bool HasChanges
        {
            get { return EditorText != _document.Text; }
        }
    }
}