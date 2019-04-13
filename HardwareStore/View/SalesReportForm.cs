﻿using HardwareStore.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class SalesReportForm : Form
    {
        UpdateCreateSalesReportBLL UpdateCreateSalesReport;
        List<DailySales> DailySalesList;

        public SalesReportForm()
        {
            InitializeComponent();
            this.UpdateCreateSalesReport = new UpdateCreateSalesReportBLL();
            DailySalesReport(); //Updates the DataGrid
            DesignConfigurator(); //Improves The design of the DataGrid
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables Resizing
            this.SalesReportComboBox.Text = this.SalesReportComboBox.Items[2].ToString();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.TotalLbl.Text = $"{this.DailySalesList.Sum(a => a.Total):f2} лв";//Returns the Total money of the day
            this.ProfitLBL.Text = $"{this.UpdateCreateSalesReport.GenerateProfitOfTheDay(this.DailySalesList):f2} лв";
        }

        private void DailySalesReport()
        {
            this.DailySalesList = new List<DailySales>();
            this.DailySalesList = this.UpdateCreateSalesReport.DailySalesReprotInfo();
            SalesReportDataGrid.DataSource = DailySalesList;
            SalesReportDataGrid.ReadOnly = true;
            SalesReportDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MonthlySalesReport()
        {
            this.DailySalesList = new List<DailySales>();
            this.DailySalesList = this.UpdateCreateSalesReport.MonthlySalesReprotInfo();
            SalesReportDataGrid.DataSource = DailySalesList;
            SalesReportDataGrid.ReadOnly = true;
            SalesReportDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void YearlySalesReport()
        {
            this.DailySalesList = new List<DailySales>();
            this.DailySalesList = this.UpdateCreateSalesReport.YearlySalesReprotInfo();
            SalesReportDataGrid.DataSource = DailySalesList;
            SalesReportDataGrid.ReadOnly = true;
            SalesReportDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DesignConfigurator()
        {
            SalesReportDataGrid.BorderStyle = BorderStyle.None;
            SalesReportDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            SalesReportDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalesReportDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            SalesReportDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            SalesReportDataGrid.EnableHeadersVisualStyles = false;
            SalesReportDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SalesReportDataGrid.Font = new Font("Arial", 16);
            SalesReportDataGrid.RowTemplate.Height = 40;
        }

        private void SalesReportComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
             var SelectedIndex =this.SalesReportComboBox.SelectedIndex;

            if (this.SalesReportComboBox.Items[SelectedIndex]== this.SalesReportComboBox.Items[2])
            {
                DailySalesReport();
                ChangeLabelText("Today","Day");

            }
            else if (this.SalesReportComboBox.Items[SelectedIndex] == this.SalesReportComboBox.Items[1])
            {
                MonthlySalesReport();
                ChangeLabelText("Of The Month", "Month");
            }
            else
            {
                YearlySalesReport();
                ChangeLabelText("Of The Year", "Year");
            }
            UpdateLabels();
        }
        private void ChangeLabelText(string First,string Second)
        {
            this.GrantTotalLbl.Text = $"Grand Total {First}";
            this.DailyProfitLbl.Text = $"Profit Of The {Second}";
        }
    }
}
