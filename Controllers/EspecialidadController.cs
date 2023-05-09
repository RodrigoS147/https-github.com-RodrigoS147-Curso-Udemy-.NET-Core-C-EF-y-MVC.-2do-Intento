using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Turnos.Models;

namespace Turnos.Controllers
{
    public class EspecialidadController : Controller
    {
        private readonly TurnosContext _context;
        public EspecialidadController(TurnosContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Especialidad.ToList());
        }

        public IActionResult Edit (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidad = _context.Especialidad.Find(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            return View(especialidad);
        }

        
    }
}