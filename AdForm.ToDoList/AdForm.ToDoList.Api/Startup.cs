using AdForm.ToDoList.Application.List.Command;
using AdForm.ToDoList.Domain;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AdForm.ToDoList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddMediatR(typeof(CreateListCommand).Assembly);

            //var cs = Configuration.GetConnectionString(ToDoRepository.ConnectionStringKey);
            var cs = @"Data Source=.\DEV2008;Initial Catalog=ToDoLists;Integrated Security=True;pooling=false";

            services.AddDbContext<ToDoRepository>(opt => opt.UseSqlServer(cs));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ToDoRepository repository)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            repository.Database.Migrate();
        }
    }
}