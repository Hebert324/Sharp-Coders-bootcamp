namespace Static.Entity.Enums
{
    internal class Circulo
    {
        // Atributos
        public static readonly double PI = 3.14159265;
        public double Espessura { get; set; }
        public double Raio { get; set; }
        public Color Cor { get; set; }


        public double Perimetro
        {
            get { return 2 * PI * Raio; }
        }

        public double Area
        {
            get { return PI * Raio * Raio; }
        }
        public Circulo(double espessura, double raio, Color cor)
        {
            Espessura = espessura;
            Raio = raio;
            Cor = cor;
        }
    }
}
