﻿using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page15 : AnyPage
    {
        public MyTableLayoutPanel page15LabelsBoxesGroup;
        public MyLabel gearLabel;
        public MyLabel wheelLabel;

        public MyLabel zOffsetLabel;
        public OutputTextBox z1OffsetTextBox;
        public OutputTextBox z2OffsetTextBox;

        public MyLabel xOffsetLabel;
        public OutputTextBox x1OffsetTextBox;
        public OutputTextBox x2OffsetTextBox;

        public MyLabel YFOffsetLabel;
        public InputTextBox<double> YF1OffsetTextBox;
        public InputTextBox<double> YF2OffsetTextBox;

        public PictureBox zPicture;

        public Page15(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page15MainTableLayout", 2, 1, DockStyle.Fill);

            page15LabelsBoxesGroup = new MyTableLayoutPanel("page15LabelsBoxesGroup", 4, 3);
            page15LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page15LabelsBoxesGroup, 0, 0);

            gearLabel = new MyLabel("page15GearLabel", "Шестерня");
            gearLabel.Anchor = AnchorStyles.None;
            page15LabelsBoxesGroup.Add(gearLabel, 0, 1);

            wheelLabel = new MyLabel("page15WheelLabel", "Колесо");
            wheelLabel.Anchor = AnchorStyles.None;
            page15LabelsBoxesGroup.Add(wheelLabel, 0, 2);

            zOffsetLabel = new MyLabel("zOffsetLabel", "Число зубьев:");
            page15LabelsBoxesGroup.Add(zOffsetLabel, 1, 0);

            z1OffsetTextBox = new OutputTextBox("z1OffsetTextBox");
            page15LabelsBoxesGroup.Add(z1OffsetTextBox, 1, 1);

            z2OffsetTextBox = new OutputTextBox("z2OffsetTextBox");
            page15LabelsBoxesGroup.Add(z2OffsetTextBox, 1, 2);

            xOffsetLabel = new MyLabel("xOffsetLabel", "Коэффициент смещения:");
            page15LabelsBoxesGroup.Add(xOffsetLabel, 2, 0);

            x1OffsetTextBox = new OutputTextBox("x1OffsetTextBox");
            page15LabelsBoxesGroup.Add(x1OffsetTextBox, 2, 1);

            x2OffsetTextBox = new OutputTextBox("x2OffsetTextBox");
            page15LabelsBoxesGroup.Add(x2OffsetTextBox, 2, 2);

            YFOffsetLabel = new MyLabel("YFOffsetLabel", "Введите коэффициент формы зуба:");
            page15LabelsBoxesGroup.Add(YFOffsetLabel, 3, 0);

            YF1OffsetTextBox = new InputTextBox<double>("YF1OffsetTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF1 = value);
            page15LabelsBoxesGroup.Add(YF1OffsetTextBox, 3, 1);

            YF2OffsetTextBox = new InputTextBox<double>("YF2OffsetTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF2 = value);
            page15LabelsBoxesGroup.Add(YF2OffsetTextBox, 3, 2);

            zPicture = new PictureBox();
            zPicture.Image = Properties.Resources.zfunc;
            zPicture.Anchor = AnchorStyles.Top;
            zPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(zPicture, 1, 0);
        }

        public override bool CanMoveOn()
        {
            return
                (!YF1OffsetTextBox.Enabled || YF1OffsetTextBox.GetIsValid()) &&
                (!YF2OffsetTextBox.Enabled || YF2OffsetTextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            return appForm.page14.ip_ending();
        }
    }
}
