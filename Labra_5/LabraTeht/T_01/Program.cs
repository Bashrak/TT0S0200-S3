using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo lada = new Kulkuneuvo("Lada", "1992");
            Kulkuneuvo Ducati = new Kulkuneuvo("Ducati", "2015");

            for (int i = 0; i < 4; i++)
            {
                lada.AddRengas("Rengas", "A52BC", "205R16");
            }

            Console.WriteLine(lada.ToString());
            for (int i = 0; i < lada.Renkaat.Count; i++)
            {
                Console.WriteLine("-Name " + lada.Renkaat[i].malli + " Model: " + lada.Renkaat[i].malli + " Tyre Size: " + lada.Renkaat[i].koko);
            }

            Console.WriteLine("\n");
            Ducati.AddRengas("DucatiRengas", "DANK213", "255SC");
            Ducati.AddRengas("DucatiRengas", "DANK213", "420BLAZE1T");
            
            Console.WriteLine(Ducati.ToString());
            for (int i = 0; i < Ducati.Renkaat.Count; i++)
            {
                Console.WriteLine("-Name " + Ducati.Renkaat[i].malli + " Model: " + Ducati.Renkaat[i].malli + " Tyre Size: " + Ducati.Renkaat[i].koko);
            }
        }
    }
}