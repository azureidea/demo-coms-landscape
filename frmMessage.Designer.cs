using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo
{
    public partial class frmMessage : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmMessage()
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
            this.txtSearchinfo = new Smobiler.Core.Controls.TextBox();
            this.btnSearch = new Smobiler.Core.Controls.ImageButton();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.tExit = new Smobiler.Core.Controls.ToolbarItem();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.Label1 = new Smobiler.Core.Controls.Label();
            // 
            // txtSearchinfo
            // 
            this.txtSearchinfo.Border = new Smobiler.Core.Border(1);
            this.txtSearchinfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSearchinfo.BorderRadius = 2;
            this.txtSearchinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtSearchinfo.Location = new System.Drawing.Point(3, 13);
            this.txtSearchinfo.Name = "txtSearchinfo";
            this.txtSearchinfo.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.txtSearchinfo.Size = new System.Drawing.Size(457, 35);
            this.txtSearchinfo.TabIndex = 2;
            this.txtSearchinfo.WaterMarkText = "����";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.BackColorAlpha = 0;
            this.btnSearch.FontSize = 10F;
            this.btnSearch.Location = new System.Drawing.Point(460, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ResourceID = "!\\ue8b6043146223";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSearch_Click);
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmMessageLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 53);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(500, 177);
            this.GridView1.TabIndex = 4;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // tExit
            // 
            this.tExit.IconID = "Exit";
            this.tExit.Name = "tExit";
            this.tExit.SelectIconID = "Exit";
            this.tExit.Text = "����";
            this.tExit.Visible = false;
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            this.Gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.Gps1_GotLocation);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.BackColorAlpha = 0;
            this.Label1.FontSize = 23F;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.Label1.Location = new System.Drawing.Point(116, 125);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(300, 38);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Ŀǰ��ʱ���κ���Ϣ";
            this.Label1.Visible = false;
            // 
            // frmMessage
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtSearchinfo,
            this.btnSearch,
            this.GridView1,
            this.Label1});
            this.ForeColor = System.Drawing.Color.White;
            this.LayoutMode = Smobiler.Core.FormLayoutMode.EFFACT3D;
            this.LeftFormLayout = "frmMenuLayout";
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 230);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("menu", System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(97)))), ((int)(((byte)(164))))), System.Drawing.Color.White);
            this.TitleText = "��Ϣ";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.tExit});
            this.LeftLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmMessage_LeftLayoutItemClick);
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.TitleImageClick += new System.EventHandler(this.frmMessage_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmMessage";

        }
        internal Smobiler.Core.Controls.TextBox txtSearchinfo;
        internal Smobiler.Core.Controls.ImageButton btnSearch;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem tExit;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.Label Label1;
        #endregion

    }


}
