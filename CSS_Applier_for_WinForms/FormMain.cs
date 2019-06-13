using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS
{
    public partial class FormMain : Form
    {
        string _ssPath;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            _ssPath = fileDialog.FileName;
            CSSReader reader = new CSSReader(_ssPath);
            reader.ApplyStyle(btnTest);
            reader.ApplyStyle(tbTest);
            reader.ApplyStyle(cbTest);
            reader.ApplyStyle(chbTest);
            reader.ApplyStyle(lblTest);
            reader.ApplyStyle(lbTest);
            reader.ApplyStyle(rbTest);
        }
    }
}
