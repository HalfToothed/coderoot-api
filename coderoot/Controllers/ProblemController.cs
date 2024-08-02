using coderoot.DataLayer.Interfaces;
using coderoot.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace coderoot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        public IProblemRepository problemRepository { get; set; }
        public ProblemController(IProblemRepository problem)
        {
            problemRepository = problem;

        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Problem problem)
        {
            try
            {
                problemRepository.Add(problem);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
           
            return Ok();
            
        }

        [HttpGet("GetAllProblems")]
        public IActionResult GetAllProblems()
        {
            var problems = problemRepository.GetAllProblems();
            return Ok(problems);
        }

        [HttpGet("GetAllTopics")]
        public IActionResult GetAllTopics()
        {
            var topics = problemRepository.GetAllTopics();
            return Ok(topics);
        }

    }
}
