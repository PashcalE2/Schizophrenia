using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page3 : AnyPage
    {
        public MyTableLayoutPanel page3TableLayout;
        public MyLabel page3InputDataLabel;

        public MyLabel page3GearLabel;
        public MyLabel page3WheelLabel;

        public MyLabel sigmaHLimbLabel;
        public InputTextBox<double> sigmaH1LimbTextBox;
        public InputTextBox<double> sigmaH2LimbTextBox;

        public MyLabel sigmaFLimbLabel;
        public InputTextBox<double> sigmaF1LimbTextBox;
        public InputTextBox<double> sigmaF2LimbTextBox;

        public MyLabel cLabel;
        public InputTextBox<double> c1TextBox;
        public InputTextBox<double> c2TextBox;

        public MyLabel KFCLabel;
        public InputTextBox<double> KFC1TextBox;
        public InputTextBox<double> KFC2TextBox;

        public MyLabel SHLabel;
        public InputTextBox<double> SHTextBox;

        public MyLabel SFLabel;
        public InputTextBox<double> SFTextBox;

        public MyLabel workModeLabel;
        public MyRadioButton constModeRadioButton;
        public MyRadioButton diffModeRadioButton;

        public MyLabel KHELabel;
        public InputTextBox<double> KHETextBox;

        public MyLabel KFELabel;
        public InputTextBox<double> KFETextBox;

        public Page3(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page3MainTableLayout", 2, 1, DockStyle.Fill);

            page3InputDataLabel = new MyLabel("page3InputDataLabel", "Исходные данные");
            page3InputDataLabel.Anchor = AnchorStyles.Top;
            page3InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            mainTableLayout.Add(page3InputDataLabel, 0, 0);

            page3TableLayout = new MyTableLayoutPanel("page3TableLayout", 11, 3, DockStyle.Fill);
            page3TableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page3TableLayout, 1, 0);

            // Gear, Wheel

            page3GearLabel = new MyLabel("page3GearLabel", "Шестерня");
            page3GearLabel.Anchor = AnchorStyles.None;
            page3TableLayout.Add(page3GearLabel, 0, 1);

            page3WheelLabel = new MyLabel("page3WheelLabel", "Колесо");
            page3WheelLabel.Anchor = AnchorStyles.None;
            page3TableLayout.Add(page3WheelLabel, 0, 2);

            // HLimb

            sigmaHLimbLabel = new MyLabel("sigmaHLimbLabel", "Базовый предел контактной выносливости:");
            page3TableLayout.Add(sigmaHLimbLabel, 1, 0);

            sigmaH1LimbTextBox = new InputTextBox<double>("sigmaH1LimbTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.sigmaH1Limb = value);
            page3TableLayout.Add(sigmaH1LimbTextBox, 1, 1);

            sigmaH2LimbTextBox = new InputTextBox<double>("sigmaH2LimbTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.sigmaH2Limb = value);
            page3TableLayout.Add(sigmaH2LimbTextBox, 1, 2);

            // FLimb

            sigmaFLimbLabel = new MyLabel("sigmaFLimbLabel", "Базовый предел изгибной выносливости:");
            page3TableLayout.Add(sigmaFLimbLabel, 2, 0);

            sigmaF1LimbTextBox = new InputTextBox<double>("sigmaF1LimbTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.sigmaF1Limb = value);
            page3TableLayout.Add(sigmaF1LimbTextBox, 2, 1);

            sigmaF2LimbTextBox = new InputTextBox<double>("sigmaF2LimbTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.sigmaF2Limb = value);
            page3TableLayout.Add(sigmaF2LimbTextBox, 2, 2);

            // c

            cLabel = new MyLabel("cLabel", "Число нагружений зуба за один оборот:");
            page3TableLayout.Add(cLabel, 3, 0);

            c1TextBox = new InputTextBox<double>("c1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.c1 = value);
            page3TableLayout.Add(c1TextBox, 3, 1);

            c2TextBox = new InputTextBox<double>("c2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.c2 = value);
            page3TableLayout.Add(c2TextBox, 3, 2);

            // KFC

            KFCLabel = new MyLabel("KFCLabel", "Коэф-т, учитывающий двустороннее нагружение:");
            page3TableLayout.Add(KFCLabel, 4, 0);

            KFC1TextBox = new InputTextBox<double>("KFC1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KFC1 = value);
            page3TableLayout.Add(KFC1TextBox, 4, 1);

            KFC2TextBox = new InputTextBox<double>("KFC2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KFC2 = value);
            page3TableLayout.Add(KFC2TextBox, 4, 2);

            // SH

            SHLabel = new MyLabel("SHLabel", "Запас проности по контактным напряжениям:");
            page3TableLayout.Add(SHLabel, 5, 0);

            SHTextBox = new InputTextBox<double>("SHTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.SH = value);
            page3TableLayout.Add(SHTextBox, 5, 1);

            // SF

            SFLabel = new MyLabel("SFLabel", "Запас прочности по изгибным напряжениям:");
            page3TableLayout.Add(SFLabel, 6, 0);

            SFTextBox = new InputTextBox<double>("SFTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.SF = value);
            page3TableLayout.Add(SFTextBox, 6, 1);

            // model

            workModeLabel = new MyLabel("workModeLabel", "Режим работы:");
            page3TableLayout.Add(workModeLabel, 7, 0);

            constModeRadioButton = new MyRadioButton("constModeRadioButton", "Постоянный");
            constModeRadioButton.CheckedChanged += new EventHandler(constModeRadioButton_CheckedChanged);
            page3TableLayout.Add(constModeRadioButton, 7, 1);

            diffModeRadioButton = new MyRadioButton("diffModeRadioButton", "Переменный");
            diffModeRadioButton.CheckedChanged += new EventHandler(diffModeRadioBtn_CheckedChanged);
            page3TableLayout.Add(diffModeRadioButton, 8, 1);

            // KHE

            KHELabel = new MyLabel("KHELabel", "Коэф-т эквивалентности по контактным напряжениям:");
            page3TableLayout.Add(KHELabel, 9, 0);

            KHETextBox = new InputTextBox<double>("KHETextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KHE = value);
            page3TableLayout.Add(KHETextBox, 9, 1);

            // KFE

            KFELabel = new MyLabel("KFELabel", "Коэф-т эквивалентности по изгибным напряжениям:");
            page3TableLayout.Add(KFELabel, 10, 0);

            KFETextBox = new InputTextBox<double>("KFETextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.KFE = value);
            page3TableLayout.Add(KFETextBox, 10, 1);

            // after init

            constModeRadioButton.Checked = true;
            KHETextBox.SetValue(1);
            KFETextBox.SetValue(1);
        }

        public override bool CanMoveOn()
        {
            return
                (!sigmaH1LimbTextBox.Enabled || sigmaH1LimbTextBox.GetIsValid()) &&
                (!sigmaH2LimbTextBox.Enabled || sigmaH2LimbTextBox.GetIsValid()) &&
                (!sigmaF1LimbTextBox.Enabled || sigmaF1LimbTextBox.GetIsValid()) &&
                (!sigmaF2LimbTextBox.Enabled || sigmaF2LimbTextBox.GetIsValid()) &&
                (!c1TextBox.Enabled || c1TextBox.GetIsValid()) &&
                (!c2TextBox.Enabled || c2TextBox.GetIsValid()) &&
                (!KFC1TextBox.Enabled || KFC1TextBox.GetIsValid()) &&
                (!KFC2TextBox.Enabled || KFC2TextBox.GetIsValid()) &&
                (!SHTextBox.Enabled || SHTextBox.GetIsValid()) &&
                (!SFTextBox.Enabled || SFTextBox.GetIsValid()) &&
                (constModeRadioButton.Checked || diffModeRadioButton.Checked) &&
                (!KHETextBox.Enabled || KHETextBox.GetIsValid()) &&
                (!KFETextBox.Enabled || KFETextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;

            ctx.NHE1 = 60.0 * ctx.c1 * ctx.n1 * ctx.th * ctx.KHE;
            ctx.NHE2 = 60.0 * ctx.c2 * ctx.n2 * ctx.th * ctx.KFE;

            if (ctx.NHE1 >= ctx.NH01) { ctx.KHL1 = 1.0; }
            else { ctx.KHL1 = Math.Pow((ctx.NH01 / ctx.NHE1), (1.0 / 6.0)); }

            if (ctx.NHE2 >= ctx.NH02) { ctx.KHL2 = 1.0; }
            else { ctx.KHL2 = Math.Pow((ctx.NH02 / ctx.NHE2), (1.0 / 6.0)); }

            if (ctx.KHL1 > 1.8 && (appForm.page2.TO1ComboBox.Text == "Цементация" || appForm.page2.TO1ComboBox.Text == "Азотирование" || appForm.page2.TO1ComboBox.Text == "Пов. закалка")) { ctx.KHL1 = 1.8; }
            if (ctx.KHL2 > 1.8 && (appForm.page2.TO2ComboBox.Text == "Цементация" || appForm.page2.TO2ComboBox.Text == "Азотирование" || appForm.page2.TO2ComboBox.Text == "Пов. закалка")) { ctx.KHL2 = 1.8; }

            if (ctx.KHL1 > 2.6 && (appForm.page2.TO1ComboBox.Text == "Нормализация" || appForm.page2.TO1ComboBox.Text == "Улучшение" || appForm.page2.TO1ComboBox.Text == "Об. закалка")) { ctx.KHL1 = 2.6; }
            if (ctx.KHL2 > 2.6 && (appForm.page2.TO2ComboBox.Text == "Нормализация" || appForm.page2.TO2ComboBox.Text == "Улучшение" || appForm.page2.TO2ComboBox.Text == "Об. закалка")) { ctx.KHL2 = 2.6; }

            ctx.sigmaH1Allow = (ctx.sigmaH1Limb * ctx.KHL1) / ctx.SH;
            ctx.sigmaH2Allow = (ctx.sigmaH2Limb * ctx.KHL2) / ctx.SH;

            if (ctx.sigmaH1Allow < ctx.sigmaH2Allow) { ctx.sigmaHAllow = ctx.sigmaH1Allow; }
            else { ctx.sigmaHAllow = ctx.sigmaH2Allow; }

            ctx.NFE1 = 60.0 * ctx.c1 * ctx.n1 * ctx.th * ctx.KFE;
            ctx.NFE2 = 60.0 * ctx.c2 * ctx.n2 * ctx.th * ctx.KFE;

            if (ctx.NFE1 >= 4000000.0) { ctx.KFL1 = 1.0; }
            else
            {
                if (ctx.HB1 <= 350.0)
                { ctx.KFL1 = Math.Pow(4000000.0 / ctx.NFE1, (1.0 / 6.0)); }
                else
                { ctx.KFL1 = Math.Pow(4000000.0 / ctx.NFE1, (1.0 / 9.0)); }
            }
            if (ctx.HB1 <= 350.0)
            {
                if (ctx.KFL1 > 4.0)
                {
                    ctx.KFL1 = 4.0;
                }
            }
            else
            {
                if (ctx.KFL1 > 2.5)
                {
                    ctx.KFL1 = 2.5;
                }
            }

            if (ctx.NFE2 >= 4000000.0) { ctx.KFL2 = 1.0; }
            else
            {
                if (ctx.HB2 <= 350.0)
                { ctx.KFL2 = Math.Pow(4000000.0 / ctx.NFE2, (1.0 / 6.0)); }
                else
                { ctx.KFL2 = Math.Pow(4000000.0 / ctx.NFE2, (1.0 / 9.0)); }
            }
            if (ctx.HB2 <= 350.0)
            {
                if (ctx.KFL2 > 4.0)
                {
                    ctx.KFL2 = 4.0;
                }
            }
            else
            {
                if (ctx.KFL2 > 2.5)
                {
                    ctx.KFL2 = 2.5;
                }
            }

            ctx.sigmaF1Allow = (ctx.sigmaF1Limb * ctx.KFL1) * ctx.KFC1 / ctx.SF;
            ctx.sigmaF2Allow = (ctx.sigmaF2Limb * ctx.KFL2) * ctx.KFC2 / ctx.SF;

            return PageID.Page4;
        }

        private void constModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appForm.context.constMode = constModeRadioButton.Checked;

            if (constModeRadioButton.Checked)
            {
                KHELabel.Visible = false;
                KFELabel.Visible = false;
                KHETextBox.Visible = false;
                KHETextBox.Enabled = false;
                KFETextBox.Visible = false;
                KFETextBox.Enabled = false;

                appForm.context.KHE = 1;
                appForm.context.KFE = 1;
            }
        }

        private void diffModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            appForm.context.diffMode = diffModeRadioButton.Checked;

            if (diffModeRadioButton.Checked)
            {
                KHELabel.Visible = true;
                KFELabel.Visible = true;
                KHETextBox.Visible = true;
                KHETextBox.Enabled = true;
                KFETextBox.Visible = true;
                KFETextBox.Enabled = true;
            }
        }
    }
}
