
using hdungx99.Core.Auth.AuthClientDI;

namespace hdungx99.Movies.MVC.ClientService
{
    public class MoviesClient : AuthClient, IMoviesClient
    {
        public MoviesClient(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
