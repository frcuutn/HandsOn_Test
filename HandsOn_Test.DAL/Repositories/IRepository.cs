using HandsOn_Test.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Test.DAL.Repositories
{
    public interface IRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
    }
}
