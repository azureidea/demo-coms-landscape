
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.RB
{
    public partial class frmRBDetail1 : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmRBDetail1()
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
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.lblRBCC = new Smobiler.Core.Controls.Label();
            this.lblRBState = new Smobiler.Core.Controls.Label();
            this.lblRBUser = new Smobiler.Core.Controls.Label();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.txtRB_REASON = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblnote1 = new Smobiler.Core.Controls.Label();
            this.lblRB_REASON1 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            // 
            // lblnote
            // 
            this.lblnote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblnote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblnote.Location = new System.Drawing.Point(88, 145);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblnote.Size = new System.Drawing.Size(412, 100);
            this.lblnote.TabIndex = 4;
            this.lblnote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // GridView1
            // 
            this.GridView1.AutoHeight = false;
            this.GridView1.Layout = "frmRBROWLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 403);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(500, 223);
            this.GridView1.TabIndex = 7;
            // 
            // lblRBNO
            // 
            this.lblRBNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRBNO.Location = new System.Drawing.Point(88, 0);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblRBNO.Size = new System.Drawing.Size(412, 35);
            this.lblRBNO.TabIndex = 8;
            // 
            // lblRBCC
            // 
            this.lblRBCC.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBCC.Location = new System.Drawing.Point(88, 78);
            this.lblRBCC.Name = "lblRBCC";
            this.lblRBCC.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblRBCC.Size = new System.Drawing.Size(412, 60);
            this.lblRBCC.TabIndex = 9;
            this.lblRBCC.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblRBState
            // 
            this.lblRBState.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblRBState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBState.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRBState.Location = new System.Drawing.Point(88, 253);
            this.lblRBState.Name = "lblRBState";
            this.lblRBState.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblRBState.Size = new System.Drawing.Size(412, 35);
            this.lblRBState.TabIndex = 10;
            // 
            // lblRBUser
            // 
            this.lblRBUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRBUser.Location = new System.Drawing.Point(88, 35);
            this.lblRBUser.Name = "lblRBUser";
            this.lblRBUser.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblRBUser.Size = new System.Drawing.Size(412, 35);
            this.lblRBUser.TabIndex = 11;
            // 
            // save
            // 
            this.save.IconID = "!\\ue065043146223";
            this.save.Name = "save";
            this.save.SelectIconID = "!\\ue065043146223";
            this.save.Text = "����";
            // 
            // txtRB_REASON
            // 
            this.txtRB_REASON.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtRB_REASON.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRB_REASON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRB_REASON.Location = new System.Drawing.Point(88, 295);
            this.txtRB_REASON.Name = "txtRB_REASON";
            this.txtRB_REASON.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.txtRB_REASON.Size = new System.Drawing.Size(412, 100);
            this.txtRB_REASON.TabIndex = 12;
            this.txtRB_REASON.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label8
            // 
            this.Label8.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(88, 35);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "�������";
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Location = new System.Drawing.Point(0, 78);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 60);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "�ɱ�����";
            this.Label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "�����û�";
            // 
            // lblnote1
            // 
            this.lblnote1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblnote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblnote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblnote1.Location = new System.Drawing.Point(0, 145);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblnote1.Size = new System.Drawing.Size(88, 100);
            this.lblnote1.TabIndex = 16;
            this.lblnote1.Text = "������ע";
            this.lblnote1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblRB_REASON1
            // 
            this.lblRB_REASON1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblRB_REASON1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRB_REASON1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRB_REASON1.Location = new System.Drawing.Point(0, 295);
            this.lblRB_REASON1.Name = "lblRB_REASON1";
            this.lblRB_REASON1.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.lblRB_REASON1.Size = new System.Drawing.Size(88, 100);
            this.lblRB_REASON1.TabIndex = 17;
            this.lblRB_REASON1.Text = "�ܾ�����";
            this.lblRB_REASON1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 253);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "״̬";
            // 
            // frmRBDetail1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblnote,
            this.GridView1,
            this.lblRBNO,
            this.lblRBCC,
            this.lblRBState,
            this.lblRBUser,
            this.txtRB_REASON,
            this.Label8,
            this.Label1,
            this.Label2,
            this.lblnote1,
            this.lblRB_REASON1,
            this.Label3});
            this.FooterBarLayout = "frmRBDefFootbarLayout";
            this.ForeColor = System.Drawing.Color.White;
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 588);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "��������";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmRBDetail1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmRBDetail1_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmRBDetail1";

        }
        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.Label lblRBCC;
        internal Smobiler.Core.Controls.Label lblRBState;
        internal Smobiler.Core.Controls.Label lblRBUser;
        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.Label txtRB_REASON;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblnote1;
        internal Smobiler.Core.Controls.Label lblRB_REASON1;
        internal Smobiler.Core.Controls.Label Label3;

        #endregion

    }
}
