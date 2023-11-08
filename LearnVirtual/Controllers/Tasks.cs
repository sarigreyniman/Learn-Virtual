using LearnVirtual.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tasks : ControllerBase
    {
        private List<Tasks> tasksList = new List<Tasks>();

        public int TaskForCourseId { get; private set; }
        public object TaskName { get; private set; }
        public object TaskDescription { get; private set; }
        public object AssignmentSubmissionDate { get; private set; }

        // GET: api/<Tasks>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<Tasks>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Tasks task = tasksList.Find(t => t.TaskForCourseId == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // POST api/<Tasks>
        [HttpPost]
        public void Post([FromBody] Tasks task)
        {
            tasksList.Add(task);
        }

        // PUT api/<Tasks>/5
        [HttpPut("{id}")]
        public ActionResult<Tasks> Put(int id, [FromBody] Tasks updateTask)
        {
            Tasks task = tasksList.Find(t => t.TaskForCourseId == id);
            if (task == null)
            {
                return NotFound();
            }
            task.TaskName = updateTask.TaskName;
            task.TaskDescription = updateTask.TaskDescription;
            task.AssignmentSubmissionDate = updateTask.AssignmentSubmissionDate;
            return Ok(task);
        }

        // DELETE api/<Tasks>/5
        [HttpDelete("{id}")]
        public ActionResult<Tasks> Delete(int id)
        {
            Tasks task = tasksList.Find(t => t.TaskForCourseId == id);
            if (task == null)
            {
                return NotFound();
            }
            tasksList.Remove(task);
            return NoContent();
        }
    }
}
