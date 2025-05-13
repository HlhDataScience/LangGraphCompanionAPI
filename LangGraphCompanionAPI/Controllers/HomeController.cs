using   LangGraphCompanionAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LangGraphCompanionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetApiPresentation()
        {
            var response = new PresentationInfo(message: "Welcome to the LangGraph Companion API!",
                description: "This API provides task data for LangGraph-powered workflows.",
                author: "Héctor López Hidalgo",
                version: 1.0,
                endpoints: new Dictionary<string, string>
                {
                    ["/tasks"] = "Get all tasks.",
                    ["/tasks/{id}"] = "Get a task by ID.",
                    ["/docs"] = "API documentation (Swagger UI).",
                    ["/openapi.json"] = "OpenAPI schema."
                },
                metadata: new Dictionary<string, string>{
                    ["Github Repository"] = "https://github.com/your-repo",
                    ["Dagshub Repository"] = "https://dagshub.com/your-repo"
                });
            return Ok(response);
        }
    }
}