using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schizophrenia
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            InitializeChildren();

            printButton.Click += new EventHandler(printButton_Click);
        }

        public void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(u.ToString());
        }
    }
}
