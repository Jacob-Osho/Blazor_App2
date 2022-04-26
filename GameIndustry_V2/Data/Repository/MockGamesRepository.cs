using GameIndustry_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameIndustry_V2.Data.Repository
{
    public class MockGamesRepository : IRepository
    {
        readonly List<GameModel> _gameModels;
        readonly List<Genre> _genres;
        public MockGamesRepository()
        {
            _gameModels = new List<GameModel>()
            {
                new GameModel()
                {
                    Name = "Farming Simulator",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)

                },
                new GameModel()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015, 05, 18)

                },
                new GameModel()
                {
                    Name = "Destroy all Humans",
                    Genre = "Actio-advanture",
                    ReleaseDate = new DateTime(2020, 07, 28)

                }
            };
            _genres = new List<Genre>()
            {
                new Genre()
                {
                    Id =0,
                    Name = "Simulator"
                },
                new Genre()
                {
                    Id =1,
                    Name = "RPG"
                },new Genre()
                {
                    Id =2,
                    Name = "Action"
                },
                 new Genre()
                  {
                      Id = 3,
                      Name = "Horror"
                  }
            };
        }
    
        public List<GameModel> GetAllGames()
        {
            return _gameModels;
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }
        public Genre GetGenreById(int id)
        {
            return _genres.FirstOrDefault(x => x.Id.Equals(id));
        }
        public bool EditGenre(Genre editedGenre)
        {
            var oldGenre = _genres.FirstOrDefault(x=>x.Id.Equals(editedGenre.Id));
            if(oldGenre is not null)
            {
                oldGenre = editedGenre;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
