using System.ComponentModel.DataAnnotations;

namespace BullPerks_Challenge;

public class RegisterDTO
{
    public string Username { get; set; }
    public string Password { get; set; }

    [EnumDataType(typeof(RolesEnum))]
    public RolesEnum Role { get; set; }
}
