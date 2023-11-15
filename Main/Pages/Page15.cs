using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page15 : AnyPage
    {
        public Page15(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page15MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
