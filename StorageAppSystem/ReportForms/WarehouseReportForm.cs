using Microsoft.EntityFrameworkCore;
using StorageAppSystem.Data;
using StorageAppSystem.Dtos;
using StorageAppSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppSystem.ReportForms
{
    public partial class WarehouseReportForm : Form
    {
        AppDBContext db;
        List<Warehouse> warehouses; 
        public WarehouseReportForm()
        {
            InitializeComponent();
            db = new AppDBContext();
            warehouses = new List<Warehouse>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            warehouses= db.warehouses.ToList();
            var dataWarehouse = warehouses.Select(w => new 
            {
                Id = w.Id,
                Name = w.Name,
                Address = w.Address,
                ManagerName = w.ManagerName
            }).ToList();
            warehousesDataGridView.DataSource = dataWarehouse;
        }

        private void warehousesDataGridView_MouseClick(object sender, EventArgs e)
        {

        }

    }
}
