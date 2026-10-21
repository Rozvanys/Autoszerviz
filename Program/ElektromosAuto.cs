using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumlatorSzint;

		public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumlatorSzint) : base(rendszam, kor, kilometerOra, 0)
		{
			this.AkkumlatorSzint = akkumlatorSzint;
		}

		public int AkkumlatorSzint { get => akkumlatorSzint; set => akkumlatorSzint = Math.Clamp(value, 0, 100); }

		public new void InformaciotAd()
		{
			Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km - rel, {AkkumlatorSzint}% töltöttséggel.");
		}

		public void Szervizel(int dij)
		{
			if (dij > 100000)
			{
				KilometerOra -= 10000;
			}
			akkumlatorSzint -= 10;
			Console.WriteLine($"A(z) {Rendszam} jármű szervizelése megtörtént ");
		}
	}
}
