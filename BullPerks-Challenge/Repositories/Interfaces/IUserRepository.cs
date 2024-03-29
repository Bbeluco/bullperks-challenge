namespace BullPerks_Challenge;

public interface IUserRepository
{
    public UsersModel RegisterUser(RegisterDTO dto);
    public UsersModel? getUserByLoginInformation(LoginDTO dto);
}
