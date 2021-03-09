using System;

namespace POO_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temas > Programacion Orientada a Objetos\r\n");
            //Herencia

            //InterfacesClonable
            IntIC icomps = new IntIC();
            icomps.IC();


            //Polimorfismo


            //Agregacion


            //Try-Catch
            try
            {//Ejecuta esta accion. 
            }
            catch (Exception ex)
            {//En caso de que exista una exepcion, ejecuta esto
            }
            finally
            { //No es obligatorio, se ejecuta siempre
            }

            //Garbage Collector


            //Interfaces
            //Done

            //Enums
            Enums en = new Enums();
            
            
            //Delegados
            Delegado del = new Delegado();
            del.Funcion();

            //LINQ
            Linq linq = new Linq();


            //Expresiones Lambda
            ExpresionesLambda exp = new ExpresionesLambda();


            //TCP-IP > Sockets
            Sockets sock = new Sockets();

        }
    }
}
