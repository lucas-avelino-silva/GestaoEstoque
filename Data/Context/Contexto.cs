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

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
