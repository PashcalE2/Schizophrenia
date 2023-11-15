using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page6 : AnyPage
    {
        public Page6(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page6MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
