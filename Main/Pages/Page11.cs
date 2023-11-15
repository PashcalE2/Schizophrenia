using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page11 : AnyPage
    {
        public MyLabel page11AWLabel;
        public OutputTextBox page11AW;

        public MyRadioButton withoutRoundRadioButton;
        public MyRadioButton roundRadioButton;
        public InputTextBox<double> aWG3TextBox;

        public Page11(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page11MainTableLayout", 3, 2, DockStyle.Fill);

            page11AWLabel = new MyLabel("page11AWLabel", "Расчётное межосевое расстояние составляет");
            mainTableLayout.Add(page11AWLabel, 0, 0);

            page11AW = new OutputTextBox("page11AW");
            mainTableLayout.Add(page11AW, 0, 1);

            withoutRoundRadioButton = new MyRadioButton("withoutRoundRadioButton", "Оставить без округления");
            mainTableLayout.Add(withoutRoundRadioButton, 1, 0);

            roundRadioButton = new MyRadioButton("roundRadioButton", "Округлить");
            mainTableLayout.Add(roundRadioButton, 2, 0);

            aWG3TextBox = new InputTextBox<double>("aWG3TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.aW = value);
            mainTableLayout.Add(aWG3TextBox, 2, 1);
        }


    }
}
