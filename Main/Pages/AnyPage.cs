using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class AnyPage
    {
        protected AppForm appForm;
        public MyTableLayoutPanel mainTableLayout;

        public AnyPage(AppForm appForm)
        {
            this.appForm = appForm;
        }
    }
}
