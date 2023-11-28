using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace costmer
{
    public partial class Form3 : Form
    {
        public void by(string p)
        {
            
            lblTest.Text = p;

            
            


        }

        public void pic(string path)
        {

           picCostumer.Image = Image.FromFile(path);
            
        }


        public Form3()
        {
            InitializeComponent();
            
        }
       
        
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        public void lblTest_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //lblTest.Text = frm1.by();

            //lblTest.Text = p;



        }

        private void picCostumer_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}
