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
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repository;

        public PedidoController(PedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPedidoDTO dto)
        {
            var pedido = new Pedido(dto);
            _repository.Cadastrar(pedido);
            return Ok(pedido);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pedido = _repository.ObterPorId(id);
            
            if (pedido is not null)
            {
                return Ok(pedido);
            }
            else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado" });
            }
        }

        [HttpGet("ListarPedidos")]
        public IActionResult ListarPedidos()
        {
            var pedidos = _repository.ListarPedidos();
            return Ok(pedidos);
        }

        [HttpGet("ListarPedidoPorVendedor/{id}")]
        public IActionResult ListarPedidoPorVendedor(int id)
        {
            var pedidos = _repository.ListarPedidoPorVendedor(id);

            if (pedidos is not null)
            {
                return Ok(pedidos);
            }
            else
            {
                return NotFound( new { Mensagem = "Esse vendedor não possui pedidos!" } );
            }
        }

        [HttpGet("ListarPedidoPorCliente/{id}")]
        public IActionResult ListarPedidoPorCliente(int id)
        {
            var pedidos = _repository.ListarPedidoPorCliente(id);
            return Ok(pedidos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarPedidoDTO dto)
        {
            var pedido = _repository.ObterPorId(id);

            if (pedido is not null)
            {
                pedido.MapearAtualizarPedidoDTO(dto);
                _repository.AtualizarPedido(pedido);
                return Ok(pedido);
            }
            else
            {
                return NotFound(new{Mensagem = "Pedido não encontrado!"});
            }
        }
    }
}