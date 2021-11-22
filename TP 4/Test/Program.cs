using System;
using TrabajoPractico3;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST DE APLICACION DE FULBOL: Santiago Leyes 2A");
            Arquero a = new Arquero("Dibu", "Martinez",22,5,5,10);
            Defensor b = new Defensor("Mateo", "Rodriguez", 20, TipoDefensor.LateralDerecho, 100, 50, 300);
            Mediocampista m = new Mediocampista("Raul", "Gonzales", 26, 156, 233, 25, 5);
            Delantero d = new Delantero("Lautaro", "Martinez", 26, 9, 35, 49);

            Console.WriteLine("MUESTO ESTADISTICAS:");
            Console.WriteLine((string)a);
            Console.WriteLine((string)b);
            Console.WriteLine((string)m);
            Console.WriteLine((string)d);

            Equipo e = new Equipo(100, "sarasa");
            bool estado = e + a;
            if(estado == true)
            {
                Console.WriteLine("Funciono");
            }
            
            estado = e - a;
            if (estado == true)
            {
                Console.WriteLine("Funciono");
            }
           

            Console.ReadKey();
        }
    }
}
