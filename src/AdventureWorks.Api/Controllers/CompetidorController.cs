using AdventureWorks.Api.ViewModels;
using AdventureWorks.Repository.Interfaces;
using AdventureWorks.Repository.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdventureWorks.Api.Controllers
{
    [Route("api/competidor")]
    [ApiController]
    public class CompetidorController : ControllerBase
    {
        private readonly IRepositoryCompetidor _repository;
        private readonly IMapper _mapper;
        public CompetidorController(IRepositoryCompetidor repos, IMapper mapper)
        {
            _repository = repos;
            _mapper = mapper;
        }
        // GET: api/Competidor
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var competidores  = _repository.FindAll();
            var competidoresVM = new List<CompetidorViewModel>();

            foreach (var item in competidores)
            {
                competidoresVM.Add(_mapper.Map<CompetidorViewModel>(item));
            }
            return Ok(competidoresVM);
        }

        // GET: api/Competidor/5
        [HttpGet("GetCompetidor/{id:int}")]
        public IActionResult GetCompetidor(int id)
        {
            var competidorVM = _mapper.Map<CompetidorViewModel>(_repository.FindById(id));
            return Ok(competidorVM);
        }

        // POST: api/Competidor
        [HttpPost]
        public IActionResult AddCompetidor([FromBody] CompetidorViewModel competidorVM)
        {
            _repository.Add(_mapper.Map<Competidor>(competidorVM));
            return Ok();
        }

        // PUT: api/Competidor/5
        [HttpPut("{id:int}")]
        public IActionResult UpdateCompetidor(int id, [FromBody] CompetidorViewModel competidorVM)
        {
            var competidor = _repository.FindById(id);
            if (competidor == null)
                return NotFound();

            _repository.Update(_mapper.Map(competidorVM, competidor));
            return Ok();
        }

        // DELETE: api/competidor/5
        [HttpDelete("{id:int}")]
        public void DeleteCompetidor(int id)
        {
            //_repository.Delete(id)
        }
    }
}
