using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Authorization;


namespace cbsStudents.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private readonly CbsStudentsContext _context;

        public EventsController(CbsStudentsContext context)
        {
            _context = context;
        }

         [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var cbsStudentsContext = _context.Event.Include(e => e.Volunteer);
            return View(await cbsStudentsContext.ToListAsync());
        }

         [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .Include(e => e.Volunteer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            ViewData["VolunteerId"] = new SelectList(_context.Volunteer, "Id", "Id");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,Title,Description,Date,VolunteerId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VolunteerId"] = new SelectList(_context.Volunteer, "Id", "Id", @event.VolunteerId);
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            ViewData["VolunteerId"] = new SelectList(_context.Volunteer, "Id", "Id", @event.VolunteerId);
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,Title,Description,Date,VolunteerId")] Event @event)
        {
            if (id != @event.EventId)
            {
                Console.WriteLine("===");
                Console.WriteLine(id);
                Console.WriteLine(@event.EventId);
                Console.WriteLine(@event.Title);
                Console.WriteLine("===");
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.EventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["VolunteerId"] = new SelectList(_context.Volunteer, "Id", "Id", @event.VolunteerId);
            return View();
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .Include(e => e.Volunteer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Event == null)
            {
                return Problem("Entity set 'CbsStudentsContext.Event'  is null.");
            }
            var @event = await _context.Event.FindAsync(id);
            if (@event != null)
            {
                _context.Event.Remove(@event);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
          return _context.Event.Any(e => e.EventId == id);
        }
    }
}
