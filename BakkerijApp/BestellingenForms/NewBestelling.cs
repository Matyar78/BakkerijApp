using BakkerijApp.Models;
using DataAccessLayer;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijApp.BestellingenForms
{
    public partial class NewBestelling : Form
    {
        private DataRepository repository;
        private Klant selectedKlant;
        private List<ProductModel> producten;

        public NewBestelling()
        {
            InitializeComponent();
            repository = new DataRepository();
            producten = new List<ProductModel>();
            //dataGridViewProducts.DataSource = producten;
            //dataGridViewProducts.Columns["Aantal"].ReadOnly = false;
        }

        private void cmdSearchKlant_Click(object sender, EventArgs e)
        {
            ZoekKlantForm zkf = new ZoekKlantForm();
            zkf.Tag = this;
            zkf.Show(this);
        }

        public void AddKlant(Klant klant)
        {
            selectedKlant = klant;

            txtVoornaam.Text = selectedKlant.Voornaam;
            txtTussenvoegsel.Text = selectedKlant.tussenvoegsel;
            txtAchternaam.Text = selectedKlant.Achternaam;
            txtContactKlant.Text = $"{selectedKlant.Straat} {selectedKlant.Huisnummer} {selectedKlant.HuisnrToevoeging}";
            txtContactKlant.AppendText($"{Environment.NewLine}{selectedKlant.Postcode} {selectedKlant.Plaats}");
            if (!string.IsNullOrEmpty(selectedKlant.Telefoon))
                txtContactKlant.AppendText($"{Environment.NewLine}{selectedKlant.Telefoon}");
            if (!string.IsNullOrEmpty(selectedKlant.Email))
                txtContactKlant.AppendText($"{Environment.NewLine}{selectedKlant.Email}");
        }

        public void AddProduct(Product product)
        {
            var productModel = new ProductModel
            {
                Id = product.Id,
                Name = product.ProductNaam,
                Prijs = product.Prijs,
                Aantal = 1,
                SubTotaal = product.Prijs
            };

            producten.Add(productModel);
            UpdateDataGridProducts();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            ZoekProductForm zpf = new ZoekProductForm();
            zpf.Tag = this;
            zpf.Show(this);
        }

        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
            var aantal = int.Parse(dataGridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            var product = producten.Single(t => t.Id == id);
            product.Aantal = aantal;
            product.SubTotaal = product.Prijs * aantal;
            UpdateDataGridProducts();
        }

        private void UpdateDataGridProducts()
        {
            dataGridViewProducts.DataSource = producten;
            for (int i = 0; i <= 4; i++)
            {
                if (i != 3)
                    dataGridViewProducts.Columns[i].ReadOnly = true;
            }

            dataGridViewProducts.Refresh();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Bestelling bestelling = new Bestelling
            {
                KlantId = selectedKlant.Id,
                BestelDatum = DateTime.Now,
                Producten = new List<BestelRegel>()
            };

            foreach (ProductModel pm in producten)
            {
                BestelRegel bs = new BestelRegel()
                {
                    ProductId = pm.Id,
                    Aantal = pm.Aantal,
                    Prijs = pm.Prijs,
                    Bestelling = bestelling
                };
                bestelling.Producten.Add(bs);
            }

            repository.InsertNewBestelling(bestelling);

            BestellingOverview bestellingOverview = (BestellingOverview)Tag;
            bestellingOverview.RefreshData();
            Close();
        }
    }
}
