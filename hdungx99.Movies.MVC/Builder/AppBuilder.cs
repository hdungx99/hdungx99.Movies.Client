using hdungx99.Core.Auth.AuthBuilder;

namespace hdungx99.Movies.MVC.Builder
{
    public static class AppBuilder
    {
        public static void AddBuilder(this IApplicationBuilder builder, bool isDev)
        {
            // Configure the HTTP request pipeline.
            if (!isDev)
            {
                builder.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                builder.UseHsts();
            }

            builder.UseHttpsRedirection();
            builder.UseStaticFiles();

            builder.UseRouting();

            builder.AddAuthBuilder();
        }
    }
}
