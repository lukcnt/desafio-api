using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ListarVendedoresDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }

        public ListarVendedoresDTO(Vendedor vendedor)
        {
            Id = vendedor.Id;
            Nome = vendedor.Nome;
            Login = vendedor.Login;
        }
    }
}