using KognitAPI.Models;

namespace KognitAPI.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        IEnumerable<User> GetAll();
    }
}
