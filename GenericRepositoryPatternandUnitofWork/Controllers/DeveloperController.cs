using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPatternandUnitofWorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("list-of")]
        public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            try
            {
                var popularDevelopers = _unitOfWork.developers.GetPopularDevelopers(count);

                return Ok(popularDevelopers);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }

        }

        [HttpPost("add-project")]
        public IActionResult AddProject()
        {

            var developer = new Developer
            {
                Followers = "35",
                Name = "Mukesh Murugan"
            };

            var project = new Project
            {
                Name = "codewithmukesh"
            };

            _unitOfWork.developers.Add(developer);


            _unitOfWork.projects.Add(project);


            _unitOfWork.Complete();


            return Ok();
        }
    }
}
