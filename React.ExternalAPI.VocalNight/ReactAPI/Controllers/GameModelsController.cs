
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAPI.Model;

namespace ReactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameModelsController : ControllerBase
    {
        private readonly APIContext _context;

        public GameModelsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/GameModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameModel>>> GetGames()
        {
            return await _context.Games.ToListAsync();
        }

        // GET: api/GameModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameModel>> GetGameModel(int id)
        {
            var gameModel = await _context.Games.FindAsync(id);

            if (gameModel == null)
            {
                return NotFound();
            }

            return gameModel;
        }

        private bool GameModelExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }
}
