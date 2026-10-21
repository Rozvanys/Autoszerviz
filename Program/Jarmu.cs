using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Program
{
    public class Jarmu
    {

        private string rendszam = "ISMERETLEN";
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        

		public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
		{
			Rendszam = rendszam;
			Kor = kor;
			KilometerOra = kilometerOra;
			UzemanyagSzint = uzemanyagSzint;
		}

		public string Rendszam { get => rendszam; set => rendszam = string.IsNullOrEmpty(value) ? "ISMERETLEN" : value; }
		public int Kor { get => kor; set => kor = Math.Clamp(value, 0, 50); }
		public int KilometerOra { get => kilometerOra; set => kilometerOra = Math.Max(value, 0); }
		public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = Math.Clamp(value, 0, 100); }
		public bool SzervizSzukseges { get => KilometerOra >= 200000; }


		public virtual void InformaciotAd(){
			Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
		}

		public virtual void Szervizel(int dij){
			if (dij > 100000){
				KilometerOra -= 10000;
			}
			UzemanyagSzint -= 10;
			Console.WriteLine($"A(z) {Rendszam} jármű szervizelése megtörtént ");
		}
	}
}
