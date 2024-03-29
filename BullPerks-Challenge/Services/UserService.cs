
namespace BullPerks_Challenge;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    private ITokenService _tokenService;

    public UserService(IUserRepository userRepository, ITokenService tokenService) {
        _userRepository = userRepository;
        _tokenService = tokenService;
    }

    public async Task<IResult> getUserByLoginInformation(LoginDTO dto)
    {
        UsersModel user = _userRepository.getUserByLoginInformation(dto);
        if(user == null) {
            return Results.Unauthorized();
        }

        return Results.Ok(_tokenService.GenerateToken(user));
    }

    public async Task<IResult> RegisterUser(RegisterDTO dto)
    {
        _userRepository.RegisterUser(dto);
        return Results.Created();
    }
}
