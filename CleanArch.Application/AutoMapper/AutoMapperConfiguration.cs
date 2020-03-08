using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterProfiles()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelProfile());
                config.AddProfile(new ViewModelToCommandProfile());
            });
        }
    }
}
