using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page13 : AnyPage
    {
        public Page13(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page13MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
