using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BP_LAB_4
{
    public partial class Form1 : Form
    {

        static string path = "C:\\Users\\MykolaV\\source\\repos\\C#\\BP_LABS\\BP_LAB_4\\f.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(path);
            using (FileStream f = new FileStream(path, FileMode.Open))
            {
                using (StreamReader fReader = new StreamReader(f))
                {            

                    if (info.Exists)
                    {
                        while (fReader.EndOfStream)
                        {
                            richTextViewFile.AppendText(fReader.ReadLine());
                        }
                    } else
                    {
                        MessageBox.Show("File error", "File does not exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
