using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalAITCodeSample.Models
{
    public class WidgetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual List<Widget> Widgets { get; set; }
    }
}
