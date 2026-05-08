using System.Collections.Generic;
using System.Linq;
using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        public IEnumerable<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}