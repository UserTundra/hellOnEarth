using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace oksana_kids.Test
{
    public class SimplyTest : AbstractTest
    {
        
        protected internal void RenderHeader(ControlCollection collection)
        {
            var headerControl = collection["questionPanel"];
            var labelQuestion = new Label
            {
                Text = "Пример интересного вопроса где мало букв и смысла зато это на формочке, потом можно из базы их брать будет, воооот?",
                Dock = DockStyle.Fill,
                MaximumSize = headerControl.MaximumSize
            };

            headerControl.Controls.Add(labelQuestion);
        }

        protected internal void RenderBody(ControlCollection collection)
        {
            //flowLayoutPanel1
            var headerControl = collection["flowLayoutPanel1"];
            foreach (var item in Variables)
            {
                var panel = new Panel();

            }
            
        }

        public override void Render(ControlCollection collection)
        {
            
        }
    }
}
