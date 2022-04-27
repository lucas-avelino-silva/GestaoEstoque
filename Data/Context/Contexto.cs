using Businiss.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Context
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions option): base(option) { }

        DbSet<Endereco> Enderecos { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<Produto> Produtos { get; set; }
    }
}
