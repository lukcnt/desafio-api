using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ItemPedidoRepository
    {
        private readonly VendasContext _context;

        public ItemPedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public ItemPedido Cadastrar(ItemPedido item)
        {
            _context.ItensPedido.Add(item);
            _context.SaveChanges();

            return item;
        }

        public List<ItemPedido> ListarPorPedido(int id)
        {
            var itens = _context.ItensPedido.Where(x => x.PedidoId.Equals(id))
                                            .Include(x => x.Pedido)
                                            .Include(x => x.Servico)
                                            .ToList();
            
            return itens;
        }

        public ItemPedido ObterPorId(int id)
        {
            var item = _context.ItensPedido.Find(id);
            return item;
        }

        public ItemPedido AtualizarPedido(ItemPedido item)
        {
            _context.ItensPedido.Update(item);
            _context.SaveChanges();

            return item;
        }

        public void DeletarItem(ItemPedido item)
        {
            _context.ItensPedido.Remove(item);
            _context.SaveChanges();
        }
    }
}