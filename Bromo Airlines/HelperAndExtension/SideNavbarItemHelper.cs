using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines.HelperAndExtension
{
    public static class SideNavbarItemHelper
    {
        public static void BindClick(this PictureBox picBox, Label label, EventHandler clickHandler)
        {
            label.Click += clickHandler;
            picBox.Click += clickHandler;
        }
    }
}
