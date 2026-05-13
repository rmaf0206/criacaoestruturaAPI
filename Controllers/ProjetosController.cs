using ExoApi.Models;
using ExoApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _repository;

        public ProjetosController(ProjetoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repository.Listar());
        }
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            _repository.Cadastrar(projeto);
            return StatusCode(201);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Projeto projeto = _repository.BuscarPorId(id);
            if (projeto == null)
            {
                return NotFound();
            }
            
            return Ok(projeto);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            _repository.Atualizar(id, projeto);
            return StatusCode(204);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            try
            {
                _repository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}