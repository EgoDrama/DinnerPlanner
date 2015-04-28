namespace IdentityAccess.Security
{
    public interface ILoginManager
    {
        bool Login(string username, string password);
    }
}