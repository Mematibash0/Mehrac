using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehracPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Main mn = new Main();

        private void Form2_Load(object sender, EventArgs e)
        {
            
            string[] url=File.ReadAllLines(mn.Yol);
            webBrowser1.Navigate(url[0]);
            
            
        }
        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                webBrowser1.ShowPrintPreviewDialog();
            }
            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
