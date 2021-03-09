using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Basics
{
         //Toda clase que utilice la interfaz esta obligado a utilizar todos sus Metodos. 
         //Por ejemplo si tengo animales mamiferos algunos caminan y otros nadan. Metodo moverse, pero diferente implementacion.
        public interface IBebida { 
        public string Marca { get; set; } 
        public int contenidoLitros { get; set; } 
        } 
    
        public class Bebidas:IBebida {
        public string Marca { get; set; } 
        public int contenidoLitros { get; set; } 
        public void Asignar() { Marca = "Quilmes"; contenidoLitros = 1; } 
        } 

        public class Vino : IBebida { 
        public string Marca { get; set; } 
        public int contenidoLitros { get; set; } 
        public void Asingar() { Marca = "Santa Julia"; contenidoLitros = 1; } 
        }
}
