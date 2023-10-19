using Microsoft.AspNetCore.Http.Extensions;
using TDDStackExample.Client;

namespace TDDStackExample.Server;

public class MyApplicationBuilder
{
    public static WebApplication Create(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        ConfigureServices(builder.Services);

        var app = builder.Build();
        
        Configure(app, app.Environment);

        return app;
    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddRazorPages();
    }

    public static void Configure(IApplicationBuilder iapp, IWebHostEnvironment env)
    {
        var app = iapp as WebApplication;

        app.Use(async (i, j) =>
        {
            Console.WriteLine(i.Request.GetDisplayUrl());
            await j();
        });

        // Configure the HTTP request pipeline.
        if (env.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
        }

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();
        app.UseRouting();


        app.MapRazorPages();
        app.MapControllers();
        app.MapFallbackToFile("index.html");
    }
}