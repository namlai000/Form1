using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOk.Click += doClick;
        }

        void doClick(object sender, EventArgs e)
        {
            MessageBox.Show("Alo");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs =  MessageBox.Show("Are you fucking sure m8?", "Que?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "")
            {
                if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back && e.KeyCode != Keys.Subtract && e.KeyCode != Keys.Add)
                {
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
                {
                    e.SuppressKeyPress = true;
                }
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string cordinator = string.Format("X = {0}, Y = {1}", e.X, e.Y);
            label1.Text = cordinator;
        }

    }
}
