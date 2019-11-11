using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjWebApplication.Model
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;
        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student() { id = 1, name = "dfdf",className = "test"},
                new Student() { id = 2, name = "dfdf",className = "test"},
                new Student() { id = 3, name = "dfdf",className = "test"},
                new Student() { id = 4, name = "dfdf",className = "test"},
                new Student() { id = 5, name = "dfdf",className = "test"}
            };
        }

        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(p => p.id == id);

        }
    }
}
