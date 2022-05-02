using Businiss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiss.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<bool> Adicionar(TEntity obj);
        Task<bool> Atualizar(TEntity obj);
        Task<TEntity> Buscar(Guid Id);
        Task Deletar(Guid Id);

    }
}