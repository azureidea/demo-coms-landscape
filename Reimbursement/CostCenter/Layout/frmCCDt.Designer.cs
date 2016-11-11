
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
using Smobiler.Core.Controls;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
public partial class frmCCDt : Smobiler.Core.MobileForm
{

    #region "VTForm Designer generated code "

    public frmCCDt()
        : base()
    {

        //This call is required by the VTForm Designer.
        InitializeComponent();

        //Add any initialization after the InitializeComponent() call

    }

    //VTForm overrides dispose to clean up the component list.
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }


    //NOTE: The following procedure is required by the VTForm Designer
    //It can be modified using the VTForm Designer.  
    //Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
            this.lblRB_COSTCENTER = new Smobiler.Core.Controls.Label();
            this.Line6 = new Smobiler.Core.Controls.Line();
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.lblCC_USER = new Smobiler.Core.Controls.Label();
            // 
            // lblRB_COSTCENTER
            // 
            this.lblRB_COSTCENTER.DataMember = "CC_NAME";
            this.lblRB_COSTCENTER.DisplayMember = "CC_NAME";
            this.lblRB_COSTCENTER.FontSize = 13F;
            this.lblRB_COSTCENTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblRB_COSTCENTER.Location = new System.Drawing.Point(0, 30);
            this.lblRB_COSTCENTER.Name = "lblRB_COSTCENTER";
            this.lblRB_COSTCENTER.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblRB_COSTCENTER.Size = new System.Drawing.Size(500, 20);
            this.lblRB_COSTCENTER.TabIndex = 6;
            this.lblRB_COSTCENTER.ZIndex = 3;
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line6.Location = new System.Drawing.Point(0, 50);
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.Size(500, 3);
            this.Line6.TabIndex = 7;
            this.Line6.ZIndex = 4;
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "CC_ID";
            this.lblCC_ID.DisplayMember = "CC_ID";
            this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.Size(150, 30);
            this.lblCC_ID.TabIndex = 8;
            this.lblCC_ID.ZIndex = 1;
            // 
            // lblCC_USER
            // 
            this.lblCC_USER.DataMember = "CC_USER";
            this.lblCC_USER.DisplayMember = "CC_USER";
            this.lblCC_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_USER.Location = new System.Drawing.Point(150, 0);
            this.lblCC_USER.Name = "lblCC_USER";
            this.lblCC_USER.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblCC_USER.Size = new System.Drawing.Size(350, 30);
            this.lblCC_USER.TabIndex = 9;
            this.lblCC_USER.ZIndex = 2;
            // 
            // frmCCDt
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.lblCC_USER,
            this.lblRB_COSTCENTER,
            this.Line6});
            this.Size = new System.Drawing.Size(500, 50);
            this.Name = "frmCCDt";

    }
    internal Smobiler.Core.Controls.Label lblRB_COSTCENTER;
    internal Smobiler.Core.Controls.Line Line6;
    internal Smobiler.Core.Controls.Label lblCC_ID;
    internal Smobiler.Core.Controls.Label lblCC_USER;
    #endregion

}
}
