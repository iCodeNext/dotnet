using WithIn.Application;
using WithIn.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.RegisterApplicationServices()
                    .RegisterPersistenceServices(builder.Configuration);
    //builder.Services.AddDbContext<>
}

// ---------- user delete --------- notification add ---- 
// -------  return;
// ---------- order add -----------
// --- Context.SaveChange(); ---------

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}