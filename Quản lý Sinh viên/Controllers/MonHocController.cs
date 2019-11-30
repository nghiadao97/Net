using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quản_lý_Sinh_viên.Models;

namespace Quản_lý_Sinh_viên.Controllers
{
    public class MonHocController : Controller
    {
        private readonly MyDBContext myDbContext;

        public MonHocController(MyDBContext context)
        {
            myDbContext = context;
        }

        // GET: MonHoc
        public async Task<IActionResult> Index()
        {
            return View(await myDbContext.MonHocs.ToListAsync());
        }

        // GET: MonHoc/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monHoc = await myDbContext.MonHocs
                .FirstOrDefaultAsync(m => m.MaMon == id);
            if (monHoc == null)
            {
                return NotFound();
            }

            return View(monHoc);
        }

        // GET: MonHoc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MonHoc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMon,TenMon,SoTinChi")] MonHoc monHoc)
        {
            if (ModelState.IsValid)
            {
                myDbContext.Add(monHoc);
                await myDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monHoc);
        }

        // GET: MonHoc/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monHoc = await myDbContext.MonHocs.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(monHoc);
        }

        // POST: MonHoc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaMon,TenMon,SoTinChi")] MonHoc monHoc)
        {
            if (id != monHoc.MaMon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    myDbContext.Update(monHoc);
                    await myDbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonHocExists(monHoc.MaMon))
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
            return View(monHoc);
        }

        // GET: MonHoc/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monHoc = await myDbContext.MonHocs
                .FirstOrDefaultAsync(m => m.MaMon == id);
            if (monHoc == null)
            {
                return NotFound();
            }

            return View(monHoc);
        }

        // POST: MonHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var monHoc = await myDbContext.MonHocs.FindAsync(id);
            myDbContext.MonHocs.Remove(monHoc);
            await myDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}