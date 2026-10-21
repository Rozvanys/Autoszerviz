using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int Rakomany;

		public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
		{
			Rakomany = rakomany;
		}

		public int Rakomany1 { get => Rakomany; set => Rakomany = Math.Clamp(value, 0, 20); }

		public void InformaciotAd()
		{
			Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km - rel, rakomány: {Rakomany} tonna.");
		}

		public void Szervizel(int dij) {
			Rakomany = 0;
			base.Szervizel(dij);
		}
	}
}
