using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace COMSSmobilerDemo.Reimbursement.RB
{
    partial class frmStatementAnalysis : Smobiler.Core.MobileForm
    {

        public int Mode;

        private MobileControl chartObj = null;
        private void TextTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            if (chartObj != null)
            {
                this.Controls.Remove(chartObj);
                chartObj = null;
            }
            Bind();
        }

        private void frmStatementAnalysis_Load(object sender, EventArgs e)
        {
            TextTabBar1.SelectItemIndex = 0;
            Bind();
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
{
	try {
		COMSSmobilerDemo.common.ReimbursementInfo ReimbursementInfo = new COMSSmobilerDemo.common.ReimbursementInfo();
		switch (Mode) {
			case 1:
				TitleText = "���Ѽ�¼�·����Ʒ���";
				DataTable table = new DataTable();
				switch (TextTabBar1.SelectItemIndex) {
					case 0:
						//���� �������·�ͳ��
                        TextTabBar2.Visible = false;
                        table = ReimbursementInfo.GetSanalysis(TextTabBar1.SelectItemIndex, "xiaofei");
						this.GridView1.Rows.Clear();
						this.GridView1.DataSource = table;
						this.GridView1.DataBind();
                        //����BarChart
						BarChart BarChart1 = new BarChart();
						chartObj = BarChart1;
						BarChart1.Size = new System.Drawing.Size(450, 250);
                        BarChart1.Location = new System.Drawing.Point(25, 63);
						BarChart1.XAxisLabelMember = "XMember";
						BarChart1.YAxisValueMember = "YMember";
						this.Controls.Add(BarChart1);
                        if (table.Rows.Count > 0) {
						System.Data.DataTable matTable = new DataTable();
						matTable.Columns.Add("XMember", typeof(string));
						matTable.Columns.Add("YMember", typeof(int));
						foreach (GridViewRow ROW in GridView1.Rows)
                        {
							string XMember = ROW.Cell.Items["lblName"].Value .ToString ();
							decimal YMember = Convert .ToDecimal (ROW.Cell.Items["lblAmount"].Value);
							matTable.Rows.Add(XMember, YMember);
						}
						    BarChart1.DataSource = matTable;
						    BarChart1.DataBind();
						} 
                        else 
                        {
							this.GridView1.Rows.Clear();
						}
						break;
					case 1:
						//�ֲ� ����������ͳ��
                        TextTabBar2.Visible = true;
						TitleText = "���Ѽ�¼���Ʒ���";
                        table = ReimbursementInfo.GetSanalysis(TextTabBar1.SelectItemIndex, "xiaofei");
						this.GridView1.Rows.Clear();
						this.GridView1.DataSource = table;
						this.GridView1.DataBind();
                        if (table.Rows.Count > 0)
                        {
                            switch (TextTabBar2.SelectItemIndex)
                            {
                                case 0:
                                    //����BubbleChart
							    BubbleChart BubbleChart1 = new BubbleChart();
							    chartObj = BubbleChart1;
							    BubbleChart1.Size = new System.Drawing.Size(450, 225);
                                BubbleChart1.Location = new System.Drawing.Point(25, 80);
							    BubbleChart1.XAxisLabelMember = "XMember";
							    BubbleChart1.YAxisValueMember = "YMember";
							    this.Controls.Add(BubbleChart1);
                           
							    DataTable matTable = new DataTable();
							    matTable.Columns.Add("XMember", typeof(string));
							    matTable.Columns.Add("YMember", typeof(int));
							    foreach (GridViewRow ROW in GridView1.Rows) 
                                {
                                    string XMember = ROW.Cell.Items["lblName"].Value.ToString();
                                    decimal YMember = Convert.ToDecimal(ROW.Cell.Items["lblAmount"].Value);
								    matTable.Rows.Add(XMember, YMember);
							    }
							    BubbleChart1.DataSource = matTable;
							    BubbleChart1.DataBind();
                                break;
                                case 1:
                                //����ScatterChart
                                ScatterChart ScatterChart1 = new ScatterChart();
                                chartObj = ScatterChart1;
                                ScatterChart1.Size = new System.Drawing.Size(450, 225);
                                ScatterChart1.Location = new System.Drawing.Point(25, 80);
                                ScatterChart1.SeriesMember = "XMember";
                                ScatterChart1.SeriesShapMember = "Shape";
                                ScatterChart1.XAxisLabelMember = "XMember";
                                ScatterChart1.YAxisValueMember = "YMember";
                                Controls.Add(ScatterChart1);
                               
                                DataTable matTable2 = new DataTable();
                                matTable2.Columns.Add("XMember", typeof(string));
                                matTable2.Columns.Add("YMember", typeof(int));
                                matTable2.Columns.Add("Shape", typeof(int));
                                int Shape = 0;
                                foreach (GridViewRow ROW in GridView1.Rows)
                                {
                                    string XMember = ROW.Cell.Items["lblName"].Value.ToString();
                                    decimal YMember = Convert.ToDecimal(ROW.Cell.Items["lblAmount"].Value);
                                    matTable2.Rows.Add(XMember, YMember, Shape);
                                    if (Shape<=4)
                                    {
                                        Shape += 1;
                                    }
                                    else {
                                         Shape = 0;
                                    }
                                }
                                ScatterChart1.DataSource = matTable2;
                                ScatterChart1.DataBind();
                                break;
                                case 2:
                                //����RadarChart
                                RadarChart RadarChart1 = new RadarChart();
                                chartObj = RadarChart1;
                                RadarChart1.Size = new System.Drawing.Size(450, 225);
                                RadarChart1.Location = new System.Drawing.Point(25, 80);
                                RadarChart1.SeriesMember = "XMember";
                                RadarChart1.XAxisLabelMember = "XMember";
                                RadarChart1.YAxisValueMember = "YMember";
                                this.Controls.Add(RadarChart1);

                                DataTable matTable3 = new DataTable();
                                matTable3.Columns.Add("XMember", typeof(string));
                                matTable3.Columns.Add("YMember", typeof(int));
                                foreach (GridViewRow ROW in GridView1.Rows)
                                {
                                    string XMember = ROW.Cell.Items["lblName"].Value.ToString();
                                    decimal YMember = Convert.ToDecimal(ROW.Cell.Items["lblAmount"].Value);
                                    matTable3.Rows.Add(XMember, YMember);
                                }
                                RadarChart1.DataSource = matTable3;
                                RadarChart1.DataBind();
                                break;
                              }
                        }
                            else {
							this.GridView1.Rows.Clear();
						}
						break;
				}

				break;
			case 2:
				switch (TextTabBar1.SelectItemIndex) {
					case 0:
                        TextTabBar2.Visible = false;
						//���� �������·�ͳ��
                        table = ReimbursementInfo.GetSanalysis(TextTabBar1.SelectItemIndex, "baoxiao");
						this.GridView1.Rows.Clear();
						this.GridView1.DataSource = table;
						this.GridView1.DataBind();

                        //����LineChart
						LineChart LineChart1 = new LineChart();
						chartObj = LineChart1;
                        LineChart1.Size = new System.Drawing.Size(450, 250);
                        LineChart1.Location = new System.Drawing.Point(25, 63);
						LineChart1.XAxisLabelMember = "XMember";
						LineChart1.YAxisValueMember = "YMember";
						this.Controls.Add(LineChart1);
                        if (table.Rows.Count > 0) 
                        {
							DataTable matTable = new DataTable();
							matTable.Columns.Add("XMember", typeof(string));
							matTable.Columns.Add("YMember", typeof(int));
							foreach (GridViewRow ROW in GridView1.Rows) 
                            {
                                string XMember = ROW.Cell.Items["lblName"].Value.ToString();
                                decimal YMember = Convert.ToDecimal(ROW.Cell.Items["lblAmount"].Value);
								matTable.Rows.Add(XMember, YMember);
							}
							LineChart1.DataSource = matTable;
							LineChart1.DataBind();
                        }
                        else
                        {
                            this.GridView1.Rows.Clear();
                        }
						break;
					case 1:
						//�ֲ� ������״̬ͳ��
                        table = ReimbursementInfo.GetSanalysis(TextTabBar1.SelectItemIndex, "baoxiao");
						this.GridView1.Rows.Clear();
						this.GridView1.DataSource = table;
						this.GridView1.DataBind();

                        //����PieChart
						PieChart PieChart1 = new PieChart();
						chartObj = PieChart1;

                        PieChart1.Size = new System.Drawing.Size(450, 250);
                        PieChart1.Location = new System.Drawing.Point(25, 63);
						PieChart1.XAxisLabelMember = "XMember";
						PieChart1.YAxisValueMember = "YMember";
						this.Controls.Add(PieChart1);
						//����״̬�ֲ�ͳ�Ʊ�
						if (table.Rows.Count > 0) {
							DataTable matTable = new DataTable();
							matTable.Columns.Add("XMember", typeof(string));
							matTable.Columns.Add("YMember", typeof(int));
							foreach (GridViewRow ROW in GridView1.Rows) {
                                string XMember = ROW.Cell.Items["lblName"].Value.ToString();
                                decimal YMember = Convert.ToDecimal(ROW.Cell.Items["lblAmount"].Value);
								matTable.Rows.Add(XMember, YMember);
							}
							PieChart1.DataSource = matTable;
							PieChart1.DataBind();
						} else {
							this.GridView1.Rows.Clear();
						}
						break;
				}

				break;
		}

	} catch (Exception ex) {
		MessageBox.Show(ex.Message);
	}
}

        private void DatePicker1_DatePicked(object sender, DatePickerEventArgs e)
        {
            Bind();
        }

        private void frmStatementAnalysis_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }

        private void HandleToast()
        {
            this.Close();
        }

        private void frmStatementAnalysis_TitleImageClick(object sender, EventArgs e)
        {
            HandleToast();
        }
        /// <summary>
        /// ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmStatementAnalysis_LeftSlipping(object sender, EventArgs e)
        {
            if (TextTabBar1.SelectItemIndex > 0 & TextTabBar1.SelectItemIndex == 1)
            {
                TextTabBar1.SelectItemIndex = 0;
                if (chartObj != null)
                {
                    this.Controls.Remove(chartObj);
                    chartObj = null;
                }
                Bind();
            }
        }

        /// <summary>
        /// �һ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmStatementAnalysis_RightSlipping(object sender, EventArgs e)
        {
            if (TextTabBar1.SelectItemIndex == 0 & TextTabBar1.SelectItemIndex != 1)
            {
                TextTabBar1.SelectItemIndex = 1;
                if (chartObj != null)
                {
                    this.Controls.Remove(chartObj);
                    chartObj = null;
                }
                Bind();
            }
        }
    }
}