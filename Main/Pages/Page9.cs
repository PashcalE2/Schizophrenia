using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page9 : AnyPage
    {
        public MyLabel xCor1Label;
        public MyLabel page9GearLabel;
        public MyLabel page9WheelLabel;

        public MyRadioButton withoutOffsetRadioButton;
        public OutputTextBox x1iCor1TextBox;
        public OutputTextBox x2iCor1TextBox;

        public MyRadioButton withOffsetRadioButton;
        public InputTextBox<double> x1Cor1TextBox;
        public InputTextBox<double> x2Cor1TextBox;

        public Page9(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page9MainTableLayout", 3, 3, DockStyle.Fill);

            xCor1Label = new MyLabel("xCor1Label", "Задайте коэффициент смещения");
            mainTableLayout.Add(xCor1Label, 0, 0);

            page9GearLabel = new MyLabel("page9GearLabel", "Шестерня");
            mainTableLayout.Add(page9GearLabel, 0, 1);

            page9WheelLabel = new MyLabel("page9WheelLabel", "Колесо");
            mainTableLayout.Add(page9WheelLabel, 0, 2);

            withoutOffsetRadioButton = new MyRadioButton("withoutOffsetRadioButton", "Без смещения (для шестерни x1=0, для колеса x2=0)");
            mainTableLayout.Add(withoutOffsetRadioButton, 1, 0);

            x1iCor1TextBox = new OutputTextBox("x1iCor1TextBox");
            mainTableLayout.Add(x1iCor1TextBox, 1, 1);

            x2iCor1TextBox = new OutputTextBox("x2iCor1TextBox");
            mainTableLayout.Add(x2iCor1TextBox, 1, 2);

            withOffsetRadioButton = new MyRadioButton("withOffsetRadioButton", "Высотная коррекция: коэффициент смещения не менее");
            mainTableLayout.Add(withOffsetRadioButton, 2, 0);

            x1Cor1TextBox = new InputTextBox<double>("x1Cor1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x1 = value);
            mainTableLayout.Add(x1Cor1TextBox, 2, 1);

            x2Cor1TextBox = new InputTextBox<double>("x2Cor1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x2 = value);
            mainTableLayout.Add(x2Cor1TextBox, 2, 2);
        }


    }
}
