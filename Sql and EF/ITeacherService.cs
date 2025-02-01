using Sql_and_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_and_EF
{
    public interface ITeacherService
    {
        public Teacher[] GetAllTeachersByStudent(string studentName);
    }
}
