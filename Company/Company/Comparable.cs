using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Comparable : IComparer<DanniZaFirmata>
    {
        public int Compare(DanniZaFirmata x, DanniZaFirmata y)
        {
           int result = x.OsnovnaZaplata.CompareTo(y.OsnovnaZaplata);
            if (result == 0)
            {
                result = y.OsnovnaZaplata.CompareTo(y.OsnovnaZaplata);
            }
            return result;
        }
    }
}
