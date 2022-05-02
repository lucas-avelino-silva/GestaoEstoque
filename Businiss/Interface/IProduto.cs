using Businiss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiss.Interface
{
    public interface IProduto
    {
        Task<Produto> ProdutoFornecedor(Guid Id);
        Task<List<Produto>> ListarProdutosFornecedores();
    }
}