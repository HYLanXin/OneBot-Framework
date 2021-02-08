using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using QQRobot.QQRobot;
using QQRobot.Services;
using QQRobot.Services.Implements;
using QQRobot.VO;

namespace QQRobot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ���û����˺���
            services.Configure<CQHttpServerConfigModel>(Configuration.GetSection("CQHttpConfig"));
            services.AddSingleton<IBotService, BotService>();
            services.AddSingleton<ICommandService, CommandService>();

            // ���û�����ģ��
            services.Scan(scan => scan
                .FromAssemblyOf<IQQRobotService>()
                .AddClasses()
                .AsImplementedInterfaces()
                .WithSingletonLifetime());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            // ��ʼ��
            var serviceProvider = app.ApplicationServices;

            // ��ʼ�������˺���
            var soraService = serviceProvider.GetService<IBotService>();
            soraService.Start();
        }
    }
}
