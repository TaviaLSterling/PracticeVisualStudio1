using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwappingElephants
{
    class Elephant
    {
        public int EarSize;
        public String Name;
        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.",
               Name + " says…");
        }

    }
}
