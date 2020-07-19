using CompraRapida.Dominio.Contracts;
using CompraRapida.Dominio.Entities;
using CompraRapida.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Repositorio.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {
        }
    }
}
