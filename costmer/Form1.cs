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

namespace costmer
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PTB.AllowDrop = true;
            txtID.Focus();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                string ID = txtID.Text;
                string Name = txtName.Text;
                string Adress = txtAdress.Text;

                //================================
               
                StreamReader R1 = new StreamReader("Data.txt");
                string R = R1.ReadToEnd();
                R1.Close();
              

                if (ID == "")
                {
                    MessageBox.Show("Please enter ID");
                    errorProvider1.SetError(txtID, "Please enter ID");
                    return;

                }
                if (Name == "")
                {
                    MessageBox.Show("Please enter Name");
                    errorProvider1.SetError(txtName, "Please enter Name");
                    return;
                }
                if (Adress == "")
                {
                    MessageBox.Show("Please enter Adress");
                    errorProvider1.SetError(txtAdress, "Please enter Adress");
                    return;
                }

                else
                {
                    if (R.Contains(ID + " \t "))
                    {

                        MessageBox.Show("this item already exist");
                    }
                    else
                    {

                        



                        if (!Directory.Exists("Image"))
                        {
                            Directory.CreateDirectory("Image");
                        }
                        else
                        {
                            //string Path1 = Path.GetFileName(PTB.Fil);
                            if (PTB.Image is Image                /*|| File.Exists("Image/" + ".jpg")*/)      //ooooooooooooooooooooooooooooooooooooooooooooo
                            {
                                
                                PTB.Image.Save("Image/" + ID + ".jpg");
                            }
                            else
                            {
                                MessageBox.Show("Please Add Photo");
                                return;

                            }


                        }

                        StreamWriter W1 = new StreamWriter("Data.txt", true);
                        W1.WriteLine(ID + " \t " + Name + " \t " + Adress);
                        W1.Close();
                        

                        //----------image()------------------

                        //if (!Directory.Exists("Image"))
                        //{
                        //    Directory.CreateDirectory("Image");
                        //}
                        //else
                        //{
                        //    if (File.Exists("Image/" + ID + ".jpg"))
                        //    { PTB.Image.Save("Image/" + ID + ".jpg"); }
                        //    //else
                        //    //{
                        //    //    MessageBox.Show("Please Add Photo");
                        //    //    return;

                        //    //}


                        //}
                        //----------------------------


                        MessageBox.Show("The costumer has been added sucssefully");
                        txtID.Clear();
                        txtName.Clear();
                        txtAdress.Clear();
                        txtID.Focus();
                        PTB.Image = new PictureBox().Image;// to clear  PictureBox //
                    }
                }
                //====================================


            }catch(Exception ex)
            {
                MessageBox.Show("Erorr" + ex);
            }



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {


            Form2 Frm = new Form2();
            Frm.ShowDialog();

           
            






        }

        public void btnFind_Click(object sender, EventArgs e)
        {

            string ID = txtID.Text;
            string Name = txtName.Text;
            string Adress = txtAdress.Text;
           
            
            
            if(ID!="")
            {
                StreamReader R2 = new StreamReader("Data.txt");
                

                string line="";
               bool F = false;
                
                do
                {
                    line = R2.ReadLine();
                    if(line!=null)
                    {
                        string[] Data = line.Split(" \t ");                 //++++++++++++++++++++++++++++++++++
//=================================================================
                    if(Data[0]==ID)
                        {
                            //Form3 FRM3 = new Form3();
                            //Label lbl3 = new Label();
                            //lbl3.Text = ";";
                            //***************************************************************
                            //MessageBox.Show("Cosumer ID : "+Data[0]+
                            //     "\n"+ "Cosumer Name : " + Data[1]+
                            //    "\n"+ "Cosumer Adress : " + Data[2]);



                            Form3 frm = new Form3();
                            frm.by("Cosumer ID :  " + Data[0] +
                               "\n\n" + "Cosumer Name :  " + Data[1] +
                              "\n\n" + "Cosumer Adress :  " + Data[2]);
                            


                            //----------image()------------------
                            string Path = "image/" +Data[0] + ".jpg";

                            if (File.Exists(Path))


                            //PTB.Image = Image.FromFile(Path);
                            {
                                frm.pic(Path);
                            }
                            

                            frm.ShowDialog();




                            F = true;


                            break;
                            
                            
                        }                  
                      
     //=================================================================
                    }
                    else 
                    { 
                        MessageBox.Show("this ID dose not exist");
                        txtID.Focus();
                    }


                } while (line != null);


                


             R2.Close();


            }
            else
            {
                MessageBox.Show("Please enter ID");
            }
            

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();

            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdress.Focus();
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {

         //   OpenFileDialog O = new OpenFileDialog();
            OFD.Filter = "Images|*.jpg";

            if(OFD.ShowDialog()==DialogResult.OK)
            {
                PTB.Image = Image.FromFile(OFD.FileName); 
            }


            
        }

        private void PTB_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTim.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            //Form3 frm = new Form3();
            //frm.by("","");
            //frm.ShowDialog();
            



          ///*public*/ string p = "youssef m";





        }
        string[] files = null;
        private void PTB_DragEnter(object sender, DragEventArgs e)
        {
            files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string str = Path.GetExtension(files[0]);
            if (str == ".jpg" && files.Count() == 1)
            {

                e.Effect = DragDropEffects.All;
            }
        }

        private void PTB_DragDrop(object sender, DragEventArgs e) 
        {
            PTB.Image = Image.FromFile(files[0]);
        }
    }


    
}
