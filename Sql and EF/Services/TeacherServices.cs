using Sql_and_EF.Data;
using Sql_and_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_and_EF.Services
{
    public class TeacherServices : ITeacherService
    {
        //Dependency Injection
        AppDbContext _dbContext;
        public TeacherServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            //LINQ Query
            var teachers = _dbContext.Teachers
                .Where(t => t.Pupils.Any(p => p.FirstName == studentName))
                .ToArray();
            return teachers;
        }
    }
}
