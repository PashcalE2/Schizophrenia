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

            // Page 1

            cylindricalTypeButton.Checked = true;
            internalTypeButton.Checked = true;
            standartContourYesButton.Checked = true;

            //

            printButton.Click += new EventHandler(printButton_Click);
        }

        // General

        public void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(standartAlpha.ToString());
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
