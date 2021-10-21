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
    public partial class BestellingOverview : Form
    {
        public IList<BestellingModel> BestellingsData;
        private int selectedId;
        private DataRepository repository;
        public BestellingOverview()
        {
            InitializeComponent();
            repository = new DataRepository();
            BindData();
        }

        private void BindData()
        {
            var bestellingen = repository.GetBestellingen();
            ConvertBestellingen(bestellingen);
            dataGridViewBestellingen.DataSource = BestellingsData;
        }

        public void RefreshData()
        {
            BindData();
            dataGridViewBestellingen.Refresh();
        }

        private void ConvertBestellingen(IList<Bestelling> bestellingen)
        {
            BestellingsData = bestellingen.Select(t => new BestellingModel
            {
                Id = t.Id,
                klantVoormaam = t.Klant.Voornaam,
                klantTussenvoegsel = t.Klant.tussenvoegsel,
                klantAchternaam = t.Klant.Achternaam,
                Bestellingsdatum = t.BestelDatum
            }).ToList();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            NewBestelling newBestellingForm = new NewBestelling();
            newBestellingForm.Tag = this;
            newBestellingForm.Show(this);
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBestellingen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewBestellingen.Rows[e.RowIndex].Cells[0].Value.ToString());
            var producten = repository.GetBestellingProducten(id).Select(p=> new ProductModel
            {
                Id = p.Id,
                Name = p.Product.ProductNaam,
                Prijs = p.Prijs,
                Aantal = p.Aantal,
                SubTotaal = p.Prijs * p.Aantal
            }).ToList();
            dataGridViewBestelRegels.DataSource = producten;
            dataGridViewBestellingen.Refresh();
        }
    }
}
