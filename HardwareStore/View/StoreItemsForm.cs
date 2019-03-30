using HardwareStore.BusinessLogic;
using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class StoreItemsForm : Form
    {
        UpdateCreateSalesReportBLL UpdateCreateSalesReport;
        NewItemForm NewItemForm;
        Items item = new Items();

        public StoreItemsForm()
        {
            InitializeComponent();
            this.UpdateCreateSalesReport = new UpdateCreateSalesReportBLL();
            UpdateGrid();
            DesignConfigurator();
        }

        private void DesignConfigurator()
        {
            ItemsGridView.BorderStyle = BorderStyle.None;
            ItemsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ItemsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ItemsGridView.BackgroundColor = Color.White;
            ItemsGridView.EnableHeadersVisualStyles = false;
            ItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            var form1 = new NewItemForm();
            form1.ShowDialog();
        }

        private void UpdateGrid()
        {
            ItemsGridView.DataSource = this.UpdateCreateSalesReport.GetAllInfo();
            ItemsGridView.ReadOnly = true;
            ItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsGridView.Columns[ItemsGridView.ColumnCount - 1].Visible = false;

        }


        private void UpdateBut_Click(object sender, EventArgs e)
        {
            if (ItemsGridView.SelectedRows.Count > 0)
            {
                var item = ItemsGridView.SelectedRows[0].Cells;
                var id = item[0].Value.ToString();
                Items Item = this.UpdateCreateSalesReport.GetAllInfo().First(a => a.Id == id);
                this.item = Item;
                this.NewItemForm = new NewItemForm(Item);
                NewItemForm.Hide();
                this.NewItemForm.ShowDialog();
                this.Close();
            }

        }
        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.NewItemForm = new NewItemForm();
            NewItemForm.Show();
        }


        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (ItemsGridView.SelectedRows.Count > 0)
            {
                var item = ItemsGridView.SelectedRows[0].Cells;
                var id = item[0].Value.ToString();
                this.UpdateCreateSalesReport.Delete(id);

            }
            UpdateGrid();
        }

        private void StoreItemsForm_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void StoreItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
