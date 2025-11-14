var builder = WebApplication.CreateBuilder(args);

// You can add services here later if needed
// builder.Services.Add...();

var app = builder.Build();

// Simple health check endpoint
app.MapGet("/", () => "API is running");

// Weather endpoint
app.MapGet("/weatherforecast", () => "Hello from Sepideh's CI/CD API!");

app.Run();
