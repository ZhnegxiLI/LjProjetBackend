using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjWebApplication.Model
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
    }
}
