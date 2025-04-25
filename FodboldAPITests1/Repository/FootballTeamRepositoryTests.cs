using Microsoft.VisualStudio.TestTools.UnitTesting;
using FodboldAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FodboldAPI.Model;

namespace FodboldAPI.Repository.Tests
{
    [TestClass()]
    public class FootballTeamRepositoryTests
    {
        [TestMethod]
        public void AddTeam_ShouldIncreaseCount()
        {
            // Arrange
            var repo = new FootballTeamRepository();
            int initialCount = repo.GetAll().Count();

            var newTeam = new FootballTeam
            {
                Id = 3,
                Name = "AGF",
                City = "Aarhus",
                YearFounded = 1880
            };

            // Act
            repo.Add(newTeam);

            // Assert
            Assert.AreEqual(initialCount + 1, repo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteTeam_ShouldRemoveTeam()
        {
            // Arrange
            var repo = new FootballTeamRepository();

            // Act
            var success = repo.Delete(1);

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void GetById_ReturnsCorrectTeam()
        {
            // Arrange
            var repo = new FootballTeamRepository();

            // Act
            var team = repo.GetById(1);

            // Assert
            Assert.IsNotNull(team);
            Assert.AreEqual("FC København", team.Name);
        }
    }
}