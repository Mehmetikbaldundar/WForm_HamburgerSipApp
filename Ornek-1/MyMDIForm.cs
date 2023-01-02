using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Left = 0;
            form1.Top = 0;
            form1.Show();
            this.Width = form1.Width + 22;
            this.Height = form1.Height + 68;
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.StartPosition = FormStartPosition.Manual;
            form4.Left = 0;
            form4.Top = 0;
            form4.Show();            
            this.Width = form4.Width + 22;
            this.Height = form4.Height + 68;
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.StartPosition = FormStartPosition.Manual;
            form2.Left = 0;
            form2.Top = 0;
            form2.Show();
            this.Width = form2.Width + 22;
            this.Height = form2.Height + 68;
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.StartPosition = FormStartPosition.Manual;
            form3.Left = 0;
            form3.Top = 0;
            form3.Show();
            this.Width = form3.Width + 22;
            this.Height = form3.Height + 68;
        }
    }
}
