using System;
using System.Windows.Forms;

namespace Schizophrenia.Main.Pages
{
    public class Page1 : AnyPage
    {
        public MyTableLayoutPanel page1TableLayout;
        public MyLabel page1InputDataLabel;
        public MyLabel gearTypeLabel;

        public MyTableLayoutPanel page1RadioGroup1;
        public MyRadioButton cylindricalTypeButton;
        public MyRadioButton conicalTypeButton;
        public MyRadioButton planetaryTypeButton;

        public MyTableLayoutPanel page1RadioGroup2;
        public MyRadioButton internalTypeButton;
        public MyRadioButton externalTypeButton;

        public MyTableLayoutPanel page1RadioGroup3;
        public MyRadioButton singleEntryTypeButton;
        public MyRadioButton doubleEntryTypeButton;

        public MyLabel uLabel;
        public InputTextBox<double> uTextBox;

        public MyLabel n1Label;
        public InputTextBox<double> n1TextBox;

        public MyLabel T1Label;
        public InputTextBox<double> T1TextBox;

        public MyLabel thLabel;
        public InputTextBox<double> thTextBox;

        public MyLabel page1CTLabel;
        public InputTextBox<int> page1CTTextBox;

        public MyLabel alphaLabel;
        public InputTextBox<double> alphaTextBox;

        public MyLabel standartContourLabel;
        public MyRadioButton standartContourYesButton;
        public MyRadioButton standartContourNoButton;

        public MyLabel standartAlphaLabel;
        public InputTextBox<double> standartAlphaTextBox;

        public MyLabel haStarLabel;
        public InputTextBox<double> haStarTextBox;

        public MyLabel cStarLabel;
        public InputTextBox<double> cStarTextBox;

        public Page1(AppForm appForm) : base(appForm)
        {
            mainTableLayout = new MyTableLayoutPanel("page1MainTableLayout", 2, 1, DockStyle.Fill);

            page1InputDataLabel = new MyLabel("page1InputDataLabel", "Исходные данные");
            page1InputDataLabel.Anchor = AnchorStyles.Top;
            page1InputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            mainTableLayout.Add(page1InputDataLabel, 0, 0);

            page1TableLayout = new MyTableLayoutPanel("page1TableLayout", 11, 4, DockStyle.Fill);
            //page1TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            mainTableLayout.Add(page1TableLayout, 1, 0);

            // gear type

            gearTypeLabel = new MyLabel("typeLabel", "Тип передачи:");
            gearTypeLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size, System.Drawing.FontStyle.Underline, DefaultFonts.Any.Unit);
            page1TableLayout.Add(gearTypeLabel, 0, 0);

            // Radio buttons

            // Group 1

            page1RadioGroup1 = new MyTableLayoutPanel("page1RadioGroup1", 3, 1, DockStyle.Fill);
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
            page1RadioGroup2.Add(internalTypeButton, 0, 0);

            externalTypeButton = new MyRadioButton("externalTypeButton", "Внешнее зацепление");
            page1RadioGroup2.Add(externalTypeButton, 1, 0);

            // Group 3

            page1RadioGroup3 = new MyTableLayoutPanel("page1RadioGroup3", 2, 1, DockStyle.Fill);
            page1TableLayout.Add(page1RadioGroup3, 1, 2);

            singleEntryTypeButton = new MyRadioButton("singleEntryTypeButton", "Одновенцовый сателит");
            page1RadioGroup3.Add(singleEntryTypeButton, 0, 0);

            doubleEntryTypeButton = new MyRadioButton("doubleEntryTypeButton", "Двухвенцовый сателит");
            page1RadioGroup3.Add(doubleEntryTypeButton, 1, 0);

            // U input

            uLabel = new MyLabel("uLabel", "Предаточное отношение");
            page1TableLayout.Add(uLabel, 2, 0);

            uTextBox = new InputTextBox<double>("uTextBox", Validators.PositiveDoubleValidator, (value) => appForm.context.u = value, "Действительное, больше 0");
            page1TableLayout.Add(uTextBox, 2, 3);

            // n1 input

            n1Label = new MyLabel("n1Label", "Частота вращения шестерни, об/мин");
            page1TableLayout.Add(n1Label, 3, 0);

            n1TextBox = new InputTextBox<double>("n1TextBox", Validators.PositiveDoubleValidator, (value) => appForm.context.n1 = value, "Действительное, больше 0");
            page1TableLayout.Add(n1TextBox, 3, 3);

            // T1 input

