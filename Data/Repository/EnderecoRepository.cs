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
    public class EnderecoRepository : Repositorio<Endereco>, IEndereco
    {
        public EnderecoRepository(Contexto context) : base(context) { }

        public Task<Endereco> EnderecoFornecedor(Guid Id)
        {
            return _contexto.Enderecos.Include(x => x.Fornecedor).FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}