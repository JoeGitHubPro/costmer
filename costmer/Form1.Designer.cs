
namespace costmer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PTB = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTim = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.LightGray;
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdress.Location = new System.Drawing.Point(294, 250);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(316, 16);
            this.txtAdress.TabIndex = 22;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAdress, "Enter Adress");
            this.txtAdress.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            this.txtAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdress_KeyDown);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(294, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 16);
            this.txtName.TabIndex = 21;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtName, "Enter Name");
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(294, 138);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(316, 16);
            this.txtID.TabIndex = 20;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtID, "Enter ID");
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Costumer Adress :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Costumer Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Costumer     ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(577, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 31);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(421, 367);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(136, 31);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show All";
            this.toolTip1.SetToolTip(this.btnShow, "Show All costumers");
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(263, 367);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(136, 31);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.toolTip1.SetToolTip(this.btnFind, "Find costumer By ID");
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(110, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add INFO";
            this.toolTip1.SetToolTip(this.btnAdd, "Add costumer information");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Costumer INFO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPhoto.Location = new System.Drawing.Point(670, 242);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(95, 31);
            this.btnAddPhoto.TabIndex = 25;
            this.btnAddPhoto.Text = "Add Photo";
            this.toolTip1.SetToolTip(this.btnAddPhoto, "Add costumer Photo");
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 450);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PTB
            // 
            this.PTB.Location = new System.Drawing.Point(670, 110);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(95, 107);
            this.PTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTB.TabIndex = 24;
            this.PTB.TabStop = false;
            this.PTB.Click += new System.EventHandler(this.PTB_Click);
            this.PTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.PTB_DragDrop);
            this.PTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.PTB_DragEnter);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(636, 308);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 26;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(76, 9);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(0, 15);
            this.lblTim.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.PTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PTB;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

