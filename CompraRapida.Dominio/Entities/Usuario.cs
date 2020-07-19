using System.Collections.Generic;

namespace CompraRapida.Dominio.Entities
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("E-mail não informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não informada");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome não informado");
            }

            if (string.IsNullOrEmpty(Sobrenome))
            {
                AdicionarCritica("Sobrenome não informado");
            }
        }
    }
}
