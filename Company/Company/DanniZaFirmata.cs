using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class DanniZaFirmata : Employee
    {
        private string imeNaFirmata;
        private int eIK;
        private string adresNaUpravlenie;

        public string ImeNaFirmata
        {
            get { return this.imeNaFirmata; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Error");
                }
                this.imeNaFirmata = value;
            }

        }

        public int EIK
        {
            get { return this.eIK; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                this.eIK = value;
            }
        }
        public string AdresNaUpravlenie
        {
            get { return this.adresNaUpravlenie; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Error");
                }
                this.adresNaUpravlenie = value;
            }
        }

        public DanniZaFirmata(string ime, int nomer, string trudovStazh, int navursheniGodini, double osnovnaZaplata, string imeNaFirmata, int eIK, string adresNaUpravlenie):base(nomer, ime, trudovStazh, navursheniGodini, osnovnaZaplata)
        {
            this.imeNaFirmata = imeNaFirmata;
            this.eIK = eIK;
            this.adresNaUpravlenie = adresNaUpravlenie;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{this.Ime} {this.Nomer} {this.TrudovStazh} {this.NavursheniGodini} {this.OsnovnaZaplata} {this.imeNaFirmata} {this.EIK} {this.adresNaUpravlenie}");
        }
    }

}
