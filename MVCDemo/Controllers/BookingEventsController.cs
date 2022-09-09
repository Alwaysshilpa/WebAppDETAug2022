using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class BookingEventsController : Controller
    {
        private readonly MVCDemoContext _context;

        public BookingEventsController(MVCDemoContext context)
        {
            _context = context;
        }

        // GET: BookingEvents
        public async Task<IActionResult> Index()
        {
              return _context.BookingEvents != null ? 
                          View(await _context.BookingEvents.ToListAsync()) :
                          Problem("Entity set 'MVCDemoContext.BookingEvents'  is null.");
        }

        // GET: BookingEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BookingEvents == null)
            {
                return NotFound();
            }

            var bookingEvents = await _context.BookingEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingEvents == null)
            {
                return NotFound();
            }

            return View(bookingEvents);
        }

        // GET: BookingEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookingEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventTitle,Qty,EventDate")] BookingEvents bookingEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingEvents);
        }

        // GET: BookingEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BookingEvents == null)
            {
                return NotFound();
            }

            var bookingEvents = await _context.BookingEvents.FindAsync(id);
            if (bookingEvents == null)
            {
                return NotFound();
            }
            return View(bookingEvents);
        }

        // POST: BookingEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventTitle,Qty,EventDate")] BookingEvents bookingEvents)
        {
            if (id != bookingEvents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingEventsExists(bookingEvents.Id))
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
            return View(bookingEvents);
        }

        // GET: BookingEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BookingEvents == null)
            {
                return NotFound();
            }

            var bookingEvents = await _context.BookingEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingEvents == null)
            {
                return NotFound();
            }

            return View(bookingEvents);
        }

        // POST: BookingEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BookingEvents == null)
            {
                return Problem("Entity set 'MVCDemoContext.BookingEvents'  is null.");
            }
            var bookingEvents = await _context.BookingEvents.FindAsync(id);
            if (bookingEvents != null)
            {
                _context.BookingEvents.Remove(bookingEvents);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingEventsExists(int id)
        {
          return (_context.BookingEvents?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
