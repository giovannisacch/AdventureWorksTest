using AdventureWorks.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Api.Controllers
{
    [Route("api/competidor")]
    [ApiController]
    public class CompetidorController : ControllerBase
    {
        private readonly IRepositoryCompetidor _repository;
        public CompetidorController(IRepositoryCompetidor repos)
        {
            _repository = repos;
        }
        // GET: api/Competidor
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var competidores = _repository.FindAll();
            return Ok(competidores);
        }

        // GET: api/Competidor/5
        [HttpGet("GetCompetidor/{id:int}")]
        public IActionResult GetCompetidor(int id)
        {
            return Ok(_repository.FindById(id));
        }

        // POST: api/Competidor
        [HttpPost]
        public IActionResult AddCompetidor([FromBody] string value)
        {
            return Ok(_repository.Add());
        }

        // PUT: api/Competidor/5
        [HttpPut("UpdateCompetidor/{id:int}")]
        public void UpdateCompetidor(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("DeleteCompetidor/{id:int}")]
        public void DeleteCompetidor(int id)
        {
        }
    }
}
