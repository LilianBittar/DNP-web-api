
namespace DNP_web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosControllers : ControllerBase
    {
        private ITodosService totosService;

        public TodosController(ITodosService todosService)
        {
            this.todosService = todosService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? isCompleted, [FromQuery] int? userId)
        {
            try 
            {
                IList<Todo> todos = null;
                return Ok(todos);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}