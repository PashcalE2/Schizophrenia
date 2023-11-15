using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page10 : AnyPage
    {
        public MyLabel xSigmaLabel;
        public OutputTextBox xSigmaTextBox;

        public MyLabel page10GearLabel;
        public MyLabel page10WheelLabel;

        public MyLabel xCor2Label;
        public OutputTextBox x1iCor2TextBox;
        public OutputTextBox x2iCor2TextBox;

        public InputTextBox<double> x1Cor2TextBox;
        public InputTextBox<double> x2Cor2TextBox;

        public Page10(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page10MainTableLayout", 4, 3, DockStyle.Fill);

            xSigmaLabel = new MyLabel("xSigmaLabel", "Суммарный коэффициент смещения");
            mainTableLayout.Add(xSigmaLabel, 0, 0);

            xSigmaTextBox = new OutputTextBox("xSigmaTextBox");
            mainTableLayout.Add(xSigmaTextBox, 0, 1);

            page10GearLabel = new MyLabel("page10GearLabel", "Шестерня");
            mainTableLayout.Add(page10GearLabel, 1, 1);

            page10WheelLabel = new MyLabel("page10WheelLabel", "Колесо");
            mainTableLayout.Add(page10WheelLabel, 1, 2);

            xCor2Label = new MyLabel("xCor2Label", "Задайте коэффициент смещения не менее");
            mainTableLayout.Add(xCor2Label, 2, 0);

            x1iCor2TextBox = new OutputTextBox("x1iCor2TextBox");
            mainTableLayout.Add(x1iCor2TextBox, 2, 1);

            x2iCor2TextBox = new OutputTextBox("x2iCor2TextBox");
            mainTableLayout.Add(x2iCor2TextBox, 2, 2);

            x1Cor2TextBox = new InputTextBox<double>("x1Cor2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x1 = value);
            mainTableLayout.Add(x1Cor2TextBox, 3, 1);

            x2Cor2TextBox = new InputTextBox<double>("x2Cor2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x2 = value);
            mainTableLayout.Add(x2Cor2TextBox, 3, 2);
        }


    }
}
