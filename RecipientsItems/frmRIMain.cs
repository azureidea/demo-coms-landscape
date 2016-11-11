using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.RecipientsItems
{
    partial class frmRIMain : Smobiler.Core.MobileForm
    {

        #region ""
        //��ҳ��
        public int pagesCount = 0;
        //��ǰҳ(�ڶ�ҳ��ʼ)
        public int pageIndex = 0;
        //��ǰҳ��ʾ����
        public int pagesize = 3;
        //������
        public int recordCount = 0;
        #endregion
        /// <summary>
        /// ��ʼ������������
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                pageIndex = 0;
                pagesCount = 2;
                DataTable table = GetRItemsData();
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
        /// ��ȡ��ά��¼
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private DataTable GetRItemsData()
        {
            COMSSmobilerDemo.common.RecipientsItemsInfo frmRItems = new COMSSmobilerDemo.common.RecipientsItemsInfo();
            DataTable table = frmRItems.GetRItemsData(pageIndex, pagesize);
            return table;
        }

       
        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRIMain_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// gridview����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string RitemNO = e.Cell.Items["lblID"].Value.ToString();
                frmRIDetail frm = new frmRIDetail();
                frm.NO = RitemNO;
                this.Redirect(frm, (MobileForm form, object args) =>
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
                    DataTable table = GetRItemsData();
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
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRIMain_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRIMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        private void frmRIMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "add":
                    frmRICreate frm = new frmRICreate();
                    this.Redirect(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            Bind();
                        }
                    });
                    break;
            }
        }
    }
}