using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.FixedAssets.NootBooks
{
    partial class frmNBRecordMain : Smobiler.Core.MobileForm
    {

        #region ""
        //��ҳ��
        public int pagesCount = 0;
        //��ǰҳ(�ڶ�ҳ��ʼ)
        public int pageIndex = 0;
        //��ǰҳ��ʾ����
        public int pagesize = 5;
        //������
        public int recordCount = 0;
        internal string NB_EQNO;
        #endregion
        internal string NBSN;

        /// <summary>
        /// ��ʼ������������
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pagesCount =1;
                pageIndex = 0;
                TitleText = "E530 L_x0035";
                DataTable table = GetNootBooksRData();
                if (table.Rows.Count > 0)
                {
                    this.GridView1.DataSource = table;
                    this.GridView1.DataBind();
                }
                else
                {
                    this.GridView1.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ��ȡ�ʼǱ�ʹ�ü�¼
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetNootBooksRData()
        {
            COMSSmobilerDemo.common.NBRecordInfo NBRecordInfo = new COMSSmobilerDemo.common.NBRecordInfo();
            DataTable table = NBRecordInfo.GetNBData();
            return table;
        }


        private void frmNBRecordMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (e.Name.Equals(add.Name))
            {
                frmNBRecordCreate frm = new frmNBRecordCreate();
                frm.NB_EQNO = NB_EQNO;
                Redirect(frm, (MobileForm form, object args) =>
                {
                    try
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            ShowResult = Smobiler.Core.ShowResult.Yes;
                            Bind();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        private void frmNBRecordMain_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNBRecordMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_DownSlippling(object sender, EventArgs e)
        {
            Toast("�����Ѽ������!", ToastLength.SHORT);
        }

        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_UpSlippling(object sender, EventArgs e)
        {
            try
            {
                pageIndex += 1;
                if (pageIndex < pagesCount)
                {
                    DataTable table = GetNootBooksRData();
                    if (table.Rows.Count > 0)
                    {
                        this.GridView1.AddData(table);
                    }
                }
                else
                {
                    Toast("�����Ѽ������!", ToastLength.SHORT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// GridView����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string ID = e.Cell.Items["lblID"].Value.ToString ();
                frmNBRecordDetail frm = new frmNBRecordDetail();
                frm.ID = ID;
                Redirect(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNBRecordMain_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}