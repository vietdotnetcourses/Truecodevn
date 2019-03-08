using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueCodeVn_UT_Lesson2
{
    public static class DataFetcher
    {
        public static List<Student> GetAllStudents()
        {
            var result = new List<Student>();
            result.Add(new Student
            {
                Id = "SV1",
                Name = "Nguyen Van A",
                IsGynasticsPassed = true,
                AverageMark = 6.5
            });
            result.Add(new Student
            {
                Id = "SV2",
                Name = "Tran Van B",
                IsGynasticsPassed = false,
                AverageMark = 7.5
            });
            result.Add(new Student
            {
                Id = "SV3",
                Name = "Pham Quang C",
                IsGynasticsPassed = true,
                AverageMark = 4.5
            });
            return result;
        }
    }

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsGynasticsPassed { get; set; }
        public double AverageMark { get; set; }
    }
}
