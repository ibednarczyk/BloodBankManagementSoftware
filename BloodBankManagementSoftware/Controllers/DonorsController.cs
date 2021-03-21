using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodBankManagementSoftware.Data;
using BloodBankManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloodBankManagementSoftware.Controllers
{
    public class DonorsController : Controller
    {
        private readonly MvcDonorContext _context;

        public DonorsController(MvcDonorContext context)
        {
            _context = context;
        }

        // GET: Donors1
        public async Task<IActionResult> Index(string searchedName)
        {
            var donor = from d in _context.Donors
                        select d;

            IQueryable<string> bloodGroupsQuery = from bt in _context.Donors
                                                  orderby bt.BloodGroup
                                                  select bt.BloodGroup;

            donor = donor.Where(s => s.Name.Contains(searchedName)) ?? throw new NullReferenceException();

            var bloodGroupViewModel = new BloodGroupViewModel
            {
                BloodGroups = new SelectList(await bloodGroupsQuery.Distinct().ToListAsync()),
                Donors = await donor.ToListAsync()
            };

            return View(bloodGroupViewModel);
        }

        // GET: Donors1/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // GET: Donors1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Donors1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,Id,Name,Address,PhoneNumber,BloodGroup,RhFactorType,EMailAddress")] Donor donor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donor);
        }

        // GET: Donors1/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors.FindAsync(id);
            if (donor == null)
            {
                return NotFound();
            }
            return View(donor);
        }

        // POST: Donors1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("RequestId,Id,Name,Address,PhoneNumber,BloodGroup,RhFactorType,EMailAddress")] Donor donor)
        {
            if (id != donor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonorExists(donor.Id))
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
            return View(donor);
        }

        // GET: Donors1/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // POST: Donors1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var donor = await _context.Donors.FindAsync(id);
            _context.Donors.Remove(donor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonorExists(long id)
        {
            return _context.Donors.Any(e => e.Id == id);
        }
    }
}
