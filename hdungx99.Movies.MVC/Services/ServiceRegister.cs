
using hdungx99.Core.Auth.AuthConstant;
using hdungx99.Core.Auth.AuthRegister;
using hdungx99.Movies.MVC.ClientService;

namespace hdungx99.Movies.MVC.Services
{
    public static class ServiceRegister
    {
        public static void AddServiceRegister(this IServiceCollection services)
        {
            var authScheme = new AuthScheme()
            {
                ClientId = "hdungx99.movies.mvc-client",
                ClientSecret = "hdungx99-movies.mvc-client"
            };
            services.AddAuthServices(authScheme);
            services.AddTransient<IMoviesClient, MoviesClient>();
            // Add services to the container.
            services.AddControllersWithViews();
        }

    }
}
