

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameIndustry_V2.Models
{
    public class GameModel
    {
        public int Id { get; set; } = 1;
        [Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Descritoion { get; set; }
        public bool Insale { get; set; }
        public string GamePlayVideo { get; set; }
        public List<GamesGenres> GamesGenres { get; set; } = new();
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string Image { get; set; }
        public string ShortName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                    return null;

                if (Name.Length > 60)
                    return Name.Substring(0, 57) + "...";
                else
                    return Name;
            }
        }
    }
}

