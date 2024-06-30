using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Schizophrenia {
    public static class DefaultColors {
        public static readonly Color ErrorTextBoxColor = Color.FromArgb(255, 255, 127, 64);
        public static readonly Color EmptyTextBoxColor = Color.FromArgb(255, 223, 239, 255);
        public static readonly Color ValidTextBoxColor = SystemColors.Window;
        public static readonly Color AlwaysDisabledTextBoxColor = Color.FromArgb(255, 223, 255, 191);
        public static readonly Color NowDisabledTextBoxColor = Color.FromArgb(255, 239, 223, 255);
    }

    public static class DefaultSizes {
        public static readonly Size TextBox = new Size(130, 40);
        public static readonly Size Button = new Size(80, 30);
        public static readonly Size ComboBox = new Size(130, 40);
    }

    public static class DefaultFonts {
        public static readonly Font Any = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
    }

    public class MyRadioButton : RadioButton {
        public MyRadioButton(string name, string text) {
            AutoSize = true;
            Font = DefaultFonts.Any;
            Name = name;
            Text = text;
        }
    }

    public class OutputTextBox : TextBox {
        public OutputTextBox(string name) {
            Name = name;
            Size = DefaultSizes.TextBox;
            Font = DefaultFonts.Any;
            BackColor = DefaultColors.AlwaysDisabledTextBoxColor;
            Enabled = false;
        }
    }

    public class InputTextBox<T> : TextBox {
        private AnyValidator<T> Validator;
        private T Value;
        private bool IsValid;
        private List<Action<T>> TextValidated;
        private ToolTip HintToolTip;
        private string Hint;

        public InputTextBox(string name, AnyValidator<T> validator) {
            DefaultInit(name, validator, new List<Action<T>>(2));
        }

        public InputTextBox(string name, AnyValidator<T> validator, Action<T> textValidated) {
            DefaultInit(name, validator, new List<Action<T>>(2) { textValidated });
        }

        public InputTextBox(string name, AnyValidator<T> validator, List<Action<T>> textValidated) {
            DefaultInit(name, validator, textValidated);
        }

        public InputTextBox(string name, AnyValidator<T> validator, Action<T> textValidated, string hint) {
            DefaultInit(name, validator, new List<Action<T>>(2) { textValidated });
            HintInit(hint);
        }

        public InputTextBox(string name, AnyValidator<T> validator, List<Action<T>> textValidated, string hint) {
            DefaultInit(name, validator, textValidated);
            HintInit(hint);
        }

        private void DefaultInit(string name, AnyValidator<T> validator, List<Action<T>> textValidated) {
            Validator = validator;
            TextValidated = textValidated;

            Name = name;
            Size = DefaultSizes.TextBox;
            Font = DefaultFonts.Any;

            BackColor = DefaultColors.EmptyTextBoxColor;

            TextChanged += new EventHandler(ValidateText);
            EnabledChanged += new EventHandler(EnabledChangedHandler);
        }

        private void HintInit(string hint) {
            HintToolTip = new ToolTip();
            HintToolTip.AutomaticDelay = 0;
            HintToolTip.AutoPopDelay = 10000;
            HintToolTip.ReshowDelay = 0;
            HintToolTip.UseFading = false;

            Hint = hint;

            Enter += new EventHandler(ShowHint);
            Leave += new EventHandler(HideHint);
        }

        private void ValidateText(object sender, EventArgs e) {
            if (!Enabled) {
                return;
            }

            IsValid = Validator.Validate(Text);

            if (Text == "") {
                BackColor = DefaultColors.EmptyTextBoxColor;
                Value = default(T);
            }
            else {
                if (IsValid) {
                    Value = Validator.GetResult();
                    BackColor = DefaultColors.ValidTextBoxColor;
                }
                else {
                    Value = default(T);
                    BackColor = DefaultColors.ErrorTextBoxColor;
                }
            }

            for (int i = 0; i < TextValidated.Count; i++) {
                TextValidated[i].Invoke(Value);
            }
        }

        public void PushTextValidatedHandler(Action<T> action) {
            TextValidated.Add(action);
        }

        public void PopTextValidatedHandler() {
            TextValidated.RemoveAt(TextValidated.Count - 1);
        }

        private void EnabledChangedHandler(object sender, EventArgs e) {
            if (Enabled) {
                ValidateText(sender, e);
            }
            else {
                BackColor = DefaultColors.NowDisabledTextBoxColor;
            }
        }

        private void ShowHint(object sender, EventArgs e) {
            HintToolTip.Show(Hint, this);
        }

        private void HideHint(object sender, EventArgs e) {
            HintToolTip.Hide(this);
        }

        public T GetValue() {
            return Value;
        }

        public void SetValue(T value) {
            Value = value;
            Text = value.ToString();

            for (int i = 0; i < TextValidated.Count; i++) {
                TextValidated[i].Invoke(Value);
            }
        }

        public bool GetIsValid() {
            return IsValid;
        }
    }

    public class MyButton : Button {
        public MyButton(string name, string text) {
            DefaultInit(name, text);
            Size = DefaultSizes.Button;
        }

        public MyButton(string name, string text, Size size) {
            DefaultInit(name, text);
            Size = size;
        }

        private void DefaultInit(string name, string text) {
            Font = DefaultFonts.Any;
            Name = name;
            Text = text;
            UseVisualStyleBackColor = true;
        }
    }

    public class MyTableLayoutPanel : TableLayoutPanel {

        public MyTableLayoutPanel(string name, int rowCount, int columnCount) {
            DefaultInit(name, rowCount, columnCount);
            Dock = DockStyle.Fill;
        }

        public MyTableLayoutPanel(string name, int rowCount, int columnCount, DockStyle dock) {
            DefaultInit(name, rowCount, columnCount);
            Dock = dock;
        }

        public void DefaultInit(string name, int rowCount, int columnCount) {
            Name = name;
            RowCount = rowCount;
            ColumnCount = columnCount;

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Margin = new Padding(3);
            Padding = new Padding(3);
            // CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int i = 0; i < columnCount; i++) {
                ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                //ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0));
            }

            for (int i = 0; i < rowCount; i++) {
                RowStyles.Add(new RowStyle(SizeType.AutoSize));
                //RowStyles.Add(new RowStyle(SizeType.Percent, 100.0));
            }
        }

        public void Add(Control control, int row, int column) {
            Controls.Add(control, column, row);
        }

        public void Add(List<Control> matrix) {
            for (int i = 0; i < matrix.Count; i++) {
                Add(matrix[i], i / ColumnCount, i % ColumnCount);
            }
        }
    }

    public class MyComboBox : ComboBox {
        public MyComboBox(string name) {
            Font = DefaultFonts.Any;
            Name = name;
            Size = DefaultSizes.ComboBox;
            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }

    public class MyLabel : Label {
        public MyLabel(string name, string text) {
            AutoSize = true;
            Font = DefaultFonts.Any;
            Name = name;
            Text = text;
        }

        public string GetText() {
            return Text.Trim(':');
        }
    }
}
