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
        private MyLabel inputDataLabel;

        // Page 1
        private MyTableLayoutPanel page1TableLayout;
        private MyLabel gearTypeLabel;

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

        // Page 2

        // Buttons panel

        private MyTableLayoutPanel buttonsTableLayout;
        private MyButton printButton;
        private MyButton backButton;
        private MyButton nextButton;

        private void InitializeChildren()
        {
            SuspendLayout();

            // 

            mainTableLayout = new MyTableLayoutPanel("mainTableLayout", 3, 1, DockStyle.Fill);
            mainTableLayout.RowStyles[1] = new RowStyle(SizeType.Percent, 100);

            // Buttons on the bottom

            buttonsTableLayout = new MyTableLayoutPanel("buttonsTableLayout", 1, 4, DockStyle.Fill);
            buttonsTableLayout.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100);

            printButton = new MyButton("printButton", "Печать");
            buttonsTableLayout.Add(printButton, 0, 0);

            backButton = new MyButton("backButton", "Назад");
            buttonsTableLayout.Add(backButton, 0, 2);

            nextButton = new MyButton("nextButton", "Далее");
            buttonsTableLayout.Add(nextButton, 0, 3);

            mainTableLayout.Add(buttonsTableLayout, 2, 0);

            // Page 1

            pagesMainTableLayout[0] = new MyTableLayoutPanel("page1MainTableLayout", 2, 1, DockStyle.Fill);

            inputDataLabel = new MyLabel("inputDataLabel", "Исходные данные");
            inputDataLabel.Anchor = AnchorStyles.Top;
            inputDataLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size + 4, DefaultFonts.Any.Style, DefaultFonts.Any.Unit);
            pagesMainTableLayout[0].Add(inputDataLabel, 0, 0);

            page1TableLayout = new MyTableLayoutPanel("page1MainTableLayout", 10, 4, DockStyle.Fill);
            page1TableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);
            pagesMainTableLayout[0].Add(page1TableLayout, 1, 0);

            gearTypeLabel = new MyLabel("typeLabel", "Тип передачи:");
            gearTypeLabel.Font = new System.Drawing.Font(DefaultFonts.Any.FontFamily, DefaultFonts.Any.Size, System.Drawing.FontStyle.Underline, DefaultFonts.Any.Unit);
            page1TableLayout.Add(gearTypeLabel, 0, 0);

            // U input

            uLabel = new MyLabel("uLabel", "Предаточное отношение");
            page1TableLayout.Add(uLabel, 2, 0);

            uTextBox = new InputTextBox<double>("uTextBox", Validators.DefaultDoubleValidator, (value) => u = value);
            page1TableLayout.Add(uTextBox, 2, 4);

            // n1 input

            n1Label = new MyLabel("n1Label", "Частота вращения шестерни, об/мин");
            page1TableLayout.Add(n1Label, 3, 0);

            n1TextBox = new InputTextBox<double>("n1TextBox", Validators.DefaultDoubleValidator, (value) => n1 = value);
            page1TableLayout.Add(n1TextBox, 3, 4);

            // T1 input

            T1Label = new MyLabel("T1Label", "Крутящий момент на валу шестерни, Н*мм");
            page1TableLayout.Add(T1Label, 4, 0);

            T1TextBox = new InputTextBox<double>("T1TextBox", Validators.DefaultDoubleValidator, (value) => T1 = value);
            page1TableLayout.Add(T1TextBox, 4, 4);

            // th input

            thLabel = new MyLabel("thLabel", "Срок службы, ч");
            page1TableLayout.Add(thLabel, 5, 0);

            thTextBox = new InputTextBox<double>("thTextBox", Validators.DefaultDoubleValidator, (value) => th = value);
            page1TableLayout.Add(thTextBox, 5, 4);

            // CT input

            CTLabel = new MyLabel("CTLabel", "Степень точности");
            page1TableLayout.Add(CTLabel, 6, 0);

            CTTextBox = new InputTextBox<int>("CTTextBox", Validators.CTValidator, (value) => CT = value);
            page1TableLayout.Add(CTTextBox, 6, 4);

            // alpha input

            alphaLabel = new MyLabel("alphaLabel", "Угол между осями, град");
            page1TableLayout.Add(alphaLabel, 7, 0);

            alphaTextBox = new InputTextBox<double>("alphaTextBox", Validators.DefaultDoubleValidator, (value) => alpha = value);
            page1TableLayout.Add(alphaTextBox, 7, 4);

            //

            mainTableLayout.Add(pagesMainTableLayout[0], 0, 0);
            Controls.Add(mainTableLayout);
            ResumeLayout(false);
        }

        
    }
}

