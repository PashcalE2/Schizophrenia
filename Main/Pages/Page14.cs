using System.Windows.Forms;

namespace Schizophrenia.Main.Pages {
    public class Page14 : AnyPage {
        public MyTableLayoutPanel page14LabelsBoxesGroup;
        public MyLabel page14Z1Label;
        public OutputTextBox z1OutputTextBox;

        public MyLabel YF1Label;
        public InputTextBox<double> YF1TextBox;

        public MyLabel page14Z2Label;
        public OutputTextBox z2OutputTextBox;

        public MyLabel YF2Label;
        public InputTextBox<double> YF2TextBox;

        public PictureBox YFPicture;

        public Page14(AppForm appForm, PageID ID) : base(appForm, ID) {
            mainTableLayout = new MyTableLayoutPanel("page14MainTableLayout", 2, 1, DockStyle.Fill);

            page14LabelsBoxesGroup = new MyTableLayoutPanel("page14LabelsBoxesGroup", 4, 2);
            page14LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page14LabelsBoxesGroup, 0, 0);

            page14Z1Label = new MyLabel("page14Z1Label", "Число зубьев шестерни:");
            page14LabelsBoxesGroup.Add(page14Z1Label, 0, 0);

            z1OutputTextBox = new OutputTextBox("page14Z1TextBox");
            page14LabelsBoxesGroup.Add(z1OutputTextBox, 0, 1);

            YF1Label = new MyLabel("YF1Label", "Введите коэффициент формы зуба шестерни:");
            page14LabelsBoxesGroup.Add(YF1Label, 1, 0);

            YF1TextBox = new InputTextBox<double>("YF1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF1 = value);
            page14LabelsBoxesGroup.Add(YF1TextBox, 1, 1);

            page14Z2Label = new MyLabel("page14Z2Label", "Число зубьев колеса:");
            page14LabelsBoxesGroup.Add(page14Z2Label, 2, 0);

            z2OutputTextBox = new OutputTextBox("page14Z2TextBox");
            page14LabelsBoxesGroup.Add(z2OutputTextBox, 2, 1);

            YF2Label = new MyLabel("YF2Label", "Введите коэффициент формы зуба колеса:");
            page14LabelsBoxesGroup.Add(YF2Label, 3, 0);

            YF2TextBox = new InputTextBox<double>("YF2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.YF2 = value);
            page14LabelsBoxesGroup.Add(YF2TextBox, 3, 1);

            YFPicture = new PictureBox();
            YFPicture.Image = Properties.Resources.YFTable;
            YFPicture.Anchor = AnchorStyles.Top;
            YFPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(YFPicture, 1, 0);
        }

        public override bool CanMoveOn() {
            return
                (!YF1TextBox.Enabled || YF1TextBox.GetIsValid()) &&
                (!YF2TextBox.Enabled || YF2TextBox.GetIsValid());
        }

        public override PageID NextPage() {
            return ip_ending();
        }

        public PageID ip_ending() {
            Context ctx = appForm.context;

            //IP, ending
            ctx.sigmaF1 = 2 * ctx.T1 * ctx.KF * ctx.YF1 / (ctx.dW1 * ctx.bW * ctx.m);
            ctx.sigmaF2 = ctx.sigmaF1 * ctx.YF2 / ctx.YF1;

            if (ctx.sigmaF1 <= ctx.sigmaF1Allow) {
                if (ctx.sigmaF2 <= ctx.sigmaF2Allow) {
                    // GG
                    MessageBox.Show("Расчёт завершён, воспользуйтесь кнопкой Печать");

                    appForm.printButton.Enabled = true;
                    return PageID.Page14;
                }
                else {
                    ctx.m = ctx.m * ctx.sigmaF2 / ctx.sigmaF2Allow; // [sigmaF2] means allowed sigmaF2

                    return PageID.Page5;
                }
            }
            else {
                ctx.m = ctx.m * ctx.sigmaF1 / ctx.sigmaF1Allow;

                return PageID.Page5;
            }
        }
    }
}
