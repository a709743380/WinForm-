
namespace 總整理
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bu = new System.Windows.Forms.PictureBox();
            this.dao = new System.Windows.Forms.PictureBox();
            this.shi = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bu
            // 
            this.bu.Location = new System.Drawing.Point(95, 233);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(140, 140);
            this.bu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bu.TabIndex = 0;
            this.bu.TabStop = false;
            this.bu.Click += new System.EventHandler(this.bu_Click);
            // 
            // dao
            // 
            this.dao.Location = new System.Drawing.Point(310, 233);
            this.dao.Name = "dao";
            this.dao.Size = new System.Drawing.Size(140, 140);
            this.dao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dao.TabIndex = 1;
            this.dao.TabStop = false;
            this.dao.Click += new System.EventHandler(this.dao_Click);
            // 
            // shi
            // 
            this.shi.Location = new System.Drawing.Point(558, 233);
            this.shi.Name = "shi";
            this.shi.Size = new System.Drawing.Size(140, 140);
            this.shi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shi.TabIndex = 2;
            this.shi.TabStop = false;
            this.shi.Click += new System.EventHandler(this.shi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(310, 12);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(140, 140);
            this.c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c.TabIndex = 4;
            this.c.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "paper.png");
            this.imageList1.Images.SetKeyName(1, "scissors.png");
            this.imageList1.Images.SetKeyName(2, "stone.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "返回";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(768, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shi);
            this.Controls.Add(this.dao);
            this.Controls.Add(this.bu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form5";
            this.Text = "猜拳";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bu;
        private System.Windows.Forms.PictureBox dao;
        private System.Windows.Forms.PictureBox shi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}