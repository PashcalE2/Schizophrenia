using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page7 : AnyPage
    {
        public MyTableLayoutPanel page7AWGroup;

        public MyLabel aWiLabel;
        public OutputTextBox aWiTextBox;

        public InputTextBox<double> aWTextBox;

        public PictureBox standartAWPicture;

        public Page7(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page7MainTableLayout", 2, 1, DockStyle.Fill);

            page7AWGroup = new MyTableLayoutPanel("page7AWGroup", 2, 3, DockStyle.Fill);
            page7AWGroup.Margin = new Padding(0);
            page7AWGroup.Padding = new Padding(0);
            page7AWGroup.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page7AWGroup, 0, 0);

            aWiLabel = new MyLabel("aWiLabel", "Введите стандартное межосевое расстояние по таблице");
            page7AWGroup.Add(aWiLabel, 0, 0);

            aWiTextBox = new OutputTextBox("aWiTextBox");
            page7AWGroup.Add(aWiTextBox, 0, 1);

            aWTextBox = new InputTextBox<double>("aWTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.aW = value);
            page7AWGroup.Add(aWTextBox, 1, 1);

            standartAWPicture = new PictureBox();
            standartAWPicture.Image = Properties.Resources.standartAWTable;
            standartAWPicture.Anchor = AnchorStyles.Top;
            standartAWPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(standartAWPicture, 1, 0);
        }


    }
}
