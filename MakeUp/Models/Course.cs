using System;
using System.Collections.Generic;

namespace MakeUp
{
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Proffesor { get; set; }
        public string SemestarYear { get; set; }
        public string Discription { get; set; }
        public decimal? CourseGrade { get; set; }
    }
}
