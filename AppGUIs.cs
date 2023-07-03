using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Schizophrenia
{
    public static class CustomColors
    {
        public static readonly Color ErrorTextBoxColor = Color.FromArgb(255, 255, 127, 64);
        public static readonly Color EmptyTextBoxColor = Color.FromArgb(255, 223, 223, 255);
        public static readonly Color ValidTextBoxColor = SystemColors.Window;
    }

    public static class DefaultSizes
    {
        public static readonly Size TextBox = new Size(130, 40);
        public static readonly Size Button = new Size(80, 30);
    }

    public static class DefaultFonts
    {
        public static readonly Font Any = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
    }
    
    public class InputTextBox<T> : TextBox
    {
        private T Value;
        private Action<T> OutterVauleSetter;
        private AnyValidator<T> Validator;
        private bool IsValid;

        public InputTextBox(string name, AnyValidator<T> validator, Action<T> outterVauleSetter)
        {
            Validator = validator;
            OutterVauleSetter = outterVauleSetter;

            Name = name;
            Size = DefaultSizes.TextBox;
            Font = DefaultFonts.Any;

            BackColor = CustomColors.EmptyTextBoxColor;

            TextChanged += new EventHandler(ValidateText);
        }

        private void ValidateText(object sender, EventArgs e)
        {
            IsValid = Validator.Validate(Text);

            if (Text == "")
            {
                BackColor = CustomColors.EmptyTextBoxColor;
            }
            else
            {
                if (IsValid)
                {
                    Value = Validator.GetResult();
                    BackColor = CustomColors.ValidTextBoxColor;
                }
                else
                {
                    Value = default(T);
                    BackColor = CustomColors.ErrorTextBoxColor;
                }
            }

            OutterVauleSetter.Invoke(Value);
        }

        public T getValue()
        {
            return Value;
        }

        public void SetValue(T value)
        {
            Value = value;
            Text = value.ToString();
        }
    }

    public class MyButton : Button
    {
        public MyButton(string name, string text)
        {
            DefaultInit(name, text);
            Size = DefaultSizes.Button;
        }

        public MyButton(string name, string text, Size size)
        {
            DefaultInit(name, text);
            Size = size;
        }

        private void DefaultInit(string name, string text)
        {
            Name = name;
            Font = DefaultFonts.Any;
            Text = text;
            UseVisualStyleBackColor = true;
        }
    }

    public class MyTableLayoutPanel : TableLayoutPanel
    {

        public MyTableLayoutPanel(string name, int rowCount, int columnCount)
        {
            DefaultInit(name, rowCount, columnCount);
        }

        public MyTableLayoutPanel(string name, int rowCount, int columnCount, DockStyle dock)
        {
            DefaultInit(name, rowCount, columnCount);
            Dock = dock;
        }

        public void DefaultInit(string name, int rowCount, int columnCount)
        {
            Name = name;
            RowCount = rowCount;
            ColumnCount = columnCount;

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            for (int i = 0; i < columnCount; i++)
            {
                ColumnStyles.Add(new ColumnStyle());
            }

            for (int i = 0; i < rowCount; i++)
            {
                RowStyles.Add(new ColumnStyle());
            }
        }

        public void Add(Control control, int row, int column)
        {
            Controls.Add(control, column, row);
        }

        public void Add(List<Control> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                Add(matrix[i], i / ColumnCount, i % ColumnCount);
            }
        }
    }
}
