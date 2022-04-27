
using Businiss.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mappings
{
    public class FornecedorMappings : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.CNPJ).HasColumnType("varchar(14)").IsRequired();
            builder.HasOne(x => x.Endereco).WithOne(e => e.Fornecedor);
            builder.HasMany(x => x.Produtos).WithOne(p => p.Fornecedor).HasForeignKey(p => p.FornecedorId);
            builder.ToTable("Fornecedores");
        }
    }
}
