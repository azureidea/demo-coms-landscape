using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveDef : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveDef()
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
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.LIMG = new Smobiler.Core.Controls.Image();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lbllNO = new Smobiler.Core.Controls.Label();
            this.lbllType = new Smobiler.Core.Controls.Label();
            this.lblbDate = new Smobiler.Core.Controls.Label();
            this.lbleDate = new Smobiler.Core.Controls.Label();
            this.lbllDay = new Smobiler.Core.Controls.Label();
            this.lbllReason = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.lblCUser = new Smobiler.Core.Controls.Label();
            this.lblCCUser = new Smobiler.Core.Controls.Label();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.lblCreateDate = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.lblState = new Smobiler.Core.Controls.Label();
            this.lblREFUSENOTE1 = new Smobiler.Core.Controls.Label();
            this.lblREFUSENOTE = new Smobiler.Core.Controls.Label();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Location = new System.Drawing.Point(0, 35);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "�������";
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 70);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "��ʼʱ��";
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 105);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "����ʱ��";
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 148);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "�������";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 183);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(88, 100);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "�������";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label6
            // 
            this.Label6.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label6.Location = new System.Drawing.Point(0, 290);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(287, 100);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "ͼƬ";
            this.Label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // LIMG
            // 
            this.LIMG.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.LIMG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LIMG.Enlarged = true;
            this.LIMG.ID = "";
            this.LIMG.Location = new System.Drawing.Point(287, 290);
            this.LIMG.Name = "LIMG";
            this.LIMG.Size = new System.Drawing.Size(213, 100);
            this.LIMG.TabIndex = 15;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "��ٱ��";
            // 
            // lbllNO
            // 
            this.lbllNO.Bold = true;
            this.lbllNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbllNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbllNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbllNO.Location = new System.Drawing.Point(87, 0);
            this.lbllNO.Name = "lbllNO";
            this.lbllNO.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lbllNO.Size = new System.Drawing.Size(412, 35);
            this.lbllNO.TabIndex = 21;
            // 
            // lbllType
            // 
            this.lbllType.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbllType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbllType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbllType.Location = new System.Drawing.Point(88, 35);
            this.lbllType.Name = "lbllType";
            this.lbllType.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lbllType.Size = new System.Drawing.Size(412, 35);
            this.lbllType.TabIndex = 22;
            // 
            // lblbDate
            // 
            this.lblbDate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblbDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblbDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblbDate.Location = new System.Drawing.Point(87, 70);
            this.lblbDate.Name = "lblbDate";
            this.lblbDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblbDate.Size = new System.Drawing.Size(412, 35);
            this.lblbDate.TabIndex = 23;
            // 
            // lbleDate
            // 
            this.lbleDate.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbleDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbleDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbleDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbleDate.Location = new System.Drawing.Point(88, 105);
            this.lbleDate.Name = "lbleDate";
            this.lbleDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lbleDate.Size = new System.Drawing.Size(412, 35);
            this.lbleDate.TabIndex = 24;
            // 
            // lbllDay
            // 
            this.lbllDay.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lbllDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbllDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbllDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lbllDay.Location = new System.Drawing.Point(88, 148);
            this.lbllDay.Name = "lbllDay";
            this.lbllDay.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lbllDay.Size = new System.Drawing.Size(412, 35);
            this.lbllDay.TabIndex = 25;
            // 
            // lbllReason
            // 
            this.lbllReason.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lbllReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbllReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbllReason.Location = new System.Drawing.Point(88, 183);
            this.lbllReason.Name = "lbllReason";
            this.lbllReason.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.lbllReason.Size = new System.Drawing.Size(412, 100);
            this.lbllReason.TabIndex = 26;
            this.lbllReason.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Location = new System.Drawing.Point(0, 398);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88, 35);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "������";
            // 
            // Label9
            // 
            this.Label9.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label9.Location = new System.Drawing.Point(0, 433);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(88, 35);
            this.Label9.TabIndex = 28;
            this.Label9.Text = "������";
            // 
            // lblCUser
            // 
            this.lblCUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblCUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCUser.Location = new System.Drawing.Point(88, 398);
            this.lblCUser.Name = "lblCUser";
            this.lblCUser.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblCUser.Size = new System.Drawing.Size(412, 35);
            this.lblCUser.TabIndex = 29;
            // 
            // lblCCUser
            // 
            this.lblCCUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblCCUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCCUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCCUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCCUser.Location = new System.Drawing.Point(88, 433);
            this.lblCCUser.Name = "lblCCUser";
            this.lblCCUser.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblCCUser.Size = new System.Drawing.Size(412, 35);
            this.lblCCUser.TabIndex = 30;
            // 
            // Label13
            // 
            this.Label13.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label13.Location = new System.Drawing.Point(0, 475);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.Size(88, 35);
            this.Label13.TabIndex = 36;
            this.Label13.Text = "����ʱ��";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblCreateDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCreateDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCreateDate.Location = new System.Drawing.Point(88, 475);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblCreateDate.Size = new System.Drawing.Size(412, 35);
            this.lblCreateDate.TabIndex = 37;
            // 
            // Label10
            // 
            this.Label10.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(0, 518);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(88, 35);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "״̬";
            // 
            // lblState
            // 
            this.lblState.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblState.Location = new System.Drawing.Point(88, 518);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblState.Size = new System.Drawing.Size(412, 35);
            this.lblState.TabIndex = 39;
            // 
            // lblREFUSENOTE1
            // 
            this.lblREFUSENOTE1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblREFUSENOTE1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblREFUSENOTE1.Location = new System.Drawing.Point(0, 560);
            this.lblREFUSENOTE1.Name = "lblREFUSENOTE1";
            this.lblREFUSENOTE1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblREFUSENOTE1.Size = new System.Drawing.Size(88, 100);
            this.lblREFUSENOTE1.TabIndex = 40;
            this.lblREFUSENOTE1.Text = "�ܾ�����";
            this.lblREFUSENOTE1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblREFUSENOTE1.Visible = false;
            // 
            // lblREFUSENOTE
            // 
            this.lblREFUSENOTE.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblREFUSENOTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblREFUSENOTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblREFUSENOTE.Location = new System.Drawing.Point(88, 560);
            this.lblREFUSENOTE.Name = "lblREFUSENOTE";
            this.lblREFUSENOTE.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.lblREFUSENOTE.Size = new System.Drawing.Size(412, 100);
            this.lblREFUSENOTE.TabIndex = 41;
            this.lblREFUSENOTE.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblREFUSENOTE.Visible = false;
            // 
            // frmLeaveDef
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.LIMG,
            this.Label8,
            this.lbllNO,
            this.lbllType,
            this.lblbDate,
            this.lbleDate,
            this.lbllDay,
            this.lbllReason,
            this.Label7,
            this.Label9,
            this.lblCUser,
            this.lblCCUser,
            this.Label13,
            this.lblCreateDate,
            this.Label10,
            this.lblState,
            this.lblREFUSENOTE1,
            this.lblREFUSENOTE});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 675);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "�������";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmLeaveDef_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmLeaveDef";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Image LIMG;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lbllNO;
        internal Smobiler.Core.Controls.Label lbllType;
        internal Smobiler.Core.Controls.Label lblbDate;
        internal Smobiler.Core.Controls.Label lbleDate;
        internal Smobiler.Core.Controls.Label lbllDay;
        internal Smobiler.Core.Controls.Label lbllReason;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label lblCUser;
        internal Smobiler.Core.Controls.Label lblCCUser;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.Label lblCreateDate;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label lblState;
        internal Smobiler.Core.Controls.Label lblREFUSENOTE1;
        internal Smobiler.Core.Controls.Label lblREFUSENOTE;
        #endregion

    }
}
