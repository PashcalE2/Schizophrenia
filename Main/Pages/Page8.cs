using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page8 : AnyPage
    {
        public Page8(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page8MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
