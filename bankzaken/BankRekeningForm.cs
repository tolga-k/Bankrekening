using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankzaken
{
    public partial class BankRekeningForm : Form
    {
        // datavelden
        private BankRekening bankrekeningLinks;
        private BankRekening bankrekeningRechts;

        // constructor
        public BankRekeningForm()
        {   
            InitializeComponent();
            bankrekeningLinks = new BankRekening("Jim");
            bankrekeningRechts = new BankRekening("Shalini");
            UpdateForm();
        }

        private void btStort_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.Stort(Convert.ToInt16(tbstortLinks.Text));
            UpdateForm();
        }

        private void btNeemOp_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.NeemOp(Convert.ToInt16(tbopneemLinks.Text));
            UpdateForm();
        }

        private void btStortRechts_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.Stort(Convert.ToInt16(tbstortRechts.Text));
            UpdateForm();
        }

        private void btNeemOpRechts_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.NeemOp(Convert.ToInt16(tbopneemRechts.Text));
            UpdateForm();
        }

        private void btLinks_Click(object sender, EventArgs e)
        {
            bool genoegGeld;
            int overgeboektBedrag = Convert.ToInt16(tbNaam.Text);

            genoegGeld = bankrekeningLinks.MaakOverNaar(bankrekeningRechts, overgeboektBedrag);
            if (genoegGeld == true)
            { MessageBox.Show("Geld storten van rechts naar links gelukt"); }
            if (genoegGeld == false)
            { MessageBox.Show("Niet genoeg geld op bankrekening van " + bankrekeningRechts.Naam + ""); }
                
            UpdateForm();
        }

        private void btRechts_Click(object sender, EventArgs e)
        {
            bool genoegGeld;
            int overgeboektBedrag = Convert.ToInt16(tbNaam.Text);

            genoegGeld = bankrekeningRechts.MaakOverNaar(bankrekeningLinks, overgeboektBedrag);
            if (genoegGeld == true)
            { MessageBox.Show("Geld storten gelukt"); }
            if (genoegGeld == false)
            { MessageBox.Show("Niet genoeg geld op bankrekening van " + bankrekeningLinks.Naam + ""); }

            UpdateForm();
        }

        private void UpdateForm()
        {
            decimal kostenLinks = bankrekeningLinks.Saldo;
            tbsaldoLinks.Text = kostenLinks.ToString("c");

            decimal kostenRechts = bankrekeningRechts.Saldo;
            tbsaldoRechts.Text = kostenRechts.ToString("c");
        }
    }
}
