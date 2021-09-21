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

namespace BakkerijApp.MedewerkersForms
{
    public partial class MedewerkersOverviewForm : Form
    {
        private IList<Medewerker> medewerkersList;
        private int selectedId;
        private DataRepository repository;

        public MedewerkersOverviewForm()
        {
            InitializeComponent();
            repository = new DataRepository();
            BindData();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            NewMedewerkerForm newMedewerkerForm = new NewMedewerkerForm();
            newMedewerkerForm.Tag = this;
            newMedewerkerForm.Show(this);
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }

        private void BindData()
        {
            medewerkersList = repository.GetMedewerkers();
            dataGridViewMedewerkers.DataSource = medewerkersList;            
        }

        public void RefreshData()
        {
            BindData();
            dataGridViewMedewerkers.Refresh();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewMedewerkers.SelectedRows.Count;
            if (rowsCount == 1)
            {
                try
                {
                    var row = dataGridViewMedewerkers.SelectedRows[0];
                    string id = row.Cells[0].Value.ToString();
                    selectedId = int.Parse(id);
                    cmdEdit.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                cmdEdit.Enabled = false;
            }                
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                repository.DeleteKlant(selectedId);
                RefreshData();
                cmdEdit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Medewerker medewerker = repository.GetMedewerkerById(selectedId);
            NewMedewerkerForm newKlantForm = new NewMedewerkerForm(medewerker);
            newKlantForm.Tag = this;
            newKlantForm.Show(this);
            cmdEdit.Enabled = false;
        }

        private void MedewerkersOverviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
        }
    }
}
