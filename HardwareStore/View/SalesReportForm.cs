using HardwareStore.BusinessLogic;
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
            UpdateGrid();
            DesignConfigurator();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.TotalLbl.Text = $"{this.DailySalesList.Sum(a => a.Total):f2} лв";
        }



        private void UpdateGrid()
        {
            this.DailySalesList = new List<DailySales>();
            this.DailySalesList = this.UpdateCreateSalesReport.SalesReprotInfo();
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
            SalesReportDataGrid.BackgroundColor = Color.White;
            SalesReportDataGrid.EnableHeadersVisualStyles = false;
            SalesReportDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

    }
}
