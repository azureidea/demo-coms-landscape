using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveCreate()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.lblDate = new Smobiler.Core.Controls.DatePicker();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblLedate = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.LDAY = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.LREASON = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.btnCUser = new Smobiler.Core.Controls.Button();
            this.BtnCUser2 = new Smobiler.Core.Controls.Button();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.btnccuser1 = new Smobiler.Core.Controls.Button();
            this.Btnccuser2 = new Smobiler.Core.Controls.Button();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.Label10 = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "�������";
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntype.Location = new System.Drawing.Point(88, 0);
            this.btntype.Name = "btntype";
            this.btntype.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btntype.Size = new System.Drawing.Size(387, 35);
            this.btntype.TabIndex = 4;
            this.btntype.Text = "ѡ�񣨱��";
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype2.Location = new System.Drawing.Point(475, 0);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.Size(25, 35);
            this.btntype2.TabIndex = 5;
            this.btntype2.Text = ">";
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // lblDate
            // 
            this.lblDate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblDate.Location = new System.Drawing.Point(287, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblDate.Size = new System.Drawing.Size(213, 35);
            this.lblDate.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(287, 35);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "��ʼʱ��";
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
            this.Label3.TabIndex = 8;
            this.Label3.Text = "����ʱ��";
            // 
            // lblLedate
            // 
            this.lblLedate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblLedate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLedate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblLedate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblLedate.Location = new System.Drawing.Point(287, 70);
            this.lblLedate.Name = "lblLedate";
            this.lblLedate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblLedate.Size = new System.Drawing.Size(213, 35);
            this.lblLedate.TabIndex = 9;
            this.lblLedate.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.lblLedate_DatePicked);
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 113);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "�������";
            // 
            // LDAY
            // 
            this.LDAY.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.LDAY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LDAY.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.LDAY.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.LDAY.Location = new System.Drawing.Point(88, 113);
            this.LDAY.Name = "LDAY";
            this.LDAY.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.LDAY.Size = new System.Drawing.Size(367, 35);
            this.LDAY.TabIndex = 11;
            this.LDAY.WaterMarkText = "�����";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 148);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(88, 100);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "�������";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // LREASON
            // 
            this.LREASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LREASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.LREASON.Location = new System.Drawing.Point(88, 148);
            this.LREASON.Multiline = true;
            this.LREASON.Name = "LREASON";
            this.LREASON.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.LREASON.Size = new System.Drawing.Size(412, 100);
            this.LREASON.TabIndex = 13;
            this.LREASON.WaterMarkText = "�����";
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0, 255);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(287, 100);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "ͼƬ";
            this.Label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // imgL
            // 
            this.imgL.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Enlarged = true;
            this.imgL.ID = "";
            this.imgL.Location = new System.Drawing.Point(287, 255);
            this.imgL.Name = "imgL";
            this.imgL.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.imgL.Size = new System.Drawing.Size(213, 70);
            this.imgL.TabIndex = 15;
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Location = new System.Drawing.Point(0, 363);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88, 35);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "������";
            // 
            // btnCUser
            // 
            this.btnCUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnCUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCUser.Location = new System.Drawing.Point(88, 363);
            this.btnCUser.Name = "btnCUser";
            this.btnCUser.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnCUser.Size = new System.Drawing.Size(387, 35);
            this.btnCUser.TabIndex = 18;
            this.btnCUser.Text = "�����";
            this.btnCUser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // BtnCUser2
            // 
            this.BtnCUser2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.BtnCUser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnCUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BtnCUser2.Location = new System.Drawing.Point(475, 363);
            this.BtnCUser2.Name = "BtnCUser2";
            this.BtnCUser2.Size = new System.Drawing.Size(25, 35);
            this.BtnCUser2.TabIndex = 19;
            this.BtnCUser2.Text = ">";
            this.BtnCUser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.SelectIconID = "!\\ue161043146223";
            this.save.Text = "����";
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Location = new System.Drawing.Point(0, 398);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "������";
            // 
            // btnccuser1
            // 
            this.btnccuser1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnccuser1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnccuser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnccuser1.Location = new System.Drawing.Point(88, 398);
            this.btnccuser1.Name = "btnccuser1";
            this.btnccuser1.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnccuser1.Size = new System.Drawing.Size(387, 35);
            this.btnccuser1.TabIndex = 21;
            this.btnccuser1.Text = "��ѡ�";
            this.btnccuser1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // Btnccuser2
            // 
            this.Btnccuser2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Btnccuser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Btnccuser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Btnccuser2.Location = new System.Drawing.Point(475, 398);
            this.Btnccuser2.Name = "Btnccuser2";
            this.Btnccuser2.Size = new System.Drawing.Size(25, 35);
            this.Btnccuser2.TabIndex = 22;
            this.Btnccuser2.Text = ">";
            this.Btnccuser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.BtnCUser_Click);
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(287, 325);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(213, 30);
            this.Label9.TabIndex = 23;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.Border = new Smobiler.Core.Border(1);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.BorderRadius = 5;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnupPhoto.Location = new System.Drawing.Point(322, 330);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65, 20);
            this.btnupPhoto.TabIndex = 24;
            this.btnupPhoto.Text = "�ϴ�";
            this.btnupPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.Border = new Smobiler.Core.Border(1);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 5;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(399, 330);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65, 20);
            this.btndelPhoto.TabIndex = 25;
            this.btndelPhoto.Text = "ɾ��";
            this.btndelPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelPhoto_Click);
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label10.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label10.Location = new System.Drawing.Point(455, 113);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label10.Size = new System.Drawing.Size(45, 35);
            this.Label10.TabIndex = 26;
            this.Label10.Text = "��";
            // 
            // frmLeaveCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Camera1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.btntype,
            this.btntype2,
            this.lblDate,
            this.Label2,
            this.Label3,
            this.lblLedate,
            this.Label4,
            this.LDAY,
            this.Label5,
            this.LREASON,
            this.Label6,
            this.imgL,
            this.Label7,
            this.btnCUser,
            this.BtnCUser2,
            this.Label8,
            this.btnccuser1,
            this.Btnccuser2,
            this.Label9,
            this.btnupPhoto,
            this.btndelPhoto,
            this.Label10});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 500);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "��ٴ���";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmLeaveCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmLeaveCreate";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.DatePicker lblDate;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker lblLedate;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox LDAY;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox LREASON;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Image imgL;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Button btnCUser;
        internal Smobiler.Core.Controls.Button BtnCUser2;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Button btnccuser1;
        internal Smobiler.Core.Controls.Button Btnccuser2;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        internal Smobiler.Core.Controls.Label Label10;
        #endregion

    }
}
