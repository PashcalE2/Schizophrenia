using System;
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

        public MyLabel CTLabel;
        public OutputTextBox CTOutputTextBox;

        public MyLabel KVLabel;
        public InputTextBox<double> KVTextBox;

        public PictureBox KVPicture;

        public Page13(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page13MainTableLayout", 2, 1, DockStyle.Fill);

            page13LabelsBoxesGroup = new MyTableLayoutPanel("page13LabelsBoxesGroup", 4, 2);
            page13LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page13LabelsBoxesGroup, 0, 0);

            VLabel = new MyLabel("VLabel", "Окружная скорость, м/с:");
            page13LabelsBoxesGroup.Add(VLabel, 0, 0);

            VTextBox = new OutputTextBox("VTextBox");
            page13LabelsBoxesGroup.Add(VTextBox, 0, 1);

            HBMinLabel = new MyLabel("HBMinLabel", "Твердость, НВ:");
            page13LabelsBoxesGroup.Add(HBMinLabel, 1, 0);

            HBMinTextBox = new OutputTextBox("HBMinTextBox");
            page13LabelsBoxesGroup.Add(HBMinTextBox, 1, 1);

            CTLabel = new MyLabel("page13CTLabel", "Степень точности:");
            page13LabelsBoxesGroup.Add(CTLabel, 2, 0);

            CTOutputTextBox = new OutputTextBox("page13CTTextBox");
            page13LabelsBoxesGroup.Add(CTOutputTextBox, 2, 1);

            KVLabel = new MyLabel("KVLabel", "Коэффициент динамической нагрузки:");
            page13LabelsBoxesGroup.Add(KVLabel, 3, 0);

            KVTextBox = new InputTextBox<double>("KVTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KV = value);
            page13LabelsBoxesGroup.Add(KVTextBox, 3, 1);

            KVPicture = new PictureBox();
            KVPicture.Image = Properties.Resources.KVTable;
            KVPicture.Anchor = AnchorStyles.Top;
            KVPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            mainTableLayout.Add(KVPicture, 1, 0);
        }

        public override bool CanMoveOn()
        {
            return !KVTextBox.Enabled || KVTextBox.GetIsValid();
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;

            // KP, ending
            ctx.KH = ctx.KHalpha * ctx.KBeta * ctx.KV;
            ctx.zH = Math.Sqrt(2.0 / Math.Sin(2 * ctx.alphaW));
            ctx.zEpsilon = Math.Sqrt((4 - ctx.epsilonAlpha) / 3.0);
            ctx.sigmaH = 275.0 * ctx.zH * ctx.zEpsilon * Math.Sqrt(2.0 * ctx.T1 * ctx.KH * (ctx.Ui + 1) / ctx.psibd / ctx.Ui / Math.Pow(ctx.dW1, 3.0));
            
            if (ctx.sigmaH <= ctx.sigmaHAllow)
            {
                ctx.eh = Math.Abs(ctx.sigmaHAllow - ctx.sigmaH) * 100 / ctx.sigmaHAllow;

                if (ctx.eh > 5)
                {
                    if (ctx.aWKnown)
                    {
                        ctx.bW = ctx.bW * Math.Pow(ctx.sigmaH / ctx.sigmaHAllow, 2.0);
                        ctx.psibd = ctx.bW / ctx.dW1;
                    }
                    else
                    {
                        ctx.dW1 = ctx.dW1 * Math.Pow(ctx.sigmaH / ctx.sigmaHAllow, 2.0 / 3.0);
                    }

                    ctx.mi = 10.0 * ctx.T1 / (ctx.psibd * Math.Pow(ctx.dW1, 2.0) * ctx.sigmaF1Allow);
                    appForm.page5.miTextBox.Text = ctx.mi.ToString("0.##");

                    MessageBox.Show(String.Format("Относительная недогрузка по контактным напряжениям: {0}%", Math.Round(ctx.eh)));

                    return PageID.Page5;
                }
                else
                {
                    ctx.bW = Math.Ceiling(ctx.psibd * ctx.dW1);

                    // Ip begining

                    if (ctx.CT <= 5)
                    {
                        ctx.KFalpha = 0.64;
                    }
                    else if (ctx.CT <= 6)
                    {
                        ctx.KFalpha = 0.725;
                    }
                    else if (ctx.CT <= 7)
                    {
                        ctx.KFalpha = 0.82;
                    }
                    else //if (ctx.CT > 7)
                    {
                        ctx.KFalpha = 0.91;
                    }

                    ctx.KF = ctx.KFalpha * ctx.KH;

                    if (ctx.x1 == 0 && ctx.x2 == 0)
                    {
                        appForm.page14.z1OutputTextBox.Text = ctx.z1.ToString("0.##");
                        appForm.page14.z2OutputTextBox.Text = ctx.z2.ToString("0.##");

                        return PageID.Page14;
                    }
                    else
                    {
                        appForm.page15.z1OffsetTextBox.Text = (ctx.z1).ToString("0.##");
                        appForm.page15.z2OffsetTextBox.Text = (ctx.z2).ToString("0.##");

                        appForm.page15.x1OffsetTextBox.Text = ctx.x1.ToString("0.##");
                        appForm.page15.x2OffsetTextBox.Text = ctx.x2.ToString("0.##");

                        return PageID.Page15;
                    }
                }
            }
            else
            {
                MessageBox.Show(String.Format("Превышение допускаемого контактного напряжения на {0} МПа", Math.Round(ctx.sigmaH - ctx.sigmaHAllow)));

                if (ctx.aWKnown)
                {
                    ctx.bW = ctx.bW * Math.Pow(ctx.sigmaH / ctx.sigmaHAllow, 2.0);
                    ctx.psibd = ctx.bW / ctx.dW1;
                }
                else
                {
                    ctx.dW1 = ctx.dW1 * Math.Pow(ctx.sigmaH / ctx.sigmaHAllow, 2.0 / 3.0);
                }

                ctx.mi = 10.0 * ctx.T1 / (ctx.psibd * Math.Pow(ctx.dW1, 2.0) * ctx.sigmaF1Allow);
                appForm.page5.miTextBox.Text = ctx.mi.ToString("0.##");

                return PageID.Page5;
            }
        }
    }
}
