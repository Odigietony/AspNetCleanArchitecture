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

        public CourseService(ICourseRepository courseRepository, IMediatorHandler handler)
        {
            _courseRepository = courseRepository;
            _handler = handler;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            CreateCourseCommand create = new CreateCourseCommand(courseViewModel.Name, courseViewModel.CourseCode);
            _handler.SendCommand(create);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
