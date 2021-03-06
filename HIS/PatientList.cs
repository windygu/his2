﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HIS.common;
using HIS.patient;
//using BusinessObject;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace HIS
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            //加载UltarGrid样式
            this.ugGrid.DisplayLayout.LoadFromXml(System.IO.Path.GetFullPath(Application.StartupPath + @"\UltragridStyle.xml"));

            LoadBucterList();

        }

        private void LoadBucterList()
        {
            List<double> outValue = new List<double>();//输出统计数
            DataSet ds = new DataSet();
             
            //PatientObject po = new PatientObject();
            Maticsoft.BLL.Patient bll = new Maticsoft.BLL.Patient();

            int startIndex = (pagination1.CurrentPage - 1) * pagination1.PageSize;
            int endIndex = pagination1.PageSize * pagination1.CurrentPage-1;
            ds = bll.GetListByPage("", "", startIndex, endIndex);
            ugGrid.DataSource = ds;
            ugGrid.DataBind();

            pagination1.RecordCount = bll.GetRecordCount("");
            //if (outValue != null && outValue.Count != 0)
            //{
            //    pagination1.RecordCount = Convert.ToInt32(outValue[0]);//记录数
            //    this.pagination1.StaticInfo = ugGrid.DisplayLayout.Bands[0].Columns["ANIMALAMOUNT"].Header.Caption + outValue[1].ToString() //检疫数
            //                                  + " " + ugGrid.DisplayLayout.Bands[0].Columns["AMOUNT"].Header.Caption + outValue[2].ToString() //进场数
            //                                  + " " + ugGrid.DisplayLayout.Bands[0].Columns["BUTCHERNUM"].Header.Caption + outValue[3].ToString() //屠宰数
            //                                  + " " + ugGrid.DisplayLayout.Bands[0].Columns["PRODUCTNUM"].Header.Caption + outValue[4].ToString(); //出厂数
            //}
            //else
            //{
            //    pagination1.RecordCount = 0;
            //}
        }

        private void ugGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            // Turn on row filtering functionality.
            e.Layout.Override.AllowRowFiltering = DefaultableBoolean.False;

            // Specifies whether to filter all rows in band or the sibling rows.
            e.Layout.Override.RowFilterMode = RowFilterMode.AllRowsInBand;

            // The action to take on rows that fail the filter criteria.
            e.Layout.Override.RowFilterAction = RowFilterAction.AppearancesOnly;

            // Setup various appearances that will be applied to rows that
            // are filtered in (ones that pass the filter criteria).
            e.Layout.Override.FilteredInRowAppearance.BackColor = Color.Blue;
            e.Layout.Override.FilteredInCellAppearance.ForeColor = Color.Yellow;

            // Setup various appearances that will be applied to rows that
            // are filtered out (ones that fail the filter criteria).
            e.Layout.Override.FilteredOutRowAppearance.BackColor = SystemColors.ControlLight;
            e.Layout.Override.FilteredOutCellAppearance.ForeColor = SystemColors.ControlDarkDark;
        }

        private void ugGrid_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            if (ugGrid.Rows.Count == 0)
            {
                return;
            }
            if (ugGrid.ActiveRow.IsFilterRow)
            {
                return;
            }
            if (this.ugGrid.ActiveRow.Cells["ID"].Value == DBNull.Value)
            {
                return;
            }

            //PatientEdit openDialog = new PatientEdit(1, ugGrid.ActiveRow.Cells["ID"].Value.ToString());
            //openDialog.ShowDialog();
            //if (openDialog.DialogResult == DialogResult.OK)
            //{
            //    LoadBucterList();
            //}
            DetailInfo openDialog = new DetailInfo(OperateType.VIew, int.Parse(ugGrid.ActiveRow.Cells["ID"].Value.ToString()));
             
            openDialog.StartPosition = FormStartPosition.CenterScreen;
            openDialog.ShowDialog(); 
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            PatientEdit openDialog = new PatientEdit(0, "");
            //Butcher_EnterregisterDetail openDialog = new Butcher_EnterregisterDetail(0, 0, "");
            openDialog.ShowDialog();
            if (openDialog.DialogResult == DialogResult.OK)
            {
                LoadBucterList();
            }
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            if (ugGrid.Rows.Count == 0)
            {
                return;
            }
            if (ugGrid.ActiveRow.IsFilterRow)
            {
                return;
            }
            if (this.ugGrid.ActiveRow.Cells["ID"].Value == DBNull.Value)
            {
                return;
            }

            PatientEdit openDialog = new PatientEdit(1, ugGrid.ActiveRow.Cells["ID"].Value.ToString());
            openDialog.ShowDialog();
            if (openDialog.DialogResult == DialogResult.OK)
            {
                LoadBucterList();
            }
        }

        private void pagination1_Paging()
        {
            LoadBucterList();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.pagination1.CurrentPage = 1;
            LoadBucterList();
        }

        private void pagination1_Load(object sender, EventArgs e)
        {

        }

        private void PatientList_Load(object sender, EventArgs e)
        {

        }

        

       
        
    }
}
