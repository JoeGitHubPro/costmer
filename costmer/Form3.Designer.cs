
namespace costmer
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCostumer = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTest.Location = new System.Drawing.Point(9, 66);
            this.lblTest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 26);
            this.lblTest.TabIndex = 0;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCostumer);
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Font = new System.Drawing.Font("Bradley Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer INFO";
            // 
            // picCostumer
            // 
            this.picCostumer.Location = new System.Drawing.Point(399, 33);
            this.picCostumer.Name = "picCostumer";
            this.picCostumer.Size = new System.Drawing.Size(173, 184);
            this.picCostumer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCostumer.TabIndex = 1;
            this.picCostumer.TabStop = false;
            this.picCostumer.Click += new System.EventHandler(this.picCostumer_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(520, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOK, "Enter to close");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 381);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "INFO";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCostumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCostumer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}