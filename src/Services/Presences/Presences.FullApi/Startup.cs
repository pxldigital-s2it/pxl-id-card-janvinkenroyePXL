using Microsoft.AspNetCore.Authentication.JwtBearer;
using Presences.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Presences.Logic;

namespace Presences.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
        services.AddAuthorization();
        services.AddControllers();
        services.AddDbContext<PresencesContext>(dbContextOptions => dbContextOptions.UseSqlServer(
            Configuration.GetConnectionString("PresencesDBConnectionString")));
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddSingleton(MappingConfig.CreateMapper());

        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ILectorRepository, LectorRepository>();
        services.AddScoped<IAdminRepository, AdminRepository>();
        services.AddScoped<IMomentRepository, MomentRepository>();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

    }
}
