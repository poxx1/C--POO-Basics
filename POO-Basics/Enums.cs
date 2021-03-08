using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basics
{
    public class Enums
    {
        public enum Generos : int {
            Rock = 1,
            Pop = 2,
            LoFi = 3,
            PsyPop = 4
        };

        public List<string> artistas;

        public void AgregarArtistas()
        {
        artistas.Add("Page");
        artistas.Add("Hendrix");
        artistas.Add("Santana");
        }

        public Dictionary<int, string> bandas;

        public void AgregarBandas()
        {
            bandas.Add(1, "Led Zeppelin");
            bandas.Add(2, "Santana");
        }
    }
}
