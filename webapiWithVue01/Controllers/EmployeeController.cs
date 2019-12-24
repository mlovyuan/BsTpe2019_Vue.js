using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapiWithVue01.Model;

namespace webapiWithVue01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return GetData.Get02();
        }
        [HttpPost]
        public void Post(List<Employee> dat)
        {
            GetData.savedata(dat);
        }
    }
}
