using System;
using System.Collections.Generic;
using System.Linq;
namespace TrueCodeVn_UT_Lesson2
{
    public interface IStudentService
    {
        /// <summary>
        /// Check if student exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExist(string id);

    }
    public class StudentService : IStudentService
    {
        private readonly List<Student> Students;
        public StudentService()
        {
            Students = DataFetcher.GetAllStudents();
        }
        /// <inheritdoc />
        public bool IsExist(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException();
            }
            if (Students.Any(x => x.Id == id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
