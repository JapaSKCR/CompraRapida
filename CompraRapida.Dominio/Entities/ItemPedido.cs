using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Dominio.Entities
{
   public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
            {
                AdicionarCritica("Nâo foi identificado a referência do produto");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Quantidade nâo informada");
            }
        }

        
    }
}
