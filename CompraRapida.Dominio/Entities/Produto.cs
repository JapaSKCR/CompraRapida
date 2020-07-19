namespace CompraRapida.Dominio.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco == 0)
            {
                AdicionarCritica("Produto sem preço");
            }

            if (Id == 0)
            {
                AdicionarCritica("Produto inválido");
            }

        }
    }
}
