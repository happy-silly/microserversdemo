using Business.WebBFFHttpApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Business.WebBFFHttpApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region 跨域配置
            //string[] ips = new string[] { "http://127.0.0.1:8099" };
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("default", policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod());
            //});
            services.AddCors(options => {

                // this defines a CORS policy called "default"

                options.AddPolicy("default", policy => {

                    policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();

                });

            });
            #endregion
            services.AddControllers();
            //读取配置信息
            services.Configure<HttpApiUrlStrs>(this.Configuration.GetSection("HttpApiUrlStrs"));
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseCors("default");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            

        }
    }
}
