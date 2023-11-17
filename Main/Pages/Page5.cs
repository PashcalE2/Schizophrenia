using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page5 : AnyPage
    {
        public Page5 page5;

        public MyTableLayoutPanel page5MiGroup;
        public MyLabel miLabel;
        public OutputTextBox miTextBox;

        public MyLabel mComentLabel;

        public MyTableLayoutPanel page5MGroup;
        public MyLabel mLabel;
        public InputTextBox<double> mTextBox;

        public PictureBox mPicture;

        public PictureBox standartMPicture;

        public Page5(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page5MainTableLayout", 5, 1, DockStyle.Fill);

            // mi

            page5MiGroup = new MyTableLayoutPanel("page5MiGroup", 1, 2);
            page5MiGroup.Margin = new Padding(0);
            page5MiGroup.Padding = new Padding(0);
            page5MiGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page5MiGroup, 0, 0);

            miLabel = new MyLabel("miLabel", "Расчетное значение модуля зацепления:");
            page5MiGroup.Add(miLabel, 0, 0);

            miTextBox = new OutputTextBox("miTextBox");
            page5MiGroup.Add(miTextBox, 0, 1);

            // comment

            mComentLabel = new MyLabel("mComentLabel", "Введите стандартное значение модуля не менее минимального по таблицам");
            mainTableLayout.Add(mComentLabel, 1, 0);

            // m

            page5MGroup = new MyTableLayoutPanel("page5MGroup", 1, 2);
            page5MGroup.Margin = new Padding(0);
            page5MGroup.Padding = new Padding(0);
            page5MGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page5MGroup, 2, 0);

            mLabel = new MyLabel("mLabel", "Модуль зацепления, мм:");
            page5MGroup.Add(mLabel, 0, 0);

            mTextBox = new InputTextBox<double>("mTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.m = value);
            page5MGroup.Add(mTextBox, 0, 1);

            // min m picture

            mPicture = new PictureBox();
            mPicture.Image = Properties.Resources.minMTable;
            mPicture.Anchor = AnchorStyles.Top;
            mPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(mPicture, 3, 0);

            standartMPicture = new PictureBox();
            standartMPicture.Image = Properties.Resources.standartMTable;
            standartMPicture.Anchor = AnchorStyles.Top;
            standartMPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(standartMPicture, 4, 0);
        }

        public override bool CanMoveOn()
        {
            return !mTextBox.Enabled || mTextBox.GetIsValid();
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;

            ctx.z1i = ctx.dW1 / ctx.m;
            appForm.page6.z1iTextBox.Text = ctx.z1i.ToString("0.##");

            return PageID.Page6;
        }

    }
}
