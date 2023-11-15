using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page12 : AnyPage
    {
        public MyLabel psibdLabel;
        public OutputTextBox psibdTextBox;

        public MyLabel KBettaLabel;
        public InputTextBox<double> KBettaTextBox;

        public PictureBox page12KBettaPicture;
        public MyTableLayoutPanel page12PicturesGroup;
        public PictureBox page12SymmPicture;
        public PictureBox page12AsymmPicture;
        public PictureBox page12ConsolePicture;

        public Page12(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page12MainTableLayout", 3, 2, DockStyle.Fill);

            psibdLabel = new MyLabel("psibdLabel", "Коэффициент ширины относительно диаметра шестерни");
            mainTableLayout.Add(psibdLabel, 0, 0);

            psibdTextBox = new OutputTextBox("psibdTextBox");
            mainTableLayout.Add(psibdTextBox, 0, 1);

            KBettaLabel = new MyLabel("KBettaLabel", "Введите начальный коэффициент неравномерности распределения нагрузки");
            mainTableLayout.Add(KBettaLabel, 1, 0);

            KBettaTextBox = new InputTextBox<double>("KBettaTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KBetta = value);
            mainTableLayout.Add(KBettaTextBox, 1, 1);

            page12KBettaPicture = new PictureBox();
            page12KBettaPicture.Image = Properties.Resources.KBettaTable;
            page12KBettaPicture.Anchor = AnchorStyles.Top;
            page12KBettaPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(page12KBettaPicture, 2, 0);

            page12PicturesGroup = new MyTableLayoutPanel("page12PicturesGroup", 3, 1);
            mainTableLayout.Add(page12PicturesGroup, 2, 1);

            page12SymmPicture = new PictureBox();
            page12SymmPicture.Image = Properties.Resources.symm;
            page12SymmPicture.Anchor = AnchorStyles.Top;
            page12SymmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12SymmPicture, 0, 0);

            page12AsymmPicture = new PictureBox();
            page12AsymmPicture.Image = Properties.Resources.asymm;
            page12AsymmPicture.Anchor = AnchorStyles.Top;
            page12AsymmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12AsymmPicture, 1, 0);

            page12ConsolePicture = new PictureBox();
            page12ConsolePicture.Image = Properties.Resources.console;
            page12ConsolePicture.Anchor = AnchorStyles.Top;
            page12ConsolePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12ConsolePicture, 2, 0);
        }


    }
}
