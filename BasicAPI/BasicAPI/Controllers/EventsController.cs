using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IDataContext context;

        public EventsController(IDataContext dataContext)
        {
            context = dataContext;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public ActionResult Get()
        {
            var filtered = context.Events;
            return Ok(context.Events);
        }

        // GET: api/<EventsController>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var eve = context.Events.Find(e => e.Id == id);
            if (eve is null)
            {
                return NotFound();
            }
            return Ok(eve);
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            context.Events.Add(new Event { Id = 2, Title = newEvent.Title });

        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event newEvent)
        {
            var eve = context.Events.Find(e => e.Id == id);
            if (eve is null)
            {
                return NotFound();
            }
            eve.Title = newEvent.Title;
            return Ok(eve);
            //TODO
            //find event by id
            //udpate event properties
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = context.Events.Find(e => e.Id == id);
            context.Events.Remove(eve);
        }
    }
}
