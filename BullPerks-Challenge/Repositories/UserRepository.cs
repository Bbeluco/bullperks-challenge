using Microsoft.EntityFrameworkCore;

namespace BullPerks_Challenge;

public class UserRepository : IUserRepository
{
    private SystemDbContext _dbContext;

    public UserRepository(SystemDbContext dbContext) {
        _dbContext = dbContext;
    }

    public UsersModel RegisterUser(RegisterDTO dto)
    {
        UsersModel usersModel = new UsersModel
        {
            Username = dto.Username,
            Password = dto.Password,
            Role = dto.Role.ToString()
        };

        _dbContext.Users.Add(usersModel);
        _dbContext.SaveChanges();

        return usersModel;
    }

    public UsersModel? getUserByLoginInformation(LoginDTO dto)
    {
        UsersModel? user = _dbContext.Users
            .Where(u => u.Username == dto.Username && u.Password == dto.Password)
            .FirstOrDefault();

        return user;
    }
}