            T1Label = new MyLabel("T1Label", "Крутящий момент на валу шестерни, Н*мм");
            page1TableLayout.Add(T1Label, 4, 0);

            T1TextBox = new InputTextBox<double>("T1TextBox", Validators.PositiveDoubleValidator, (value) => appForm.context.T1 = value, "Действительное, больше 0");
            page1TableLayout.Add(T1TextBox, 4, 3);

            // th input

            thLabel = new MyLabel("thLabel", "Срок службы, ч");
            page1TableLayout.Add(thLabel, 5, 0);

            thTextBox = new InputTextBox<double>("thTextBox", Validators.PositiveDoubleValidator, (value) => appForm.context.th = value, "Действительное, больше 0");
            page1TableLayout.Add(thTextBox, 5, 3);

            // CT input

            page1CTLabel = new MyLabel("CTLabel", "Степень точности");
            page1TableLayout.Add(page1CTLabel, 6, 0);

            page1CTTextBox = new InputTextBox<int>("page1CTTextBox", Validators.CTValidator, (value) => appForm.context.CT = value, "Натуральное число, от 5 до 9");
            page1TableLayout.Add(page1CTTextBox, 6, 3);

            // alpha input

            alphaLabel = new MyLabel("alphaLabel", "Угол между осями, град");
            page1TableLayout.Add(alphaLabel, 7, 0);

            alphaTextBox = new InputTextBox<double>("alphaTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.alpha = value);
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

            standartAlphaTextBox = new InputTextBox<double>("standartAlphaTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.standartAlpha = value * System.Math.PI / 180.0);
            page1TableLayout.Add(standartAlphaTextBox, 8, 3);

            // haStar

            haStarLabel = new MyLabel("haStarLabel", "ha*");
            page1TableLayout.Add(haStarLabel, 9, 2);

            haStarTextBox = new InputTextBox<double>("haStarTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.haStar = value);
            page1TableLayout.Add(haStarTextBox, 9, 3);

            // cStar

            cStarLabel = new MyLabel("cStarLabel", "c*");
            page1TableLayout.Add(cStarLabel, 10, 2);

            cStarTextBox = new InputTextBox<double>("cStarTextBox", Validators.DefaultDoubleValidator, (value) => appForm.context.cStar = value);
            page1TableLayout.Add(cStarTextBox, 10, 3);

            // after init

            cylindricalTypeButton.Checked = true;
            internalTypeButton.Checked = true;
            standartContourYesButton.Checked = true;
        }

        public void cylindricalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cylindricalTypeButton.Checked)
            {
                internalTypeButton.Enabled = true;
                externalTypeButton.Enabled = true;
                singleEntryTypeButton.Enabled = false;
                doubleEntryTypeButton.Enabled = false;

                singleEntryTypeButton.Checked = false;
                doubleEntryTypeButton.Checked = false;

                alphaTextBox.Enabled = false;

                T1Label.Text = "Крутящий момент на валу шестерни, Н*мм:";
            }
        }

        private void conicalTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (conicalTypeButton.Checked)
            {
                internalTypeButton.Enabled = true;
                externalTypeButton.Enabled = true;
                singleEntryTypeButton.Enabled = false;
                doubleEntryTypeButton.Enabled = false;

                singleEntryTypeButton.Checked = false;
                doubleEntryTypeButton.Checked = false;

                alphaTextBox.Enabled = true;

                T1Label.Text = "Крутящий момент на валу солнечного колеса, Н*мм:";
            }
        }

        private void planetTypeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (planetaryTypeButton.Checked)
            {
                internalTypeButton.Enabled = false;
                externalTypeButton.Enabled = false;
                singleEntryTypeButton.Enabled = true;
                doubleEntryTypeButton.Enabled = true;

                internalTypeButton.Checked = false;
                externalTypeButton.Checked = false;

                alphaTextBox.Enabled = false;

                T1Label.Text = "Крутящий момент на валу шестерни, Н*мм:";
            }
        }

        private void standartContourYesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (standartContourYesButton.Checked)
            {
                standartAlphaTextBox.SetValue(20);
                standartAlphaTextBox.Enabled = false;

                haStarTextBox.SetValue(1);
                haStarTextBox.Enabled = false;

                cStarTextBox.SetValue(0.25);
                cStarTextBox.Enabled = false;
            }
        }

        private void standartContourNoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (standartContourNoButton.Checked)
            {
                standartAlphaTextBox.Enabled = true;
                haStarTextBox.Enabled = true;
                cStarTextBox.Enabled = true;
            }
        }
    }
}
