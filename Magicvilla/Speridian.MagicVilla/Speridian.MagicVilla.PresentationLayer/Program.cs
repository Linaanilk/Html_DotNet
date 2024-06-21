using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Speridian.MagicVilla.BL;
using Speridian.MagicVilla.DAL;
using Speridian.MagicVilla.Helpers;
using Speridian.MagicVilla.PresentationLayer.Models;
using System.Text;

namespace Speridian.MagicVilla.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(options =>
     {
         options.TokenValidationParameters = new TokenValidationParameters
         {
             ValidateIssuer = true,// Indicates that the JWT issuer (iss) should be validated. 
             ValidateAudience = true,// Indicates that the JWT audience (aud) should be validated. 
             ValidateLifetime = true,
             ValidIssuer = builder.Configuration["Jwt:Issuer"],
             ValidAudience = builder.Configuration["Jwt:Audience"],
             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
             ClockSkew = TimeSpan.Zero

         };
     });

            // Add services to the container.
            builder.Services.AddDbContext<MagicVillaContext>();
            builder.Services.AddScoped<IVillaDAL, VillaDAL>();
            builder.Services.AddScoped<VillaBL>();
            builder.Services.AddScoped<ILoginDAL, LoginDAL>();
            builder.Services.AddScoped<IAuthorize, Authorize>();
            builder.Services.AddScoped<LoginBL>();
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

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
