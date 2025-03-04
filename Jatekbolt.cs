using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatekoop
{
	internal class Jatekbolt
	{
		public List<Jatek> Jatekok { get; private set; }
		public List<Felhasznalo> Felhasznalok { get; private set; }

		public Jatekbolt() 
		{
			Jatekok = new List<Jatek>();
			Felhasznalok = new List<Felhasznalo>();
		}

		public void JatekHozzaadas(Jatek jatek) 
		{ 
			Jatekok.Add(jatek);
            Console.WriteLine("Jatek sikeresen hozzáadva!");

        }
		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			Felhasznalok.Add(felhasznalo);
            Console.WriteLine("Felhasznalo sikeresen hozzadva!");
        }
		public Jatek KeresJatek(string cim)
		{
			foreach(var jatek in Jatekok)
			{
				if (jatek.Cim == cim)
				{
					return jatek;
				}
			}
			return null;
		}

	}
}
