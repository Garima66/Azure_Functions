using Azure;
using EmployeeRecordFunctionApp.Service;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordFunctionApp.Functions
{
    public class GetAllEmployee
    {
        [Function("GetAllEmployees")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function,"Get")] HttpRequestData req)
        {
            var response=req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(EmployeeRepository.Employees);
            return response;

        }
    }
}
