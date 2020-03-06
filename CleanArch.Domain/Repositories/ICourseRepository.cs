using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Repositories
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetCourses();
    }
}
