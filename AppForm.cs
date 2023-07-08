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
        private Stack<int> pagesHistory = new Stack<int>(15);
        public AppForm()
        {
            InitializeComponent();
            InitializeChildren();

            // Page 1

            cylindricalTypeButton.Checked = true;
            internalTypeButton.Checked = true;
            standartContourYesButton.Checked = true;

            //

            
        }

        // General

        public void backButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            mainTableLayout.SuspendLayout();

            pagesMainTableLayout[currentPage].Visible = false;
            currentPage = pagesHistory.Pop();
            pagesMainTableLayout[currentPage].Visible = true;

            mainTableLayout.ResumeLayout();

            if (currentPage == 0)
            {
                backButton.Enabled = false;
            }
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            pagesHistory.Push(currentPage);
            backButton.Enabled = true;

            mainTableLayout.SuspendLayout();

            pagesMainTableLayout[currentPage].Visible = false;
            currentPage++;
            pagesMainTableLayout[currentPage].Visible = true;

            mainTableLayout.ResumeLayout();

            if (currentPage == 14)
            {
                nextButton.Enabled = false;
            }

            
        }

        public void printButton_Click(object sender, EventArgs e)
        {
            u = u / 2;
            uTextBox.SetValue(u);
            MessageBox.Show(u.ToString() + " " + uTextBox.GetValue().ToString());
        }

        // Page 1

        public void cylindricalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cylindricalTypeButton.Checked)
            {
                internalTypeButton.Enabled = true;
                externalTypeButton.Enabled = true;
                singleEntryTypeButton.Enabled = false;
                doubleEntryTypeButton.Enabled = false;

                singleEntryTypeButton.Checked = false;
                doubleEntryTypeButton.Checked = false;

                alphaTextBox.Enabled = false;

                T1Label.Text = "Крутящий момент на валу шестерни, Н*мм:";
            }
        }

        private void conicalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (conicalTypeButton.Checked)
            {
                internalTypeButton.Enabled = true;
                externalTypeButton.Enabled = true;
                singleEntryTypeButton.Enabled = false;
                doubleEntryTypeButton.Enabled = false;

                singleEntryTypeButton.Checked = false;
                doubleEntryTypeButton.Checked = false;

                alphaTextBox.Enabled = true;

                T1Label.Text = "Крутящий момент на валу солнечного колеса, Н*мм:";
            }
        }

        private void planetTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (planetaryTypeButton.Checked)
            { 
                internalTypeButton.Enabled = false;
                externalTypeButton.Enabled = false;
                singleEntryTypeButton.Enabled = true;
                doubleEntryTypeButton.Enabled = true;

                internalTypeButton.Checked = false;
                externalTypeButton.Checked = false;

                alphaTextBox.Enabled = false;

                T1Label.Text = "Крутящий момент на валу шестерни, Н*мм:";
            }
        }

        private void internalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void externalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void singleEntryTypeButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void doubleEntryTypeButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void standartContourYesButton_CheckedChanged(object sender, EventArgs e)
        {
            standartAlphaTextBox.Enabled = false;
            standartAlphaTextBox.SetValue(20);

            haStarTextBox.Enabled = false;
            haStarTextBox.SetValue(1);

            cStarTextBox.Enabled = false;
            cStarTextBox.SetValue(0.25);
        }

        private void standartContourNoButton_CheckedChanged(object sender, EventArgs e)
        {
            standartAlphaTextBox.Enabled = true;
            haStarTextBox.Enabled = true;
            cStarTextBox.Enabled = true;
        }

        // Page 2
    }
}
