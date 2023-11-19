using System.Windows.Forms;
using System;
using Schizophrenia.Main.Pages;
using System.Collections.Generic;
using System.Linq;

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

        public Dictionary<PageID, AnyPage> pages;
        public AnyPage currentPage;

        public Stack<Context> contextHistory = new Stack<Context>(15);
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

        public string Title = "Приложение";

        public void InitializeChildren()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));

            SuspendLayout();

            Size = new System.Drawing.Size(1008, 682);
            MaximumSize = Size;
            MinimumSize = Size;
            //AutoSize = true;
            //AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // BEGIN

            contextHistory.Push(context);

            mainTableLayout = new MyTableLayoutPanel("mainTableLayout", 2, 1, DockStyle.Fill);

            toolTip = new ToolTip();
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 10000;
            toolTip.ReshowDelay = 0;
            toolTip.UseFading = false;


            // Buttons on the bottom (and every page, actually)

            buttonsTableLayout = new MyTableLayoutPanel("buttonsTableLayout", 1, 3, DockStyle.Fill);
            buttonsTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);

            printButton = new MyButton("printButton", "Печать");
            printButton.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            // printButton.Enabled = false;
            printButton.Click += new System.EventHandler(printButton_Click);
            buttonsTableLayout.Add(printButton, 0, 0);

            backButton = new MyButton("backButton", "Назад");
            backButton.Anchor = AnchorStyles.Bottom;
            backButton.Click += new System.EventHandler(backButton_Click);
            buttonsTableLayout.Add(backButton, 0, 1);

            nextButton = new MyButton("nextButton", "Далее");
            nextButton.Anchor = AnchorStyles.Bottom;
            nextButton.Click += new System.EventHandler(nextButton_Click);
            buttonsTableLayout.Add(nextButton, 0, 2);

            mainTableLayout.Add(buttonsTableLayout, 1, 0);

            // Pages

            page1 = new Page1(this, PageID.Page1);
            page2 = new Page2(this, PageID.Page2);
            page3 = new Page3(this, PageID.Page3);
            page4 = new Page4(this, PageID.Page4);
            page5 = new Page5(this, PageID.Page5);
            page6 = new Page6(this, PageID.Page6);
            page7 = new Page7(this, PageID.Page7);
            page8 = new Page8(this, PageID.Page8);
            page9 = new Page9(this, PageID.Page9);
            page10 = new Page10(this, PageID.Page10);
            page11 = new Page11(this, PageID.Page11);
            page12 = new Page12(this, PageID.Page12);
            page13 = new Page13(this, PageID.Page13);
            page14 = new Page14(this, PageID.Page14);
            page15 = new Page15(this, PageID.Page15);

            pages = new Dictionary<PageID, AnyPage>()
            {
                [page1.ID] = page1,
                [page2.ID] = page2,
                [page3.ID] = page3,
                [page4.ID] = page4,
                [page5.ID] = page5,
                [page6.ID] = page6,
                [page7.ID] = page7,
                [page8.ID] = page8,
                [page9.ID] = page9,
                [page10.ID] = page10,
                [page11.ID] = page11,
                [page12.ID] = page12,
                [page13.ID] = page13,
                [page14.ID] = page14,
                [page15.ID] = page15
            };

            currentPage = page1;
            mainTableLayout.Add(page1.mainTableLayout, 0, 0);
            Controls.Add(mainTableLayout);

            SetTitle(currentPage);

            ResumeLayout(false);
        }

        public void SetTitle(AnyPage page)
        {
            Text = String.Format("{0} | Страница {1}", Title, page.ID);
        }
    }
}

