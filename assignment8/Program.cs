using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using assignment8.Models;

var builder = WebApplication.CreateBuilder(args);

// 添加服务到容器
builder.Services.AddRazorPages();
builder.Services.AddDbContext<assignment8.Data.assignment8Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 调用 SeedData 初始化数据库
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the database.");
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
