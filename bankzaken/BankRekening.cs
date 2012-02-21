using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankzaken
{
    class BankRekening
    {
        // constructor
        public BankRekening(String naam)
        {
            this.naam = naam;
            this.rekeningnummer = VolgendVrijRekeningnummer;
            VolgendVrijRekeningnummer++;
            MessageBox.Show("Gegevens rekeninghouder:\n" + this.naam + "\n" + this.rekeningnummer + "\n");
        }

        // constructor
        public BankRekening(String naam, int saldo) 
        {
            this.saldo = saldo;
            this.naam = naam;
            this.rekeningnummer = VolgendVrijRekeningnummer;
            VolgendVrijRekeningnummer++;
        }

        // properties & datavelden
        private int rekeningnummer;
        public String Rekeningnummer
        {
            get { return rekeningnummer.ToString(); }
        }

        private String naam;
        public String Naam
        {
            get { return naam; }
        }

        // TODO: Saldo in centen
        private int saldo=0;
        public int Saldo
        {
            get { return saldo; }
        }

        private static int VolgendVrijRekeningnummer=2001;

        // methoden
        public void NeemOp(int bedrag)
        {
            if (bedrag < 0)
            {
                MessageBox.Show("U kunt geen negatief bedrag opnemen.");
            }

            if (bedrag > this.saldo)
            {
                MessageBox.Show("Er is niet genoeg geld op de rekening.");
            }
            else
            {
                this.saldo = this.saldo - bedrag;
            }
        }

        public void Stort(int bedrag)
        {
            if (bedrag < 0)
            {
                MessageBox.Show("U kunt geen negatief bedrag storten.");
            }
            else
            {
                this.saldo = this.saldo + bedrag;
            }
        }

        public bool MaakOverNaar(BankRekening andereRekening, int bedrag) 
        {
            if (andereRekening.saldo > bedrag)
            {
                this.saldo = this.saldo + bedrag;
                andereRekening.saldo = andereRekening.saldo - bedrag;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
