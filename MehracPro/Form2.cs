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
            string yol = mn.Yol;
            string[] url = File.ReadAllLines(yol);
            webView21.Source = new Uri(url[0]);
        }
          
        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        
    }
}
