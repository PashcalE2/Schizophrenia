using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page4 : AnyPage
    {
        public MyTableLayoutPanel page4TableLayout;
        public MyLabel page4InputDataLabel;

        public MyLabel aWLabel;
        public MyTableLayoutPanel aWRadioGroup;
        public MyRadioButton aWKnownRadioButton;
        public MyRadioButton aWUnknownRadioButton;
        public InputTextBox<double> aWKnownTextBox;

        public MyLabel standartAWLabel;
        public MyTableLayoutPanel standartAWRadioGroup;
        public MyRadioButton standartAWYesRadioButton;
        public MyRadioButton standartAWNoRadioButton;

        public MyLabel psibaLabel;
        public InputTextBox<double> psibaTextBox;

        public MyLabel psibaCommentLabel;

        public MyLabel symmCommentLabel;
        public MyLabel symmLabel;

        public MyLabel asymmCommentLabel;
        public MyLabel asymmLabel;

        public MyLabel consoleCommentLabel;
        public MyLabel consoleLabel;

        public MyLabel internalCommentLabel;
        public MyLabel internalLabel;

        public MyLabel chevronCommentLabel;
        public MyLabel chevronLabel;

        public MyLabel transmissionCommentLabel;
        public MyLabel transmissionLabel;

        public Page4(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page4MainTableLayout", 2, 1, DockStyle.Fill);

            page4InputDataLabel = new MyLabel("page4InputDataLabel", "Исходные данные");
            page4InputDataLabel.Anchor = AnchorStyles.Top;
            page4InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            mainTableLayout.Add(page4InputDataLabel, 0, 0);

            page4TableLayout = new MyTableLayoutPanel("page4TableLayout", 10, 3, DockStyle.Fill);
            //page4TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page4TableLayout, 1, 0);

            // Aw

            aWLabel = new MyLabel("aWLabel", "Межосевое расстояние");
            page4TableLayout.Add(aWLabel, 0, 0);

            aWRadioGroup = new MyTableLayoutPanel("aWRadioGroup", 2, 1, DockStyle.Fill);
            page4TableLayout.Add(aWRadioGroup, 0, 1);

            aWKnownRadioButton = new MyRadioButton("aWKnownRadioButton", "Задано");
            aWKnownRadioButton.CheckedChanged += new EventHandler(aWKnownRadioButton_CheckedChanged);
            aWRadioGroup.Add(aWKnownRadioButton, 0, 0);

            aWUnknownRadioButton = new MyRadioButton("aWUnknownRadioButton", "Не задано");
            aWUnknownRadioButton.CheckedChanged += new EventHandler(aWUnknownRadioButton_CheckedChanged);
            aWRadioGroup.Add(aWUnknownRadioButton, 1, 0);

            aWKnownTextBox = new InputTextBox<double>("aWKnownTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.aW = value);
            page4TableLayout.Add(aWKnownTextBox, 0, 2);

            // StandartAW

            standartAWLabel = new MyLabel("standartAWLabel", "Стандартное межосевое расстояние");
            page4TableLayout.Add(standartAWLabel, 1, 0);

            standartAWRadioGroup = new MyTableLayoutPanel("standartAWRadioGroup", 2, 1);
            page4TableLayout.Add(standartAWRadioGroup, 1, 1);

            standartAWYesRadioButton = new MyRadioButton("standartAWYesRadioButton", "Да");
            standartAWRadioGroup.Add(standartAWYesRadioButton, 0, 0);

            standartAWNoRadioButton = new MyRadioButton("standartAWNoRadioButton", "Нет");
            standartAWRadioGroup.Add(standartAWNoRadioButton, 1, 0);

            // psiba

            psibaLabel = new MyLabel("psibaLabel", "Коэф-т ширины относительного межосевого расстояния");
            page4TableLayout.Add(psibaLabel, 2, 0);

            psibaTextBox = new InputTextBox<double>("psibaTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.psiba = value);
            page4TableLayout.Add(psibaTextBox, 2, 2);

            // Hints

            psibaCommentLabel = new MyLabel("psibaCommentLabel", "Принимается в зависимости от положения колёс относительно опор");
            page4TableLayout.Add(psibaCommentLabel, 3, 0);

            symmCommentLabel = new MyLabel("symmCommentLabel", "При симметричном расположении");
            page4TableLayout.Add(symmCommentLabel, 4, 0);

            symmLabel = new MyLabel("symmLabel", "0,315...0,400");
            page4TableLayout.Add(symmLabel, 4, 1);

            asymmCommentLabel = new MyLabel("asymmCommentLabel", "При несимметричном расположении");
            page4TableLayout.Add(asymmCommentLabel, 5, 0);

            asymmLabel = new MyLabel("asymmLabel", "0,250...0,315");
            page4TableLayout.Add(asymmLabel, 5, 1);

            consoleCommentLabel = new MyLabel("consoleCommentLabel", "При консольном расположении");
            page4TableLayout.Add(consoleCommentLabel, 6, 0);

            consoleLabel = new MyLabel("consoleLabel", "0,20...0,25");
            page4TableLayout.Add(consoleLabel, 6, 1);

            internalCommentLabel = new MyLabel("internalCommentLabel", "Для передач внутреннего зацепления");
            page4TableLayout.Add(internalCommentLabel, 7, 0);

            internalLabel = new MyLabel("internalLabel", "0,315...0,400");
            page4TableLayout.Add(internalLabel, 7, 1);

            chevronCommentLabel = new MyLabel("chevronCommentLabel", "Для шевронных передач");
            page4TableLayout.Add(chevronCommentLabel, 8, 0);

            chevronLabel = new MyLabel("chevronLabel", "0,4...0,5");
            page4TableLayout.Add(chevronLabel, 8, 1);

            transmissionCommentLabel = new MyLabel("transmissionCommentLabel", "Для коробок передач:");
            page4TableLayout.Add(transmissionCommentLabel, 9, 0);

            transmissionLabel = new MyLabel("transmissionLabel", "0,1...0,2");
            page4TableLayout.Add(transmissionLabel, 9, 1);

            // after init

            aWUnknownRadioButton.Checked = true;
            standartAWYesRadioButton.Checked = true;
        }

        private void aWKnownRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aWKnownRadioButton.Checked)
            {
                aWKnownTextBox.Visible = true;

                standartAWLabel.Visible = false;
                standartAWYesRadioButton.Visible = false;
                standartAWNoRadioButton.Visible = false;
                psibaLabel.Visible = false;
                psibaTextBox.Visible = false;

                psibaCommentLabel.Visible = false;
                symmCommentLabel.Visible = false;
                symmLabel.Visible = false;
                asymmCommentLabel.Visible = false;
                asymmLabel.Visible = false;
                consoleCommentLabel.Visible = false;
                consoleLabel.Visible = false;
                internalCommentLabel.Visible = false;
                internalLabel.Visible = false;
                chevronCommentLabel.Visible = false;
                chevronLabel.Visible = false;
                transmissionCommentLabel.Visible = false;
                transmissionLabel.Visible = false;
            }
        }

        private void aWUnknownRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aWUnknownRadioButton.Checked)
            {
                aWKnownTextBox.Visible = false;

                standartAWLabel.Visible = true;
                standartAWYesRadioButton.Visible = true;
                standartAWNoRadioButton.Visible = true;
                psibaLabel.Visible = true;
                psibaTextBox.Visible = true;

                psibaCommentLabel.Visible = true;
                symmCommentLabel.Visible = true;
                symmLabel.Visible = true;
                asymmCommentLabel.Visible = true;
                asymmLabel.Visible = true;
                consoleCommentLabel.Visible = true;
                consoleLabel.Visible = true;
                internalCommentLabel.Visible = true;
                internalLabel.Visible = true;
                chevronCommentLabel.Visible = true;
                chevronLabel.Visible = true;
                transmissionCommentLabel.Visible = true;
                transmissionLabel.Visible = true;
            }
        }
    }
}
