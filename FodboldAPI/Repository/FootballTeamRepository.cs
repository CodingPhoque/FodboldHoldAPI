using System.Collections.Generic;
using System.Linq;
using FodboldAPI.Model;

namespace FodboldAPI.Repository
{
    public class FootballTeamRepository
    {
        private readonly List<FootballTeam> _teams = new List<FootballTeam>();

        public FootballTeamRepository()
        {
            _teams.Add(new FootballTeam { Id = 1, Name = "FC København", City = "København", YearFounded = 1992 });
            _teams.Add(new FootballTeam { Id = 2, Name = "Brøndby IF", City = "Brøndby", YearFounded = 1964 });
        }

        public IEnumerable<FootballTeam> GetAll() => _teams;

        public FootballTeam? GetById(int id) => _teams.FirstOrDefault(t => t.Id == id);

        public void Add(FootballTeam team) => _teams.Add(team);

        public bool Delete(int id)
        {
            var team = GetById(id);
            if (team == null) return false;
            _teams.Remove(team);
            return true;
        }
    }
}

