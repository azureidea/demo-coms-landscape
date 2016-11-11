using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Text.RegularExpressions;
using System.Data;

namespace COMSSmobilerDemo
{
    partial class frmInfoEdit : Smobiler.Core.MobileForm
    {
        Int32 sex;
        /// <summary>
        /// ͷ���ϴ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imguser_Click(object sender, EventArgs e)
        {
            try
            {
                this.Camera1.GetPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// ����ͷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryData e)
        {
            try
            {
                if (System.String.IsNullOrEmpty(e.ResourceID) == false)
                {
                    string filename ="Demo.png";
                    e.SaveFile(filename);
                    imguser.ResourceID = filename;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// ��֤�ֻ�����͵绰�����Ƿ���ȷ
        /// </summary>
        /// <remarks></remarks>
        private void valiPhoneorTel()
        {
            try
            {
                if (txtTel.Text.Trim().Length > 0)
                {
                    string tels = txtTel.Text.Trim();
                    foreach (string t1 in tels.Split(new char[] { ',' }))
                    {
                        if (t1.Trim().Length > 0)
                        {
                            //����ֻ������Ƿ�����ȷ��
                            Regex r = new Regex("((\\d{11})|^((\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1})|(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1}))$)");
                            if (r.IsMatch(t1) == false)
                                throw new Exception("�ֻ�����" + t1.ToString() + "��д�������顣");
                        }
                    }

                }
                //���绰�����Ƿ�����ȷ��
                if (txtPhone.Text.Trim().Length > 0)
                {
                    string phones = txtPhone.Text.Trim();
                    foreach (string p1 in phones.Split(new char[] {','}))
                    {
                        if (p1.Trim().Length > 0)
                        {
                            Regex r = new Regex("((\\d{11})|^((\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})|(\\d{4}|\\d{3})-(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1})|(\\d{7,8})-(\\d{4}|\\d{3}|\\d{2}|\\d{1}))$)");
                            if (r.IsMatch(p1) == false)
                                throw new Exception("�绰����" + p1.Trim().Length.ToString() + "��д�������顣");
                        }
                    }
                }
                if (txtEmail.Text.Trim().Length > 0)
                {
                    string Emails = txtEmail.Text.Trim();
                    if (System.Text.RegularExpressions.Regex.IsMatch(Emails, "^(?(\")(\".+?\"@)|(([0-9a-zA-Z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-zA-Z])@))" + "(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,6}))$") == false)
                    {
                        throw new Exception("�����ʼ�" + Emails + "��д�������顣");
                    }
                }
            }
            catch (Exception ex)
            {
                throw  ex ;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInfoEdit_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            try
            {
                valiPhoneorTel();
                MessageBox.Show("������Ϣ���޸ı��棡");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmInfoEdit_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Demo";
            txtUserName.Text = "�����û�";
            imguser.ResourceID = "Demo";
            sex = 0;
            btnSex.Text = "��";
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            PopList1.Groups.Clear();
            DataTable table = new DataTable();
            PopListGroup poli = new PopListGroup();
            PopList1.Groups.Add(poli);
            poli.Text = "�Ա�";
            table.Columns.Add("sex", typeof(System.Int32 ));
            table.Columns.Add("sexDesc", typeof(System.String));
            table.Rows.Add(0, "��");
            table.Rows.Add(1, "Ů");
            foreach (DataRow rowli in table.Rows)
            {
                poli.Items.Add(rowli["sexDesc"].ToString(), rowli["sex"].ToString());

                if (sex.ToString().Length > 0)
                {
                    if (sex.Equals(rowli["sex"]))
                    {
                        PopList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            PopList1.ShowDialog();

        }

        private void PopList1_Selected(object sender, EventArgs e)
        {
            if (PopList1.Selection != null)
            {
                sex = int.Parse(PopList1.Selection.Value);
                this.btnSex .Text = PopList1.Selection.Text.Trim();
            }
          
        }
        private DateTime taosttime;
        private bool handleExit = false;
        private void MobileForm_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            if (handleExit == true && taosttime.AddSeconds(3) >= DateTime.Now)
            {
                handleExit = false;
                this.Close();
            }
            else
            {
                handleExit = true;
                taosttime = DateTime.Now;
                this.Toast("�ٰ�һ���˳�����", ToastLength.SHORT);
            }
        }

        private void frmInfoEdit_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
    }
}