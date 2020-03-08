using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _handler;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler handler, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _handler = handler;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //CreateCourseCommand create = new CreateCourseCommand(
            //    courseViewModel.Name, courseViewModel.CourseCode);
            _handler.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses()
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
