using System;
using System.Collections.Generic;
using System.Linq;

namespace POO_Basics
{
    public class Delegado
    {
        delegate int Delegad(List<int> Lista);
        
        public int Odenar(List<int> List)
        {
            return List.OrderByDescending(a => a).First();
        }

        public int UnicoValor(List<int> List)
        {
            //Le doy un valor cualquiera
            return 1;
        }

        public void Funcion()
        {
            //Asigno al delegado un Metodo.
            Delegad d = Odenar;
            Console.WriteLine(d(new List<int> { 2, 3, 4, 5, 6 }));
            d = UnicoValor;
            Console.WriteLine(d);   
        }
    }
}
