using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page11 : AnyPage
    {
        public MyLabel aWG3Label;
        public OutputTextBox aWG3OutputTextBox;

        public MyRadioButton withoutRoundRadioButton;
        public MyRadioButton withRoundRadioButton;
        public InputTextBox<double> aWG3InputTextBox;

        public Page11(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page11MainTableLayout", 3, 2, DockStyle.Fill);
            mainTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            aWG3Label = new MyLabel("page11aWG3Label", "Расчётное межосевое расстояние составляет:");
            mainTableLayout.Add(aWG3Label, 0, 0);

            aWG3OutputTextBox = new OutputTextBox("aWG3OutputTextBox");
            mainTableLayout.Add(aWG3OutputTextBox, 0, 1);

            withoutRoundRadioButton = new MyRadioButton("withoutRoundRadioButton", "Оставить без округления");
            withoutRoundRadioButton.CheckedChanged += new System.EventHandler(withoutRoundRadioButton_CheckedChanged);
            mainTableLayout.Add(withoutRoundRadioButton, 1, 0);

            withRoundRadioButton = new MyRadioButton("withRoundRadioButton", "Округлить");
            withRoundRadioButton.CheckedChanged += new System.EventHandler(roundRadioButton_CheckedChanged);
            mainTableLayout.Add(withRoundRadioButton, 2, 0);

            aWG3InputTextBox = new InputTextBox<double>("aWG3InputTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.aW = value);
            mainTableLayout.Add(aWG3InputTextBox, 2, 1);

            // after init

            withoutRoundRadioButton.Checked = true;
        }

        public override bool CanMoveOn()
        {
            return
                (withoutRoundRadioButton.Checked || withRoundRadioButton.Checked) &&
                (!aWG3InputTextBox.Enabled || aWG3InputTextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            if (appForm.context.withoutRound)
            {
                appForm.page8.g4();

                return appForm.page8.kp_begining();
            }
            else
            {
                return appForm.page8.x3();
            }
        }

        private void withoutRoundRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            appForm.context.withoutRound = withoutRoundRadioButton.Checked;

            if (withoutRoundRadioButton.Checked)
            {
                appForm.context.aW = appForm.contextHistory.Peek().aW;

                aWG3InputTextBox.Enabled = false;
                aWG3InputTextBox.SetValue(appForm.context.aW);
            }
        }

        private void roundRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            appForm.context.withRound = withRoundRadioButton.Checked;

            if (withRoundRadioButton.Checked)
            {
                aWG3InputTextBox.Enabled = true;
            }
        }
    }
}
