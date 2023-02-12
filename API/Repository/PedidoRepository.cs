using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.DTO;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class PedidoRepository
    {
        private readonly VendasContext _context;

        public PedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public Pedido Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return pedido;
        }

        public List<Pedido> ListarPedidos()
        {
            var pedidos = _context.Pedidos.Include(x => x.Vendedor)
                                          .Include(x => x.Cliente)
                                          .ToList();

            return pedidos;
        }

        public Pedido ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Include(x => x.Vendedor)
                                         .Include(x => x.Cliente)
                                         .FirstOrDefault(x => x.Id == id);
                                         
            return pedido;
        }

        public List<Pedido> ListarPedidoPorVendedor(int id)
        {
            var pedidos = _context.Pedidos.Where(x => x.VendedorId.Equals(id))
                                          .Include(x => x.Vendedor)
                                          .Include(x => x.Cliente)
                                          .ToList();
            
            return pedidos;
        }

        public List<Pedido> ListarPedidoPorCliente(int id)
        {
            var pedidos = _context.Pedidos.Where(x => x.ClienteId.Equals(id))
                                          .Include(x => x.Vendedor)
                                          .Include(x => x.Cliente)
                                          .ToList();
            
            return pedidos;
        }

        public Pedido AtualizarPedido(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();

            return pedido;
        }
    }
}