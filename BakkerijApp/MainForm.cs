using BakkerijApp.BestellingenForms;
using BakkerijApp.KlantenForms;
using BakkerijApp.MedewerkersForms;
using BakkerijApp.ProductenForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkerijApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdKlantenBeheer_Click(object sender, EventArgs e)
        {
            KlantenOverviewForm kof = new KlantenOverviewForm();
            kof.Tag = this;
            kof.Show(this);
            Hide();
        }

        private void cmdMedewerkersBeheer_Click(object sender, EventArgs e)
        {
            MedewerkersOverviewForm mof = new MedewerkersOverviewForm();
            mof.Tag = this;
            mof.Show(this);
            Hide();
        }

        private void cmdProductenBeheer_Click(object sender, EventArgs e)
        {
            ProductenOverviewForm pof = new ProductenOverviewForm();
            pof.Tag = this;
            pof.Show(this);
            Hide();
        }

        private void cmdBestellingen_Click(object sender, EventArgs e)
        {
            BestellingOverview bof = new BestellingOverview();
            bof.Tag = this;
            bof.Show(this);
            Hide();
        }
    }
}
