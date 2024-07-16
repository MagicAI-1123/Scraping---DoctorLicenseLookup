
namespace DocLicenseLookupApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var specificOrgins = "AppOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: specificOrgins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:4200");
                                  });
            });

            var app = builder.Build();

            app.UseCors(specificOrgins);

            // Configure the HTTP request pipeline.
           // if (app.Environment.IsDevelopment())
          //  {
                app.UseSwagger();
                app.UseSwaggerUI();
        //    }

           

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
