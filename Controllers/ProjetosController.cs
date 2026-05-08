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
    }
}