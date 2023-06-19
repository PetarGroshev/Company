using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<DanniZaFirmata> danniZaFirmata = new List<DanniZaFirmata>();
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    var danni = Console.ReadLine().Split();
                    DanniZaFirmata firma = new DanniZaFirmata(danni[0], int.Parse(danni[1]), danni[2], int.Parse(danni[3]), double.Parse(danni[4]), danni[5], int.Parse(danni[6]), danni[7]);
                    danniZaFirmata.Add(firma);
                }
                Comparable comparable = new Comparable();

                danniZaFirmata.Sort(comparable);
                danniZaFirmata.ForEach(x => x.Print());
            }

        }
    }
}
