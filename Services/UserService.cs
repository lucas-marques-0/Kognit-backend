using KognitAPI.Models;
using KognitAPI.Repositories;

namespace KognitAPI.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void AddUser(User user) => _repository.Add(user);
    }

}
