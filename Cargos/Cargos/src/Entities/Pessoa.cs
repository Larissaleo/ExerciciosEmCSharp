namespace Cargos.src.Entities
{
    public class Pessoa
    {
        public string Nome{get; set;}

        public string Cargo {get; set;}

        public Pessoa(string Nome, string Cargo)
        {
            this.Nome = Nome;
            this.Cargo = Cargo;
        }
    }
}