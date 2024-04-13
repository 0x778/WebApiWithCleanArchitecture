using SchoolProject.Data.Entities;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implemention
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Constructor
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region Handle Request
        public Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsListAsync() ;
        }
        #endregion
    }
}
