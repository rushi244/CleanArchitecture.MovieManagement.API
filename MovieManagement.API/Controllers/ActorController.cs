
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;
using MovieManagement.Mapping.DTO;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ActorController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Actor>))]
        public IActionResult Get()
        {
          var actors=_mapper.Map<List<ActorDTO>>(_unitOfWork.ActorRepository.GetAll());
            return Ok(actors);
        
        }
        [HttpPost]
        public IActionResult AddActor([FromBody] ActorDTO actor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var mapActor = _mapper.Map<Actor>(actor);
            _unitOfWork.ActorRepository.Add(mapActor);
            _unitOfWork.Save();
            return Ok("Success");

        }
        [HttpPost]
        [Route("AddMultiple")]
        public IActionResult AddMultipleActors(List<ActorDTO> actor)
        {
           
            if (!ModelState.IsValid)
                return BadRequest();
          

            var ActorMap = _mapper.Map<List<Actor>>(actor);
            _unitOfWork.ActorRepository.AddRange(ActorMap);
            _unitOfWork.Save();
            return Ok("Success");
        }
    }
}
