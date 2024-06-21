using Microsoft.EntityFrameworkCore;
using WebApplicationAPI13.Model;

namespace WebApplicationAPI13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddSingleton();
            //builder.Services.AddTransient();
            //builder.Services.AddScoped();

            //builder.Services.AddSingleton<IEmployeeService, EmployeeMockService>(); 
           /// builder.Services.AddTransient<IEmployeeService,EmployeeDbService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeDbService>();

            builder.Services.AddDbContextPool<DatabaseContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("mydb"));
            });

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200");
                    });

                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowAll");

            app.UseAuthorization();



            app.MapControllers();

            app.Run();
        }
    }
}
