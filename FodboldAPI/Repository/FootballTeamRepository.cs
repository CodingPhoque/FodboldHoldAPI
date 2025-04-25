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
            _teams.Add(new FootballTeam { Id = 3, Name = "FC Midtjylland", City = "Herning", YearFounded = 1999 });
            _teams.Add(new FootballTeam { Id = 4, Name = "AGF", City = "Aarhus", YearFounded = 1880 });
            _teams.Add(new FootballTeam { Id = 5, Name = "Silkeborg IF", City = "Silkeborg", YearFounded = 1917 });
            _teams.Add(new FootballTeam { Id = 6, Name = "Randers FC", City = "Randers", YearFounded = 2003 });
            _teams.Add(new FootballTeam { Id = 7, Name = "Viborg FF", City = "Viborg", YearFounded = 1896 });
            _teams.Add(new FootballTeam { Id = 8, Name = "Lyngby BK", City = "Lyngby", YearFounded = 1921 });
            _teams.Add(new FootballTeam { Id = 9, Name = "FC Nordsjælland", City = "Farum", YearFounded = 2003 });
            _teams.Add(new FootballTeam { Id = 10, Name = "SønderjyskE", City = "Haderslev", YearFounded = 2004 }); // Oprykker
            _teams.Add(new FootballTeam { Id = 11, Name = "Vejle BK", City = "Vejle", YearFounded = 1891 });
            _teams.Add(new FootballTeam { Id = 12, Name = "Aalborg BK", City = "Aalborg", YearFounded = 1885 }); // Oprykker

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

