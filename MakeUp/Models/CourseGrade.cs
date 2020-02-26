using System;
using System.Collections.Generic;

namespace MakeUp
{
    public partial class CourseGrade
    {
        public int CourseGradeId { get; set; }
        public int? StudentId { get; set; }
        public int? CouseId { get; set; }
        public int? Grade { get; set; }
    }
}
