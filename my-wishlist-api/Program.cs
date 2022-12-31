using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using my_wishlist_api.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MyWishlist API",
        Description = "Making easier remember your desires",
        Version = "v1"
    });
});

var connectionString = builder.Configuration.GetConnectionString("SqliteConnectionString");
builder.Services.AddDbContext<MyWishlistDbContext>(options =>
    options.UseSqlite(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyWishlist API V1");
    });
}

app.UseHttpsRedirection();

#region Routes
app.MapGet("/", () => "Hello Wishlist!");
#endregion

app.Run();
