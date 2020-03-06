using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Repositories;
using CleanArch.Infrastructure.Data.RepositoryImplementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.InversionOfControl
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Domain repository and Infrastructure Data courseRepository implementation Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
