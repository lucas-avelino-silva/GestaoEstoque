using Businiss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiss.Interface
{
    public interface IEndereco
    {
        Task<Endereco> EnderecoFornecedor(Guid Id);
    }
}