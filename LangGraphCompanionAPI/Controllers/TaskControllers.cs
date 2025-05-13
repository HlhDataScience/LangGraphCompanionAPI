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
            new() { id = 1, dueDate = DateTime.Now.AddDays(2), name = "Prepare Presentation", isCompleted = false },
            new() { id = 2, dueDate = DateTime.Now.AddDays(3), name = "Write Report", isCompleted = true }
        ];
   
        [HttpGet]
        public ActionResult<List<TaskItem>> Get()
        {
            return Ok(_tasks);
        }
    }
}
