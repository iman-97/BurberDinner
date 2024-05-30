using BurberDinner.Application.Common.Interfaces.Persistence;
using BurberDinner.Domain.Entities;

namespace BurberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new List<User>();

    public void Add(User user) =>
        _users.Add(user);

    public User? GetUserByEmail(string email) =>
         _users.SingleOrDefault(u => u.Email == email);

}
