using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page6 : AnyPage
    {
        public MyLabel z1iLabel;
        public OutputTextBox z1iTextBox;

        public MyLabel z1Label;
        public InputTextBox<double> z1TextBox;

        public MyLabel z2iLabel;
        public OutputTextBox z2iTextBox;

        public MyLabel z2Label;
        public InputTextBox<double> z2TextBox;

        public MyLabel badDeltaU1label;
        public MyLabel badDeltaU2label;

        public Page6(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page6MainTableLayout", 6, 2, DockStyle.Fill);

            // z1

            z1iLabel = new MyLabel("z1iLabel", "Расчетное значение числа зубьев шестерни");
            mainTableLayout.Add(z1iLabel, 0, 0);

            z1iTextBox = new OutputTextBox("z1iTextBox");
            mainTableLayout.Add(z1iTextBox, 0, 1);

            z1Label = new MyLabel("z1Label", "Округлите до целого и введите число зубьев шестерни");
            mainTableLayout.Add(z1Label, 1, 0);

            z1TextBox = new InputTextBox<double>("z1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.z1 = value);
            mainTableLayout.Add(z1TextBox, 1, 1);

            // z2

            z2iLabel = new MyLabel("z2iLabel", "Расчетное значение числа зубьев колеса");
            mainTableLayout.Add(z2iLabel, 2, 0);

            z2iTextBox = new OutputTextBox("z2iTextBox");
            mainTableLayout.Add(z2iTextBox, 2, 1);

            z2Label = new MyLabel("z2Label", "Округлите до целого и введите число зубьев колеса");
            mainTableLayout.Add(z2Label, 3, 0);

            z2TextBox = new InputTextBox<double>("z2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.z2 = value);
            mainTableLayout.Add(z2TextBox, 3, 1);

            // bad delta u

            badDeltaU1label = new MyLabel("badDeltaU1label", "Отклонение передаточного отношения от исходного превышает 3%");
            mainTableLayout.Add(badDeltaU1label, 4, 0);

            badDeltaU2label = new MyLabel("badDeltaU2label", "Измените числа зубьев шестерни и/или колеса");
            mainTableLayout.Add(badDeltaU2label, 5, 0);
        }


    }
}
