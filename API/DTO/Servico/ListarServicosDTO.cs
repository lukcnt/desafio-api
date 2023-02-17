using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ListarServicosDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ListarServicosDTO(Servico servico)
        {
            Id = servico.Id;
            Nome = servico.Nome;
            Descricao = servico.Descricao;
        }
    }
}