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

        public Page2(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page2MainTableLayout", 2, 1, DockStyle.Fill);

            page2InputDataLabel = new MyLabel("page2InputDataLabel", "Исходные данные");
            page2InputDataLabel.Anchor = AnchorStyles.Top;
            page2InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            mainTableLayout.Add(page2InputDataLabel, 0, 0);

            page2TableLayout = new MyTableLayoutPanel("page2TableLayout", 9, 3, DockStyle.Fill);
            mainTableLayout.Add(page2TableLayout, 1, 0);

            // Radio Group

            identityRadioButton = new MyRadioButton("identityRadioButton", "Материалы идентичны");
            page2TableLayout.Add(identityRadioButton, 0, 0);

            notIdentityRadioButton = new MyRadioButton("notIdentityRadioButton", "Материалы различны");
            page2TableLayout.Add(notIdentityRadioButton, 1, 0);

            // Gear, Wheel

            page2GearLabel = new MyLabel("page2GearLabel", "Шестерня");
            page2GearLabel.Anchor = AnchorStyles.None;
            page2TableLayout.Add(page2GearLabel, 1, 1);

            page2WheelLabel = new MyLabel("page2WheelLabel", "Колесо");
            page2WheelLabel.Anchor = AnchorStyles.None;
            page2TableLayout.Add(page2WheelLabel, 1, 2);

            // Material

            materialLabel = new MyLabel("materialLabel", "Материал");
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

            TOLabel = new MyLabel("TOLabel", "Термическая обработка");
            page2TableLayout.Add(TOLabel, 3, 0);

            TO1ComboBox = new MyComboBox("TO1ComboBox");
            page2TableLayout.Add(TO1ComboBox, 3, 1);

            TO2ComboBox = new MyComboBox("TO2ComboBox");
            page2TableLayout.Add(TO2ComboBox, 3, 2);

            // Hints

            strengthLabel = new MyLabel("strengthLabel", "Твёрдость раб. поверхности зубьев");
            page2TableLayout.Add(strengthLabel, 4, 0);

            HBLabel = new MyLabel("HBLabel", "по шкале Бриннеля, HB");
            page2TableLayout.Add(HBLabel, 5, 0);

            HB1TextBox = new InputTextBox<double>("HB1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HB1 = value);
            page2TableLayout.Add(HB1TextBox, 5, 1);

            HB2TextBox = new InputTextBox<double>("HB2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HB2 = value);
            page2TableLayout.Add(HB2TextBox, 5, 2);

            HRCLabel = new MyLabel("HRCLabel", "по шкале Роквелла, HRC");
            page2TableLayout.Add(HRCLabel, 6, 0);

            HRC1TextBox = new InputTextBox<double>("HRC1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRC1 = value);
            page2TableLayout.Add(HRC1TextBox, 6, 1);

            HRC2TextBox = new InputTextBox<double>("HRC2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRC2 = value);
            page2TableLayout.Add(HRC2TextBox, 6, 2);

            HVLabel = new MyLabel("HVLabel", "по шкале Виккерса, HV");
            page2TableLayout.Add(HVLabel, 7, 0);

            HV1TextBox = new InputTextBox<double>("HV1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HV1 = value);
            page2TableLayout.Add(HV1TextBox, 7, 1);

            HV2TextBox = new InputTextBox<double>("HV2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HV2 = value);
            page2TableLayout.Add(HV2TextBox, 7, 2);

            coreStrengthLabel = new MyLabel("coreStrengthLabel", "Твёрдость сердцевины зубьев, HRCs");
            page2TableLayout.Add(coreStrengthLabel, 8, 0);

            HRCs1TextBox = new InputTextBox<double>("HRCs1TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRCs1 = value);
            page2TableLayout.Add(HRCs1TextBox, 8, 1);

            HRCs2TextBox = new InputTextBox<double>("HRCs2TextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.HRCs2 = value);
            page2TableLayout.Add(HRCs2TextBox, 8, 2);

            // after init

            
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
    }
}
