using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ListarServicosDTO
    {
        public string Nome { get; set; }

        public ListarServicosDTO(Servico servico)
        {
            Nome = servico.Nome;
        }
    }
}