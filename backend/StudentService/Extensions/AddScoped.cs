using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StudentService.Interfaces;
using StudentService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IStatusStudentService, StatusStudentService>();
            services.AddScoped<IStudentsService, StudentsService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IKursService, KursService>();
        }
    }
}
