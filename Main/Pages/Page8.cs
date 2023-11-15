using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page8 : AnyPage
    {
        public MyLabel page8GearLabel;
        public MyLabel page8WheelLabel;

        public MyLabel xLabel;
        public OutputTextBox x1iTextBox;
        public OutputTextBox x2iTextBox;

        public InputTextBox<double> x1TextBox;

        public InputTextBox<double> x2TextBox;

        public Page8(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page8MainTableLayout", 3, 3, DockStyle.Fill);

            page8GearLabel = new MyLabel("page8GearLabel", "Шестерня");
            mainTableLayout.Add(page8GearLabel, 0, 1);

            page8WheelLabel = new MyLabel("page8WheelLabel", "Колесо");
            mainTableLayout.Add(page8WheelLabel, 0, 2);

            xLabel = new MyLabel("xLabel", "Задайте коэффициент смещения не менее");
            mainTableLayout.Add(xLabel, 1, 0);

            x1iTextBox = new OutputTextBox("x1iTextBox");
            mainTableLayout.Add(x1iTextBox, 1, 1);

            x2iTextBox = new OutputTextBox("x2iTextBox");
            mainTableLayout.Add(x2iTextBox, 1, 2);

            x1TextBox = new InputTextBox<double>("x1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x1 = value);
            mainTableLayout.Add(x1TextBox, 2, 1);

            x2TextBox = new InputTextBox<double>("x2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x2 = value);
            mainTableLayout.Add(x2TextBox, 2, 2);
        }


    }
}
