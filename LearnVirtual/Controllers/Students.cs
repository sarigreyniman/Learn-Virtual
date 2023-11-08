using LearnVirtual.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        private List<Students> studentsList = new List<Students>();

        public int StudentId { get; private set; }
        public object StudentName { get; private set; }
        public object StudentStatus { get; private set; }

        // GET: api/<Students>
        [HttpGet]
        public List<Students> Get()
        { 
            return studentsList;
        }

        // GET api/<Students>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Students student = studentsList.Find(s => s.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
            
        }

        // POST api/<Students>
        [HttpPost]
        public void Post([FromBody] Students student)
        {
            studentsList.Add(student);
        }

        // PUT api/<Students>/5
        [HttpPut("{id}")]
        public ActionResult<Students> Put(int id, [FromBody] Students updatedStudent)
        {
            Students student = studentsList.Find(s => s.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }
            student.StudentName = updatedStudent.StudentName;
            student.StudentStatus = updatedStudent.StudentStatus;

            return Ok(student);
        }

        // DELETE api/<Students>/5
        [HttpDelete("{id}")]
        public ActionResult<Students> Delete(int id)
        {
            Students student = studentsList.Find(s => s.StudentId == id);

            if (student == null)
            {
                return NotFound();
            }
            studentsList.Remove(student);
            return NoContent();
           
        }
    }
}
