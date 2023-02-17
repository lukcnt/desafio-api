using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemPedidoController : ControllerBase
    {
        private readonly ItemPedidoRepository _repository;
        
        public ItemPedidoController(ItemPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarItemPedidoDTO dto)
        {
            var item = new ItemPedido(dto);
            _repository.Cadastrar(item);
            return Ok(item);
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorPedido(int id)
        {
            var itens = _repository.ListarPorPedido(id);

            if (itens is not null)
            {
                return Ok(itens);
            }
            else
            {
                return NotFound(new{Mensagem="Não há nenhum item neste pedido!"});
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarItemPedidoDTO dto)
        {
            var item = _repository.ObterPorId(id);

            if (item is not null)
            {
                item.MapearAtualizarItemPedidoDTO(dto);
                _repository.AtualizarPedido(item);
                return Ok(item);
            }
            else
            {
                return NotFound(new{Mensagem="Itens não encontrados!"});
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var item = _repository.ObterPorId(id);
            
            if (item is not null)
            {
                _repository.DeletarItem(item);
                return Ok(new{Mensagem="Item deletado com sucesso!"});
            }
            else
            {
                return NotFound(new{Mensagem="Item não encontrado!"});
            }
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var itensPedido = _repository.Listar();
            return Ok(itensPedido);
        }
    }
}