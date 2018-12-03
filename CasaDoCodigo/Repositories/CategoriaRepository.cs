using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria> SaveCategoria(string nome);
    }

    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<Categoria> SaveCategoria(string nome)
        {
            Categoria model = dbSet.FirstOrDefault(c => c.Nome.Trim().ToUpper() == nome.Trim().ToUpper());

            if(model == null)
            {
                model = new Categoria(nome);

                dbSet.Add(model);

                await contexto.SaveChangesAsync();
            }

            return model;
        }
    }
}
