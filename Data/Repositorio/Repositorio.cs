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
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly Contexto _contexto;
        protected readonly DbSet<TEntity> DbSet;
        public Repositorio(Contexto context)
        {
            _contexto = context;
            DbSet = _contexto.Set<TEntity>();
        }
        public async Task<bool> Adicionar(TEntity obj)
        {
            try
            {
                DbSet.Add(obj);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
             
        }

        public async Task<bool> Atualizar(TEntity obj)
        {
            try
            {
                DbSet.Update(obj);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        public Task<TEntity> Buscar(Guid Id)
        {
            return DbSet.FirstAsync(x => x.Id == Id);
        }

        public async Task Deletar(Guid Id)
        {
           DbSet.Remove(await Buscar(Id));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
