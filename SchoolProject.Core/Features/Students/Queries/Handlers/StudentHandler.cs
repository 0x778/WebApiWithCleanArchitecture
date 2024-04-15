using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    internal class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentService _studentService;
        #region Fields

        #endregion

        #region Constructors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion
        
        #region Handle Functions
        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsListAsync();
        }
        #endregion
    }
}
