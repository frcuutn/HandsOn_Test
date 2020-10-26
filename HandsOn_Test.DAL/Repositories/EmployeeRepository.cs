using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HandsOn_Test.DAL.Models;
using Newtonsoft.Json;

namespace HandsOn_Test.DAL.Repositories
{
    public class EmployeeRepository : IRepository
    {
        private static string baseUrl = "http://masglobaltestapi.azurewebsites.net/api/";

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var employeesJson = await GetStringAsync($"{baseUrl}/Employees");
            return JsonConvert.DeserializeObject<IEnumerable<Employee>>(employeesJson);
        }

        private async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}
