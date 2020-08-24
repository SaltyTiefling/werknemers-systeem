using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werknemers_systeem
{
    public partial class fNieuwewerknemer : Form
    {
        public Werknemer nieuweWerknemer = new Werknemer("test");
        public fNieuwewerknemer()
        {
            InitializeComponent();
        }

        private void NieuweWerknemer_Load(object sender, EventArgs e)
        {
            txtNaam_TextChanged(sender, e);
            cbContract.Items.Add(Salaris.contracttype.Maand);
            cbContract.Items.Add(Salaris.contracttype.Week);

            txtLand.Text = nieuweWerknemer.moederland;
            cbContract.SelectedIndex = 0;
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {
            if (txtNaam.Text == "")
            {
                epName.SetError(txtNaam, "geef een geldige naam in");
                btnOk.Enabled = false;
            }
            else
            {
                epName.Clear();
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nieuweWerknemer.naam = txtNaam.Text;
            nieuweWerknemer.moederland = txtLand.Text;
            nieuweWerknemer.salaris = new Salaris(contract:(Salaris.contracttype)cbContract.SelectedItem);
            DialogResult = DialogResult.OK;
        }
    }
}
