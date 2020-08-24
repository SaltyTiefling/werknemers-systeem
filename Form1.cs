using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werknemers_systeem
{
    public partial class Form1 : Form
    {
        List<Bedrijf> bedrijven = new List<Bedrijf>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemer geert = new Werknemer("Geert", new Salaris(contract: Salaris.contracttype.Week));
            Werknemer frank = new Werknemer("Frank", new Salaris(2200,Salaris.contracttype.Maand));
            Werknemer daniel = new Werknemer("Daniel",new Salaris(contract: Salaris.contracttype.Week), moederland: "Nederland");
            Werknemer sofia = new Werknemer("Sofia",new Salaris(3110, Salaris.contracttype.Maand), "Nederland");

            Werknemer lisa = new Werknemer("Lisa");
            Werknemer laura = new Werknemer("Laura");
            Werknemer jack = new Werknemer("Jack");

            Werknemer alan = new Werknemer("Alan");
            Werknemer seth = new Werknemer("Seth");
            Werknemer gilles = new Werknemer("Gilles");


            Bedrijf jonasinc = new Bedrijf("jonas inc.","BE1235465798765413");
            jonasinc.AddWerknemer(geert,frank,daniel,sofia);
            bedrijven.Add(jonasinc);

            Bedrijf kenco = new Bedrijf("Ken & Co.", "DA1235465798765413");
            kenco.AddWerknemer(lisa, laura, jack);
            bedrijven.Add(kenco);

            Bedrijf VDAB = new Bedrijf("Vandalisten die andere Beschilderen", "NL1235465798765413");
            VDAB.AddWerknemer(alan, seth, gilles);
            bedrijven.Add(VDAB);

            LaadBedrijven();
        }
        private void LaadBedrijven()
        {
            cbBedrijf.DataSource = null;
            cbBedrijf.DataSource = bedrijven;
            Laadwerknemers();
        }
        private void Laadwerknemers()
        {
            lbxWerknemers.DataSource = null;
            if (cbBedrijf.DataSource == bedrijven)
            {
                lbxWerknemers.DataSource = (cbBedrijf.SelectedValue as Bedrijf).werknemerslijst;
            }

        }

        private void cbBedrijf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Laadwerknemers();
            if (cbBedrijf.DataSource != null)
            {
                lblNaam.Text = (cbBedrijf.SelectedItem as Bedrijf).naam;
                lblWerknemerAmount.Text = (cbBedrijf.SelectedItem as Bedrijf).werknemerslijst.Count().ToString();
                lblBtw.Text = (cbBedrijf.SelectedItem as Bedrijf).btwnummer.ToString();
            }
        }

        private void lbxWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWerknemers.DataSource != null)
            {
                txtSamenvatting.Text = $"{(lbxWerknemers.SelectedItem as Werknemer).naam} {Environment.NewLine}"
                + $"{(lbxWerknemers.SelectedItem as Werknemer).moederland} {Environment.NewLine}"
                + $"{(lbxWerknemers.SelectedItem as Werknemer).salaris}";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fNieuwewerknemer werknemer = new fNieuwewerknemer();
            if (werknemer.ShowDialog() == DialogResult.OK)
            {
                (cbBedrijf.SelectedItem as Bedrijf).AddWerknemer(werknemer.nieuweWerknemer);
            }
            Laadwerknemers();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            (cbBedrijf.SelectedItem as Bedrijf).VerwijderWerknemer((lbxWerknemers.SelectedItem as Werknemer));
            Laadwerknemers();
        }
    }
}
