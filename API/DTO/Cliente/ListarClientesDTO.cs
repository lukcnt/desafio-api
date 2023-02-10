using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ListarClientesDTO
    {
        public string Nome { get; set; }

        public ListarClientesDTO(Cliente cliente)
        {
            Nome = cliente.Nome;
        }
    }
}