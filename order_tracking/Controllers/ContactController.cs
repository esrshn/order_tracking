using Microsoft.AspNetCore.Mvc;
using order_tracking.Models;

namespace order_tracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] ContactCreateRequest model)
        {
            if (model == null)
            {
                return BadRequest("Gönderilen veri geçerli değil.");
            }

            var contact = new Contact
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
             
                TCKN = model.TCKN,
                Gender = model.Gender
            };

            _dbContext.Contacts.Add(contact);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContact), new { id = contact.ContactId }, contact);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact == null)
                return NotFound();

            return Ok(contact);
        }
    }
}
