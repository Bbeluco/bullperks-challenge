namespace BullPerks_Challenge;

public interface IUserService
{
    public Task<IResult> RegisterUser(RegisterDTO dto);
    public Task<IResult> getUserByLoginInformation(LoginDTO dto);
}
