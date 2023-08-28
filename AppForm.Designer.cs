using System.Windows.Forms;
using System.Reflection;

namespace Schizophrenia
{
    partial class AppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.ResumeLayout(false);

        }

        #endregion

        // gui
        private MyTableLayoutPanel mainTableLayout;

        private MyTableLayoutPanel[] pagesMainTableLayout = new MyTableLayoutPanel[15];
        private int currentPage;

        // Page 1
        private MyTableLayoutPanel page1TableLayout;
        private MyLabel page1InputDataLabel;
        private MyLabel gearTypeLabel;

        private MyTableLayoutPanel page1RadioGroup1;
        private MyRadioButton cylindricalTypeButton;
        private MyRadioButton conicalTypeButton;
        private MyRadioButton planetaryTypeButton;

        private MyTableLayoutPanel page1RadioGroup2;
        private MyRadioButton internalTypeButton;
        private MyRadioButton externalTypeButton;

        private MyTableLayoutPanel page1RadioGroup3;
        private MyRadioButton singleEntryTypeButton;
        private MyRadioButton doubleEntryTypeButton;

        private MyLabel uLabel;
        private InputTextBox<double> uTextBox;
        private double u;

        private MyLabel n1Label;
        private InputTextBox<double> n1TextBox;
        private double n1;

        private MyLabel T1Label;
        private InputTextBox<double> T1TextBox;
        private double T1;

        private MyLabel thLabel;
        private InputTextBox<double> thTextBox;
        private double th;

        private MyLabel CTLabel;
        private InputTextBox<int> CTTextBox;
        private int CT;

        private MyLabel alphaLabel;
        private InputTextBox<double> alphaTextBox;
        private double alpha;

        private MyLabel standartContourLabel;
        private MyRadioButton standartContourYesButton;
        private MyRadioButton standartContourNoButton;

        private MyLabel standartAlphaLabel;
        private InputTextBox<double> standartAlphaTextBox;
        private double standartAlpha;

        private MyLabel haStarLabel;
        private InputTextBox<double> haStarTextBox;
        private double haStar;

        private MyLabel cStarLabel;
        private InputTextBox<double> cStarTextBox;
        private double cStar;

        // Page 2

        private MyTableLayoutPanel page2TableLayout;
        private MyLabel page2InputDataLabel;

        private MyRadioButton identityRadioButton;
        private MyRadioButton notIdentityRadioButton;

        private MyLabel page2GearLabel;
        private MyLabel page2WheelLabel;

        private MyLabel materialLabel;
        private MyComboBox gearMaterialComboBox;
        private MyComboBox wheelMaterialComboBox;

        private MyLabel TOLabel;
        private MyComboBox TO1ComboBox;
        private MyComboBox TO2ComboBox;

        // Hints

        private MyLabel strengthLabel;

        private MyLabel HBLabel;
        private InputTextBox<double> HB1TextBox;
        private double HB1;
        private InputTextBox<double> HB2TextBox;
        private double HB2;

        private MyLabel HRCLabel;
        private InputTextBox<double> HRC1TextBox;
        private double HRC1;
        private InputTextBox<double> HRC2TextBox;
        private double HRC2;

        private MyLabel HVLabel;
        private InputTextBox<double> HV1TextBox;
        private double HV1;
        private InputTextBox<double> HV2TextBox;
        private double HV2;

        private MyLabel coreStrengthLabel;
        private InputTextBox<double> HRCs1TextBox;
        private double HRCs1;
        private InputTextBox<double> HRCs2TextBox;
        private double HRCs2;

        // Page 3

        private MyTableLayoutPanel page3TableLayout;
        private MyLabel page3InputDataLabel;

        private MyLabel page3GearLabel;
        private MyLabel page3WheelLabel;

        private MyLabel sigmaHLimbLabel;
        private InputTextBox<double> sigmaH1LimbTextBox;
        private double sigmaH1Limb;
        private InputTextBox<double> sigmaH2LimbTextBox;
        private double sigmaH2Limb;

        private MyLabel sigmaFLimbLabel;
        private InputTextBox<double> sigmaF1LimbTextBox;
        private double sigmaF1Limb;
        private InputTextBox<double> sigmaF2LimbTextBox;
        private double sigmaF2Limb;

        private MyLabel cLabel;
        private InputTextBox<double> c1TextBox;
        private double c1;
        private InputTextBox<double> c2TextBox;
        private double c2;

        private MyLabel KFCLabel;
        private InputTextBox<double> KFC1TextBox;
        private double KFC1;
        private InputTextBox<double> KFC2TextBox;
        private double KFC2;

        private MyLabel SHLabel;
        private InputTextBox<double> SHTextBox;
        private double SH;

        private MyLabel SFLabel;
        private InputTextBox<double> SFTextBox;
        private double SF;

        private MyLabel workModeLabel;
        private MyRadioButton constModeRadioButton;
        private MyRadioButton diffModeRadioButton;

        private MyLabel KHELabel;
        private InputTextBox<double> KHETextBox;
        private double KHE;

        private MyLabel KFELabel;
        private InputTextBox<double> KFETextBox;
        private double KFE;

        // Page 4

        private MyTableLayoutPanel page4TableLayout;
        private MyLabel page4InputDataLabel;

        private MyLabel aWLabel;
        private MyTableLayoutPanel aWRadioGroup;
        private MyRadioButton aWKnownRadioButton;
        private MyRadioButton aWUnknownRadioButton;
        private InputTextBox<double> aWKnownTextBox;
        private double aW;

        private MyLabel standartAWLabel;
        private MyTableLayoutPanel standartAWRadioGroup;
        private MyRadioButton standartAWYesRadioButton;
        private MyRadioButton standartAWNoRadioButton;

        private MyLabel psibaLabel;
        private InputTextBox<double> psibaTextBox;
        private double psiba;

        private MyLabel psibaCommentLabel;

        private MyLabel symmCommentLabel;
        private MyLabel symmLabel;

        private MyLabel asymmCommentLabel;
        private MyLabel asymmLabel;

        private MyLabel consoleCommentLabel;
        private MyLabel consoleLabel;

        private MyLabel internalCommentLabel;
        private MyLabel internalLabel;

        private MyLabel chevronCommentLabel;
        private MyLabel chevronLabel;

        private MyLabel transmissionCommentLabel;
        private MyLabel transmissionLabel;

        // Page 5



        // Buttons panel

        private MyTableLayoutPanel buttonsTableLayout;
        private MyButton printButton;
        private MyButton backButton;
        private MyButton nextButton;

        private ToolTip toolTip;

        private void InitializeChildren()
        {
            SuspendLayout();

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // BEGIN

            mainTableLayout = new MyTableLayoutPanel("mainTableLayout", 16, 1, DockStyle.None);

            toolTip = new ToolTip();
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 10000;
            toolTip.ReshowDelay = 0;
            toolTip.UseFading = false;


            // Buttons on the bottom (and every page, actually)

            buttonsTableLayout = new MyTableLayoutPanel("buttonsTableLayout", 1, 4, DockStyle.Fill);
            buttonsTableLayout.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100);

            printButton = new MyButton("printButton", "Печать");
            printButton.Click += new System.EventHandler(printButton_Click);
            buttonsTableLayout.Add(printButton, 0, 0);

            backButton = new MyButton("backButton", "Назад");
            backButton.Click += new System.EventHandler(backButton_Click);
            buttonsTableLayout.Add(backButton, 0, 2);

            nextButton = new MyButton("nextButton", "Далее");
            nextButton.Click += new System.EventHandler(nextButton_Click);
            buttonsTableLayout.Add(nextButton, 0, 3);

            mainTableLayout.Add(buttonsTableLayout, 15, 0);

            // Page 1

            pagesMainTableLayout[0] = new MyTableLayoutPanel("page1MainTableLayout", 2, 1, DockStyle.Fill);

            page1InputDataLabel = new MyLabel("page1InputDataLabel", "Исходные данные");
            page1InputDataLabel.Anchor = AnchorStyles.Top;
            page1InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            pagesMainTableLayout[0].Add(page1InputDataLabel, 0, 0);

            page1TableLayout = new MyTableLayoutPanel("page1TableLayout", 11, 4, DockStyle.Fill);
            //page1TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[0].Add(page1TableLayout, 1, 0);

            // gear type

            gearTypeLabel = new MyLabel("typeLabel", "Тип передачи:");
            gearTypeLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size, System.Drawing.FontStyle.Underline, DefaultFonts.Any.Unit);
            page1TableLayout.Add(gearTypeLabel, 0, 0);

            // Radio buttons

            // Group 1

            page1RadioGroup1 = new MyTableLayoutPanel("page1RadioGroup1", 3, 1, DockStyle.None);
            page1TableLayout.Add(page1RadioGroup1, 1, 0);

            cylindricalTypeButton = new MyRadioButton("cylindricalTypeButton", "Цилиндрическая");
            cylindricalTypeButton.CheckedChanged += new System.EventHandler(cylindricalTypeButton_CheckedChanged);
            page1RadioGroup1.Add(cylindricalTypeButton, 0, 0);

            conicalTypeButton = new MyRadioButton("conicalTypeButton", "Коническая");
            conicalTypeButton.CheckedChanged += new System.EventHandler(conicalTypeButton_CheckedChanged);
            page1RadioGroup1.Add(conicalTypeButton, 1, 0);

            planetaryTypeButton = new MyRadioButton("planetaryTypeButton", "Планетарная");
            planetaryTypeButton.CheckedChanged += new System.EventHandler(planetTypeButton_CheckedChanged);
            page1RadioGroup1.Add(planetaryTypeButton, 2, 0);

            // Group 2

            page1RadioGroup2 = new MyTableLayoutPanel("page1RadioGroup2", 2, 1, DockStyle.Fill);
            page1TableLayout.Add(page1RadioGroup2, 1, 1);

            internalTypeButton = new MyRadioButton("internalTypeButton", "Внутреннее зацепление");
            internalTypeButton.CheckedChanged += new System.EventHandler(internalTypeButton_CheckedChanged);
            page1RadioGroup2.Add(internalTypeButton, 0, 0);

            externalTypeButton = new MyRadioButton("externalTypeButton", "Внешнее зацепление");
            externalTypeButton.CheckedChanged += new System.EventHandler(externalTypeButton_CheckedChanged);
            page1RadioGroup2.Add(externalTypeButton, 1, 0);

            // Group 3

            page1RadioGroup3 = new MyTableLayoutPanel("page1RadioGroup3", 2, 1, DockStyle.Fill);
            page1TableLayout.Add(page1RadioGroup3, 1, 2);

            singleEntryTypeButton = new MyRadioButton("singleEntryTypeButton", "Одновенцовый сателит");
            singleEntryTypeButton.CheckedChanged += new System.EventHandler(singleEntryTypeButton_CheckedChanged);
            page1RadioGroup3.Add(singleEntryTypeButton, 0, 0);

            doubleEntryTypeButton = new MyRadioButton("doubleEntryTypeButton", "Двухвенцовый сателит");
            doubleEntryTypeButton.CheckedChanged += new System.EventHandler(doubleEntryTypeButton_CheckedChanged);
            page1RadioGroup3.Add(doubleEntryTypeButton, 1, 0);

            // U input

            uLabel = new MyLabel("uLabel", "Предаточное отношение");
            page1TableLayout.Add(uLabel, 2, 0);

            uTextBox = new InputTextBox<double>("uTextBox", Validators.PositiveDoubleValidator, (value) => u = value, "Действительное, больше 0");
            page1TableLayout.Add(uTextBox, 2, 3);

            // n1 input

            n1Label = new MyLabel("n1Label", "Частота вращения шестерни, об/мин");
            page1TableLayout.Add(n1Label, 3, 0);

            n1TextBox = new InputTextBox<double>("n1TextBox", Validators.PositiveDoubleValidator, (value) => n1 = value, "Действительное, больше 0");
            page1TableLayout.Add(n1TextBox, 3, 3);

            // T1 input

            T1Label = new MyLabel("T1Label", "Крутящий момент на валу шестерни, Н*мм");
            page1TableLayout.Add(T1Label, 4, 0);

            T1TextBox = new InputTextBox<double>("T1TextBox", Validators.PositiveDoubleValidator, (value) => T1 = value, "Действительное, больше 0");
            page1TableLayout.Add(T1TextBox, 4, 3);

            // th input

            thLabel = new MyLabel("thLabel", "Срок службы, ч");
            page1TableLayout.Add(thLabel, 5, 0);

            thTextBox = new InputTextBox<double>("thTextBox", Validators.PositiveDoubleValidator, (value) => th = value, "Действительное, больше 0");
            page1TableLayout.Add(thTextBox, 5, 3);

            // CT input

            CTLabel = new MyLabel("CTLabel", "Степень точности");
            page1TableLayout.Add(CTLabel, 6, 0);

            CTTextBox = new InputTextBox<int>("CTTextBox", Validators.CTValidator, (value) => CT = value, "Натуральное число, от 5 до 9");
            page1TableLayout.Add(CTTextBox, 6, 3);

            // alpha input

            alphaLabel = new MyLabel("alphaLabel", "Угол между осями, град");
            page1TableLayout.Add(alphaLabel, 7, 0);

            alphaTextBox = new InputTextBox<double>("alphaTextBox", Validators.DefaultDoubleValidator, (value) => alpha = value);
            page1TableLayout.Add(alphaTextBox, 7, 3);

            // standart contour

            standartContourLabel = new MyLabel("standartContourLabel", "Стандартный исходный контур");
            page1TableLayout.Add(standartContourLabel, 8, 0);

            // Radio Group 4

            standartContourYesButton = new MyRadioButton("standartContourYesButton", "Да");
            standartContourYesButton.CheckedChanged += new System.EventHandler(standartContourYesButton_CheckedChanged);
            page1TableLayout.Add(standartContourYesButton, 8, 1);

            standartContourNoButton = new MyRadioButton("standartContourNoButton", "Нет");
            standartContourNoButton.CheckedChanged += new System.EventHandler(standartContourNoButton_CheckedChanged);
            page1TableLayout.Add(standartContourNoButton, 9, 1);

            // standart alpha input

            standartAlphaLabel = new MyLabel("standartAlphaLabel", "alpha");
            page1TableLayout.Add(standartAlphaLabel, 8, 2);

            standartAlphaTextBox = new InputTextBox<double>("standartAlphaTextBox", Validators.DefaultDoubleValidator, (value) => standartAlpha = value * System.Math.PI / 180.0);
            page1TableLayout.Add(standartAlphaTextBox, 8, 3);

            // haStar

            haStarLabel = new MyLabel("haStarLabel", "ha*");
            page1TableLayout.Add(haStarLabel, 9, 2);

            haStarTextBox = new InputTextBox<double>("haStarTextBox", Validators.DefaultDoubleValidator, (value) => haStar = value);
            page1TableLayout.Add(haStarTextBox, 9, 3);

            // cStar

            cStarLabel = new MyLabel("cStarLabel", "c*");
            page1TableLayout.Add(cStarLabel, 10, 2);

            cStarTextBox = new InputTextBox<double>("cStarTextBox", Validators.DefaultDoubleValidator, (value) => cStar = value);
            page1TableLayout.Add(cStarTextBox, 10, 3);

            // Page 2

            pagesMainTableLayout[1] = new MyTableLayoutPanel("page2MainTableLayout", 2, 1, DockStyle.Fill);

            page2InputDataLabel = new MyLabel("page2InputDataLabel", "Исходные данные");
            page2InputDataLabel.Anchor = AnchorStyles.Top;
            page2InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            pagesMainTableLayout[1].Add(page2InputDataLabel, 0, 0);

            page2TableLayout = new MyTableLayoutPanel("page2TableLayout", 9, 3, DockStyle.Fill);
            pagesMainTableLayout[1].Add(page2TableLayout, 1, 0);

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
            page2TableLayout.Add(gearMaterialComboBox, 2, 1);

            wheelMaterialComboBox = new MyComboBox("wheelMaterialComboBox");
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

            HB1TextBox = new InputTextBox<double>("HB1TextBox", Validators.DefaultDoubleValidator, (value) => HB1 = value);
            page2TableLayout.Add(HB1TextBox, 5, 1);

            HB2TextBox = new InputTextBox<double>("HB2TextBox", Validators.DefaultDoubleValidator, (value) => HB2 = value);
            page2TableLayout.Add(HB2TextBox, 5, 2);

            HRCLabel = new MyLabel("HRCLabel", "по шкале Роквелла, HRC");
            page2TableLayout.Add(HRCLabel, 6, 0);

            HRC1TextBox = new InputTextBox<double>("HRC1TextBox", Validators.DefaultDoubleValidator, (value) => HRC1 = value);
            page2TableLayout.Add(HRC1TextBox, 6, 1);

            HRC2TextBox = new InputTextBox<double>("HRC2TextBox", Validators.DefaultDoubleValidator, (value) => HRC2 = value);
            page2TableLayout.Add(HRC2TextBox, 6, 2);

            HVLabel = new MyLabel("HVLabel", "по шкале Виккерса, HV");
            page2TableLayout.Add(HVLabel, 7, 0);

            HV1TextBox = new InputTextBox<double>("HV1TextBox", Validators.DefaultDoubleValidator, (value) => HV1 = value);
            page2TableLayout.Add(HV1TextBox, 7, 1);

            HV2TextBox = new InputTextBox<double>("HV2TextBox", Validators.DefaultDoubleValidator, (value) => HV2 = value);
            page2TableLayout.Add(HV2TextBox, 7, 2);

            coreStrengthLabel = new MyLabel("coreStrengthLabel", "Твёрдость сердцевины зубьев, HRCs");
            page2TableLayout.Add(coreStrengthLabel, 8, 0);

            HRCs1TextBox = new InputTextBox<double>("HRCs1TextBox", Validators.DefaultDoubleValidator, (value) => HRCs1 = value);
            page2TableLayout.Add(HRCs1TextBox, 8, 1);

            HRCs2TextBox = new InputTextBox<double>("HRCs2TextBox", Validators.DefaultDoubleValidator, (value) => HRCs2 = value);
            page2TableLayout.Add(HRCs2TextBox, 8, 2);

            // Page 3

            pagesMainTableLayout[2] = new MyTableLayoutPanel("page3MainTableLayout", 2, 1, DockStyle.Fill);

            page3InputDataLabel = new MyLabel("page3InputDataLabel", "Исходные данные");
            page3InputDataLabel.Anchor = AnchorStyles.Top;
            page3InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            pagesMainTableLayout[2].Add(page3InputDataLabel, 0, 0);

            page3TableLayout = new MyTableLayoutPanel("page3TableLayout", 11, 4, DockStyle.Fill);
            //page3TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[2].Add(page3TableLayout, 1, 0);

            // Gear, Wheel

            page3GearLabel = new MyLabel("page3GearLabel", "Шестерня");
            page3GearLabel.Anchor = AnchorStyles.None;
            page3TableLayout.Add(page3GearLabel, 0, 1);

            page3WheelLabel = new MyLabel("page3WheelLabel", "Колесо");
            page3WheelLabel.Anchor = AnchorStyles.None;
            page3TableLayout.Add(page3WheelLabel, 0, 2);

            // HLimb

            sigmaHLimbLabel = new MyLabel("sigmaHLimbLabel", "Базовый предел контактной выносливости");
            page3TableLayout.Add(sigmaHLimbLabel, 1, 0);

            sigmaH1LimbTextBox = new InputTextBox<double>("sigmaH1LimbTextBox", Validators.DefaultDoubleValidator, (value) => sigmaH1Limb = value);
            page3TableLayout.Add(sigmaH1LimbTextBox, 1, 1);

            sigmaH2LimbTextBox = new InputTextBox<double>("sigmaH2LimbTextBox", Validators.DefaultDoubleValidator, (value) => sigmaH2Limb = value);
            page3TableLayout.Add(sigmaH2LimbTextBox, 1, 2);

            // FLimb

            sigmaFLimbLabel = new MyLabel("sigmaFLimbLabel", "Базовый предел изгибной выносливости");
            page3TableLayout.Add(sigmaFLimbLabel, 2, 0);

            sigmaF1LimbTextBox = new InputTextBox<double>("sigmaF1LimbTextBox", Validators.DefaultDoubleValidator, (value) => sigmaF1Limb = value);
            page3TableLayout.Add(sigmaF1LimbTextBox, 2, 1);

            sigmaF2LimbTextBox = new InputTextBox<double>("sigmaF2LimbTextBox", Validators.DefaultDoubleValidator, (value) => sigmaF2Limb = value);
            page3TableLayout.Add(sigmaF2LimbTextBox, 2, 2);

            // c

            cLabel = new MyLabel("cLabel", "Число нагружений зуба за один оборот");
            page3TableLayout.Add(cLabel, 3, 0);

            c1TextBox = new InputTextBox<double>("c1TextBox", Validators.DefaultDoubleValidator, (value) => c1 = value);
            page3TableLayout.Add(c1TextBox, 3, 1);

            c2TextBox = new InputTextBox<double>("c2TextBox", Validators.DefaultDoubleValidator, (value) => c2 = value);
            page3TableLayout.Add(c2TextBox, 3, 2);

            // KFC

            KFCLabel = new MyLabel("KFCLabel", "Коэф-т, учитывающий двустороннее нагружение");
            page3TableLayout.Add(KFCLabel, 4, 0);

            KFC1TextBox = new InputTextBox<double>("KFC1TextBox", Validators.DefaultDoubleValidator, (value) => KFC1 = value);
            page3TableLayout.Add(KFC1TextBox, 4, 1);

            KFC2TextBox = new InputTextBox<double>("KFC2TextBox", Validators.DefaultDoubleValidator, (value) => KFC2 = value);
            page3TableLayout.Add(KFC2TextBox, 4, 2);

            // SH

            SHLabel = new MyLabel("SHLabel", "Запас проности по контактным напряжениям");
            page3TableLayout.Add(SHLabel, 5, 0);

            SHTextBox = new InputTextBox<double>("SHTextBox", Validators.DefaultDoubleValidator, (value) => SH = value);
            page3TableLayout.Add(SHTextBox, 5, 1);

            // SF

            SFLabel = new MyLabel("SFLabel", "Запас прочности по изгибным напряжениям");
            page3TableLayout.Add(SFLabel, 6, 0);

            SFTextBox = new InputTextBox<double>("SFTextBox", Validators.DefaultDoubleValidator, (value) => SF = value);
            page3TableLayout.Add(SFTextBox, 6, 1);

            // model

            workModeLabel = new MyLabel("workModeLabel", "Режим работы");
            page3TableLayout.Add(workModeLabel, 7, 0);

            constModeRadioButton = new MyRadioButton("constModeRadioButton", "Постоянный");
            page3TableLayout.Add(constModeRadioButton, 7, 1);

            diffModeRadioButton = new MyRadioButton("diffModeRadioButton", "Переменный");
            page3TableLayout.Add(diffModeRadioButton, 8, 1);

            // KHE

            KHELabel = new MyLabel("KHELabel", "Коэф-т эквивалентности по контактным напряжениям");
            page3TableLayout.Add(KHELabel, 9, 0);

            KHETextBox = new InputTextBox<double>("KHETextBox", Validators.DefaultDoubleValidator, (value) => KHE = value);
            page3TableLayout.Add(KHETextBox, 9, 1);

            // KFE

            KFELabel = new MyLabel("KFELabel", "Коэф-т эквивалентности по контактным напряжениям");
            page3TableLayout.Add(KFELabel, 10, 0);

            KFETextBox = new InputTextBox<double>("KFETextBox", Validators.DefaultDoubleValidator, (value) => KFE = value);
            page3TableLayout.Add(KFETextBox, 10, 1);

            // Page 4

            pagesMainTableLayout[3] = new MyTableLayoutPanel("page4MainTableLayout", 2, 1, DockStyle.Fill);

            page4InputDataLabel = new MyLabel("page4InputDataLabel", "Исходные данные");
            page4InputDataLabel.Anchor = AnchorStyles.Top;
            page4InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            pagesMainTableLayout[3].Add(page4InputDataLabel, 0, 0);

            page4TableLayout = new MyTableLayoutPanel("page4TableLayout", 10, 4, DockStyle.Fill);
            //page4TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[3].Add(page4TableLayout, 1, 0);

            // Aw

            aWLabel = new MyLabel("aWLabel", "Межосевое расстояние");
            page4TableLayout.Add(aWLabel, 0, 0);

            aWRadioGroup = new MyTableLayoutPanel("aWRadioGroup", 2, 1, DockStyle.Fill);
            page4TableLayout.Add(aWRadioGroup, 0, 1);

            aWKnownRadioButton = new MyRadioButton("aWKnownRadioButton", "Задано");
            aWRadioGroup.Add(aWKnownRadioButton, 0, 0);

            aWUnknownRadioButton = new MyRadioButton("aWUnknownRadioButton", "Не задано");
            aWRadioGroup.Add(aWUnknownRadioButton, 1, 0);

            aWKnownTextBox = new InputTextBox<double>("aWKnownTextBox", Validators.DefaultDoubleValidator, (value) => aW = value);
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

            psibaTextBox = new InputTextBox<double>("psibaTextBox", Validators.DefaultDoubleValidator, (value) => psiba = value);
            page4TableLayout.Add(psibaTextBox, 2, 2);

            // Hints


            // Page 5

            pagesMainTableLayout[4] = new MyTableLayoutPanel("page5MainTableLayout", 5, 1, DockStyle.Fill);

            // Page 6

            pagesMainTableLayout[5] = new MyTableLayoutPanel("page6MainTableLayout", 6, 1, DockStyle.Fill);

            // Page 7

            pagesMainTableLayout[6] = new MyTableLayoutPanel("page7MainTableLayout", 2, 1, DockStyle.Fill);

            // Page 8

            pagesMainTableLayout[7] = new MyTableLayoutPanel("page8MainTableLayout", 3, 4, DockStyle.Fill);

            // Page 9

            pagesMainTableLayout[8] = new MyTableLayoutPanel("page9MainTableLayout", 3, 4, DockStyle.Fill);

            // Page 10

            pagesMainTableLayout[9] = new MyTableLayoutPanel("page10MainTableLayout", 4, 4, DockStyle.Fill);

            // Page 11

            pagesMainTableLayout[10] = new MyTableLayoutPanel("page11MainTableLayout", 3, 3, DockStyle.Fill);

            // Page 12

            pagesMainTableLayout[11] = new MyTableLayoutPanel("page12MainTableLayout", 3, 3, DockStyle.Fill);

            // Page 13

            pagesMainTableLayout[12] = new MyTableLayoutPanel("page13MainTableLayout", 2, 1, DockStyle.Fill);

            // Page 14

            pagesMainTableLayout[13] = new MyTableLayoutPanel("page14MainTableLayout", 2, 1, DockStyle.Fill);

            // Page 15

            pagesMainTableLayout[14] = new MyTableLayoutPanel("page15MainTableLayout", 2, 1, DockStyle.Fill);

            // END

            currentPage = 0;
            mainTableLayout.Add(pagesMainTableLayout[0], 0, 0);

            for (int i = 1; i < 15; i++)
            {
                pagesMainTableLayout[i].Visible = false;
                mainTableLayout.Add(pagesMainTableLayout[i], i, 0);
            }

            Controls.Add(mainTableLayout);

            ResumeLayout(false);
        }
    }
}

