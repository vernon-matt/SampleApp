using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerticalAITCodeSample.Models;

namespace VerticalAITCodeSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WidgetSubTypeController : ControllerBase
    {
        private SiteContext db;

        public WidgetSubTypeController(SiteContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<WidgetSubType>> Get()
        {
            return db.WidgetSubTypes;
        }
        [HttpGet("{incomingType}")]
        public ActionResult<IEnumerable<WidgetSubType>> GetByType(string incomingType)
        {
            WidgetType type = db.WidgetTypes.First(w => w.Type == incomingType);
            return db.WidgetSubTypes.Where(h => h.WidgetTypeId == type.Id).ToList();
        }
    }
}
