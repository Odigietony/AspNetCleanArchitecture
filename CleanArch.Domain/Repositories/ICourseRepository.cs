using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Domain.Repositories
{
    public interface ICourseRepository
    {
        public IQueryable<Course> GetCourses();
        public void Add(Course course);
    }
}
