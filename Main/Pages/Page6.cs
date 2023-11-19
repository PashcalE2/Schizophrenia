using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page6 : AnyPage
    {
        public MyLabel z1iLabel;
        public OutputTextBox z1iTextBox;

        public MyLabel z1Label;
        public InputTextBox<double> z1TextBox;

        public MyLabel z2iLabel;
        public OutputTextBox z2iTextBox;

        public MyLabel z2Label;
        public InputTextBox<double> z2TextBox;

        public MyLabel badDeltaU1label;
        public MyLabel badDeltaU2label;

        public Page6(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page6MainTableLayout", 6, 2, DockStyle.Fill);
            mainTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            // z1

            z1iLabel = new MyLabel("z1iLabel", "Расчетное значение числа зубьев шестерни:");
            mainTableLayout.Add(z1iLabel, 0, 0);

            z1iTextBox = new OutputTextBox("z1iTextBox");
            mainTableLayout.Add(z1iTextBox, 0, 1);

            z1Label = new MyLabel("z1Label", "Округлите до целого и введите число зубьев шестерни:");
            mainTableLayout.Add(z1Label, 1, 0);

            z1TextBox = new InputTextBox<double>("z1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.z1 = value);
            z1TextBox.TextChanged += new EventHandler(badUCheck);
            z1TextBox.TextChanged += new EventHandler((sender, e) => {
                appForm.context.z2i = appForm.context.z1 * appForm.context.u;
                z2iTextBox.Text = appForm.context.z2i.ToString("0.##");
            });
            mainTableLayout.Add(z1TextBox, 1, 1);

            // z2

            z2iLabel = new MyLabel("z2iLabel", "Расчетное значение числа зубьев колеса:");
            mainTableLayout.Add(z2iLabel, 2, 0);

            z2iTextBox = new OutputTextBox("z2iTextBox");
            mainTableLayout.Add(z2iTextBox, 2, 1);

            z2Label = new MyLabel("z2Label", "Округлите до целого и введите число зубьев колеса:");
            mainTableLayout.Add(z2Label, 3, 0);

            z2TextBox = new InputTextBox<double>("z2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.z2 = value);
            z2TextBox.TextChanged += new EventHandler(badUCheck);
            mainTableLayout.Add(z2TextBox, 3, 1);

            // bad delta u

            badDeltaU1label = new MyLabel("badDeltaU1label", "Отклонение передаточного отношения от исходного превышает 3%");
            mainTableLayout.Add(badDeltaU1label, 4, 0);

            badDeltaU2label = new MyLabel("badDeltaU2label", "Измените числа зубьев шестерни и/или колеса");
            mainTableLayout.Add(badDeltaU2label, 5, 0);
        }

        public override bool CanMoveOn()
        {
            return
                (!z1TextBox.Enabled || z1TextBox.GetIsValid()) &&
                (!z2TextBox.Enabled || z2TextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;

            if (ctx.aWKnown)
            {
                // List 10_1
                ctx.a = ctx.m / 2.0 * (ctx.z1 + ctx.z2);
                z();
            }
            else if (ctx.standartAWYes)
            {
                // List 10_2
                ctx.a = ctx.m / 2.0 * (ctx.z1 + ctx.z2);
                ctx.aMin = 1.0001 * ctx.a * Math.Cos(ctx.standartAlpha);

                appForm.page7.aWiTextBox.Text = ctx.aMin.ToString("0.##");

                return PageID.Page7;
            }
            else
            {
                // List 10_3
                z();
            }

            return PageID.Page8;
        }

        public void z()
        {
            Context ctx = appForm.context;

            if (ctx.z1 == 17.0)
            {
                ctx.x1Min = 0.0;
            }
            else
            {
                ctx.x1Min = 1.0 - ctx.z1 * Math.Pow(Math.Sin(ctx.standartAlpha), 2.0) / 2.0;
            }

            if (ctx.z2 == 17.0)
            {
                ctx.x2Min = 0.0;
            }
            else
            {
                ctx.x2Min = 1.0 - ctx.z2 * Math.Pow(Math.Sin(ctx.standartAlpha), 2.0) / 2.0;
            }

            appForm.page8.x1iTextBox.Text = ctx.x1Min.ToString("0.##");
            appForm.page8.x2iTextBox.Text = ctx.x2Min.ToString("0.##");
        }

        private void badUCheck(object sender, EventArgs e)
        {
            appForm.context.Ui = appForm.context.z2 / appForm.context.z1;
            appForm.context.deltaU = Math.Abs(appForm.context.u - appForm.context.Ui) / appForm.context.u * 100.0;

            if (appForm.context.deltaU > 3)
            {
                badDeltaU1label.Visible = true;
                badDeltaU2label.Visible = true;

                appForm.nextButton.Enabled = false;
            }
            else
            {
                badDeltaU1label.Visible = false;
                badDeltaU2label.Visible = false;

                appForm.nextButton.Enabled = true;
            }
        }
    }
}
