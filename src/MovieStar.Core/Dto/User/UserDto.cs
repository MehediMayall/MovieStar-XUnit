namespace MovieStar.Core.Dto;
public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }= string.Empty;
    public string LastName { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty;
    public string CreatedByID { get; set; }= string.Empty;
    public DateTime CreatedOn { get; set; }
    public List<CharacterDto> Characters { get; set; }
}
