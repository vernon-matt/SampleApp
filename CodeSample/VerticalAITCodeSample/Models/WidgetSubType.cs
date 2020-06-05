using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalAITCodeSample.Models
{
    public class WidgetSubType
    {
        public int Id { get; set; }
        public string SubType { get; set; }
        public virtual int WidgetTypeId { get; set; }

    }
}
