using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page14 : AnyPage
    {
        public MyTableLayoutPanel page14LabelsBoxesGroup;
        public MyLabel page14Z1Label;
        public OutputTextBox page14Z1TextBox;

        public MyLabel YF1Label;
        public InputTextBox<double> YF1TextBox;

        public MyLabel page14Z2Label;
        public OutputTextBox page14Z2TextBox;

        public MyLabel YF2Label;
        public InputTextBox<double> YF2TextBox;

        public PictureBox YFPicture;

        public Page14(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page14MainTableLayout", 2, 1, DockStyle.Fill);

            page14LabelsBoxesGroup = new MyTableLayoutPanel("page14LabelsBoxesGroup", 4, 2);
            page14LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page14LabelsBoxesGroup, 0, 0);

            page14Z1Label = new MyLabel("page14Z1Label", "Число зубьев шестерни");
            page14LabelsBoxesGroup.Add(page14Z1Label, 0, 0);

            page14Z1TextBox = new OutputTextBox("page14Z1TextBox");
            page14LabelsBoxesGroup.Add(page14Z1TextBox, 0, 1);

            YF1Label = new MyLabel("YF1Label", "Введите коэффициент формы зуба шестерни");
            page14LabelsBoxesGroup.Add(YF1Label, 1, 0);

            YF1TextBox = new InputTextBox<double>("YF1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF1 = value);
            page14LabelsBoxesGroup.Add(YF1TextBox, 1, 1);

            page14Z2Label = new MyLabel("page14Z2Label", "Число зубьев колеса");
            page14LabelsBoxesGroup.Add(page14Z2Label, 2, 0);

            page14Z2TextBox = new OutputTextBox("page14Z2TextBox");
            page14LabelsBoxesGroup.Add(page14Z2TextBox, 2, 1);

            YF2Label = new MyLabel("YF2Label", "Введите коэффициент формы зуба колеса");
            page14LabelsBoxesGroup.Add(YF2Label, 3, 0);

            YF2TextBox = new InputTextBox<double>("YF2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF2 = value);
            page14LabelsBoxesGroup.Add(YF2TextBox, 3, 1);

            YFPicture = new PictureBox();
            YFPicture.Image = Properties.Resources.YFTable;
            YFPicture.Anchor = AnchorStyles.Top;
            YFPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(YFPicture, 1, 0);
        }


    }
}
