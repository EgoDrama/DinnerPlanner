using Common.Repository;
using DinnerPlanner.Domain.Domain.Model;

namespace DinnerPlanner.Domain.Security
{
    public class LoginManager: ILoginManager
    {
        private readonly IRepository<User, IAggregate> _useRepository;

        public LoginManager(IRepository<User, IAggregate> useRepository)
        {
            _useRepository = useRepository;
        }

        public bool Login(string username, string password)
        {
            return true;
        }
    }
}