using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatekoop
{
	internal class Jatek
	{
		public  string Cim {  get; private set; }
		public string Kategoria { get; private set; }
		public int Ar { get; private set; }
		public Jatek(string cim, string kategoria, int ar) 
		{
		 Cim = cim; Kategoria = kategoria; Ar = ar;
		}

	}
}
