using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProCleaningBlazorAi.Application.Interfaces.Repositories;
using ProCleaningBlazorAi.Application.Interfaces.Services;
using ProCleaningBlazorAi.Application.Services;
using ProCleaningBlazorAi.Domain.Entities;
using ProCleaningBlazorAi.Infrastructure.Persistence;
using ProCleaningBlazorAi.Infrastructure.Repositories;
using ProCleaningBlazorAi.WebUI.Components;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Lokalizácia
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrácia Repositories a Services
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ITrailerRepository, TrailerRepository>();
builder.Services.AddScoped<ITrailerService, TrailerService>();
builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
builder.Services.AddScoped<IPlatformService, PlatformService>();

// Registrácia Validátorov (všetky v Application assembly)
builder.Services.AddValidatorsFromAssemblyContaining<IAuthService>();
// Registrácia Validátorov z WebUI (napr. UserCreateDtoValidator)
builder.Services.AddValidatorsFromAssemblyContaining<ProCleaningBlazorAi.WebUI.Validators.UserCreateDtoValidator>();


// ...

// Auth Services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => 
    {
        options.LoginPath = "/login";
        options.Cookie.Name = "ProCleaning.Auth";
    });

builder.Services.AddAuthorization();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddCascadingAuthenticationState();

// Add Controllers (pre Login/Logout)
builder.Services.AddControllers();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication(); // Musí byť pred Authorization
app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapControllers(); // Mapovanie controllerov
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
