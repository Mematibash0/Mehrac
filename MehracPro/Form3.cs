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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Main mn = new Main();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form1 f1 = new Form1();
            
            string[] pass = File.ReadAllLines(mn.Yol);
            if (textBox1.Text==pass[1])
            {
                f2.Close();
                f1.Close();
                this.Close();
            }
            else
            {
                f2.Show();
                this.Close();
            }
        }
    }
}
