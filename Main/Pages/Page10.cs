using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page10 : AnyPage
    {
        public MyLabel xSigmaLabel;
        public OutputTextBox xSigmaTextBox;

        public MyLabel gearLabel;
        public MyLabel wheelLabel;

        public MyLabel xCor2Label;
        public OutputTextBox x1iCor2TextBox;
        public OutputTextBox x2iCor2TextBox;

        public InputTextBox<double> x1Cor2TextBox;
        public InputTextBox<double> x2Cor2TextBox;

        public Page10(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page10MainTableLayout", 4, 3, DockStyle.Fill);
            mainTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            xSigmaLabel = new MyLabel("xSigmaLabel", "Суммарный коэффициент смещения:");
            mainTableLayout.Add(xSigmaLabel, 0, 0);

            xSigmaTextBox = new OutputTextBox("xSigmaTextBox");
            mainTableLayout.Add(xSigmaTextBox, 0, 1);

            gearLabel = new MyLabel("page10GearLabel", "Шестерня:");
            gearLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(gearLabel, 1, 1);

            wheelLabel = new MyLabel("page10WheelLabel", "Колесо");
            wheelLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(wheelLabel, 1, 2);

            xCor2Label = new MyLabel("xCor2Label", "Задайте коэффициент смещения не менее:");
            mainTableLayout.Add(xCor2Label, 2, 0);

            x1iCor2TextBox = new OutputTextBox("x1iCor2TextBox");
            mainTableLayout.Add(x1iCor2TextBox, 2, 1);

            x2iCor2TextBox = new OutputTextBox("x2iCor2TextBox");
            mainTableLayout.Add(x2iCor2TextBox, 2, 2);

            x1Cor2TextBox = new InputTextBox<double>("x1Cor2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x1 = value);
            x1Cor2TextBox.TextChanged += new EventHandler(x1Cor2TextBox_TextChanged);
            mainTableLayout.Add(x1Cor2TextBox, 3, 1);

            x2Cor2TextBox = new InputTextBox<double>("x2Cor2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x2 = value);
            x1Cor2TextBox.TextChanged += new EventHandler(x2Cor2TextBox_TextChanged);
            mainTableLayout.Add(x2Cor2TextBox, 3, 2);
        }

        public override bool CanMoveOn()
        {
            return
                (!x1Cor2TextBox.Enabled || x1Cor2TextBox.GetIsValid()) &&
                (!x2Cor2TextBox.Enabled || x2Cor2TextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            appForm.page8.g4();

            return appForm.page8.kp_begining();
        }

        private void x1Cor2TextBox_TextChanged(object sender, EventArgs e)
        {
            appForm.context.x2 = appForm.context.xSigma - appForm.context.x1;
            x2Cor2TextBox.SetValue(appForm.context.x2);

            appForm.nextButton.Enabled = (appForm.context.x1 >= appForm.context.x1Min) && (appForm.context.x2 >= appForm.context.x2Min);
        }

        private void x2Cor2TextBox_TextChanged(object sender, EventArgs e)
        {
            appForm.context.x1 = appForm.context.xSigma - appForm.context.x2;
            x1Cor2TextBox.SetValue(appForm.context.x1);

            appForm.nextButton.Enabled = (appForm.context.x1 >= appForm.context.x1Min) && (appForm.context.x2 >= appForm.context.x2Min);
        }
    }
}
