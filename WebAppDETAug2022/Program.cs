using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppDETAug2022.Data;
using WebAppDETAug2022.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Add services dependency of IHello
builder.Services.AddSingleton<IHello, Hello1>();
builder.Services.AddDbContext<WebAppDETAug2022Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppDETAug2022Context") ?? throw new InvalidOperationException("Connection string 'WebAppDETAug2022Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
   name: "default",
   pattern: "{controller=Friend}/{action=Details}/{id}");

app.Run();
