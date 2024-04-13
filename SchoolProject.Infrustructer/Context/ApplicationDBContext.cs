using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SchoolProject.Infrustructer.Data
{
    //
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext()
        {
         
        }
        //prepar for Migration
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        //Tables that will Generated using Migration
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }   
        public DbSet<DepartmetSubject> departmentSubjects { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
    }
}
