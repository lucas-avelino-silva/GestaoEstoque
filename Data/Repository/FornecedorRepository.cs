using Businiss.Interface;
using Businiss.Model;
using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    public class FornecedorRepository : Repositorio<Fornecedor>, IFornecedor
    {
        public FornecedorRepository(Contexto contexto) : base(contexto) { }

        public async Task<Fornecedor> FornecedorEndereco(Guid Id)
        {
            return _contexto.Fornecedores.Include(x => x.Endereco).FirstOrDefault(x => x.Id == Id);

        }



        public async Task<List<Fornecedor>> ListarFornecedor()
        {
            return await _contexto.Fornecedores.ToListAsync();
        }

        public async Task<List<Fornecedor>> ListarFornecedorEndereco()
        {
            return await _contexto.Fornecedores.Include(x => x.Endereco).ToListAsync();
        }
    }


}
