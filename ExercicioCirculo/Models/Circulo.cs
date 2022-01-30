namespace ExercicioCirculo.Models
{
    public class Circulo
    {
        private double raio;
        public double percentual;


        public void definirRaio(double raio)
        {
            this.raio = raio;
            
        }

        public double Area()
        {   double area;
            return area = 3.14159265358979323846*raio*raio;

            
        }

        public double Circunferencia()
        {
            double C;
            return C = 2*3.14159265358979323846*raio;
        }

        public double aumentarRaio(double percentual)
        {
        
            return percentual*raio+raio;
        }
    }
}