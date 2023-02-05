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
    public class VendedorController : ControllerBase
    {
        private readonly VendedorRepository _repository;

        public VendedorController(VendedorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarVendedorDTO dto)
        {
            var vendedor = new Vendedor(dto);
            _repository.Cadastrar(vendedor);
            return Ok(vendedor);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _repository.ObterPorId(id);

            if (vendedor is not null)
            {
                var vendedorDTO = new ObterVendedorDTO(vendedor);
                return Ok(vendedorDTO);
            }
            else
            {
                return NotFound(new { Mensagem = "Vendedor não encontrado!"});
            }
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var vendedores = _repository.ObterPorNome(nome);
            return Ok(vendedores);
        }
    }
}