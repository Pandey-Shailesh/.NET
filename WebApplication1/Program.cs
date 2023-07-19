using Microsoft.Extensions.FileProviders;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
            //{
            //    WebRootPath = "myroot"
            //}) ;
            var app = builder.Build();

            // app.MapGet("/", () => "Hello World!");
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //       Path.Combine(builder.Environment.ContentRootPath, "mysecondroot")) // it will work for the mysecondroot folder
            //});



            //var builder = WebApplication.CreateBuilder(args);
            //var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Getting the Response from first Enpoints/Middleware");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\nGetting the Response from second Enpoints/Middleware");

            //});

            //app.Run();




            //DefaultFilesOptions defaultOptions = new DefaultFilesOptions();
            //defaultOptions.DefaultFileNames.Clear();
            //defaultOptions.DefaultFileNames.Add("Home.html");
            //app.UseDefaultFiles(defaultOptions);

            app.UseDirectoryBrowser();
            app.UseStaticFiles();
            // app.MapGet("/", () => "Hello World!");
            app.Run();
        }
    }
}