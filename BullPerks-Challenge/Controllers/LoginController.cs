using Microsoft.AspNetCore.Mvc;

namespace BullPerks_Challenge;

[ApiController]
public class LoginController : ControllerBase
{
    private IUserService _userService;

    public LoginController(IUserService userService) {
        _userService = userService;
    }

    [HttpPost("/login")]
    public async Task<IResult> Login(LoginDTO dto) {
        return await _userService.getUserByLoginInformation(dto);
    }

}
