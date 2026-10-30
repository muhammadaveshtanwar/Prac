
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        // Read all students
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Students.ToListAsync());
        }

        // Read one student
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        // Create student
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(student);
        }

        // Update student
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id, Student student)
        {
            if (id != student.Id)
                return BadRequest();

            if (!await _context.Students.AnyAsync(s => s.Id == id))
                return NotFound();

            _context.Entry(student).State =
                EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Delete student
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
