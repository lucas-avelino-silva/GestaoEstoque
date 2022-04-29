using Businiss.Interface;
using Businiss.Model;
using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositorio
{
    public class ProdutoRepository : Repositorio<Produto>, IProduto
    {
        public ProdutoRepository(Contexto contexto): base(contexto) { }

        public Task<List<Produto>> ListarProdutosFornecedores()
        {
            return _contexto.Produtos.Include(x => x.Fornecedor).ToListAsync();
        }

        public Task<Produto> ProdutoFornecedor(Guid Id)
        {
            return _contexto.Produtos.Include(x => x.Fornecedor).FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
