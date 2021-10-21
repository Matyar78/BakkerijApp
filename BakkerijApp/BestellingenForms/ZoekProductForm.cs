using DataAccessLayer;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BakkerijApp.BestellingenForms
{
    public partial class ZoekProductForm : Form
    {
        private DataRepository repository;
        private IList<Product> producten;

        public ZoekProductForm()
        {
            InitializeComponent();
            repository = new DataRepository();
            producten = repository.GetProducten();
            dataGridViewProducten.DataSource = producten;
        }

        private void txtZoekProducten_KeyUp(object sender, KeyEventArgs e)
        {
            producten = repository.SearchProductsByIdOrName(txtZoekProduct.Text.Trim());
            dataGridViewProducten.DataSource = producten;
            dataGridViewProducten.Refresh();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewProducten.SelectedRows.Count;
            if (rowsCount == 1)
            {
                try
                {
                    var row = dataGridViewProducten.SelectedRows[0];
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    Product product = producten[id];

                    NewBestelling nbf = (NewBestelling)Tag;
                    nbf.AddProduct(product);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Selecteer een rij A.U.B!");
            }
        }
    }
}
