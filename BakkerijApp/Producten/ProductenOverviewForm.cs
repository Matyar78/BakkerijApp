using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entity;

namespace BakkerijApp.ProductenForms
{
    public partial class ProductenOverviewForm : Form
    {
        private IList<Product> productenList;
        private int selectedId;
        private DataRepository repository;

        public ProductenOverviewForm()
        {
            InitializeComponent();
            dataGridViewProducten.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            repository = new DataRepository();
            BindData();
        }

        private void cmdAddKlant_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.Tag = this;
            newProductForm.Show(this);
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }

        private void BindData()
        {
            productenList = repository.GetProducten();
            dataGridViewProducten.DataSource = productenList;            
        }

        public void RefreshData()
        {
            BindData();
            dataGridViewProducten.Refresh();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewProducten.SelectedRows.Count;
            if (rowsCount == 1)
            {
                try
                {
                    var row = dataGridViewProducten.SelectedRows[0];
                    string id = row.Cells[0].Value.ToString();
                    selectedId = int.Parse(id);
                    cmdDelete.Enabled = true;
                    cmdEdit.Enabled = true;
                }
                catch (Exception ex)
                {
                    cmdDelete.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                DisableButtons();
            }                
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                repository.DeleteKlant(selectedId);
                RefreshData();
                DisableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Product product = repository.GetProductById(selectedId);
            NewProductForm newProductForm = new NewProductForm(product);
            newProductForm.Tag = this;
            newProductForm.Show(this);
            DisableButtons();
        }

        private void DisableButtons()
        {
            cmdEdit.Enabled = false;
            cmdDelete.Enabled = false;
        }

        private void KlantenOverviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
        }
    }
}
