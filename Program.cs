namespace Middleware.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            // Add services to the container.
            //builder.Services.AddRazorPages();
            builder.Services.AddTransient<CustomMiddlewareBase>();
            var app = builder.Build();

            app.UseMiddleware<CustomMiddlewareBase>();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // app.UseRouting();

           // app.UseAuthorization();

           // app.MapRazorPages();

            app.Run();
        }
        
    }
}