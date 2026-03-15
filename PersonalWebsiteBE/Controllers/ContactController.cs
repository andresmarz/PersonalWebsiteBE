using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteBE.Data;
using PersonalWebsiteBE.Models;
using PersonalWebsiteBE.DTOs;

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
        public async Task<IActionResult> PostMessage(CreateMessageDto dto)
        {
            var message = new Message
            {
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Mensaje = dto.Mensaje,
                Fecha = DateTime.UtcNow
            };

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