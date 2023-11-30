using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page2 : AnyPage
    {
        public MyTableLayoutPanel page2TableLayout;
        public MyLabel page2InputDataLabel;

        public MyRadioButton identityRadioButton;
        public MyRadioButton notIdentityRadioButton;

        public MyLabel page2GearLabel;
        public MyLabel page2WheelLabel;

        public MyLabel materialLabel;
        public MyComboBox gearMaterialComboBox;
        public MyComboBox wheelMaterialComboBox;
        public string[] materialOptions = new string[] { "40", "45", "40Х", "40ХН", "35ХМ", "12ХН3А", "12Х2Н4А", "18ХГТ", "25ХГТ", "20Х", "20ХН", "18ХН3А", "38Х2Ю", "38Х2МЮА" };

        public MyLabel TOLabel;
        public MyComboBox TO1ComboBox;
        public MyComboBox TO2ComboBox;
        public Dictionary<string, string[]> TOOptions = new Dictionary<string, string[]>() {
            [""] = new string[] { "" },
            ["40"] = new string[] { "Улучшение" },
            ["45"] = new string[] { "Улучшение", "Нормализация" },
            ["40Х"] = new string[] { "Улучшение", "Об. закалка", "Пов. закалка", "Азотирование" },
            ["40ХН"] = new string[] { "Улучшение", "Об. закалка", "Пов. закалка" },
            ["35ХМ"] = new string[] { "Улучшение", "Об. закалка", "Пов. закалка" },
            ["38Х2Ю"] = new string[] { "Азотирование" },
            ["38Х2МЮА"] = new string[] { "Азотирование" },
            ["12ХН3А"] = new string[] { "Цементация" },
            ["12Х2Н4А"] = new string[] { "Цементация" },
            ["18ХГТ"] = new string[] { "Цементация" },
            ["25ХГТ"] = new string[] { "Цементация" },
            ["20Х"] = new string[] { "Цементация" },
            ["20ХН"] = new string[] { "Цементация" },
            ["20ХН3А"] = new string[] { "Цементация" },
        };

        public MyLabel strengthLabel;

        public MyLabel HBLabel;
        public InputTextBox<double> HB1TextBox;
        public InputTextBox<double> HB2TextBox;

        public MyLabel HRCLabel;
        public InputTextBox<double> HRC1TextBox;
        public InputTextBox<double> HRC2TextBox;

        public MyLabel HVLabel;
        public InputTextBox<double> HV1TextBox;
        public InputTextBox<double> HV2TextBox;

        public MyLabel coreStrengthLabel;
        public InputTextBox<double> HRCs1TextBox;
        public InputTextBox<double> HRCs2TextBox;

        public Page2(AppForm appForm, PageID ID) : base(appForm, ID)
        {
            mainTableLayout = new MyTableLayoutPanel("page2MainTableLayout", 2, 1, DockStyle.Fill);

            page2InputDataLabel = new MyLabel("page2InputDataLabel", "Исходные данные");
            page2InputDataLabel.Anchor = AnchorStyles.Top;
            page2InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            mainTableLayout.Add(page2InputDataLabel, 0, 0);

            page2TableLayout = new MyTableLayoutPanel("page2TableLayout", 9, 3, DockStyle.Fill);
            page2TableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page2TableLayout, 1, 0);

            // Radio Group

            identityRadioButton = new MyRadioButton("identityRadioButton", "Материалы идентичны");
            identityRadioButton.CheckedChanged += new EventHandler(identityRadioButton_CheckedChanged);
            page2TableLayout.Add(identityRadioButton, 0, 0);

            notIdentityRadioButton = new MyRadioButton("notIdentityRadioButton", "Материалы различны");
            notIdentityRadioButton.CheckedChanged += new EventHandler(notIdentityRadioButton_CheckedChanged);
            page2TableLayout.Add(notIdentityRadioButton, 1, 0);

            // Gear, Wheel

            page2GearLabel = new MyLabel("page2GearLabel", "Шестерня");
            page2GearLabel.Anchor = AnchorStyles.None;
            page2TableLayout.Add(page2GearLabel, 1, 1);

            page2WheelLabel = new MyLabel("page2WheelLabel", "Колесо");
            page2WheelLabel.Anchor = AnchorStyles.None;
            page2TableLayout.Add(page2WheelLabel, 1, 2);

            // Material

            materialLabel = new MyLabel("materialLabel", "Материал:");
            page2TableLayout.Add(materialLabel, 2, 0);

            gearMaterialComboBox = new MyComboBox("gearMaterialComboBox");
            gearMaterialComboBox.Items.AddRange(materialOptions);
            gearMaterialComboBox.SelectedValueChanged += new EventHandler(gearMaterialComboBox_SelectedValueChanged);
            page2TableLayout.Add(gearMaterialComboBox, 2, 1);

            wheelMaterialComboBox = new MyComboBox("wheelMaterialComboBox");
            wheelMaterialComboBox.Items.AddRange(materialOptions);
            wheelMaterialComboBox.SelectedValueChanged += new EventHandler(wheelMaterialComboBox_SelectedValueChanged);
            page2TableLayout.Add(wheelMaterialComboBox, 2, 2);

            // TO

            TOLabel = new MyLabel("TOLabel", "Термическая обработка:");
            page2TableLayout.Add(TOLabel, 3, 0);

            TO1ComboBox = new MyComboBox("TO1ComboBox");
            page2TableLayout.Add(TO1ComboBox, 3, 1);

            TO2ComboBox = new MyComboBox("TO2ComboBox");
            page2TableLayout.Add(TO2ComboBox, 3, 2);

            // Hints

            strengthLabel = new MyLabel("strengthLabel", "Твёрдость раб. поверхности зубьев:");
            page2TableLayout.Add(strengthLabel, 4, 0);

            HBLabel = new MyLabel("HBLabel", "по шкале Бриннеля, HB:");
            page2TableLayout.Add(HBLabel, 5, 0);

            HB1TextBox = new InputTextBox<double>("HB1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HB1 = value);
            page2TableLayout.Add(HB1TextBox, 5, 1);

            HB2TextBox = new InputTextBox<double>("HB2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HB2 = value);
            page2TableLayout.Add(HB2TextBox, 5, 2);

            HRCLabel = new MyLabel("HRCLabel", "по шкале Роквелла, HRC:");
            page2TableLayout.Add(HRCLabel, 6, 0);

            HRC1TextBox = new InputTextBox<double>("HRC1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRC1 = value);
            page2TableLayout.Add(HRC1TextBox, 6, 1);

            HRC2TextBox = new InputTextBox<double>("HRC2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRC2 = value);
            page2TableLayout.Add(HRC2TextBox, 6, 2);

            HVLabel = new MyLabel("HVLabel", "по шкале Виккерса, HV:");
            page2TableLayout.Add(HVLabel, 7, 0);

            HV1TextBox = new InputTextBox<double>("HV1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HV1 = value);
            page2TableLayout.Add(HV1TextBox, 7, 1);

            HV2TextBox = new InputTextBox<double>("HV2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HV2 = value);
            page2TableLayout.Add(HV2TextBox, 7, 2);

            coreStrengthLabel = new MyLabel("coreStrengthLabel", "Твёрдость сердцевины зубьев, HRCs:");
            page2TableLayout.Add(coreStrengthLabel, 8, 0);

            HRCs1TextBox = new InputTextBox<double>("HRCs1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRCs1 = value);
            page2TableLayout.Add(HRCs1TextBox, 8, 1);

            HRCs2TextBox = new InputTextBox<double>("HRCs2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRCs2 = value);
            page2TableLayout.Add(HRCs2TextBox, 8, 2);

        }

        public override bool CanMoveOn()
        {
            return
                (identityRadioButton.Checked || notIdentityRadioButton.Checked) &&
                (gearMaterialComboBox.Text.Length > 0) &&
                (wheelMaterialComboBox.Text.Length > 0) &&
                (TO1ComboBox.Text.Length > 0) &&
                (TO2ComboBox.Text.Length > 0) &&
                (!HB1TextBox.Enabled || HB1TextBox.GetIsValid()) &&
                (!HB2TextBox.Enabled || HB2TextBox.GetIsValid()) &&
                (!HRC1TextBox.Enabled || HRC1TextBox.GetIsValid()) &&
                (!HRC2TextBox.Enabled || HRC2TextBox.GetIsValid()) &&
                (!HV1TextBox.Enabled || HV1TextBox.GetIsValid()) &&
                (!HV2TextBox.Enabled || HV2TextBox.GetIsValid()) &&
                (!HRCs1TextBox.Enabled || HRCs1TextBox.GetIsValid()) &&
                (!HRCs2TextBox.Enabled || HRCs2TextBox.GetIsValid());
        }

        public override PageID NextPage()
        {
            Context ctx = appForm.context;
            
            if (TO1ComboBox.Text == "Азотирование")
            {
                appForm.page3.sigmaH1LimbTextBox.Text = "1050";
                appForm.page3.sigmaF1LimbTextBox.Text = String.Format("{0}", 12.0 * ctx.HRCs1 + 300.0);
            }
            else if (TO1ComboBox.Text == "Цементация")
            {
                appForm.page3.sigmaH1LimbTextBox.Text = String.Format("{0}", 23.0 * ctx.HRC1);
                appForm.page3.sigmaF1LimbTextBox.Text = "800";
            }
            else if (TO1ComboBox.Text == "Пов. закалка")
            {
                appForm.page3.sigmaH1LimbTextBox.Text = String.Format("{0}", 17.0 * ctx.HRC1 + 200.0);
                appForm.page3.sigmaF1LimbTextBox.Text = "650";
            }
            else if (TO1ComboBox.Text == "Об. закалка")
            {
                appForm.page3.sigmaH1LimbTextBox.Text = String.Format("{0}", 18.0 * ctx.HRC1 + 150.0);
                appForm.page3.sigmaF1LimbTextBox.Text = "550";
            }
            else if (TO1ComboBox.Text == "Нормализация" || TO1ComboBox.Text == "Улучшение")
            {
                appForm.page3.sigmaH1LimbTextBox.Text = String.Format("{0}", 2.0 * ctx.HB1 + 70.0);
                appForm.page3.sigmaF1LimbTextBox.Text = String.Format("{0}", 1.8 * ctx.HB1);
            }

            if (TO2ComboBox.Text == "Азотирование")
            {
                appForm.page3.sigmaH2LimbTextBox.Text = "1050";
                appForm.page3.sigmaF2LimbTextBox.Text = String.Format("{0}", 12.0 * ctx.HRCs1 + 300.0);
            }
            else if (TO2ComboBox.Text == "Цементация")
            {
                appForm.page3.sigmaH2LimbTextBox.Text = String.Format("{0}", 23.0 * ctx.HRC2);
                appForm.page3.sigmaF2LimbTextBox.Text = "800";
            }
            else if (TO2ComboBox.Text == "Пов. закалка")
            {
                appForm.page3.sigmaH2LimbTextBox.Text = String.Format("{0}", 17.0 * ctx.HRC2 + 200.0);
                appForm.page3.sigmaF2LimbTextBox.Text = "650";
            }
            else if (TO2ComboBox.Text == "Об. закалка")
            {
                appForm.page3.sigmaH2LimbTextBox.Text = String.Format("{0}", 18.0 * ctx.HRC2 + 150.0);
                appForm.page3.sigmaF2LimbTextBox.Text = "550";
            }
            else if (TO2ComboBox.Text == "Нормализация" || TO2ComboBox.Text == "Улучшение")
            {
                appForm.page3.sigmaH2LimbTextBox.Text = String.Format("{0}", 2.0 * ctx.HB2 + 70.0);
                appForm.page3.sigmaF2LimbTextBox.Text = String.Format("{0}", 1.8 * ctx.HB2);
            }


            if (ctx.HB1 <= 200.0) { ctx.NH01 = 10000000.0; }
            else if (ctx.HRC1 >= 56.0) { ctx.NH01 = 120000000.0; }
            else { ctx.NH01 = 30.0 * Math.Pow(ctx.HB1, 2.4); }

            if (ctx.HB2 <= 200.0) { ctx.NH02 = 10000000.0; }
            else if (ctx.HRC2 >= 56.0) { ctx.NH02 = 120000000.0; }
            else { ctx.NH02 = 30.0 * Math.Pow(ctx.HB2, 2.4); }

            return PageID.Page3;
        }

        private void gearMaterialComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            TO1ComboBox.Items.Clear();
            TO1ComboBox.Items.AddRange(TOOptions[gearMaterialComboBox.Text]);
        }

        private void wheelMaterialComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            TO2ComboBox.Items.Clear();
            TO2ComboBox.Items.AddRange(TOOptions[wheelMaterialComboBox.Text]);
        }

        public void gearCopyToWheel(object sender, EventArgs e)
        {
            wheelMaterialComboBox.SelectedItem = gearMaterialComboBox.SelectedItem;
        }

        public void TO1CopyToTO2(object sender, EventArgs e)
        {
            TO2ComboBox.SelectedItem = TO1ComboBox.SelectedItem;
        }

        private void identityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appForm.context.identity = identityRadioButton.Checked;

            if (identityRadioButton.Checked)
            {
                gearMaterialComboBox.SelectedValueChanged += new EventHandler(gearCopyToWheel);
                wheelMaterialComboBox.Enabled = false;
                wheelMaterialComboBox.SelectedItem = gearMaterialComboBox.SelectedItem;

                TO1ComboBox.SelectedValueChanged += new EventHandler(TO1CopyToTO2);
                TO2ComboBox.Enabled = false;
                TO2ComboBox.SelectedItem = TO1ComboBox.SelectedItem;

                HB1TextBox.PushTextValidatedHandler((value) => HB2TextBox.SetValue(HB1TextBox.GetValue()));
                HB2TextBox.Enabled = false;
                HB2TextBox.SetValue(HB1TextBox.GetValue());

                HRC1TextBox.PushTextValidatedHandler((value) => HRC2TextBox.SetValue(HRC1TextBox.GetValue()));
                HRC2TextBox.Enabled = false;
                HRC2TextBox.SetValue(HRC1TextBox.GetValue());

                HV1TextBox.PushTextValidatedHandler((value) => HV2TextBox.SetValue(HV1TextBox.GetValue()));
                HV2TextBox.Enabled = false;
                HV2TextBox.SetValue(HV1TextBox.GetValue());

                HRCs1TextBox.PushTextValidatedHandler((value) => HRCs2TextBox.SetValue(HRCs1TextBox.GetValue()));
                HRCs2TextBox.Enabled = false;
                HRCs2TextBox.SetValue(HRCs1TextBox.GetValue());

                appForm.page3.sigmaH1LimbTextBox.PushTextValidatedHandler((value) => appForm.page3.sigmaH2LimbTextBox.SetValue(appForm.page3.sigmaH1LimbTextBox.GetValue()));
                appForm.page3.sigmaH2LimbTextBox.Enabled = false;
                appForm.page3.sigmaH2LimbTextBox.SetValue(appForm.page3.sigmaH1LimbTextBox.GetValue());

                appForm.page3.sigmaF1LimbTextBox.PushTextValidatedHandler((value) => appForm.page3.sigmaF2LimbTextBox.SetValue(appForm.page3.sigmaF1LimbTextBox.GetValue()));
                appForm.page3.sigmaF2LimbTextBox.Enabled = false;
                appForm.page3.sigmaF2LimbTextBox.SetValue(appForm.page3.sigmaF1LimbTextBox.GetValue());

                appForm.page3.c1TextBox.PushTextValidatedHandler((value) => appForm.page3.c2TextBox.SetValue(appForm.page3.c1TextBox.GetValue()));
                appForm.page3.c2TextBox.Enabled = false;
                appForm.page3.c2TextBox.SetValue(appForm.page3.c1TextBox.GetValue());

                appForm.page3.KFC1TextBox.PushTextValidatedHandler((value) => appForm.page3.KFC2TextBox.SetValue(appForm.page3.KFC1TextBox.GetValue()));
                appForm.page3.KFC2TextBox.Enabled = false;
                appForm.page3.KFC2TextBox.SetValue(appForm.page3.KFC1TextBox.GetValue());
            }
        }

        private void notIdentityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appForm.context.notIdentity = notIdentityRadioButton.Checked;

            if (notIdentityRadioButton.Checked)
            {
                gearMaterialComboBox.SelectedValueChanged -= new EventHandler(gearCopyToWheel);
                wheelMaterialComboBox.Enabled = true;

                TO1ComboBox.SelectedValueChanged -= new EventHandler(TO1CopyToTO2);
                TO2ComboBox.Enabled = true;

                HB1TextBox.PopTextValidatedHandler();
                HB2TextBox.Enabled = true;

                HRC1TextBox.PopTextValidatedHandler();
                HRC2TextBox.Enabled = true;

                HV1TextBox.PopTextValidatedHandler();
                HV2TextBox.Enabled = true;

                HRCs1TextBox.PopTextValidatedHandler();
                HRCs2TextBox.Enabled = true;

                appForm.page3.sigmaH1LimbTextBox.PopTextValidatedHandler();
                appForm.page3.sigmaH2LimbTextBox.Enabled = true;

                appForm.page3.sigmaF1LimbTextBox.PopTextValidatedHandler();
                appForm.page3.sigmaF2LimbTextBox.Enabled = true;

                appForm.page3.c1TextBox.PopTextValidatedHandler();
                appForm.page3.c2TextBox.Enabled = true;

                appForm.page3.KFC1TextBox.PopTextValidatedHandler();
                appForm.page3.KFC2TextBox.Enabled = true;
            }
        }
    }
}
