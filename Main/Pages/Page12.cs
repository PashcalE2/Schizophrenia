using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page12 : AnyPage
    {
        public Page12(AppForm appForm) : base(appForm)
        {
            this.appForm = appForm;

            mainTableLayout = new MyTableLayoutPanel("page12MainTableLayout", 1, 1, DockStyle.Fill);
        }


    }
}
