using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>((options) =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext"))
           .LogTo(Console.WriteLine, LogLevel.Information);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/User", () =>
{

});
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
