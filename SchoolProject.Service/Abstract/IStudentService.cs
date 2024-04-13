using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
