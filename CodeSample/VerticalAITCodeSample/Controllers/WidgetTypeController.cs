using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VerticalAITCodeSample.Models;

namespace VerticalAITCodeSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WidgetTypeController: ControllerBase
    {
        private SiteContext db;

        public WidgetTypeController(SiteContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WidgetType>> Get()
        {
            return db.WidgetTypes;
        }

    }
}