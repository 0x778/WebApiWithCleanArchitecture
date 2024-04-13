using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Infrustructer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructer.Repositories
{
    //Inherit the Abstraction From IStudentRepository
    public class StudentRepository : IStudentRepository
    {
        #region Fileds
        private readonly ApplicationDBContext _dbContext;
        #endregion

        #region Constructor
        public StudentRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        #endregion

        #region Handle funcation
        //Return Data using Thread
        //use Async with await
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbContext.students.ToListAsync(); 
        }
        #endregion
    }
}
