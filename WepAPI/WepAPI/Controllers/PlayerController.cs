using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepAPI.Models;

namespace WepAPI.Controllers
{
    /// <summary>
    /// API controller deve SEMPRE ereditare da ControllerBase
    /// </summary>
    [Route("api/[controller]")] // Route
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IRepository _repository;
        public PlayerController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<GiocatoreBasketAmatoriale> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<GiocatoreBasketAmatoriale> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id richiesto deve essere maggiore di zero");
            }
            return Ok(_repository.GetById(id));
        }
    }
}
