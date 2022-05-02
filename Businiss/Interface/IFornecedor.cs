using Businiss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiss.Interface
{
    public interface IFornecedor
    {
        Task<Fornecedor> FornecedorEndereco(Guid Id);

        Task<List<Fornecedor>> ListarFornecedor();
        Task<List<Fornecedor>> ListarFornecedorEndereco();

    }
}