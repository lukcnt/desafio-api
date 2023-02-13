using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;

namespace API.Repository
{
    public class ItemPedidoRepository
    {
        private readonly VendasContext _context;

        public ItemPedidoRepository(VendasContext context)
        {
            _context = context;
        }
    }
}