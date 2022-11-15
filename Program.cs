using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ColmadosAPP.Data;
using ColmadosAPP.Data.Service;
using ColmadosAPP.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSqlite<ColmadoDbContext>("Data Source=.//Data//Context//DataBase.sqlite");
builder.Services.AddScoped<IColmadoDbContext,ColmadoDbContext>();
builder.Services.AddScoped<IColmadoService,ColmadoService>();
builder.Services.AddScoped<IUsuarioService,UsuarioService>();
builder.Services.AddSingleton<WeatherForecastService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ColmadoDbContext>();
    db.Database.EnsureCreated();
}

app.Run();
