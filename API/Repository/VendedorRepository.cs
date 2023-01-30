using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;

namespace API.Repository
{
    public class VendedorRepository
    {
        private readonly VendasContext _context;

        public VendedorRepository(VendasContext context)
        {
            _context = context;
        }
    }
}