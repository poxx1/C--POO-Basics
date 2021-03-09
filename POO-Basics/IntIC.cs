using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace POO_Basics
{
    public class IntIC
    {
        
        public void IC()
        {
            List<int> listaInts = new List<int>();
            listaInts.Add(1);
            listaInts.Add(2);
            listaInts.Add(5);
            listaInts.Add(4);
            listaInts.Add(3);
            listaInts.Sort();

            List<Auto> autos = new List<Auto>
            {
                new Auto("Fiat 147",1987),
                new Auto("VW Gol",2021),
                new Auto("Ford Fiesta",1996),
                new Auto("Peugeot 407",2019)
            };

            //Ordeno Autos por Modelo > IComparable
            autos.Sort();
            autos.ForEach(auto => Console.WriteLine(auto.Modelo));

            //Ordeno Autos por year > IComparer
            autos.Sort(new CompradorAuto());
            autos.ForEach(auto => Console.WriteLine(auto.Year));

            //Ienumerator me permite recorrer como un forEach una lista.
            IEnumerator ien = autos.GetEnumerator();
            while (ien.MoveNext())
            {
                Console.WriteLine(ien.Current);
            }

        }
    }
    //IComparable > Compara propiedades de objetos. Devuelve int.
    public class Auto:IComparable<Auto>
    {
        public string Modelo { get; set; }
        public int Year { get; set; }
        public Auto(string modelo,int year)
        {
            Modelo = modelo;
            Year = year;
        }

        public int CompareTo([AllowNull] Auto other)
        {   
            return Modelo.CompareTo(other.Modelo);
        }
    }

    public class CompradorAuto : IComparer<Auto>
    {
        //Compara 2, puede ser ej, izquierda y derecha
        public int Compare([AllowNull] Auto x, [AllowNull] Auto y)
        {
            return x.Year - y.Year;
        }
    }
}
