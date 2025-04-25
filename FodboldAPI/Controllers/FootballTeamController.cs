using Microsoft.AspNetCore.Mvc;
using FodboldAPI.Model;
using FodboldAPI.Repository;

namespace FootballAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FootballTeamController : ControllerBase
    {
        private readonly FootballTeamRepository _repository = new FootballTeamRepository();

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var team = _repository.GetById(id);
            return team == null ? NotFound() : Ok(team);
        }

        [HttpPost]
        public IActionResult Create(FootballTeam team)
        {
            _repository.Add(team);
            return CreatedAtAction(nameof(GetById), new { id = team.Id }, team);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _repository.Delete(id);
            return success ? NoContent() : NotFound();
        }
    }
}
