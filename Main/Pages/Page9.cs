using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages {
    public class Page9 : AnyPage {
        public MyLabel xCor1Label;
        public MyLabel gearLabel;
        public MyLabel wheelLabel;

        public MyRadioButton withoutOffsetRadioButton;
        public OutputTextBox x1iCor1TextBox;
        public OutputTextBox x2iCor1TextBox;

        public MyRadioButton withOffsetRadioButton;
        public InputTextBox<double> x1Cor1TextBox;
        public InputTextBox<double> x2Cor1TextBox;

        public Page9(AppForm appForm, PageID ID) : base(appForm, ID) {
            mainTableLayout = new MyTableLayoutPanel("page9MainTableLayout", 3, 3, DockStyle.Fill);
            mainTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            xCor1Label = new MyLabel("xCor1Label", "Задайте коэффициент смещения:");
            mainTableLayout.Add(xCor1Label, 0, 0);

            gearLabel = new MyLabel("page9GearLabel", "Шестерня");
            gearLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(gearLabel, 0, 1);

            wheelLabel = new MyLabel("page9WheelLabel", "Колесо");
            wheelLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(wheelLabel, 0, 2);

            withoutOffsetRadioButton = new MyRadioButton("withoutOffsetRadioButton", "Без смещения (для шестерни x1=0, для колеса x2=0)");
            withoutOffsetRadioButton.CheckedChanged += new EventHandler(withoutOffsetRadioButton_CheckedChange);
            mainTableLayout.Add(withoutOffsetRadioButton, 1, 0);

            x1iCor1TextBox = new OutputTextBox("x1iCor1TextBox");
            mainTableLayout.Add(x1iCor1TextBox, 1, 1);

            x2iCor1TextBox = new OutputTextBox("x2iCor1TextBox");
            mainTableLayout.Add(x2iCor1TextBox, 1, 2);

            withOffsetRadioButton = new MyRadioButton("withOffsetRadioButton", "Высотная коррекция: коэффициент смещения не менее");
            withOffsetRadioButton.CheckedChanged += new EventHandler(withOffsetRadioButton_CheckedChange);
            mainTableLayout.Add(withOffsetRadioButton, 2, 0);

            DoubleValidator x1Cor1Validator = new DoubleValidator((value) => value >= appForm.context.x1Min);
            x1Cor1TextBox = new InputTextBox<double>("x1Cor1TextBox", x1Cor1Validator, (value) => appForm.context.x1 = value);
            x1Cor1TextBox.TextChanged += new EventHandler(x1Cor1TextBox_TextChanged);
            mainTableLayout.Add(x1Cor1TextBox, 2, 1);

            DoubleValidator x2Cor1Validator = new DoubleValidator((value) => value >= appForm.context.x2Min);
            x2Cor1TextBox = new InputTextBox<double>("x2Cor1TextBox", x2Cor1Validator, (value) => appForm.context.x2 = value);
            x2Cor1TextBox.TextChanged += new EventHandler(x2Cor1TextBox_TextChanged);
            mainTableLayout.Add(x2Cor1TextBox, 2, 2);
        }

        public override bool CanMoveOn() {
            return
                (!x1Cor1TextBox.Enabled || x1Cor1TextBox.GetIsValid()) &&
                (!x2Cor1TextBox.Enabled || x2Cor1TextBox.GetIsValid());
        }

        public override PageID NextPage() {

            if (appForm.context.withoutOffset) {
                appForm.context.xSigma = 0;
            }

            if ((appForm.context.aWKnown || appForm.context.standartAWYes) && SomeUtils.DoubleEqauals(appForm.context.aW, appForm.context.a, 1e-12)) {
                if (withoutOffsetRadioButton.Checked) {
                    appForm.page8.g1();

                    // KP, begining
                    return appForm.page8.kp_begining();
                }
                else {
                    appForm.page8.g2();

                    // KP, begining
                    return appForm.page8.kp_begining();
                }
            }

            return PageID.Page10;
        }

        private void withoutOffsetRadioButton_CheckedChange(object sender, EventArgs e) {
            appForm.context.withoutOffset = withoutOffsetRadioButton.Checked;

            if (appForm.context.withoutOffset) {
                x1Cor1TextBox.Enabled = false;
                appForm.context.x1 = 0;
                x1Cor1TextBox.SetValue(appForm.context.x1);

                x2Cor1TextBox.Enabled = false;
                appForm.context.x2 = 0;
                x2Cor1TextBox.SetValue(appForm.context.x2);
            }
        }

        private void withOffsetRadioButton_CheckedChange(object sender, EventArgs e) {
            appForm.context.withOffset = withOffsetRadioButton.Checked;

            if (appForm.context.withOffset) {
                x1Cor1TextBox.Enabled = appForm.context.x1Min >= appForm.context.x2Min;

                x2Cor1TextBox.Enabled = !x1Cor1TextBox.Enabled;
            }
        }

        private void x1Cor1TextBox_TextChanged(object sender, EventArgs e) {
            if (appForm.context.withOffset) {
                appForm.context.x2 = -appForm.context.x1;
                x2Cor1TextBox.SetValue(appForm.context.x2);
            }
        }

        private void x2Cor1TextBox_TextChanged(object sender, EventArgs e) {
            if (appForm.context.withOffset) {
                appForm.context.x1 = -appForm.context.x2;
                x1Cor1TextBox.SetValue(appForm.context.x1);
            }
        }
    }
}
