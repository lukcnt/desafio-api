using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;

namespace API.Repository
{
    public class PedidoRepository
    {
        private readonly VendasContext _context;

        public PedidoRepository(VendasContext context)
        {
            _context = context;
        }
    }
}