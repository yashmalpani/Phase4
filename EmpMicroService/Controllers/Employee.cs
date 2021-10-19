using EmpMicroService.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpMicroService.Controllers
{
    [EnableCors]

    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        EmployeeDBContext context = new EmployeeDBContext();
        // GET: api/<Employee>
        [HttpGet]
        public IEnumerable<TblEmployees> Get()
        {
            return context.TblEmployees.ToList();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public TblEmployees Get(int id)
        {
            return context.TblEmployees.SingleOrDefault(x=>x.EmplyeeId==id);
        }

        // POST api/<Employee>
        [HttpPost]
        public void Post([FromBody] TblEmployees model)
        {
            context.TblEmployees.Add(model);
            context.SaveChanges();
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TblEmployees model)
        {
            context.TblEmployees.Update(model);
            context.SaveChanges();
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TblEmployees model = context.TblEmployees.SingleOrDefault(x => x.EmplyeeId == id);
            context.TblEmployees.Remove(model);
            context.SaveChanges();
        }
    }
}
