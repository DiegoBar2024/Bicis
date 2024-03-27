namespace Bicicleta
{
    using System;
    public class Bicicleta
    {
        public Bicicleta(string marca, string color, int tamaño, string uso)
        {
            this.Marca = marca;
            this.Color = color;
            this.Tamaño = tamaño;
            if (uso == "Montaña" || uso == "Ciudad"){
                this.Uso = uso;
            }
            else{
                this.Uso = "Montaña";
            }
        }

        public string Marca { get; }

        public string Color { get; set; }

        public int Tamaño { get; }

        public string Uso { get; set; }

    }
}