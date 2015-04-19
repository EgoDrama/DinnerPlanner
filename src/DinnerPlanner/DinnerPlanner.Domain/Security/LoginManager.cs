using DinnerPlanner.Domain.Model;
using DinnerPlanner.Domain.Repository;

namespace DinnerPlanner.Domain.Security
{
    public class LoginManager: ILoginManager
    {
        private readonly IRepository<User> _useRepository;

        public LoginManager(IRepository<User> useRepository)
        {
            _useRepository = useRepository;
        }

        public bool Login(string username, string password)
        {
            return true;
        }
    }
}