using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContarOvejas
{
    public partial class Form1 : Form
    {
        int ovejas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovejas ++;
            label2.Text = Convert.ToString(ovejas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ovejas = 0;
            label2.Text = Convert.ToString(ovejas);
            MessageBox.Show("Buenas Noches");
            Close();
        }
    }
}
