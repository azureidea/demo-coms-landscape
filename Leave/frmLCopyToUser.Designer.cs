using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLCopyToUser : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLCopyToUser()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.CopyTo = new Smobiler.Core.Controls.ToolbarItem();
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmLCopyToUserLayout";
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(500, 230);
            this.GridView1.TabIndex = 2;
            // 
            // CopyTo
            // 
            this.CopyTo.IconID = "!\\ue2bc043146223";
            this.CopyTo.Name = "CopyTo";
            this.CopyTo.SelectIconID = "!\\ue2bc043146223";
            this.CopyTo.Text = "����";
            // 
            // frmLCopyToUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 230);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "������Ա";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.CopyTo});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmLCopyToUser_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLCopyToUser_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmLCopyToUser_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmLCopyToUser";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem CopyTo;
        #endregion

    }
}
