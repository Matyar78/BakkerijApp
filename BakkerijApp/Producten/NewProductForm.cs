using DataAccessLayer;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijApp.ProductenForms
{
    public partial class NewProductForm : Form
    {
        private Product _productToEdit;
        public NewProductForm()
        {
            InitializeComponent();
        }

        public NewProductForm(Product product)
        {
            InitializeComponent();
            lblTitle.Text = "Product bewerken";
            _productToEdit = product;
            textProductNaam.Text = product.ProductNaam;
            textOmschrijving.Text = product.Omschrijving;
            textPrijs.Text = product.Prijs.ToString(); //"c", CultureInfo.CreateSpecificCulture("nl-NL")
            textVoorraad.Text = product.Voorraad.ToString();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = _productToEdit ?? new Product();
                product.ProductNaam = textProductNaam.Text;
                product.Omschrijving = textOmschrijving.Text;
                product.Prijs = decimal.Parse(textPrijs.Text);
                product.Voorraad = int.Parse(textVoorraad.Text);

                DataRepository repository = new DataRepository();
            
                if(_productToEdit == null)
                {
                    repository.InsertProduct(product);
                }
                else
                {
                    repository.UpdateProduct(product);
                }
                
                ProductenOverviewForm overviewForm = (ProductenOverviewForm)Tag;
                overviewForm.RefreshData();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
