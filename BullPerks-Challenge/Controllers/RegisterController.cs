using Microsoft.AspNetCore.Mvc;

namespace BullPerks_Challenge;

[ApiController]
public class RegisterController : ControllerBase
{
    private IUserService _userService;

    public RegisterController(IUserService userService) {
        _userService = userService;
    }

    [HttpPost("/register")]
    public async Task<IResult> Register(RegisterDTO dto) {
        return await _userService.RegisterUser(dto);
    }
}
