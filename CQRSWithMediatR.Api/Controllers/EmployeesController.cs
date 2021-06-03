using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CQRSWithMediateR.InfraStructure.Entities;
using CQRSWithMediateR.InfraStructure.Query;
using CQRSWithMediateR.InfraStructure.Command;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRSWithMediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public EmployeesController(IMediator mediatR)
        {
            this._mediatR = mediatR;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _mediatR.Send(new GetEmployeesListQuery());
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee employee)
        {
            return await _mediatR.Send(new AddEmployeeCommand(employee.Id, employee.Name, employee.Position));

        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
