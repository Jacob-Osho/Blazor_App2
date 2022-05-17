

using GameIndustry_V2.Models;
using System.Collections.Generic;

namespace GameIndustry_V2.Data.Repository
{
    public interface IRepository
    {
        List<GameModel> GetAllGames();
        bool CreateNewGame(GameModel newGame);
        GameModel GetGameById(int id);
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        bool  EditGenre(Genre editedGenre);
        List<GameDeveloper> GetAllDevelopers();
    }
}
