namespace Impostos.src.Entities
{
    public class CONFINS : IImposto
    {
        public double valor{get; set;}

        public CONFINS(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            if(valor<= 13000){
                return valor;
            }
            else{
                double imposto = valor *0.04;
                return imposto;
            }
        }
    }
}