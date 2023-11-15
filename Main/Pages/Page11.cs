using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page11 : AnyPage
    {
        public Page11(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page11MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
