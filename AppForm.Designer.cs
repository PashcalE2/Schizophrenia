using System.Windows.Forms;
using System;
using Schizophrenia.Main.Pages;
using System.Collections.Generic;

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

        public Stack<Context> contextHistory = new Stack<Context>(1);
        public Context context = new Context();

        public Page1 page1;
        public Page2 page2;
        public Page3 page3;
        public Page4 page4;
        public Page5 page5;
        public Page6 page6;
        public Page7 page7;
        public Page8 page8;
        public Page9 page9;
        public Page10 page10;
        public Page11 page11;
        public Page12 page12;
        public Page13 page13;
        public Page14 page14;
        public Page15 page15;

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

            page2 = new Page2(this);
            pagesMainTableLayout[1] = page2.mainTableLayout;

            page3 = new Page3(this);
            pagesMainTableLayout[2] = page3.mainTableLayout;

            page4 = new Page4(this);
            pagesMainTableLayout[3] = page4.mainTableLayout;

            page5 = new Page5(this);
            pagesMainTableLayout[4] = page5.mainTableLayout;

            page6 = new Page6(this);
            pagesMainTableLayout[5] = page6.mainTableLayout;

            page7 = new Page7(this);
            pagesMainTableLayout[6] = page7.mainTableLayout;

            page8 = new Page8(this);
            pagesMainTableLayout[7] = page8.mainTableLayout;

            page9 = new Page9(this);
            pagesMainTableLayout[8] = page9.mainTableLayout;

            page10 = new Page10(this);
            pagesMainTableLayout[9] = page10.mainTableLayout;

            page11 = new Page11(this);
            pagesMainTableLayout[10] = page11.mainTableLayout;

            page12 = new Page12(this);
            pagesMainTableLayout[11] = page12.mainTableLayout;

            page13 = new Page13(this);
            pagesMainTableLayout[12] = page13.mainTableLayout;

            page14 = new Page14(this);
            pagesMainTableLayout[13] = page14.mainTableLayout;

            page15 = new Page15(this);
            pagesMainTableLayout[14] = page15.mainTableLayout;

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

