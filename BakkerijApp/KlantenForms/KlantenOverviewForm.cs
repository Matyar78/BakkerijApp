using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakkerijApp.KlantenForms;
using DataAccessLayer;
using DataAccessLayer.Entity;

namespace BakkerijApp.KlantenForms
{
    public partial class KlantenOverviewForm : Form
    {
        private IList<Klant> klantenList;
        private int selectedId;
        private DataRepository repository;

        public KlantenOverviewForm()
        {
            InitializeComponent();
            repository = new DataRepository();
            BindData();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            NewKlantForm newKlantForm = new NewKlantForm();
            newKlantForm.Tag = this;
            newKlantForm.Show(this);
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Tag;
            mainForm.Show();
            Close();
        }

        private void BindData()
        {
            klantenList = repository.GetKlanten();
            dataGridViewKlanten.DataSource = klantenList;            
        }

        public void RefreshData()
        {
            BindData();
            dataGridViewKlanten.Refresh();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewKlanten.SelectedRows.Count;
            if (rowsCount == 1)
            {
                try
                {
                    var row = dataGridViewKlanten.SelectedRows[0];
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
            Klant klant = repository.GetKlantById(selectedId);
            NewKlantForm newKlantForm = new NewKlantForm(klant);
            newKlantForm.Tag = this;
            newKlantForm.Show(this);
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
