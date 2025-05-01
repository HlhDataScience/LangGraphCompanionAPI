using LangGraphCompanionAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace LangGraphCompanionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private static readonly List<TaskItem> _tasks =
        [
            new TaskItem { Id = 1, DueTime = DateTime.Now.AddDays(2), Name = "Prepare Presentation", IsCompleted = false },
            new TaskItem { Id = 2, DueTime = DateTime.Now.AddDays(3), Name = "Write Report", IsCompleted = true }
        ];
   

        [HttpGet]
        public ActionResult<List<TaskItem>> Get()
        {
            return Ok(_tasks);
        }



    }
}
