using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentyRepository _studentyRepository;
        public StudentService(IStudentyRepository studentyRepository)
        {
            _studentyRepository = studentyRepository;
        }

        public List<Student> GetAll()
        {
            return _studentyRepository.GetAll();
        }
    }
}
