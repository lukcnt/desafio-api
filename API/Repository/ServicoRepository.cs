using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;

namespace API.Repository
{
    public class ServicoRepository
    {
        private readonly VendasContext _context;

        public ServicoRepository(VendasContext context)
        {
            _context = context;
        }
    }
}