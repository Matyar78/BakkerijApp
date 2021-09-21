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

namespace BakkerijApp.MedewerkersForms
{
    public partial class NewMedewerkerForm : Form
    {
        private Medewerker _medewerkerToEdit;
        public NewMedewerkerForm()
        {
            InitializeComponent();
            SetDateFormat();
        }

        public NewMedewerkerForm(Medewerker medewerker)
        {
            InitializeComponent();
            SetDateFormat();
            lblTitle.Text = "Medewerker bewerken";

            _medewerkerToEdit = medewerker;
            textVoornaam.Text = medewerker.Voornaam;
            textTussemvoegsel.Text = medewerker.tussenvoegsel;
            textAchternaam.Text = medewerker.Achternaam;
            textStraat.Text = medewerker.Straat;
            textHuisnummer.Text = medewerker.Huisnummer.ToString();
            texHuisnummerToev.Text = medewerker.HuisnrToevoeging;
            textPostcode.Text = medewerker.Postcode;
            textPlaats.Text = medewerker.Plaats;
            textTelefoon.Text = medewerker.Telefoon;
            textEmail.Text = medewerker.Email;
            textBsn.Text = medewerker.BSN.ToString();
            textFunctie.Text = medewerker.Functie;
            dateTimePickerDatumInDienst.Value = medewerker.DatumInDienst;
            checkBoxUitDienst.Checked = medewerker.UitDienst;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Medewerker medewerker = _medewerkerToEdit ?? new Medewerker();
            medewerker.Voornaam = textVoornaam.Text;
            medewerker.tussenvoegsel = textTussemvoegsel.Text;
            medewerker.Achternaam = textAchternaam.Text;
            medewerker.Straat = textStraat.Text;
            medewerker.Huisnummer = int.Parse(textHuisnummer.Text);
            medewerker.HuisnrToevoeging = texHuisnummerToev.Text;
            medewerker.Postcode = textPostcode.Text;
            medewerker.Plaats = textPlaats.Text;
            medewerker.Telefoon = textTelefoon.Text;
            medewerker.Email = textEmail.Text;
            medewerker.BSN = int.Parse(textBsn.Text);
            medewerker.Functie = textFunctie.Text;
            medewerker.DatumInDienst = dateTimePickerDatumInDienst.Value;
            medewerker.UitDienst = checkBoxUitDienst.Checked;

            DataRepository repository = new DataRepository();
            try
            {
                if(_medewerkerToEdit == null)
                {
                    repository.InsertMedewerker(medewerker);
                }
                else
                {
                    repository.UpdateMedewerker(medewerker);
                }
                
                MedewerkersOverviewForm overviewForm = (MedewerkersOverviewForm)Tag;
                overviewForm.RefreshData();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetDateFormat()
        {
            dateTimePickerDatumInDienst.Format = DateTimePickerFormat.Custom;
            dateTimePickerDatumInDienst.CustomFormat = "dd-MM-yyyy";            
        }
    }
}
