using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatekoop
{
	internal class Felhasznalo
	{

		public string Nev { get; private set; }
		public int Egyenleg { get; private set; }
		public List<Jatek> Konyvtar { get; private set; }

		public Felhasznalo(string nev, int egyenleg)
		{ Nev = nev; Egyenleg = egyenleg;
			Konyvtar = new List<Jatek>(); }

		public bool Vasarlas(Jatek jatek) 
		{
				foreach( var game in Konyvtar) 
				{
				if (game == jatek || Egyenleg < jatek.Ar) 
					{
                        Console.WriteLine("Nem lehet megvásárolni!");
                        return false;
					}
				}
				Konyvtar.Add(jatek);
				Egyenleg -= jatek.Ar;
				Console.WriteLine("Sikeresen hozzáadva!");
				Console.WriteLine($"Új egyenleg: {Egyenleg} ");
				return true;
			/*if (!Konyvtar.Contains(jatek) &&  Egyenleg > jatek.Ar  ) 
			{
				Konyvtar.Add(jatek);
				Egyenleg -= jatek.Ar;
				Console.WriteLine("Sikeresen hozzáadva!");
				Console.WriteLine($"Új egyenleg: {Egyenleg} ");
				return true;
				
			} else { Console.WriteLine("Nem lehet megvenni!");
			return false;}
            */
            
		}
		public void KonyvtarMegtekintes()
		{
            Console.WriteLine("Játékaid: ");
            foreach (var jatek in Konyvtar)
			{
				Console.WriteLine(jatek.Cim);
			}
		}
		public void Feltoltes(int osszeg) 
		{
		 Egyenleg += osszeg;
            Console.WriteLine("Pénz sikeresen feltöltve!");
        }

		
	}
}
