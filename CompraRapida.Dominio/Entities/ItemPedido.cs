﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Dominio.Entities
{
   public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}