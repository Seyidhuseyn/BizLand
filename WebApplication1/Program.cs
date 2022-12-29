namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
            app.Run();
        }
    }
}