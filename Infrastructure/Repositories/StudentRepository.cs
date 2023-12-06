using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentyRepository
    {
        public static List<Student> studentList = new List<Student>()
        {
            new Student{ Id = Guid.NewGuid(), FirstName = "Chandler", LastName = "Bing"},
            new Student{ Id = Guid.NewGuid(), FirstName = "Joey", LastName = "Tribbiani"},
            new Student{ Id = Guid.NewGuid(), FirstName = "Ross", LastName = "Geller"}
        };
        public List<Student> GetAll()
        {
            return studentList;
        }
    }
}
