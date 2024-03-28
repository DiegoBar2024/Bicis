using System;

namespace Bicicleta
{
    public class ProgramBicicleta
    {
        public static void Main(string[] args)
        {
            Bicicleta b1 = new Bicicleta("marca1", "azul", 100, "Montaña");
            Bicicleta b2 = new Bicicleta("marca2", "roja", 120, "Ciudad");
            Bicicleta b3 = new Bicicleta("marca3", "verde", 200, "Calle");

            Bicicleta miBici = new Bicicleta("miMarca","miColor",100,"miCasa");
        
            Console.WriteLine($"Bicicleta 1: {b1.Marca}, {b1.Color} de tamaño {b1.Tamaño} y tipo {b1.Uso}");
            Console.WriteLine($"Bicicleta 2: {b2.Marca}, {b2.Color} de tamaño {b2.Tamaño} y tipo {b2.Uso}");
            Console.WriteLine($"Bicicleta 3: {b3.Marca}, {b3.Color} de tamaño {b3.Tamaño} y tipo {b3.Uso}");

            Console.WriteLine($"Bicicleta 3: {miBici.Marca}, {miBici.Color} de tamaño {miBici.Tamaño} y tipo {miBici.Uso}");

        }
    }
}