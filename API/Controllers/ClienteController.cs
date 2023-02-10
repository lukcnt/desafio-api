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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;

        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarClienteDTO dto)
        {
            var cliente = new Cliente(dto);
            _repository.Cadastrar(cliente);
            return Ok(cliente);
        }

        [HttpPost("EfetuarLogin")]
        public IActionResult EfetuarLogin(LoginClienteDTO dto)
        {
            bool autorizarLogin = _repository.EfetuarLogin(dto);

            if (autorizarLogin)
            {
                return Ok(new { Mensagem = "Login autorizado" });
            }
            else
            {
                return NotFound( new { Mensagem = "Login ou senha não encontrados"});
            }
        }

        [HttpGet("ListarClientes")]
        public IActionResult ListarClientes()
        {
            var clientes = _repository.ListarClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _repository.ObterPorId(id);

            if (cliente is not null)
            {
                var clienteDTO =  new ObterClienteDTO(cliente);
                return Ok(clienteDTO);
            }
            else
            {
                return NotFound(new { Mensagem = "Cliente não encontrado!" });
            }
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var clientes = _repository.ObterPorNome(nome);
            return Ok(clientes);
        }
    }
}