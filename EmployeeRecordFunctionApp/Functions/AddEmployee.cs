using EmployeeRecordFunctionApp.Model;
using EmployeeRecordFunctionApp.Service;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;


namespace EmployeeRecordFunctionApp.Functions
{
    public class AddEmployee
    {
        [Function("AddEmployee")]
        public async Task<HttpResponseData> Run(
           [HttpTrigger(AuthorizationLevel.Function, "Post")] HttpRequestData req)
        {
            var emp = await req.ReadFromJsonAsync<Employee>();
            EmployeeRepository.Employees.Add(emp);
            var response = req.CreateResponse();
            await response.WriteStringAsync("EmployeeAdded");
            return response;
        }
    }
}
