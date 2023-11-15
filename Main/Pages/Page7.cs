using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page7 : AnyPage
    {
        public Page7(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page7MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
