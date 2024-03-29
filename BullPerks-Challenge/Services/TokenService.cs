using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;

namespace BullPerks_Challenge;

public class TokenService : ITokenService
{
    public static string secret = "12345678-1234-1234-1234-123456789123";

    public string GenerateToken(UsersModel user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secret);
        var claims = user.Role;
        var tokenDescriptor = new SecurityTokenDescriptor {
            Subject = new System.Security.Claims.ClaimsIdentity(claims),
            Expires = DateTime.Now.AddHours(8),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
