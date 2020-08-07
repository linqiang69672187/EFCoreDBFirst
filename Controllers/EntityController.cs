using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDBFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private DagdbContext dataContext;
        public EntityController(DagdbContext context)
        {
            dataContext = context;
        }

        [HttpGet]
        public ActionResult<List<Entity>> GetAuthors()
        {
            return dataContext.Entity.ToList();
        }
    }
}
