using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRIDetail : Smobiler.Core.MobileForm
    {
        public string NO = "";//��ά���
        private void frmRIDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmRIDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRIDetail_Load(object sender, EventArgs e)
        {
            lblITEM_NAME.Text = "��ԡ¶";
            lblITEM_QTY.Text = "1";
            lblITEM_DATE.Text =DateTime .Now .ToShortDateString() ;
            lblITEM_USER.Text ="Demo";
            lblITEM_NOTE.Text ="���·��ͱ�";
            imgITEM_SIGNATURE.ResourceID = "";
        }
    }
}