using Schizophrenia.Main.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Schizophrenia {
    public partial class AppForm : Form {
        private Stack<PageID> pagesHistory = new Stack<PageID>(15);

        public AppForm() {
            InitializeComponent();
            InitializeChildren();

            page2.identityRadioButton.Checked = true;
        }

        public void backButton_Click(object sender, EventArgs e) {
            nextButton.Enabled = true;
            context = contextHistory.Pop();

            mainTableLayout.SuspendLayout();

            currentPage = pages[pagesHistory.Pop()];

            SetTitle(currentPage);

            mainTableLayout.Controls.Remove(mainTableLayout.GetControlFromPosition(0, 0));
            mainTableLayout.Add(currentPage.mainTableLayout, 0, 0);

            mainTableLayout.ResumeLayout();

            if (currentPage.ID == PageID.Page1) {
                backButton.Enabled = false;
            }
        }

        public void nextButton_Click(object sender, EventArgs e) {
            if (!currentPage.CanMoveOn()) {
                MessageBox.Show("Введите все значения в поля");
                return;
            }

            backButton.Enabled = true;
            pagesHistory.Push(currentPage.ID);

            mainTableLayout.SuspendLayout();

            currentPage = pages[currentPage.NextPage()];
            //currentPage = pages[currentPage.ID + 1];
            contextHistory.Push(context);

            SetTitle(currentPage);

            mainTableLayout.Controls.Remove(mainTableLayout.GetControlFromPosition(0, 0));
            mainTableLayout.Add(currentPage.mainTableLayout, 0, 0);

            mainTableLayout.ResumeLayout();
        }

        public void printButton_Click(object sender, EventArgs e) {
            try {
                String outputText = "";

                outputText += "ИСХОДНЫЕ ДАННЫЕ\n";

                if (page1.conicalTypeButton.Checked) {
                    outputText += String.Format("Тип передачи: {0}\n", context.checkedType);
                }
                else {
                    outputText += String.Format("Тип передачи: {0}, {1}\n", context.checkedType, context.checkedSubType);
                }

                outputText += String.Format("{0} {1}\n", page1.uLabel.Text, page1.uTextBox.Text);
                outputText += String.Format("{0} {1}\n", page1.n1Label.Text, page1.n1TextBox.Text);
                outputText += String.Format("Частота вращения колеса, об/мин: {0}\n", context.n2.ToString("0.##"));
                outputText += String.Format("{0} {1}\n", page1.T1Label.Text, page1.T1TextBox.Text);

                outputText += String.Format("{0} {1}\n", page1.thLabel.Text, page1.thTextBox.Text);
                if (page1.conicalTypeButton.Checked) {
                    outputText += String.Format("{0} {1}\n", page1.alphaLabel.Text, page1.alphaTextBox.Text);
                }

                outputText += String.Format("{0} {1}\n", page1.CTLabel.Text, page1.CTInputTextBox.Text);
                outputText += String.Format("Исходный контур:\n    alpha = {0}, град\n    h* = {1}\n    c* = {2}\n ", page1.standartAlphaTextBox.Text, page1.haStarTextBox.Text, page1.cStarTextBox.Text);

                if (page2.identityRadioButton.Checked) {
                    outputText += String.Format("\n{0} колеса и шестерни: {1}\n", page2.materialLabel.Text, page2.gearMaterialComboBox.Text);
                    outputText += String.Format("{0} {1}\n", page2.TOLabel.Text, page2.TO1ComboBox.Text);
                    outputText += String.Format("Твёрдость рабочей части\n    {0} {1}\n", page2.HBLabel.Text, page2.HB1TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC1TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC1TextBox.Text);
                    outputText += String.Format("{0} {1}\n", page2.coreStrengthLabel.Text, page2.HRCs1TextBox.Text);

                    outputText += String.Format("\n{0} {1}\n", page3.sigmaHLimbLabel.Text, page3.sigmaH1LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.sigmaFLimbLabel.Text, page3.sigmaF1LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.cLabel.Text, page3.c1TextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.KFCLabel.Text, page3.KFC1TextBox.Text);
                }
                else if (page2.notIdentityRadioButton.Checked) {
                    outputText += String.Format("\n{0} шестерни {1}\n", page2.materialLabel.Text, page2.gearMaterialComboBox.Text);
                    outputText += String.Format("{0} {1}\n", page2.TOLabel.Text, page2.TO1ComboBox.Text);
                    outputText += String.Format("Твёрдость рабочей части шестерни\n    {0} {1}\n", page2.HBLabel.Text, page2.HB1TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC1TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC1TextBox.Text);
                    outputText += String.Format("{0} шестерни: {1}\n", page2.coreStrengthLabel.Text, page2.HRCs1TextBox.Text);
                    outputText += String.Format("\n{0} {1}\n", page3.sigmaHLimbLabel.Text, page3.sigmaH1LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.sigmaFLimbLabel.Text, page3.sigmaF1LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.cLabel.Text, page3.c1TextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.KFCLabel.Text, page3.KFC1TextBox.Text);

                    outputText += String.Format("\n{0} колеса {1}\n", page2.materialLabel.Text, page2.wheelMaterialComboBox.Text);
                    outputText += String.Format("{0} {1}\n", page2.TOLabel.Text, page2.TO2ComboBox.Text);
                    outputText += String.Format("Твёрдость рабочей части колеса\n    {0} {1}\n", page2.HBLabel.Text, page2.HB2TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC2TextBox.Text);
                    outputText += String.Format("    {0} {1}\n", page2.HRCLabel.Text, page2.HRC2TextBox.Text);
                    outputText += String.Format("{0} колеса {1}\n", page2.coreStrengthLabel.Text, page2.HRCs2TextBox.Text);
                    outputText += String.Format("\n{0} {1}\n", page3.sigmaHLimbLabel.Text, page3.sigmaH2LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.sigmaFLimbLabel.Text, page3.sigmaF2LimbTextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.cLabel.Text, page3.c2TextBox.Text);
                    outputText += String.Format("{0} {1}\n", page3.KFCLabel.Text, page3.KFC2TextBox.Text);
                }

                outputText += String.Format("{0} {1}\n", page3.SHLabel.Text, page3.SHTextBox.Text);
                outputText += String.Format("{0} {1}\n", page3.SFLabel.Text, page3.SFTextBox.Text);

                if (page3.constModeRadioButton.Checked) {
                    outputText += String.Format("{0} {1}\n", page3.workModeLabel.Text, page3.constModeRadioButton.Text);
                    outputText += String.Format("Допускаемое контактное напряжение: {0}\n", context.sigmaHAllow.ToString("0.##"));
                }
                else {
                    outputText += String.Format("\n{0} {1}\n", page3.workModeLabel.Text, page3.diffModeRadioButton.Text);
                    outputText += String.Format("Коэффициент долговечности шестерни по контактным напряжениям (KHL1): {0}\n", context.KHL1.ToString("0.##"));
                    outputText += String.Format("Коэффициент долговечности колеса по контактным напряжениям (KHL2): {0}\n", context.KHL2.ToString("0.##"));
                    outputText += String.Format("{0} (KHE): {1}\n", page3.KHELabel.Text, context.KHE.ToString("0.##"));
                    outputText += String.Format("Допускаемое контактное напряжение: {0}\n", context.sigmaH.ToString("0.##"));
                    outputText += String.Format("Коэффициент долговечности шестерни по изгибным напряжениям (KFL1): {0}\n", context.KFL1.ToString("0.##"));
                    outputText += String.Format("Коэффициент долговечности колеса по изгибным напряжениям (KFL1): {0}\n", context.KFL2.ToString("0.##"));
                    outputText += String.Format("Допускаемое изгибное напряжение шестерни: {0}\n", context.sigmaF1Allow.ToString("0.##"));
                    outputText += String.Format("Допускаемое изгибное напряжение колеса: {0}\n", context.sigmaF2Allow.ToString("0.##"));
                }

                if (page4.aWKnownRadioButton.Checked) {
                    outputText += String.Format("{0}: {1}\n", page4.aWLabel.Text, page4.aWKnownTextBox.Text);
                }
                else {
                    outputText += String.Format("{0} {1}\n", page4.aWLabel.Text, page4.aWUnknownRadioButton.Text);
                    outputText += String.Format("\n{0} {1}\n", page4.psibaLabel.Text, page4.psibaTextBox.Text);
                }

                outputText += String.Format("\nРЕЗУЛЬТАТЫ РАСЧЁТА\n");
                outputText += String.Format("Коэффициент ширины зубчатого венца относительно диаметра шестерни: {0}\n", context.psibd.ToString("0.##"));
                outputText += String.Format("Начальный диаметр шестерни: {0}, мм\n", context.dW1.ToString("0.##"));
                outputText += String.Format("Начальный диаметр колеса: {0}, мм\n", context.dW2.ToString("0.##"));
                outputText += String.Format("Нормальный модуль: {0}\n", context.mi.ToString("0.##"));
                outputText += String.Format("Число зубьев шестерни: {0}\n", context.z1i.ToString("0.##"));
                outputText += String.Format("Число зубьев колеса: {0}\n", context.z2i.ToString("0.##"));
                outputText += String.Format("Передаточное число передачи: {0}\n", context.Ui.ToString("0.##"));
                outputText += String.Format("Делительное межосевое расстояние: {0}, мм\n", context.a.ToString("0.##"));
                outputText += String.Format("Межосевое расстояние: {0}, мм\n", context.aW.ToString("0.##"));

                outputText += String.Format("Основной диаметр шестерни: {0}, мм\n", context.db1.ToString("0.##"));
                outputText += String.Format("Основной диаметр колеса: {0}, мм\n", context.db2.ToString("0.##"));
                outputText += String.Format("Диаметр вершин зубьев шестерни: {0}, мм\n", context.da1.ToString("0.##"));
                outputText += String.Format("Диаметр вершин зубьев колеса: {0}, мм\n", context.da2.ToString("0.##"));
                outputText += String.Format("Диаметр впадин зубьев шестерни: {0}, мм\n", context.df1.ToString("0.##"));
                outputText += String.Format("Диаметр впадин зубьев колеса: {0}, мм\n", context.df2.ToString("0.##"));
                outputText += String.Format("ha1: {0}\n", context.ha1.ToString("0.##"));
                outputText += String.Format("hf1: {0}\n", context.hf1.ToString("0.##"));
                outputText += String.Format("ha2: {0}\n", context.ha2.ToString("0.##"));
                outputText += String.Format("hf2: {0}\n", context.hf2.ToString("0.##"));
                outputText += String.Format("h: {0}\n", context.h.ToString("0.##"));
                outputText += String.Format("c: {0}\n", context.c.ToString("0.##"));
                outputText += String.Format("P: {0}\n", context.P.ToString("0.##"));
                outputText += String.Format("Pb: {0}\n", context.Pb.ToString("0.##"));
                outputText += String.Format("Коэффициент торцевого перекрытия: {0}\n", context.epsilonAlpha.ToString("0.##"));

                outputText += String.Format("Коэффициент смещения шестерни: {0}\n", context.x1.ToString("0.##"));
                outputText += String.Format("Коэффициент смещения колеса: {0}\n", context.x2.ToString("0.##"));

                outputText += String.Format("Окружная скорость: {0}, м/с\n", context.V.ToString("0.##"));
                outputText += String.Format("Эффективное значение коэффициента неравномерности: {0}\n", context.KBeta.ToString("0.##"));
                outputText += String.Format("Коэффициент нагрузки по контактным напряжениям: {0}\n", context.KH.ToString("0.##"));
                outputText += String.Format("Коэффициент динамической нагрузки: {0}\n", context.KV.ToString("0.##"));
                outputText += String.Format("Коэффициент, учитывающий геометрию контактирующих тел: {0}\n", context.zH.ToString("0.##"));
                outputText += String.Format("Коэффициент, учитывающий торцевое перекрытие: {0}\n", context.zEpsilon.ToString("0.##"));
                outputText += String.Format("Контактное напряжение в зубьях: {0}, МПа\n", context.sigmaH.ToString("0.##"));
                outputText += String.Format("Изгибное напряжение в зубьях шестерни: {0}, МПа\n", context.sigmaF1.ToString("0.##"));
                outputText += String.Format("Изгибное напряжение в зубьях колеса: {0}, МПа\n", context.sigmaF2.ToString("0.##"));

                outputText += String.Format("Коэффициент формы зуба шестерни: {0}\n", context.YF1.ToString("0.##"));
                outputText += String.Format("Коэффициент формы зуба колеса: {0}\n", context.YF2.ToString("0.##"));

                /*
                Word.Application app = new Word.Application();
                Word.Document doc = app.Documents.Add();

                doc.Paragraphs[1].Range.Text = outputText;
                app.Visible = true;
                */

                File.WriteAllText("output.txt", outputText);
            }


            catch (Exception exception) { MessageBox.Show(exception.ToString()); }
        }

    }
}
