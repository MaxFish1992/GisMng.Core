using Autofac;
using Autofac.Extensions.DependencyInjection;
using GisMng.Api.AutoModule;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace GisMng.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowDomain", pBuilder =>
                {
                    pBuilder.AllowAnyOrigin() //允许任何来源的主机访问
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials();//指定处理cookie
                });
            });

            #region Swagger
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v0.1.0",
                    Title = "GisMng API",
                    Description = "框架说明文档"
                });
                #region 读取xml信息
                var xmlPath = Path.Combine(basePath, "GisMng.Api.xml");//这个就是刚刚配置的xml文件名
                c.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，记得修改
                #endregion

            });
            #endregion

            #region AutoFac
            //实例化Autofac容器
            var builder = new ContainerBuilder();

            //注册要通过反射创建的组件
            //var assemblys = Assembly.Load("Service");//Service是继承接口的实现方法类库名称
            //var baseType = typeof(IDependency);//IDependency 是一个接口（所有要实现依赖注入的借口都要继承该接口）
            //builder.RegisterAssemblyTypes(assemblys)
            //    .Where(m => baseType.IsAssignableFrom(m) && m != baseType)
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();

            var serviceDllFile = Path.Combine(basePath, "GisMng.Service.dll");//获取注入项目绝对路径
            var assemblysService = Assembly.LoadFile(serviceDllFile);
            builder.RegisterAssemblyTypes(assemblysService).AsImplementedInterfaces();


            //将services填充Autofac容器生成器
            builder.Populate(services);
            //新模块组件注册
            //builder.RegisterModule<DefaultModuleRegister>();
            //使用已进行的组件登记创建新容器
            var ApplicationContainer = builder.Build();
            #endregion
            //第三方IOC接管
            return new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("AllowSameDomain");

            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GisMng API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
