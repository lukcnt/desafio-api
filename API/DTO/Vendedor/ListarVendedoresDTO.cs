using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ListarVendedoresDTO
    {
        public string Nome { get; set; }

        public ListarVendedoresDTO(Vendedor vendedor)
        {
            Nome = vendedor.Nome;
        }
    }
}