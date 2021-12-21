using EAD_CORE.Infra.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_CORE_V1.Controllers
{
    public class Lesson : Controller
    {
        private readonly PreventivaContext _context;
        public Lesson(PreventivaContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Home/Get")]
        public async Task<ActionResult<Object>> GetAtributes()
        {
            var item = _context.Aulas.FirstOrDefault();
            return item;
        }

    }
}
