using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalAITCodeSample.Models
{
    public class Widget
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string WidgetName { get; set; }
        public virtual int WidgetTypeId { get; set; }
        public virtual int WidgetSubTypeId { get; set; }

    }
}
