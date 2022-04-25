

using GameIndustry_V2.Models;
using System.Collections.Generic;

namespace GameIndustry_V2.Data.Repository
{
    public interface IRepository
    {
        List<GameModel> GetAllGames();
    }
}
