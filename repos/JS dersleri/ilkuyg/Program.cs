using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
public IConfiguration Configuration { get; }
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.AddSession();
}
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();
    app.UseSession();

    app.UseAuthorization();

    app.MapControllerRoute(name: "ACAR",
                           pattern: "{controller=cookies}/{action=Index}/{id?}");

    app.Run();
}




