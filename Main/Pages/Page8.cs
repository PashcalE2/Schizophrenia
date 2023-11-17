using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page8 : AnyPage
    {
        public MyLabel gearLabel;
        public MyLabel wheelLabel;

        public MyLabel xLabel;
        public OutputTextBox x1iTextBox;
        public OutputTextBox x2iTextBox;

        public InputTextBox<double> x1TextBox;

        public InputTextBox<double> x2TextBox;

        public Page8(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page8MainTableLayout", 3, 3, DockStyle.Fill);
            mainTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            gearLabel = new MyLabel("page8GearLabel", "Шестерня");
            gearLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(gearLabel, 0, 1);

            wheelLabel = new MyLabel("page8WheelLabel", "Колесо");
            wheelLabel.Anchor = AnchorStyles.None;
            mainTableLayout.Add(wheelLabel, 0, 2);

            xLabel = new MyLabel("xLabel", "Задайте коэффициент смещения не менее:");
            mainTableLayout.Add(xLabel, 1, 0);

            x1iTextBox = new OutputTextBox("x1iTextBox");
            mainTableLayout.Add(x1iTextBox, 1, 1);

            x2iTextBox = new OutputTextBox("x2iTextBox");
            mainTableLayout.Add(x2iTextBox, 1, 2);

            x1TextBox = new InputTextBox<double>("x1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x1 = value);
            mainTableLayout.Add(x1TextBox, 2, 1);

            x2TextBox = new InputTextBox<double>("x2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.x2 = value);
            mainTableLayout.Add(x2TextBox, 2, 2);
        }

        public override bool CanMoveOn()
        {
            return
                (!x1TextBox.Enabled || x1TextBox.GetIsValid()) &&
                (!x2TextBox.Enabled || x2TextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;

            if (ctx.aWKnown || ctx.standartAWYes)
            {
                if (SomeUtils.DoubleEqauals(ctx.aW, ctx.a, 1e-12))
                {
                    // X2

                    if (ctx.z1 >= 17 && ctx.z2 >= 17)
                    {
                        appForm.page9.withoutOffsetRadioButton.Enabled = true;
                    }
                    else
                    {
                        appForm.page9.withoutOffsetRadioButton.Enabled = false;
                        appForm.page9.withOffsetRadioButton.Checked = true;
                    }

                    appForm.page9.x1iCor1TextBox.Text = ctx.x1Min.ToString("0.##");
                    appForm.page9.x2iCor1TextBox.Text = ctx.x2Min.ToString("0.##");

                    if (ctx.x1Min >= ctx.x2Min)
                    {
                        appForm.page9.x1Cor1TextBox.Enabled = true;

                        appForm.page9.x2Cor1TextBox.Enabled = false;
                        appForm.page9.x2Cor1TextBox.Text = "";
                    }
                    else
                    {
                        appForm.page9.x1Cor1TextBox.Enabled = false;
                        appForm.page9.x1Cor1TextBox.Text = "";

                        appForm.page9.x2Cor1TextBox.Enabled = true;
                    }
                }

                else
                {
                    // X3

                    return x3();
                }
            }

            else
            {
                // X1

                ctx.xSigma = ctx.x1 + ctx.x2;

                if (ctx.xSigma == 0)
                {
                    if (ctx.x1 == ctx.x2) // == 0
                    {
                        // G1
                        g1();

                        // KP, begining
                        return kp_begining();
                    }
                    else
                    {
                        // G2
                        g2();

                        // KP, begining
                        return kp_begining();
                    }
                }
                else
                {
                    ctx.a = ctx.m / 2 * (ctx.z1 + ctx.z2);

                    // G3
                    ctx.invAlpha = Math.Tan(ctx.standartAlpha) - ctx.standartAlpha;
                    ctx.invAlphaW = ctx.invAlpha + (2 * ctx.xSigma * Math.Tan(ctx.standartAlpha)) / (ctx.z1 + ctx.z2);

                    double d;
                    if (ctx.invAlphaW > ctx.invAlpha)
                    {
                        d = 0.01;
                    }
                    else
                    {
                        d = -0.01;
                    }

                    double alphaWx = ctx.standartAlpha;
                    double delta;

                    do
                    {
                        alphaWx = alphaWx + d;
                        double invAlphaWx = Math.Tan(alphaWx) - alphaWx;
                        delta = Math.Abs(invAlphaWx - ctx.invAlphaW);
                    }
                    while (delta >= 0.001);

                    ctx.alphaW = alphaWx;
                    ctx.aW = ctx.a * Math.Cos(ctx.standartAlpha) / Math.Cos(ctx.alphaW);

                    appForm.page11.aWG3OutputTextBox.Text = ctx.aW.ToString("0.##");
                    appForm.page11.aWG3InputTextBox.Text = ctx.aW.ToString("0.##");

                    return PageID.Page11;
                }
            }

            return PageID.Page9;
        }

        public PageID x3()
        {
            Context ctx = appForm.context;

            ctx.alphaW = Math.Acos(ctx.a * Math.Cos(ctx.standartAlpha) / ctx.aW);

            if (ctx.alphaW == double.NaN)
            {
                MessageBox.Show("Увеличьте межосевое расстояние");
                return PageID.Page7;
            }

            ctx.invAlphaW = Math.Tan(ctx.alphaW) - ctx.alphaW;
            ctx.invAlpha = Math.Tan(ctx.standartAlpha) - ctx.standartAlpha;
            ctx.xSigma = (ctx.z1 + ctx.z2) / (2.0 * Math.Tan(ctx.standartAlpha)) * (ctx.invAlphaW - ctx.invAlpha);

            appForm.page10.xSigmaTextBox.Text = ctx.xSigma.ToString("0.##");

            appForm.page10.x1iCor2TextBox.Text = ctx.x1Min.ToString("0.##");
            appForm.page10.x2iCor2TextBox.Text = ctx.x2Min.ToString("0.##");

            if (ctx.x1Min >= ctx.x2Min)
            {
                appForm.page10.x1Cor2TextBox.Enabled = true;

                appForm.page10.x2Cor2TextBox.Enabled = false;
                appForm.page10.x2Cor2TextBox.Text = "";
            }
            else
            {
                appForm.page10.x1Cor2TextBox.Enabled = false;
                appForm.page10.x1Cor2TextBox.Text = "";

                appForm.page10.x2Cor2TextBox.Enabled = true;
            }

            return PageID.Page10;
        }

        public void g1()
        {
            Context ctx = appForm.context;

            ctx.a = ctx.m / 2.0 * (ctx.z1 + ctx.z2);
            ctx.aW = ctx.a;
            ctx.dW1 = ctx.m * ctx.z1;
            ctx.dW2 = ctx.m * ctx.z2;
            ctx.alphaW = ctx.standartAlpha;
            ctx.db1 = ctx.dW1 * Math.Cos(ctx.alphaW);
            ctx.db2 = ctx.dW2 * Math.Cos(ctx.alphaW);
            ctx.da1 = ctx.m * (ctx.z1 + 2.0 * ctx.haStar);
            ctx.da2 = ctx.m * (ctx.z2 + 2.0 * ctx.haStar);
            ctx.df1 = ctx.m * (ctx.z1 - 2.0 * (ctx.haStar + ctx.cStar));
            ctx.df2 = ctx.m * (ctx.z2 - 2.0 * (ctx.haStar + ctx.cStar));
            ctx.ha1 = ctx.haStar * ctx.m;
            ctx.ha2 = ctx.ha1;
            ctx.hf1 = (ctx.haStar + ctx.cStar) * ctx.m;
            ctx.hf2 = ctx.hf1;
            ctx.h = ctx.ha1 + ctx.hf1;
            ctx.c = ctx.cStar * ctx.m;
            ctx.P = Math.PI * ctx.m;
            ctx.Pb = ctx.P * Math.Cos(ctx.standartAlpha);
            ctx.epsilonAlpha = (Math.Sqrt(Math.Pow(ctx.da1, 2.0) - Math.Pow(ctx.db1, 2.0)) + Math.Sqrt(Math.Pow(ctx.da2, 2.0) - Math.Pow(ctx.db2, 2.0)) - 2.0 * ctx.aW * Math.Sin(ctx.alphaW)) / (2.0 * ctx.Pb);
        }

        public void g2()
        {
            Context ctx = appForm.context;

            ctx.a = ctx.m / 2.0 * (ctx.z1 + ctx.z2);
            ctx.aW = ctx.a;
            ctx.d1 = ctx.m * ctx.z1;
            ctx.dW1 = ctx.d1;
            ctx.d2 = ctx.m * ctx.z2;
            ctx.dW2 = ctx.d2;
            ctx.alphaW = ctx.standartAlpha;
            ctx.db1 = ctx.dW1 * Math.Cos(ctx.alphaW);
            ctx.db2 = ctx.dW2 * Math.Cos(ctx.alphaW);
            ctx.da1 = ctx.m * (ctx.z1 + 2.0 * ctx.haStar + 2.0 * ctx.x1);
            ctx.da2 = ctx.m * (ctx.z2 + 2.0 * ctx.haStar + 2.0 * ctx.x2);
            ctx.df1 = ctx.m * (ctx.z1 - 2.0 * (ctx.haStar + ctx.cStar) + 2.0 * ctx.x1);
            ctx.df2 = ctx.m * (ctx.z2 - 2.0 * (ctx.haStar + ctx.cStar) + 2.0 * ctx.x2);
            ctx.ha1 = (ctx.haStar + ctx.x1) * ctx.m;
            ctx.ha2 = (ctx.haStar + ctx.x2) * ctx.m;
            ctx.hf1 = (ctx.haStar + ctx.cStar - ctx.x1) * ctx.m;
            ctx.hf2 = (ctx.haStar + ctx.cStar - ctx.x2) * ctx.m;
            ctx.h = ctx.m * (2.0 * ctx.haStar + ctx.cStar);
            ctx.c = ctx.cStar * ctx.m;
            ctx.P = Math.PI * ctx.m;
            ctx.Pb = ctx.P * Math.Cos(ctx.standartAlpha);
            ctx.epsilonAlpha = (Math.Sqrt(Math.Pow(ctx.da1, 2.0) - Math.Pow(ctx.db1, 2.0)) + Math.Sqrt(Math.Pow(ctx.da2, 2.0) - Math.Pow(ctx.db2, 2.0)) - 2.0 * ctx.aW * Math.Sin(ctx.alphaW)) / (2.0 * ctx.Pb);
        }

        public void g4()
        {
            Context ctx = appForm.context;

            ctx.y = (ctx.aW - ctx.a) / ctx.m;
            ctx.deltay = ctx.xSigma - ctx.y;
            ctx.dW1 = 2 * ctx.aW / (ctx.Ui + 1);
            ctx.dW2 = 2 * ctx.aW - ctx.dW1;
            ctx.db1 = ctx.dW1 * Math.Cos(ctx.alphaW);
            ctx.db2 = ctx.dW2 * Math.Cos(ctx.alphaW);
            ctx.da1 = ctx.m * (ctx.z1 + 2 * ctx.haStar + 2 * ctx.x1 - 2 * ctx.deltay);
            ctx.da2 = ctx.m * (ctx.z2 + 2 * ctx.haStar + 2 * ctx.x2 - 2 * ctx.deltay);
            ctx.ha1 = (ctx.haStar + ctx.x1 - ctx.deltay) * ctx.m;
            ctx.ha2 = (ctx.haStar + ctx.x2 - ctx.deltay) * ctx.m;
            ctx.hf1 = (ctx.haStar + ctx.cStar - ctx.x1) * ctx.m;
            ctx.hf2 = (ctx.haStar + ctx.cStar - ctx.x2) * ctx.m;
            ctx.h = ctx.m * (2 * ctx.haStar + ctx.cStar - ctx.deltay);
            ctx.c = ctx.cStar * ctx.m;
            ctx.P = Math.PI * ctx.m;
            ctx.Pb = ctx.P * Math.Cos(ctx.standartAlpha);
            ctx.epsilonAlpha = (Math.Sqrt(Math.Pow(ctx.da1, 2.0) - Math.Pow(ctx.db1, 2.0)) + Math.Sqrt(Math.Pow(ctx.da2, 2.0) - Math.Pow(ctx.db2, 2.0)) - 2.0 * ctx.aW * Math.Sin(ctx.alphaW)) / (2.0 * ctx.Pb);
        }

        public PageID kp_begining()
        {
            Context ctx = appForm.context;

            ctx.V = Math.PI * ctx.dW1 * ctx.n1 / 60000;
            ctx.KHalpha = 1.0;

            if (ctx.HB1 <= 350.0)
            {
                if (ctx.constMode)
                {
                    ctx.KBeta = 1.0;

                    appForm.page13.VTextBox.Text = ctx.V.ToString("0.##");
                    appForm.page13.HBMinTextBox.Text = Math.Min(ctx.HB1, ctx.HB2).ToString("0.##");
                    appForm.page13.CTOutputTextBox.Text = ctx.CT.ToString();
                    return PageID.Page13;
                }
                else
                {
                    appForm.page12.psibdTextBox.Text = ctx.psibd.ToString("0.##");
                }
            }
            else
            {
                appForm.page12.psibdTextBox.Text = ctx.psibd.ToString("0.##");
            }

            return PageID.Page12;
        }
    }
}
