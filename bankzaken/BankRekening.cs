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
        }

        // constructor
        public BankRekening(String naam, int saldo) 
        {
            this.saldo = saldo;
            this.naam = naam;
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
            if (bedrag < 0 || bedrag > saldo)
            {
                MessageBox.Show("Not enough money or deposit value is negative");
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
                MessageBox.Show("You cannot deposit a negative value!");
            }
            else
            {
                this.saldo = this.saldo + bedrag;
            }
        }

        public bool MaakOverNaar(BankRekening andereRekening, int bedrag) 
        {
            if (bedrag > 0 || andereRekening.Saldo > saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
