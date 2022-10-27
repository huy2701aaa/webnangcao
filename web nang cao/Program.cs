using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using web_nang_cao.Data;
using web_nang_cao.Models;
using web_nang_cao.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<web_nang_caoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("web_nang_caoContext") ?? throw new InvalidOperationException("Connection string 'web_nang_caoContext' not found.")));

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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

app.MapRazorPages();

app.Run();
