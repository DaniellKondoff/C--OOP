using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;

namespace Demo
{
    public  class HighScore
    {
        private readonly IFileProvider fileProvider;

        public HighScore(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public  IEnumerable<Player> Load()
        {
            var savedData = this.fileProvider.ReadAll("highscore.dat");

            var list = Player.Parse(savedData);

            return new ReadOnlyCollection<Player>(list);
        }

        public  void AddPlayer(Player player)
        {
            var data = this.Load().ToList();
            data.Add(player);
            var newData=data
                .OrderByDescending(p => p.Points)
                .Take(10)
                .Select(p=> $"{p.Name},{p.Points}")
                .ToList();

            this.fileProvider.WiteAll("highscore.dat",string.Join(",",newData));
        }
    }
}
