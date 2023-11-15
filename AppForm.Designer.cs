using System.Windows.Forms;
using System;
using Schizophrenia.Main.Pages;

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
        public MyTableLayoutPanel mainTableLayout;

        public MyTableLayoutPanel[] pagesMainTableLayout = new MyTableLayoutPanel[15];
        public int currentPage;

        // Page 1
        public Page1 page1;

        public double u;
        public double n1;
        public double T1;
        public double th;
        public int CT;
        public double alpha;
        public double standartAlpha;
        public double haStar;
        public double cStar;

        public String checkedSubTypeRadioButton;

        // Page 2

        public Page2 page2;

        public double HB1;
        public double HB2;
        public double HRC1;
        public double HRC2;
        public double HV1;
        public double HV2;
        public double HRCs1;
        public double HRCs2;

        // Page 3

        public Page3 page3;

        public double sigmaH1Limb;
        public double sigmaH2Limb;
        public double sigmaF1Limb;
        public double sigmaF2Limb;
        public double c1;
        public double c2;
        public double KFC1;
        public double KFC2;
        public double SH;
        public double SF;
        public double KHE;
        public double KFE;

        // Page 4

        public Page4 page4;

        public double aW;
        public double psiba;

        // Page 5

        public MyTableLayoutPanel page5MiGroup;
        public MyLabel miLabel;
        public OutputTextBox miTextBox;

        public MyLabel mComentLabel;

        public MyTableLayoutPanel page5MGroup;
        public MyLabel mLabel;
        public InputTextBox<double> mTextBox;
        public double m;

        public PictureBox mPicture;

        public PictureBox standartMPicture;

        // Page 6

        public MyLabel z1iLabel;
        public OutputTextBox z1iTextBox;

        public MyLabel z1Label;
        public InputTextBox<double> z1TextBox;
        public double z1;

        public MyLabel z2iLabel;
        public OutputTextBox z2iTextBox;

        public MyLabel z2Label;
        public InputTextBox<double> z2TextBox;
        public double z2;

        public MyLabel badDeltaU1label;
        public MyLabel badDeltaU2label;

        // Page 7

        public MyTableLayoutPanel page7AWGroup;

        public MyLabel aWiLabel;
        public OutputTextBox aWiTextBox;

        public InputTextBox<double> aWTextBox;

        public PictureBox standartAWPicture;

        // Page 8

        public MyLabel page8GearLabel;
        public MyLabel page8WheelLabel;

        public MyLabel xLabel;
        public OutputTextBox x1iTextBox;
        public OutputTextBox x2iTextBox;

        public InputTextBox<double> x1TextBox;
        public double x1;

        public InputTextBox<double> x2TextBox;
        public double x2;

        // Page 9

        public MyLabel xCor1Label;
        public MyLabel page9GearLabel;
        public MyLabel page9WheelLabel;

        public MyRadioButton withoutOffsetRadioButton;
        public OutputTextBox x1iCor1TextBox;
        public OutputTextBox x2iCor1TextBox;

        public MyRadioButton withOffsetRadioButton;
        public InputTextBox<double> x1Cor1TextBox;
        public InputTextBox<double> x2Cor1TextBox;

        // Page 10

        public MyLabel xSigmaLabel;
        public OutputTextBox xSigmaTextBox;

        public MyLabel page10GearLabel;
        public MyLabel page10WheelLabel;

        public MyLabel xCor2Label;
        public OutputTextBox x1iCor2TextBox;
        public OutputTextBox x2iCor2TextBox;

        public InputTextBox<double> x1Cor2TextBox;
        public InputTextBox<double> x2Cor2TextBox;

        // Page 11

        public MyLabel page11AWLabel;
        public OutputTextBox page11AW;

        public MyRadioButton withoutRoundRadioButton;
        public MyRadioButton roundRadioButton;
        public InputTextBox<double> aWG3TextBox;

        // Page 12

        public MyLabel psibdLabel;
        public OutputTextBox psibdTextBox;

        public MyLabel KBettaLabel;
        public InputTextBox<double> KBettaTextBox;
        public double KBetta;

        public PictureBox page12KBettaPicture;
        public MyTableLayoutPanel page12PicturesGroup;
        public PictureBox page12SymmPicture;
        public PictureBox page12AsymmPicture;
        public PictureBox page12ConsolePicture;

        // Page 13

        public MyTableLayoutPanel page13LabelsBoxesGroup;
        public MyLabel VLabel;
        public OutputTextBox VTextBox;

        public MyLabel HBMinLabel;
        public OutputTextBox HBMinTextBox;

        public MyLabel page13CTLabel;
        public OutputTextBox page13CTTextBox;

        public MyLabel KVLabel;
        public InputTextBox<double> KVTextBox;
        public double KV;

        public PictureBox KVPicture;

        // Page 14

        public MyTableLayoutPanel page14LabelsBoxesGroup;
        public MyLabel page14Z1Label;
        public OutputTextBox page14Z1TextBox;

        public MyLabel YF1Label;
        public InputTextBox<double> YF1TextBox;
        public double YF1;

        public MyLabel page14Z2Label;
        public OutputTextBox page14Z2TextBox;

        public MyLabel YF2Label;
        public InputTextBox<double> YF2TextBox;
        public double YF2;

        public PictureBox YFPicture;

        // Page 15

        public MyTableLayoutPanel page15LabelsBoxesGroup;
        public MyLabel page15GearLabel;
        public MyLabel page15WheelLabel;

        public MyLabel zOffsetLabel;
        public OutputTextBox z1OffsetTextBox;
        public OutputTextBox z2OffsetTextBox;

        public MyLabel xOffsetLabel;
        public OutputTextBox x1OffsetTextBox;
        public OutputTextBox x2OffsetTextBox;

        public MyLabel YFOffsetLabel;
        public InputTextBox<double> YF1OffsetTextBox;
        public InputTextBox<double> YF2OffsetTextBox;

        public PictureBox zPicture;

        // Buttons panel

        public MyTableLayoutPanel buttonsTableLayout;
        public MyButton printButton;
        public MyButton backButton;
        public MyButton nextButton;

        public ToolTip toolTip;

        public void InitializeChildren()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));

            SuspendLayout();

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // BEGIN

            mainTableLayout = new MyTableLayoutPanel("mainTableLayout", 16, 1, DockStyle.Fill);

            toolTip = new ToolTip();
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 10000;
            toolTip.ReshowDelay = 0;
            toolTip.UseFading = false;


            // Buttons on the bottom (and every page, actually)

            buttonsTableLayout = new MyTableLayoutPanel("buttonsTableLayout", 1, 3, DockStyle.Fill);
            buttonsTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            printButton = new MyButton("printButton", "Печать");
            printButton.Click += new System.EventHandler(printButton_Click);
            buttonsTableLayout.Add(printButton, 0, 0);

            backButton = new MyButton("backButton", "Назад");
            backButton.Click += new System.EventHandler(backButton_Click);
            buttonsTableLayout.Add(backButton, 0, 1);

            nextButton = new MyButton("nextButton", "Далее");
            nextButton.Click += new System.EventHandler(nextButton_Click);
            buttonsTableLayout.Add(nextButton, 0, 2);

            mainTableLayout.Add(buttonsTableLayout, 15, 0);

            // Page 1

            page1 = new Page1(this);
            pagesMainTableLayout[0] = page1.mainTableLayout;

            // Page 2

            page2 = new Page2(this);
            pagesMainTableLayout[1] = page2.mainTableLayout;

            // Page 3

            page3 = new Page3(this);
            pagesMainTableLayout[2] = page3.mainTableLayout;

            
            // Page 4

            page4 = new Page4(this);
            pagesMainTableLayout[3] = page4.mainTableLayout;

            // Page 5

            pagesMainTableLayout[4] = new MyTableLayoutPanel("page5MainTableLayout", 5, 1, DockStyle.Fill);

            // mi

            page5MiGroup = new MyTableLayoutPanel("page5MiGroup", 1, 2);
            page5MiGroup.Margin = new Padding(0);
            page5MiGroup.Padding = new Padding(0);
            page5MiGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[4].Add(page5MiGroup, 0, 0);

            miLabel = new MyLabel("miLabel", "Расчетное значение модуля зацепления");
            page5MiGroup.Add(miLabel, 0, 0);

            miTextBox = new OutputTextBox("miTextBox");
            page5MiGroup.Add(miTextBox, 0, 1);

            // comment

            mComentLabel = new MyLabel("mComentLabel", "Введите стандартное значение модуля не менее минимального по таблицам");
            pagesMainTableLayout[4].Add(mComentLabel, 1, 0);

            // m

            page5MGroup = new MyTableLayoutPanel("page5MGroup", 1, 2);
            page5MGroup.Margin = new Padding(0);
            page5MGroup.Padding = new Padding(0);
            page5MGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[4].Add(page5MGroup, 2, 0);

            mLabel = new MyLabel("mLabel", "Модуль зацепления, мм");
            page5MGroup.Add(mLabel, 0, 0);

            mTextBox = new InputTextBox<double>("mTextBox", Validators.DefaultDoubleValidator, (value) => m = value);
            page5MGroup.Add(mTextBox, 0, 1);

            // min m picture

            mPicture = new PictureBox();
            mPicture.Image = Properties.Resources.minMTable;
            mPicture.Anchor = AnchorStyles.Top;
            mPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[4].Add(mPicture, 3, 0);

            standartMPicture = new PictureBox();
            standartMPicture.Image = Properties.Resources.standartMTable;
            standartMPicture.Anchor = AnchorStyles.Top;
            standartMPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[4].Add(standartMPicture, 4, 0);

            // Page 6

            pagesMainTableLayout[5] = new MyTableLayoutPanel("page6MainTableLayout", 6, 2, DockStyle.Fill);

            // z1

            z1iLabel = new MyLabel("z1iLabel", "Расчетное значение числа зубьев шестерни");
            pagesMainTableLayout[5].Add(z1iLabel, 0, 0);

            z1iTextBox = new OutputTextBox("z1iTextBox");
            pagesMainTableLayout[5].Add(z1iTextBox, 0, 1);

            z1Label = new MyLabel("z1Label", "Округлите до целого и введите число зубьев шестерни");
            pagesMainTableLayout[5].Add(z1Label, 1, 0);

            z1TextBox = new InputTextBox<double>("z1TextBox", Validators.DefaultDoubleValidator, (value) => z1 = value);
            pagesMainTableLayout[5].Add(z1TextBox, 1, 1);

            // z2

            z2iLabel = new MyLabel("z2iLabel", "Расчетное значение числа зубьев колеса");
            pagesMainTableLayout[5].Add(z2iLabel, 2, 0);

            z2iTextBox = new OutputTextBox("z2iTextBox");
            pagesMainTableLayout[5].Add(z2iTextBox, 2, 1);

            z2Label = new MyLabel("z2Label", "Округлите до целого и введите число зубьев колеса");
            pagesMainTableLayout[5].Add(z2Label, 3, 0);

            z2TextBox = new InputTextBox<double>("z2TextBox", Validators.DefaultDoubleValidator, (value) => z2 = value);
            pagesMainTableLayout[5].Add(z2TextBox, 3, 1);

            // bad delta u

            badDeltaU1label = new MyLabel("badDeltaU1label", "Отклонение передаточного отношения от исходного превышает 3%");
            pagesMainTableLayout[5].Add(badDeltaU1label, 4, 0);

            badDeltaU2label = new MyLabel("badDeltaU2label", "Измените числа зубьев шестерни и/или колеса");
            pagesMainTableLayout[5].Add(badDeltaU2label, 5, 0);

            // Page 7

            pagesMainTableLayout[6] = new MyTableLayoutPanel("page7MainTableLayout", 2, 1, DockStyle.Fill);

            page7AWGroup = new MyTableLayoutPanel("page7AWGroup", 2, 3, DockStyle.Fill);
            page7AWGroup.Margin = new Padding(0);
            page7AWGroup.Padding = new Padding(0);
            page7AWGroup.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[6].Add(page7AWGroup, 0, 0);

            aWiLabel = new MyLabel("aWiLabel", "Введите стандартное межосевое расстояние по таблице");
            page7AWGroup.Add(aWiLabel, 0, 0);

            aWiTextBox = new OutputTextBox("aWiTextBox");
            page7AWGroup.Add(aWiTextBox, 0, 1);

            aWTextBox = new InputTextBox<double>("aWTextBox", Validators.DefaultDoubleValidator, (value) => aW = value);
            page7AWGroup.Add(aWTextBox, 1, 1);

            standartAWPicture = new PictureBox();
            standartAWPicture.Image = Properties.Resources.standartAWTable;
            standartAWPicture.Anchor = AnchorStyles.Top;
            standartAWPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[6].Add(standartAWPicture, 1, 0);

            // Page 8

            pagesMainTableLayout[7] = new MyTableLayoutPanel("page8MainTableLayout", 3, 3, DockStyle.Fill);

            page8GearLabel = new MyLabel("page8GearLabel", "Шестерня");
            pagesMainTableLayout[7].Add(page8GearLabel, 0, 1);

            page8WheelLabel = new MyLabel("page8WheelLabel", "Колесо");
            pagesMainTableLayout[7].Add(page8WheelLabel, 0, 2);

            xLabel = new MyLabel("xLabel", "Задайте коэффициент смещения не менее");
            pagesMainTableLayout[7].Add(xLabel, 1, 0);

            x1iTextBox = new OutputTextBox("x1iTextBox");
            pagesMainTableLayout[7].Add(x1iTextBox, 1, 1);

            x2iTextBox = new OutputTextBox("x2iTextBox");
            pagesMainTableLayout[7].Add(x2iTextBox, 1, 2);

            x1TextBox = new InputTextBox<double>("x1TextBox", Validators.DefaultDoubleValidator, (value) => x1 = value);
            pagesMainTableLayout[7].Add(x1TextBox, 2, 1);

            x2TextBox = new InputTextBox<double>("x2TextBox", Validators.DefaultDoubleValidator, (value) => x2 = value);
            pagesMainTableLayout[7].Add(x2TextBox, 2, 2);

            // Page 9

            pagesMainTableLayout[8] = new MyTableLayoutPanel("page9MainTableLayout", 3, 3, DockStyle.Fill);

            xCor1Label = new MyLabel("xCor1Label", "Задайте коэффициент смещения");
            pagesMainTableLayout[8].Add(xCor1Label, 0, 0);

            page9GearLabel = new MyLabel("page9GearLabel", "Шестерня");
            pagesMainTableLayout[8].Add(page9GearLabel, 0, 1);

            page9WheelLabel = new MyLabel("page9WheelLabel", "Колесо");
            pagesMainTableLayout[8].Add(page9WheelLabel, 0, 2);

            withoutOffsetRadioButton = new MyRadioButton("withoutOffsetRadioButton", "Без смещения (для шестерни x1=0, для колеса x2=0)");
            pagesMainTableLayout[8].Add(withoutOffsetRadioButton, 1, 0);

            x1iCor1TextBox = new OutputTextBox("x1iCor1TextBox");
            pagesMainTableLayout[8].Add(x1iCor1TextBox, 1, 1);

            x2iCor1TextBox = new OutputTextBox("x2iCor1TextBox");
            pagesMainTableLayout[8].Add(x2iCor1TextBox, 1, 2);

            withOffsetRadioButton = new MyRadioButton("withOffsetRadioButton", "Высотная коррекция: коэффициент смещения не менее");
            pagesMainTableLayout[8].Add(withOffsetRadioButton, 2, 0);

            x1Cor1TextBox = new InputTextBox<double>("x1Cor1TextBox", Validators.DefaultDoubleValidator, (value) => x1 = value);
            pagesMainTableLayout[8].Add(x1Cor1TextBox, 2, 1);

            x2Cor1TextBox = new InputTextBox<double>("x2Cor1TextBox", Validators.DefaultDoubleValidator, (value) => x2 = value);
            pagesMainTableLayout[8].Add(x2Cor1TextBox, 2, 2);

            // Page 10

            pagesMainTableLayout[9] = new MyTableLayoutPanel("page10MainTableLayout", 4, 3, DockStyle.Fill);

            xSigmaLabel = new MyLabel("xSigmaLabel", "Суммарный коэффициент смещения");
            pagesMainTableLayout[9].Add(xSigmaLabel, 0, 0);

            xSigmaTextBox = new OutputTextBox("xSigmaTextBox");
            pagesMainTableLayout[9].Add(xSigmaTextBox, 0, 1);

            page10GearLabel = new MyLabel("page10GearLabel", "Шестерня");
            pagesMainTableLayout[9].Add(page10GearLabel, 1, 1);

            page10WheelLabel = new MyLabel("page10WheelLabel", "Колесо");
            pagesMainTableLayout[9].Add(page10WheelLabel, 1, 2);

            xCor2Label = new MyLabel("xCor2Label", "Задайте коэффициент смещения не менее");
            pagesMainTableLayout[9].Add(xCor2Label, 2, 0);

            x1iCor2TextBox = new OutputTextBox("x1iCor2TextBox");
            pagesMainTableLayout[9].Add(x1iCor2TextBox, 2, 1);

            x2iCor2TextBox = new OutputTextBox("x2iCor2TextBox");
            pagesMainTableLayout[9].Add(x2iCor2TextBox, 2, 2);

            x1Cor2TextBox = new InputTextBox<double>("x1Cor2TextBox", Validators.DefaultDoubleValidator, (value) => x1 = value);
            pagesMainTableLayout[9].Add(x1Cor2TextBox, 3, 1);

            x2Cor2TextBox = new InputTextBox<double>("x2Cor2TextBox", Validators.DefaultDoubleValidator, (value) => x2 = value);
            pagesMainTableLayout[9].Add(x2Cor2TextBox, 3, 2);

            // Page 11

            pagesMainTableLayout[10] = new MyTableLayoutPanel("page11MainTableLayout", 3, 2, DockStyle.Fill);

            page11AWLabel = new MyLabel("page11AWLabel", "Расчётное межосевое расстояние составляет");
            pagesMainTableLayout[10].Add(page11AWLabel, 0, 0);

            page11AW = new OutputTextBox("page11AW");
            pagesMainTableLayout[10].Add(page11AW, 0, 1);

            withoutRoundRadioButton = new MyRadioButton("withoutRoundRadioButton", "Оставить без округления");
            pagesMainTableLayout[10].Add(withoutRoundRadioButton, 1, 0);

            roundRadioButton = new MyRadioButton("roundRadioButton", "Округлить");
            pagesMainTableLayout[10].Add(roundRadioButton, 2, 0);

            aWG3TextBox = new InputTextBox<double>("aWG3TextBox", Validators.DefaultDoubleValidator, (value) => aW = value);
            pagesMainTableLayout[10].Add(aWG3TextBox, 2, 1);

            // Page 12

            pagesMainTableLayout[11] = new MyTableLayoutPanel("page12MainTableLayout", 3, 2, DockStyle.Fill);

            psibdLabel = new MyLabel("psibdLabel", "Коэффициент ширины относительно диаметра шестерни");
            pagesMainTableLayout[11].Add(psibdLabel, 0, 0);

            psibdTextBox = new OutputTextBox("psibdTextBox");
            pagesMainTableLayout[11].Add(psibdTextBox, 0, 1);

            KBettaLabel = new MyLabel("KBettaLabel", "Введите начальный коэффициент неравномерности распределения нагрузки");
            pagesMainTableLayout[11].Add(KBettaLabel, 1, 0);

            KBettaTextBox = new InputTextBox<double>("KBettaTextBox", Validators.DefaultDoubleValidator, (value) => KBetta = value);
            pagesMainTableLayout[11].Add(KBettaTextBox, 1, 1);

            page12KBettaPicture = new PictureBox();
            page12KBettaPicture.Image = Properties.Resources.KBettaTable;
            page12KBettaPicture.Anchor = AnchorStyles.Top;
            page12KBettaPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[11].Add(page12KBettaPicture, 2, 0);

            page12PicturesGroup = new MyTableLayoutPanel("page12PicturesGroup", 3, 1);
            pagesMainTableLayout[11].Add(page12PicturesGroup, 2, 1);

            page12SymmPicture = new PictureBox();
            page12SymmPicture.Image = Properties.Resources.symm;
            page12SymmPicture.Anchor = AnchorStyles.Top;
            page12SymmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12SymmPicture, 0, 0);

            page12AsymmPicture = new PictureBox();
            page12AsymmPicture.Image = Properties.Resources.asymm;
            page12AsymmPicture.Anchor = AnchorStyles.Top;
            page12AsymmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12AsymmPicture, 1, 0);

            page12ConsolePicture = new PictureBox();
            page12ConsolePicture.Image = Properties.Resources.console;
            page12ConsolePicture.Anchor = AnchorStyles.Top;
            page12ConsolePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            page12PicturesGroup.Add(page12ConsolePicture, 2, 0);

            // Page 13

            pagesMainTableLayout[12] = new MyTableLayoutPanel("page13MainTableLayout", 2, 1, DockStyle.Fill);

            page13LabelsBoxesGroup = new MyTableLayoutPanel("page13LabelsBoxesGroup", 4, 2);
            page13LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[12].Add(page13LabelsBoxesGroup, 0, 0);

            VLabel = new MyLabel("VLabel", "Окружная скорость, м/с");
            page13LabelsBoxesGroup.Add(VLabel, 0, 0);

            VTextBox = new OutputTextBox("VTextBox");
            page13LabelsBoxesGroup.Add(VTextBox, 0, 1);

            HBMinLabel = new MyLabel("HBMinLabel", "Твердость, НВ");
            page13LabelsBoxesGroup.Add(HBMinLabel, 1, 0);

            HBMinTextBox = new OutputTextBox("HBMinTextBox");
            page13LabelsBoxesGroup.Add(HBMinTextBox, 1, 1);

            page13CTLabel = new MyLabel("page13CTLabel", "Степень точности");
            page13LabelsBoxesGroup.Add(page13CTLabel, 2, 0);

            page13CTTextBox = new OutputTextBox("page13CTTextBox");
            page13LabelsBoxesGroup.Add(page13CTTextBox, 2, 1);

            KVLabel = new MyLabel("KVLabel", "Коэффициент динамической нагрузки");
            page13LabelsBoxesGroup.Add(KVLabel, 3, 0);

            KVTextBox = new InputTextBox<double>("KVTextBox", Validators.DefaultDoubleValidator, (value) => KV = value);
            page13LabelsBoxesGroup.Add(KVTextBox, 3, 1);

            KVPicture = new PictureBox();
            KVPicture.Image = Properties.Resources.KVTable;
            KVPicture.Anchor = AnchorStyles.Top;
            KVPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[12].Add(KVPicture, 1, 0);

            // Page 14

            pagesMainTableLayout[13] = new MyTableLayoutPanel("page14MainTableLayout", 2, 1, DockStyle.Fill);

            page14LabelsBoxesGroup = new MyTableLayoutPanel("page14LabelsBoxesGroup", 4, 2);
            page14LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[13].Add(page14LabelsBoxesGroup, 0, 0);

            page14Z1Label = new MyLabel("page14Z1Label", "Число зубьев шестерни");
            page14LabelsBoxesGroup.Add(page14Z1Label, 0, 0);

            page14Z1TextBox = new OutputTextBox("page14Z1TextBox");
            page14LabelsBoxesGroup.Add(page14Z1TextBox, 0, 1);

            YF1Label = new MyLabel("YF1Label", "Введите коэффициент формы зуба шестерни");
            page14LabelsBoxesGroup.Add(YF1Label, 1, 0);

            YF1TextBox = new InputTextBox<double>("YF1TextBox", Validators.DefaultDoubleValidator, (value) => YF1 = value);
            page14LabelsBoxesGroup.Add(YF1TextBox, 1, 1);

            page14Z2Label = new MyLabel("page14Z2Label", "Число зубьев колеса");
            page14LabelsBoxesGroup.Add(page14Z2Label, 2, 0);

            page14Z2TextBox = new OutputTextBox("page14Z2TextBox");
            page14LabelsBoxesGroup.Add(page14Z2TextBox, 2, 1);

            YF2Label = new MyLabel("YF2Label", "Введите коэффициент формы зуба колеса");
            page14LabelsBoxesGroup.Add(YF2Label, 3, 0);

            YF2TextBox = new InputTextBox<double>("YF2TextBox", Validators.DefaultDoubleValidator, (value) => YF2 = value);
            page14LabelsBoxesGroup.Add(YF2TextBox, 3, 1);

            YFPicture = new PictureBox();
            YFPicture.Image = Properties.Resources.YFTable;
            YFPicture.Anchor = AnchorStyles.Top;
            YFPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[13].Add(YFPicture, 1, 0);

            // Page 15

            pagesMainTableLayout[14] = new MyTableLayoutPanel("page15MainTableLayout", 2, 1, DockStyle.Fill);

            page15LabelsBoxesGroup = new MyTableLayoutPanel("page15LabelsBoxesGroup", 4, 3);
            page15LabelsBoxesGroup.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[14].Add(page15LabelsBoxesGroup, 0, 0);

            page15GearLabel = new MyLabel("page15GearLabel", "Шестерня");
            page15LabelsBoxesGroup.Add(page15GearLabel, 0, 1);

            page15WheelLabel = new MyLabel("page15WheelLabel", "Колесо");
            page15LabelsBoxesGroup.Add(page15WheelLabel, 0, 2);

            zOffsetLabel = new MyLabel("zOffsetLabel", "Число зубьев");
            page15LabelsBoxesGroup.Add(zOffsetLabel, 1, 0);

            z1OffsetTextBox = new OutputTextBox("z1OffsetTextBox");
            page15LabelsBoxesGroup.Add(z1OffsetTextBox, 1, 1);

            z2OffsetTextBox = new OutputTextBox("z2OffsetTextBox");
            page15LabelsBoxesGroup.Add(z2OffsetTextBox, 1, 2);

            xOffsetLabel = new MyLabel("xOffsetLabel", "Коэффициент смещения");
            page15LabelsBoxesGroup.Add(xOffsetLabel, 2, 0);

            x1OffsetTextBox = new OutputTextBox("x1OffsetTextBox");
            page15LabelsBoxesGroup.Add(x1OffsetTextBox, 2, 1);

            x2OffsetTextBox = new OutputTextBox("x2OffsetTextBox");
            page15LabelsBoxesGroup.Add(x2OffsetTextBox, 2, 2);

            YFOffsetLabel = new MyLabel("YFOffsetLabel", "Введите коэффициент формы зуба");
            page15LabelsBoxesGroup.Add(YFOffsetLabel, 3, 0);

            YF1OffsetTextBox = new InputTextBox<double>("YF1OffsetTextBox", Validators.DefaultDoubleValidator, (value) => YF1 = value);
            page15LabelsBoxesGroup.Add(YF1OffsetTextBox, 3, 1);

            YF2OffsetTextBox = new InputTextBox<double>("YF2OffsetTextBox", Validators.DefaultDoubleValidator, (value) => YF2 = value);
            page15LabelsBoxesGroup.Add(YF2OffsetTextBox, 3, 2);

            zPicture = new PictureBox();
            zPicture.Image = Properties.Resources.zfunc;
            zPicture.Anchor = AnchorStyles.Top;
            zPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            pagesMainTableLayout[14].Add(zPicture, 1, 0);

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

