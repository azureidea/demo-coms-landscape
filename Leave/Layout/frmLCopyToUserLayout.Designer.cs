using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave.Layout
{
    public partial class frmLCopyToUserLayout : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLCopyToUserLayout()
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
            this.lblUSER_ID = new Smobiler.Core.Controls.Label();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.checkUser = new Smobiler.Core.Controls.CheckBox();
            this.lblUSER_NAME = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblUSER_ID
            // 
            this.lblUSER_ID.DataMember = "USER_ID";
            this.lblUSER_ID.DisplayMember = "USER_ID";
            this.lblUSER_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUSER_ID.Location = new System.Drawing.Point(55, 0);
            this.lblUSER_ID.Name = "lblUSER_ID";
            this.lblUSER_ID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUSER_ID.Size = new System.Drawing.Size(405, 30);
            this.lblUSER_ID.TabIndex = 3;
            this.lblUSER_ID.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lblUSER_ID.ZIndex = 2;
            // 
            // Image1
            // 
            this.Image1.Border = new Smobiler.Core.Border(1);
            this.Image1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Image1.BorderRadius = 10;
            this.Image1.DataMember = "USER_ID";
            this.Image1.DisplayMember = "USER_ID";
            this.Image1.ID = "";
            this.Image1.Location = new System.Drawing.Point(5, 3);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(44, 45);
            this.Image1.TabIndex = 5;
            this.Image1.ZIndex = 1;
            // 
            // checkUser
            // 
            this.checkUser.Border = new Smobiler.Core.Border(1);
            this.checkUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.checkUser.BorderRadius = 4;
            this.checkUser.Checked = false;
            this.checkUser.CheckedBackColor = System.Drawing.Color.White;
            this.checkUser.CheckedColor = System.Drawing.Color.DeepSkyBlue;
            this.checkUser.Location = new System.Drawing.Point(460, 12);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(25, 25);
            this.checkUser.TabIndex = 6;
            this.checkUser.UnCheckedBackColor = System.Drawing.Color.White;
            this.checkUser.ZIndex = 4;
            // 
            // lblUSER_NAME
            // 
            this.lblUSER_NAME.DataMember = "USER_NAME";
            this.lblUSER_NAME.DisplayMember = "USER_NAME";
            this.lblUSER_NAME.FontSize = 13F;
            this.lblUSER_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblUSER_NAME.Location = new System.Drawing.Point(55, 30);
            this.lblUSER_NAME.Name = "lblUSER_NAME";
            this.lblUSER_NAME.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblUSER_NAME.Size = new System.Drawing.Size(405, 20);
            this.lblUSER_NAME.TabIndex = 7;
            this.lblUSER_NAME.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 50);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(500, 3);
            this.Line1.TabIndex = 8;
            this.Line1.ZIndex = 5;
            // 
            // frmLCopyToUserLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1,
            this.lblUSER_ID,
            this.lblUSER_NAME,
            this.checkUser,
            this.Line1});
            this.Size = new System.Drawing.Size(500, 50);
            this.Name = "frmLCopyToUserLayout";

        }
        internal Smobiler.Core.Controls.Label lblUSER_ID;
        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.CheckBox checkUser;
        internal Smobiler.Core.Controls.Label lblUSER_NAME;
        internal Smobiler.Core.Controls.Line Line1;
        #endregion

    }
}
