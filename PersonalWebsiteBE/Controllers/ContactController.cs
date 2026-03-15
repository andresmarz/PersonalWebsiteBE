using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteBE.Data;
using PersonalWebsiteBE.Models;

namespace PersonalWebsiteBE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostMessage(Message message)
        {
            message.Fecha = DateTime.UtcNow;

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return Ok(message);
        }

        [HttpGet]
        public IActionResult GetMessages()
        {
            var messages = _context.Messages
                .OrderByDescending(m => m.Fecha)
                .ToList();

            return Ok(messages);
        }
    }
}