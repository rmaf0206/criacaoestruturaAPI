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

        public void Cadastrar (Projeto projeto)
        {
            _context.Projetos.Add (projeto);
            _context.SaveChanges();
        }
        public Projeto BuscarPorId (int id)
        {
            return _context.Projetos.Find(id)!;
        }

        public void Atualizar (int id, Projeto proj)
        {
            Projeto projBuscado = _context.Projetos.Find(id)!;

            if(projBuscado == null)
            {
            projBuscado.NomeDoProjeto = proj.NomeDoProjeto;
            projBuscado.Area = proj.Area;
            projBuscado.Status = proj.Status;
            }
            _context.Projetos.Update(projBuscado);
            _context.SaveChanges();
        }

        public void Deletar (int id)
        {
            Projeto? projetoBuscado = _context.Projetos.Find(id);
            _context.Projetos.Remove(projetoBuscado);
            _context.SaveChanges();
        }
    }
}