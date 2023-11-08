using LearnVirtual.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lecturers : ControllerBase
    {
        private List<Lecturers> lecturersList = new List<Lecturers>();
        private object lecturerStatus;

        public int LecturerId { get; private set; }
        public object LecturerName { get; private set; }

        // GET: api/<Lecturers>
        [HttpGet]
        public List<Lecturers> Get()
        {
            return lecturersList;
        }

        // GET api/<Lecturers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            
            Lecturers lecturer = lecturersList.Find(l => l.LecturerId == id);
            if (lecturer == null)
            {
                return NotFound();
            }
            return Ok(lecturer);
        }

        // POST api/<Lecturers>
        [HttpPost]
        public void Post([FromBody] Lecturers lecturer)
        {
            lecturersList.Add(lecturer);
        }

        // PUT api/<Lecturers>/5
        [HttpPut("{id}")]
        public ActionResult<Lecturers> Put(int id, [FromBody] Lecturers updatedLecturer)
        {
            Lecturers lecturer = lecturersList.Find(l => l.LecturerId == id);

            if (lecturer == null)
            {
                return NotFound();
            }
                lecturer.LecturerName = updatedLecturer.LecturerName;
                lecturer.LecturerName = updatedLecturer.lecturerStatus;
            return Ok(lecturer);
        }

        // DELETE api/<Lecturers>/5
        [HttpDelete("{id}")]
        public ActionResult<Lecturers> Delete(int id)
        {
            Lecturers lecturer = lecturersList.Find(l => l.LecturerId == id);
            if (lecturer == null)
            {
                return NotFound();
            }
            lecturersList.Remove(lecturer);
            return NoContent();
        }
    }
}
