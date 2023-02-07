using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.DTO;
using API.Models;

namespace API.Repository
{
    public class VendedorRepository
    {
        private readonly VendasContext _context;

        public VendedorRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }

        public Vendedor ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            return vendedor;
        }

        public List<ObterVendedorDTO> ObterPorNome(string nome)
        {
            var vendedores = _context.Vendedores.Where(x => x.Nome.Contains(nome))
                                                .Select(x => new ObterVendedorDTO(x))
                                                .ToList();
            
            return vendedores;
        }

        public Vendedor AtualizarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();

            return vendedor;
        }

        public void DeletarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }

        public void AtualizarSenha(Vendedor vendedor, AtualizarSenhaVendedorDTO dto)
        {
            vendedor.Senha = dto.Senha;
            AtualizarVendedor(vendedor);
        }

        public List<ListarVendedoresDTO> ListarVendedores()
        {
            var vendedores = _context.Vendedores.Select(x => new ListarVendedoresDTO(x))
                                                .ToList();

            return vendedores;
        }

        public bool EfetuarLogin(LoginVendedorDTO dto)
        {
            var login = false;

            foreach(var vendedor in _context.Vendedores)
            {
                if(vendedor.Login == dto.Login && vendedor.Senha == dto.Senha)
                {
                    login = true;
                }
            }
            return login;
        }
    }
}