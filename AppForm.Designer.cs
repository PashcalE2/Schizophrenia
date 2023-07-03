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

        private MyTableLayoutPanel[] pagesTableLayout = new MyTableLayoutPanel[15];
        private InputTextBox<double> uTextBox;

        private MyTableLayoutPanel buttonsTableLayout;
        private MyButton printButton;
        private MyButton backButton;
        private MyButton nextButton;

        // inputable variables
        private double u;

        private void InitializeChildren()
        {
            SuspendLayout();

            // 

            mainTableLayout = new MyTableLayoutPanel("mainTableLayout", 2, 1, DockStyle.Fill);

            // Buttons on the bottom

            buttonsTableLayout = new MyTableLayoutPanel("buttonsTableLayout", 1, 4, DockStyle.Fill);
            buttonsTableLayout.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100);

                printButton = new MyButton("printButton", "Печать");
            buttonsTableLayout.Add(printButton, 0, 0);

                backButton = new MyButton("backButton", "Назад");
            buttonsTableLayout.Add(backButton, 0, 2);

                nextButton = new MyButton("nextButton", "Далее");
            buttonsTableLayout.Add(nextButton, 0, 3);

            mainTableLayout.Add(buttonsTableLayout, 1, 0);

            //

            pagesTableLayout[0] = new MyTableLayoutPanel("page2TableLayout", 10, 4, DockStyle.Fill);
            pagesTableLayout[0].ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 100);

                uTextBox = new InputTextBox<double>("uTextBox", Validators.DefaultDoubleValidator, (value) => u = value);
            pagesTableLayout[0].Add(uTextBox, 0, 0);

            //


            //

            //

            mainTableLayout.Add(pagesTableLayout[0], 0, 0);
            Controls.Add(mainTableLayout);
            ResumeLayout(false);
        }

        
    }
}

