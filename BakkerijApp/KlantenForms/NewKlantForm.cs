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

namespace BakkerijApp.KlantenForms
{
    public partial class NewKlantForm : Form
    {
        private Klant _klantToEdit;
        public NewKlantForm()
        {
            InitializeComponent();
        }

        public NewKlantForm(Klant klant)
        {
            InitializeComponent();
            lblTitle.Text = "Klant bewerken";
            _klantToEdit = klant;
            textVoornaam.Text = klant.Voornaam;
            textTussemvoegsel.Text = klant.tussenvoegsel;
            textAchternaam.Text = klant.Achternaam;
            textStraat.Text = klant.Straat;
            textHuisnummer.Text = klant.Huisnummer.ToString();
            texHuisnummerToev.Text = klant.HuisnrToevoeging;
            textPostcode.Text = klant.Postcode;
            textPlaats.Text = klant.Plaats;
            textTelefoon.Text = klant.Telefoon;
            textEmail.Text = klant.Email;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                Klant klant = _klantToEdit ?? new Klant();
                klant.Voornaam = textVoornaam.Text;
                klant.tussenvoegsel = textTussemvoegsel.Text;
                klant.Achternaam = textAchternaam.Text;
                klant.Straat = textStraat.Text;
                klant.Huisnummer = int.Parse(textHuisnummer.Text);
                klant.HuisnrToevoeging = texHuisnummerToev.Text;
                klant.Postcode = textPostcode.Text;
                klant.Plaats = textPlaats.Text;
                klant.Telefoon = textTelefoon.Text;
                klant.Email = textEmail.Text;

                DataRepository repository = new DataRepository();
            
                if(_klantToEdit == null)
                {
                    repository.InsertKlant(klant);
                }
                else
                {
                    repository.UpdateKlant(klant);
                }
                
                KlantenOverviewForm overviewForm = (KlantenOverviewForm)Tag;
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
