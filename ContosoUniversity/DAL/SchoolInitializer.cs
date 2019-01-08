﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //构建学生数据
            //将学生数据加入实体集

            var students = new List<Student>
            {
            new Student{Name="阿1",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{Name="阿2",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Name="阿3",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{Name="阿4",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Name="阿5",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Name="阿6",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{Name="阿7",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{Name="阿8",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="C#",Credits=3,},
            new Course{CourseID=4022,Title="Web开发",Credits=3,},
            new Course{CourseID=4041,Title="SQL数据库",Credits=3,},
            new Course{CourseID=1045,Title="算法数据结构",Credits=4,},
            new Course{CourseID=3141,Title="安卓开发",Credits=4,},
            new Course{CourseID=2021,Title="C++入门",Credits=3,},
            new Course{CourseID=2042,Title="JAVA入门",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}