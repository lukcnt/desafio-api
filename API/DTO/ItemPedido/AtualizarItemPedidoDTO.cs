using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class AtualizarItemPedidoDTO
    {
        public int ServicoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}