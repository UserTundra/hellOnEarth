using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace oksana_kids.Test
{
    public abstract class AbstractTest
    {
        public RenderObject Question { get; set; }
        public List<RenderObject> Questions { get; set; }
        public IEnumerable<RenderObject> Variables { get; set; }
        public int RightIdx { get; set; }
        public String TestType { get; set; }
        public abstract void Render(ControlCollection collection);
    }
}
