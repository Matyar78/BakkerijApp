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
    public partial class ZoekKlantForm : Form
    {
        private DataRepository repository;
        private IList<Klant> klanten;

        public ZoekKlantForm()
        {
            InitializeComponent();
            repository = new DataRepository();
            klanten = repository.GetKlanten();
            dataGridViewZoekKlant.DataSource = klanten;
        }

        private void txtSearchKlant_KeyUp(object sender, KeyEventArgs e)
        {            
            klanten = repository.SearchKlantenByIdOrName(txtSearchKlant.Text.Trim());
            dataGridViewZoekKlant.DataSource = klanten;
            dataGridViewZoekKlant.Refresh();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewZoekKlant.SelectedRows.Count;
            if (rowsCount == 1)
            {
                try
                {
                    var row = dataGridViewZoekKlant.SelectedRows[0];
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    Klant klant = klanten[id];

                    NewBestelling nbf = (NewBestelling)Tag;
                    nbf.AddKlant(klant);
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
