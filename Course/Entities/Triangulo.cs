namespace Course.Entities
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // Metodo é uma Função dentro da classe
        // Delegação de responsabilidades, só a classe triangulo deve ser responsavel por calcular a area

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
        }
    }
}
