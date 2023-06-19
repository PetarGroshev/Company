using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public abstract class Employee
    {
        private int nomer;
        private string ime;
        private string trudovStazh;
        private int navursheniGodini;
        private double osnovnaZaplata;

        public int Nomer
        {
            get { return nomer; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka");
                }
            }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka");
                }
                this.Ime = value;
            }
        }

        public string TrudovStazh
        {
            get { return trudovStazh; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka");
                }
                this.TrudovStazh = value;
            }
        }

        public int NavursheniGodini
        {
            get { return navursheniGodini; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka");
                }
                this.NavursheniGodini = value;
            }
        }
        public double OsnovnaZaplata
        {
            get { return osnovnaZaplata; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka");
                }
                this.osnovnaZaplata = value;
            }
        }
        public Employee(int nomer, string ime, string trudovStazh, int navursheniGodini, double osnovnaZaplata)
        {
            this.nomer = nomer;
            this.ime = ime;
            this.trudovStazh = trudovStazh;
            this.navursheniGodini = navursheniGodini;
            this.osnovnaZaplata = osnovnaZaplata;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{this.nomer}, {this.ime}, {this.trudovStazh}, {this.navursheniGodini}, {this.osnovnaZaplata}");
        }


    }
}
