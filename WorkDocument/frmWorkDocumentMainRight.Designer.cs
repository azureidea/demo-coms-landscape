using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.WorkDocument
{
    public partial class frmWorkDocumentMainRight : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmWorkDocumentMainRight()
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
            this.btnAllWorkD = new Smobiler.Core.Controls.Button();
            this.btntotalDay1 = new Smobiler.Core.Controls.Button();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.btnAllWorkD1 = new Smobiler.Core.Controls.Button();
            this.btntotalDay = new Smobiler.Core.Controls.Button();
            // 
            // btnAllWorkD
            // 
            this.btnAllWorkD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAllWorkD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAllWorkD.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAllWorkD.HoverBackColor = System.Drawing.Color.White;
            this.btnAllWorkD.HoverForeColor = System.Drawing.Color.White;
            this.btnAllWorkD.Name = "btnAllWorkD";
            this.btnAllWorkD.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnAllWorkD.Size = new System.Drawing.Size(75, 35);
            this.btnAllWorkD.TabIndex = 3;
            this.btnAllWorkD.Text = "���й���";
            this.btnAllWorkD.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // btntotalDay1
            // 
            this.btntotalDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalDay1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalDay1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btntotalDay1.HoverBackColor = System.Drawing.Color.White;
            this.btntotalDay1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btntotalDay1.Location = new System.Drawing.Point(298, 0);
            this.btntotalDay1.Name = "btntotalDay1";
            this.btntotalDay1.Size = new System.Drawing.Size(202, 35);
            this.btntotalDay1.TabIndex = 4;
            this.btntotalDay1.Text = "0";
            this.btntotalDay1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // GridView1
            // 
            this.GridView1.Layout = "frmWorkDocumentRightLayout";
            this.GridView1.Location = new System.Drawing.Point(0, 35);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(500, 195);
            this.GridView1.TabIndex = 5;
            this.GridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.GridView1_ItemClick);
            // 
            // btnAllWorkD1
            // 
            this.btnAllWorkD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAllWorkD1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllWorkD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAllWorkD1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAllWorkD1.HoverBackColor = System.Drawing.Color.White;
            this.btnAllWorkD1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAllWorkD1.Location = new System.Drawing.Point(75, 0);
            this.btnAllWorkD1.Name = "btnAllWorkD1";
            this.btnAllWorkD1.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnAllWorkD1.Size = new System.Drawing.Size(173, 35);
            this.btnAllWorkD1.TabIndex = 6;
            this.btnAllWorkD1.Text = "��0��";
            this.btnAllWorkD1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // btntotalDay
            // 
            this.btntotalDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntotalDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntotalDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btntotalDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntotalDay.HoverBackColor = System.Drawing.Color.White;
            this.btntotalDay.HoverForeColor = System.Drawing.Color.White;
            this.btntotalDay.Location = new System.Drawing.Point(248, 0);
            this.btntotalDay.Name = "btntotalDay";
            this.btntotalDay.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntotalDay.Size = new System.Drawing.Size(50, 35);
            this.btntotalDay.TabIndex = 7;
            this.btntotalDay.Text = "�ܼƣ�";
            this.btntotalDay.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntotalDay_Click);
            // 
            // frmWorkDocumentMainRight
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAllWorkD,
            this.btntotalDay1,
            this.GridView1,
            this.btnAllWorkD1,
            this.btntotalDay});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 230);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "����ɸѡ";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmWorkDocumentMainRight_Load);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmWorkDocumentMainRight";

        }
        internal Smobiler.Core.Controls.Button btnAllWorkD;
        internal Smobiler.Core.Controls.Button btntotalDay1;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.Button btnAllWorkD1;
        internal Smobiler.Core.Controls.Button btntotalDay;

        #endregion

    }
}
