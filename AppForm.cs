using System;
using System.Collections.Generic;
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

            page2.identityRadioButton.CheckedChanged += new EventHandler(identityRadioButton_CheckedChanged);
            page2.identityRadioButton.Checked = true;
            page2.notIdentityRadioButton.CheckedChanged += new EventHandler(notIdentityRadioButton_CheckedChanged);

            page11.aWG3TextBox.Enabled = false;

        }



        // General

        public void backButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            context = contextHistory.Pop();

            mainTableLayout.SuspendLayout();

            pagesMainTableLayout[currentPage].Visible = false;
            currentPage = pagesHistory.Pop();

            // update currentpage view by context

            pagesMainTableLayout[currentPage].Visible = true;

            mainTableLayout.ResumeLayout();

            if (currentPage == 0)
            {
                backButton.Enabled = false;
            }
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            backButton.Enabled = true;
            contextHistory.Push(context);
            pagesHistory.Push(currentPage);

            mainTableLayout.SuspendLayout();

            pagesMainTableLayout[currentPage].Visible = false;
            currentPage++;

            // update currentpage view by context

            pagesMainTableLayout[currentPage].Visible = true;

            mainTableLayout.ResumeLayout();

            if (currentPage == 14)
            {
                nextButton.Enabled = false;
            }
        }

        public void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implement me");
        }

        // Page 2

        private void identityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (page2.identityRadioButton.Checked)
            {
                page2.gearMaterialComboBox.SelectedValueChanged += new EventHandler(page2.gearCopyToWheel);
                page2.wheelMaterialComboBox.Enabled = false;
                page2.wheelMaterialComboBox.SelectedItem = page2.gearMaterialComboBox.SelectedItem;

                page2.TO1ComboBox.SelectedValueChanged += new EventHandler(page2.TO1CopyToTO2);
                page2.TO2ComboBox.Enabled = false;
                page2.TO2ComboBox.SelectedItem = page2.TO1ComboBox.SelectedItem;

                page2.HB1TextBox.PushTextValidatedHandler((value) => page2.HB2TextBox.Text = page2.HB1TextBox.Text);
                page2.HB2TextBox.Enabled = false;
                page2.HB2TextBox.Text = page2.HB1TextBox.Text;

                page2.HRC1TextBox.PushTextValidatedHandler((value) => page2.HRC2TextBox.Text = page2.HRC1TextBox.Text);
                page2.HRC2TextBox.Enabled = false;
                page2.HRC2TextBox.Text = page2.HRC1TextBox.Text;

                page2.HV1TextBox.PushTextValidatedHandler((value) => page2.HV2TextBox.Text = page2.HV1TextBox.Text);
                page2.HV2TextBox.Enabled = false;
                page2.HV2TextBox.Text = page2.HV1TextBox.Text;

                page2.HRCs1TextBox.PushTextValidatedHandler((value) => page2.HRCs2TextBox.Text = page2.HRCs1TextBox.Text);
                page2.HRCs2TextBox.Enabled = false;
                page2.HRCs2TextBox.Text = page2.HRCs1TextBox.Text;

                page3.sigmaH1LimbTextBox.PushTextValidatedHandler((value) => page3.sigmaH2LimbTextBox.Text = page3.sigmaH1LimbTextBox.Text);
                page3.sigmaH2LimbTextBox.Enabled = false;
                page3.sigmaH2LimbTextBox.Text = page3.sigmaH1LimbTextBox.Text;

                page3.sigmaF1LimbTextBox.PushTextValidatedHandler((value) => page3.sigmaF2LimbTextBox.Text = page3.sigmaF1LimbTextBox.Text);
                page3.sigmaF2LimbTextBox.Enabled = false;
                page3.sigmaF2LimbTextBox.Text = page3.sigmaF1LimbTextBox.Text;

                page3.c1TextBox.PushTextValidatedHandler((value) => page3.c2TextBox.Text = page3.c1TextBox.Text);
                page3.c2TextBox.Enabled = false;
                page3.c2TextBox.Text = page3.c1TextBox.Text;

                page3.KFC1TextBox.PushTextValidatedHandler((value) => page3.KFC2TextBox.Text = page3.KFC1TextBox.Text);
                page3.KFC2TextBox.Enabled = false;
                page3.KFC2TextBox.Text = page3.KFC1TextBox.Text;
            }
        }

        private void notIdentityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (page2.notIdentityRadioButton.Checked)
            {
                page2.gearMaterialComboBox.SelectedValueChanged -= new EventHandler(page2.gearCopyToWheel);
                page2.wheelMaterialComboBox.Enabled = true;

                page2.TO1ComboBox.SelectedValueChanged -= new EventHandler(page2.TO1CopyToTO2);
                page2.TO2ComboBox.Enabled = true;

                page2.HB1TextBox.PopTextValidatedHandler();
                page2.HB2TextBox.Enabled = true;

                page2.HRC1TextBox.PopTextValidatedHandler();
                page2.HRC2TextBox.Enabled = true;

                page2.HV1TextBox.PopTextValidatedHandler();
                page2.HV2TextBox.Enabled = true;

                page2.HRCs1TextBox.PopTextValidatedHandler();
                page2.HRCs2TextBox.Enabled = true;

                page3.sigmaH1LimbTextBox.PopTextValidatedHandler();
                page3.sigmaH2LimbTextBox.Enabled = true;

                page3.sigmaF1LimbTextBox.PopTextValidatedHandler();
                page3.sigmaF2LimbTextBox.Enabled = true;

                page3.c1TextBox.PopTextValidatedHandler();
                page3.c2TextBox.Enabled = true;

                page3.KFC1TextBox.PopTextValidatedHandler();
                page3.KFC2TextBox.Enabled = true;
            }
        }

    }
}
