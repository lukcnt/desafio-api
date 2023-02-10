using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO.Cliente
{
    public class ListarClientesDTO
    {
        public string Nome { get; set; }

        public ListarClientesDTO(Vendedor vendedor)
        {
            Nome = vendedor.Nome;
        }
    }
}