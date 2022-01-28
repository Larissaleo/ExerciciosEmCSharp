namespace Impostos.src.Entities
{
    public class ICMS : IImposto
    {
        public double valor {get; set;}

        public ICMS(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            double imposto = valor* 0.27;

            return imposto;
        }
    }
}