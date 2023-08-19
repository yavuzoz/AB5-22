using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB5_22
{
	class Program
	{
		static void Main(string[] args)
		{
			// Erste Person gibt den Urlaubsbeginn und das -ende ein
			Console.WriteLine("Zeitspanne1 Anfang eingeben (TT.MM.JJJJ):");
			DateTime urlaubStart1 = DateTime.Parse(Console.ReadLine());

			Console.WriteLine("Zeitspanne1 Ende eingeben (TT.MM.JJJJ):");
			DateTime urlaubEnde1 = DateTime.Parse(Console.ReadLine());

			// Zweite Person gibt den Urlaubsbeginn und das -ende ein
			Console.WriteLine("Zeitspanne2 Anfang eingeben (TT.MM.JJJJ):");
			DateTime urlaubStart2 = DateTime.Parse(Console.ReadLine());

			Console.WriteLine("Zeitspanne2 Ende eingeben (TT.MM.JJJJ):");
			DateTime urlaubEnde2 = DateTime.Parse(Console.ReadLine());

			// Überprüfen auf Überschneidung
			if ((urlaubStart2 >= urlaubStart1 && urlaubStart2 <= urlaubEnde1) ||
				(urlaubEnde2 >= urlaubStart1 && urlaubEnde2 <= urlaubEnde1))
			{
				Console.WriteLine("Die Urlaubszeiten der beiden Personen überschneiden sich. Sie können gemeinsam Urlaub machen.");

				// Berechnen Überschneidung
				DateTime uberschneidungsStart = urlaubStart2 > urlaubStart1 ? urlaubStart2 : urlaubStart1;
				DateTime uberschneidungsEnde = urlaubEnde2 < urlaubEnde1 ? urlaubEnde2 : urlaubEnde1;
				Console.WriteLine("Es wurde eine Überscheidung gefunden");
				Console.WriteLine("Die Überschneidung ist vom {0} bis {1}", uberschneidungsStart.ToShortDateString(), uberschneidungsEnde.ToShortDateString());
			}
			else
			{
				Console.WriteLine("Die beiden Personen können nicht gemeinsam Urlaub machen. Die Urlaubszeiten passen nicht zusammen.");
			}

			Console.ReadLine();
		}
	}			
}
