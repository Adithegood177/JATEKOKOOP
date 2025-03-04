namespace Jatekoop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Jatek wicser = new Jatek("Witcher","RPG",12000); 
			Jatek fifa = new Jatek("Fifa","Sport",18000);
			Jatek cyberpunk = new Jatek("Cyber","RPG",15000);

			Jatekbolt jatekBolt = new Jatekbolt();
			jatekBolt.JatekHozzaadas(cyberpunk);
			jatekBolt.JatekHozzaadas(fifa);
			jatekBolt.JatekHozzaadas(wicser);




			Felhasznalo adam = new Felhasznalo("Ádám", 20000);

			jatekBolt.FelhasznaloHozzaadas(adam);
			Jatek witcher = jatekBolt.KeresJatek("The Witcher 3");
			Console.ReadKey();
			adam.Vasarlas(witcher);
			Console.ReadKey();
            Console.WriteLine("Space a továbbhoz");
			Console.Clear();
            adam.Feltoltes(10000);
			Jatek pikpuk = jatekBolt.KeresJatek("Cyberpunk 2077");
			adam.Vasarlas(cyberpunk);
			Console.WriteLine("Space a továbbhoz");
			Console.ReadKey();
			Console.Clear();
			adam.KonyvtarMegtekintes();

		}
	}
}
