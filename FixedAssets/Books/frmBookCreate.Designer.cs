using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.FixedAssets.Books
{
    partial class frmBookCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBookCreate()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]

        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.txtBOOKNAME = new Smobiler.Core.Controls.TextBox();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.nrcQty = new Smobiler.Core.Controls.Numeric();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtPRICE = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.dpkDATE = new Smobiler.Core.Controls.DatePicker();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.imgbtn = new Smobiler.Core.Controls.ImageButton();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.img1 = new Smobiler.Core.Controls.Image();
            this.btndelimg1 = new Smobiler.Core.Controls.Button();
            this.img2 = new Smobiler.Core.Controls.Image();
            this.btndelimg2 = new Smobiler.Core.Controls.Button();
            this.img3 = new Smobiler.Core.Controls.Image();
            this.btndelimg3 = new Smobiler.Core.Controls.Button();
            this.img4 = new Smobiler.Core.Controls.Image();
            this.btndelimg4 = new Smobiler.Core.Controls.Button();
            this.img5 = new Smobiler.Core.Controls.Image();
            this.btndelimg5 = new Smobiler.Core.Controls.Button();
            this.img9 = new Smobiler.Core.Controls.Image();
            this.btndelimg9 = new Smobiler.Core.Controls.Button();
            this.img6 = new Smobiler.Core.Controls.Image();
            this.btndelimg6 = new Smobiler.Core.Controls.Button();
            this.img7 = new Smobiler.Core.Controls.Image();
            this.btndelimg7 = new Smobiler.Core.Controls.Button();
            this.img8 = new Smobiler.Core.Controls.Image();
            this.btndelimg8 = new Smobiler.Core.Controls.Button();
            this.ResourceUploader1 = new Smobiler.Core.Controls.ResourceUploader();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(287, 35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "ͼ������";
            this.Label1.ZIndex = 1;
            // 
            // txtBOOKNAME
            // 
            this.txtBOOKNAME.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtBOOKNAME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBOOKNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtBOOKNAME.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtBOOKNAME.Location = new System.Drawing.Point(88, 0);
            this.txtBOOKNAME.Name = "txtBOOKNAME";
            this.txtBOOKNAME.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtBOOKNAME.Size = new System.Drawing.Size(412, 35);
            this.txtBOOKNAME.TabIndex = 3;
            this.txtBOOKNAME.WaterMarkText = "�����";
            this.txtBOOKNAME.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(499, 35);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "�������";
            this.Label2.ZIndex = 3;
            // 
            // nrcQty
            // 
            this.nrcQty.Location = new System.Drawing.Point(374, 35);
            this.nrcQty.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrcQty.Name = "nrcQty";
            this.nrcQty.Size = new System.Drawing.Size(125, 35);
            this.nrcQty.TabIndex = 5;
            this.nrcQty.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 70);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(287, 35);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "����";
            this.Label3.ZIndex = 5;
            // 
            // txtPRICE
            // 
            this.txtPRICE.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.txtPRICE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPRICE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtPRICE.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtPRICE.Location = new System.Drawing.Point(88, 70);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.txtPRICE.Size = new System.Drawing.Size(362, 35);
            this.txtPRICE.TabIndex = 7;
            this.txtPRICE.WaterMarkText = "0.00";
            this.txtPRICE.ZIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(450, 70);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label6.Size = new System.Drawing.Size(50, 35);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Ԫ";
            this.Label6.ZIndex = 7;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 113);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(287, 35);
            this.Label10.TabIndex = 9;
            this.Label10.Text = "����ʱ��";
            this.Label10.ZIndex = 8;
            // 
            // dpkDATE
            // 
            this.dpkDATE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.dpkDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkDATE.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkDATE.Location = new System.Drawing.Point(287, 113);
            this.dpkDATE.Name = "dpkDATE";
            this.dpkDATE.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkDATE.Size = new System.Drawing.Size(213, 35);
            this.dpkDATE.TabIndex = 10;
            this.dpkDATE.ZIndex = 9;
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label13.Location = new System.Drawing.Point(0, 148);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.Size(499, 35);
            this.Label13.TabIndex = 11;
            this.Label13.Text = "ͼƬ";
            this.Label13.ZIndex = 10;
            // 
            // imgbtn
            // 
            this.imgbtn.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.imgbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgbtn.FontSize = 10F;
            this.imgbtn.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.imgbtn.Location = new System.Drawing.Point(455, 148);
            this.imgbtn.Name = "imgbtn";
            this.imgbtn.ResourceID = "Camera";
            this.imgbtn.Size = new System.Drawing.Size(45, 35);
            this.imgbtn.TabIndex = 12;
            this.imgbtn.ZIndex = 11;
            this.imgbtn.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtn_Click);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.SelectIconID = "!\\ue161043146223";
            this.save.Text = "����";
            // 
            // img1
            // 
            this.img1.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img1.Enlarged = true;
            this.img1.ID = "";
            this.img1.Location = new System.Drawing.Point(0, 183);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(75, 75);
            this.img1.TabIndex = 13;
            this.img1.Visible = false;
            // 
            // btndelimg1
            // 
            this.btndelimg1.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg1.ForeColor = System.Drawing.Color.Red;
            this.btndelimg1.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg1.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg1.Location = new System.Drawing.Point(0, 258);
            this.btndelimg1.Name = "btndelimg1";
            this.btndelimg1.Size = new System.Drawing.Size(75, 30);
            this.btndelimg1.TabIndex = 14;
            this.btndelimg1.Text = "ɾ��";
            this.btndelimg1.Visible = false;
            this.btndelimg1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img2
            // 
            this.img2.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img2.Enlarged = true;
            this.img2.ID = "";
            this.img2.Location = new System.Drawing.Point(75, 183);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(75, 75);
            this.img2.TabIndex = 15;
            this.img2.Visible = false;
            // 
            // btndelimg2
            // 
            this.btndelimg2.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg2.ForeColor = System.Drawing.Color.Red;
            this.btndelimg2.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg2.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg2.Location = new System.Drawing.Point(75, 258);
            this.btndelimg2.Name = "btndelimg2";
            this.btndelimg2.Size = new System.Drawing.Size(75, 30);
            this.btndelimg2.TabIndex = 16;
            this.btndelimg2.Text = "ɾ��";
            this.btndelimg2.Visible = false;
            this.btndelimg2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img3
            // 
            this.img3.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img3.Enlarged = true;
            this.img3.ID = "";
            this.img3.Location = new System.Drawing.Point(150, 183);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(75, 75);
            this.img3.TabIndex = 17;
            this.img3.Visible = false;
            // 
            // btndelimg3
            // 
            this.btndelimg3.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg3.ForeColor = System.Drawing.Color.Red;
            this.btndelimg3.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg3.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg3.Location = new System.Drawing.Point(150, 258);
            this.btndelimg3.Name = "btndelimg3";
            this.btndelimg3.Size = new System.Drawing.Size(75, 30);
            this.btndelimg3.TabIndex = 18;
            this.btndelimg3.Text = "ɾ��";
            this.btndelimg3.Visible = false;
            this.btndelimg3.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img4
            // 
            this.img4.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img4.Enlarged = true;
            this.img4.ID = "";
            this.img4.Location = new System.Drawing.Point(225, 183);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(75, 75);
            this.img4.TabIndex = 19;
            this.img4.Visible = false;
            // 
            // btndelimg4
            // 
            this.btndelimg4.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg4.ForeColor = System.Drawing.Color.Red;
            this.btndelimg4.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg4.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg4.Location = new System.Drawing.Point(225, 258);
            this.btndelimg4.Name = "btndelimg4";
            this.btndelimg4.Size = new System.Drawing.Size(75, 30);
            this.btndelimg4.TabIndex = 20;
            this.btndelimg4.Text = "ɾ��";
            this.btndelimg4.Visible = false;
            this.btndelimg4.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img5
            // 
            this.img5.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img5.Enlarged = true;
            this.img5.ID = "";
            this.img5.Location = new System.Drawing.Point(300, 183);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(75, 75);
            this.img5.TabIndex = 21;
            this.img5.Visible = false;
            // 
            // btndelimg5
            // 
            this.btndelimg5.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg5.ForeColor = System.Drawing.Color.Red;
            this.btndelimg5.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg5.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg5.Location = new System.Drawing.Point(299, 258);
            this.btndelimg5.Name = "btndelimg5";
            this.btndelimg5.Size = new System.Drawing.Size(75, 30);
            this.btndelimg5.TabIndex = 22;
            this.btndelimg5.Text = "ɾ��";
            this.btndelimg5.Visible = false;
            this.btndelimg5.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img9
            // 
            this.img9.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img9.Enlarged = true;
            this.img9.ID = "";
            this.img9.Location = new System.Drawing.Point(150, 288);
            this.img9.Name = "img9";
            this.img9.Size = new System.Drawing.Size(75, 75);
            this.img9.TabIndex = 23;
            this.img9.Visible = false;
            // 
            // btndelimg9
            // 
            this.btndelimg9.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg9.ForeColor = System.Drawing.Color.Red;
            this.btndelimg9.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg9.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg9.Location = new System.Drawing.Point(150, 363);
            this.btndelimg9.Name = "btndelimg9";
            this.btndelimg9.Size = new System.Drawing.Size(75, 30);
            this.btndelimg9.TabIndex = 24;
            this.btndelimg9.Text = "ɾ��";
            this.btndelimg9.Visible = false;
            this.btndelimg9.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img6
            // 
            this.img6.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img6.Enlarged = true;
            this.img6.ID = "";
            this.img6.Location = new System.Drawing.Point(375, 183);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(75, 75);
            this.img6.TabIndex = 25;
            this.img6.Visible = false;
            // 
            // btndelimg6
            // 
            this.btndelimg6.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg6.ForeColor = System.Drawing.Color.Red;
            this.btndelimg6.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg6.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg6.Location = new System.Drawing.Point(375, 258);
            this.btndelimg6.Name = "btndelimg6";
            this.btndelimg6.Size = new System.Drawing.Size(75, 30);
            this.btndelimg6.TabIndex = 26;
            this.btndelimg6.Text = "ɾ��";
            this.btndelimg6.Visible = false;
            this.btndelimg6.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img7
            // 
            this.img7.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img7.Enlarged = true;
            this.img7.ID = "";
            this.img7.Location = new System.Drawing.Point(0, 288);
            this.img7.Name = "img7";
            this.img7.Size = new System.Drawing.Size(75, 75);
            this.img7.TabIndex = 27;
            this.img7.Visible = false;
            // 
            // btndelimg7
            // 
            this.btndelimg7.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg7.ForeColor = System.Drawing.Color.Red;
            this.btndelimg7.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg7.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg7.Location = new System.Drawing.Point(0, 363);
            this.btndelimg7.Name = "btndelimg7";
            this.btndelimg7.Size = new System.Drawing.Size(75, 30);
            this.btndelimg7.TabIndex = 28;
            this.btndelimg7.Text = "ɾ��";
            this.btndelimg7.Visible = false;
            this.btndelimg7.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // img8
            // 
            this.img8.Border = new Smobiler.Core.Border(0, 0, 1, 0);
            this.img8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.img8.Enlarged = true;
            this.img8.ID = "";
            this.img8.Location = new System.Drawing.Point(75, 288);
            this.img8.Name = "img8";
            this.img8.Size = new System.Drawing.Size(75, 75);
            this.img8.TabIndex = 29;
            this.img8.Visible = false;
            // 
            // btndelimg8
            // 
            this.btndelimg8.Border = new Smobiler.Core.Border(0, 0, 1, 1);
            this.btndelimg8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btndelimg8.ForeColor = System.Drawing.Color.Red;
            this.btndelimg8.HoverBackColor = System.Drawing.Color.White;
            this.btndelimg8.HoverForeColor = System.Drawing.Color.Red;
            this.btndelimg8.Location = new System.Drawing.Point(75, 363);
            this.btndelimg8.Name = "btndelimg8";
            this.btndelimg8.Size = new System.Drawing.Size(75, 30);
            this.btndelimg8.TabIndex = 30;
            this.btndelimg8.Text = "ɾ��";
            this.btndelimg8.Visible = false;
            this.btndelimg8.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelimg_Click);
            // 
            // ResourceUploader1
            // 
            this.ResourceUploader1.CompressedResolution = 960;
            this.ResourceUploader1.Name = "ResourceUploader1";
            this.ResourceUploader1.Uploading += new Smobiler.Core.ResourceUploadingEventHandler(this.ResourceUploader1_Uploading);
            // 
            // frmBookCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.ResourceUploader1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.img1,
            this.btndelimg1,
            this.img2,
            this.btndelimg2,
            this.img3,
            this.btndelimg3,
            this.img4,
            this.btndelimg4,
            this.img5,
            this.btndelimg5,
            this.img9,
            this.img6,
            this.btndelimg6,
            this.img7,
            this.btndelimg7,
            this.img8,
            this.btndelimg8,
            this.btndelimg9,
            this.Label1,
            this.txtBOOKNAME,
            this.Label2,
            this.nrcQty,
            this.Label3,
            this.txtPRICE,
            this.Label6,
            this.Label10,
            this.dpkDATE,
            this.Label13,
            this.imgbtn});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 500);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "ͼ�����";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmBookCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmBookCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmBookCreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.TextBox txtBOOKNAME;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Numeric nrcQty;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtPRICE;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.DatePicker dpkDATE;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.ImageButton imgbtn;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Image img1;
        internal Smobiler.Core.Controls.Button btndelimg1;
        internal Smobiler.Core.Controls.Image img2;
        internal Smobiler.Core.Controls.Button btndelimg2;
        internal Smobiler.Core.Controls.Image img3;
        internal Smobiler.Core.Controls.Button btndelimg3;
        internal Smobiler.Core.Controls.Image img4;
        internal Smobiler.Core.Controls.Button btndelimg4;
        internal Smobiler.Core.Controls.Image img5;
        internal Smobiler.Core.Controls.Button btndelimg5;
        internal Smobiler.Core.Controls.Image img9;
        internal Smobiler.Core.Controls.Button btndelimg9;
        internal Smobiler.Core.Controls.Image img6;
        internal Smobiler.Core.Controls.Button btndelimg6;
        internal Smobiler.Core.Controls.Image img7;
        internal Smobiler.Core.Controls.Button btndelimg7;
        internal Smobiler.Core.Controls.Image img8;
        internal Smobiler.Core.Controls.Button btndelimg8;
        internal Smobiler.Core.Controls.ResourceUploader ResourceUploader1;

        #endregion
    }
}
