using EmployeeInfo.Components;
using Microsoft.EntityFrameworkCore;
using EmployeeInfo.Models;
using EmployeeInfo.Reposiotries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var connectionString= builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EmployeesContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 10)))); // Thay đổi phiên bản nếu cần

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
