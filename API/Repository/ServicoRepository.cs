using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.DTO;
using API.Models;

namespace API.Repository
{
    public class ServicoRepository
    {
        private readonly VendasContext _context;

        public ServicoRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }

        public List<ListarServicosDTO> ListarServicos()
        {
            var servicos = _context.Servicos.Select(x => new ListarServicosDTO(x))
                                            .ToList();
            
            return servicos;
        }

        public Servico ObterPorId(int id)
        {
            var servico = _context.Servicos.Find(id);
            return servico;
        }
    }
}