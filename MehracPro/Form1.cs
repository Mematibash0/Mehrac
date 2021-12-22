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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Main mn = new Main();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            File.WriteAllText(mn.Yol,textBox1.Text+"\n"+textBox2.Text);
            if (textBox1.Text!=string.Empty&&textBox2.Text!=string.Empty)
            {
                Form2 f2 = new Form2();
                
                f2.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
