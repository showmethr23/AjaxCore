using AjaxCore.Models;
using System.Collections.Generic;

namespace AjaxCore.Services
{
    public interface ICourseService
    {
        List<Semester> GetSemesters();
        List<Course> GetCoursesForASemester(int semesterId);
        List<Enrollment> GetEnrollmentForACourse(string courseNum);

    }
}
