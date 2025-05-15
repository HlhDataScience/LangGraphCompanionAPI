

namespace LangGraphCompanionAPI.Models
{
    public class TaskItem 
    {
   
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dueDate { get; set; }
        public bool isCompleted { get; set; }

    }
}
