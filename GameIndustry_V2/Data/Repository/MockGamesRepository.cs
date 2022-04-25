using GameIndustry_V2.Models;
using System;
using System.Collections.Generic;

namespace GameIndustry_V2.Data.Repository
{
    public class MockGamesRepository : IRepository
    {
        private List<GameModel> _gameModels;
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
        }
        public List<GameModel> GetAllGames()
        {
            return _gameModels;
        }
    }
}
