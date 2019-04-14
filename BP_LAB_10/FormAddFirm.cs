using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_10
{
    public partial class FormAddFirm : Form
    {
        public Firm NewFirm { get; set; }
        public FormAddFirm()
        {
            InitializeComponent();
        }
        private void ButtonCreateFirm_Click(object sender, EventArgs e)
        {
            if (textBoxFirmName.Text == "")
            {
                MessageBox.Show("Firm name cannot be empty!", "Firm creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NewFirm == null)
            {
                NewFirm = new Firm(textBoxFirmName.Text);
                MessageBox.Show("Created!", "Firm creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
        }
    }
}
