using TokenBaseAuthentication.Models;

namespace TokenBaseAuthentication.Business.IServices
{
    public interface IAuthService
    {
        public Task<User> Login(string email, string password);
        public Task<User> Register(User user);
    }
}
