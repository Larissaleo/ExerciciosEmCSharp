namespace Olimpiada.src.Entities
{
    public class Atleta
    {
        
        public string Nome { get; set; }
        public string Pais { get; set; }
        public double Distancia { get; set; }

        public Atleta(string nome, string pais, double distancia)
        {
            this.Nome = nome;
            this.Pais = pais;
            this.Distancia = distancia;
        }
    }
}