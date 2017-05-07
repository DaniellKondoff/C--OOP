using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Moq;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class HighScoreTest
    {
        private HighScore highScore;

        [TestInitialize]
        public void PreparePlayers()
        {
            var fileProviderMock = new Mock<IFileProvider>();
            var data = new List<Player>();

            fileProviderMock.Setup(f => f.ReadAll(It.IsAny<string>()))
                .Returns(()=> 
                {
                    return string.Join(",", data.Select(n => $"{n.Name},{n.Points}"));
                });

            fileProviderMock.Setup(f => f.WiteAll(It.IsAny<string>(), It.IsAny<string>()))
                .Callback<string, string>((filePath, content) =>
                 {
                     data=Player.Parse(content).ToList();
                 });

            this.highScore = new HighScore(fileProviderMock.Object);

            for (int i = 0; i < 20; i++)
            {
                highScore.AddPlayer(new Player(i.ToString(), i + 100));
            }
        }

        [TestMethod]
        public void AddPlayerShouldHaveNoMoreThantenPlayers()
        {           
            Assert.AreEqual(10, this.highScore.Load().Count());
        }

        [TestMethod]
        public void AddPlayerShouldBeOrderBydescending()
        {
            var points = this.highScore.Load().Select(p => p.Points).ToList();

            Assert.IsTrue(points.Any());

            var max = points.First();

            for (int i = 1; i < points.Count; i++)
            {
                var current = points[i];

                Assert.IsTrue(max >= current);
                max = current;
            }
        }
    }
}
