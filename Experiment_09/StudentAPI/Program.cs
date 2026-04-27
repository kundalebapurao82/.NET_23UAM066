var builder = WebApplication.CreateBuilder(args);

// Add controller support
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

// 🔥 MOST IMPORTANT
app.MapControllers();

app.Run();