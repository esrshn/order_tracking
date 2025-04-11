using Microsoft.EntityFrameworkCore;
using order_tracking; // Bu senin DbContext ve model sınıflarının namespace'i

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true).Build();

// ✅ Buraya DbContext servisini ekliyoruz:
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Diğer servisler<
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Migration'ları uygulama
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate(); // Migration'ları uygula
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred during migration.");
    }
}

// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();