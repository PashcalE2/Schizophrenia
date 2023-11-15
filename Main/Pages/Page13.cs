using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page13 : AnyPage
    {
        public MyTableLayoutPanel page13LabelsBoxesGroup;
        public MyLabel VLabel;
        public OutputTextBox VTextBox;

        public MyLabel HBMinLabel;
        public OutputTextBox HBMinTextBox;

        public MyLabel page13CTLabel;
        public OutputTextBox page13CTTextBox;

        public MyLabel KVLabel;
        public InputTextBox<double> KVTextBox;

        public PictureBox KVPicture;

        public Page13(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page13MainTableLayout", 2, 1, DockStyle.Fill);

            page13LabelsBoxesGroup = new MyTableLayoutPanel("page13LabelsBoxesGroup", 4, 2);
            page13LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page13LabelsBoxesGroup, 0, 0);

            VLabel = new MyLabel("VLabel", "Окружная скорость, м/с");
            page13LabelsBoxesGroup.Add(VLabel, 0, 0);

            VTextBox = new OutputTextBox("VTextBox");
            page13LabelsBoxesGroup.Add(VTextBox, 0, 1);

            HBMinLabel = new MyLabel("HBMinLabel", "Твердость, НВ");
            page13LabelsBoxesGroup.Add(HBMinLabel, 1, 0);

            HBMinTextBox = new OutputTextBox("HBMinTextBox");
            page13LabelsBoxesGroup.Add(HBMinTextBox, 1, 1);

            page13CTLabel = new MyLabel("page13CTLabel", "Степень точности");
            page13LabelsBoxesGroup.Add(page13CTLabel, 2, 0);

            page13CTTextBox = new OutputTextBox("page13CTTextBox");
            page13LabelsBoxesGroup.Add(page13CTTextBox, 2, 1);

            KVLabel = new MyLabel("KVLabel", "Коэффициент динамической нагрузки");
            page13LabelsBoxesGroup.Add(KVLabel, 3, 0);

            KVTextBox = new InputTextBox<double>("KVTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KV = value);
            page13LabelsBoxesGroup.Add(KVTextBox, 3, 1);

            KVPicture = new PictureBox();
            KVPicture.Image = Properties.Resources.KVTable;
            KVPicture.Anchor = AnchorStyles.Top;
            KVPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(KVPicture, 1, 0);
        }


    }
}
