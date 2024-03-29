using System.ComponentModel.DataAnnotations;

namespace MovieStar.Core.Dto;
public class CharacterAddDto
{
    [Required]
    public string CharacterName { get; set; } = "";
    public int HitPoints { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }
    public int Intelligence { get; set; }
    [Required]
    public int CreatedByID { get; set; }
}
