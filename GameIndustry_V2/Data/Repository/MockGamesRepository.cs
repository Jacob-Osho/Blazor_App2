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
                    GenreId = 0,
                    ReleaseDate = new DateTime(2018, 11, 19),
                    Image="https://s1.gaming-cdn.com/images/products/8676/orig-fallback-v1/farming-simulator-22-pc-mac-game-steam-cover.jpg"


                },
                new GameModel()
                {
                    Name = "The Witcher 3",
                    GenreId = 2,
                    ReleaseDate = new DateTime(2015, 05, 18),
                    Image="https://s1.gaming-cdn.com/images/products/972/orig-fallback-v1/the-witcher-3-wild-hunt-expansion-pass-pc-game-gogcom-cover.jpg"

                },
                new GameModel()
                {
                    Name = "Destroy all Humans",
                    GenreId = 1,
                    ReleaseDate = new DateTime(2020, 07, 28),
                    Image ="https://cdn1.epicgames.com/c12a5687fb024192999b2d22c555d4c6/offer/DAH_Portrait-1200x1600-2e2b6bca291228e4df252c4857664408.jpg"

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
                     Name = "Platformer"
                 },
                 new Genre()
                  {
                      Id = 4,
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
