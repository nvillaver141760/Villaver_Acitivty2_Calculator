using System.Drawing;
using System.Windows.Forms;

namespace Villaver_Activity2_Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layout;
        private Label heading;
        private Panel displayPanel;
        private Label display;
        private Label expression;
        private TableLayoutPanel keypad;
        private Button clearButton;
        private Button clearEntryButton;
        private Button backspaceButton;
        private Button divideButton;
        private Button percentButton;
        private Button squareButton;
        private Button squareRootButton;
        private Button multiplyButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button subtractButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button addButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button reciprocalButton;
        private Button signButton;
        private Button zeroButton;
        private Button decimalButton;
        private Button equalsButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.layout = new TableLayoutPanel();
            this.heading = new Label();
            this.displayPanel = new Panel();
            this.display = new Label();
            this.expression = new Label();
            this.keypad = new TableLayoutPanel();
            this.clearButton = new Button();
            this.clearEntryButton = new Button();
            this.backspaceButton = new Button();
            this.divideButton = new Button();
            this.percentButton = new Button();
            this.squareButton = new Button();
            this.squareRootButton = new Button();
            this.multiplyButton = new Button();
            this.sevenButton = new Button();
            this.eightButton = new Button();
            this.nineButton = new Button();
            this.subtractButton = new Button();
            this.fourButton = new Button();
            this.fiveButton = new Button();
            this.sixButton = new Button();
            this.addButton = new Button();
            this.oneButton = new Button();
            this.twoButton = new Button();
            this.threeButton = new Button();
            this.reciprocalButton = new Button();
            this.signButton = new Button();
            this.zeroButton = new Button();
            this.decimalButton = new Button();
            this.equalsButton = new Button();
            this.layout.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.keypad.SuspendLayout();
            this.SuspendLayout();

            // Main layout
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.layout.Dock = DockStyle.Fill;
            this.layout.Name = "layout";
            this.layout.Controls.Add(this.heading, 0, 0);
            this.layout.Controls.Add(this.displayPanel, 0, 1);
            this.layout.Controls.Add(this.keypad, 0, 2);

            // Heading
            this.heading.BackColor = Color.FromArgb(101, 58, 158);
            this.heading.Dock = DockStyle.Fill;
            this.heading.ForeColor = Color.White;
            this.heading.Margin = new Padding(0);
            this.heading.Name = "heading";
            this.heading.Padding = new Padding(17, 0, 0, 0);
            this.heading.Text = "Calculator";
            this.heading.TextAlign = ContentAlignment.MiddleLeft;

            // Display
            this.displayPanel.BackColor = Color.White;
            this.displayPanel.BorderStyle = BorderStyle.FixedSingle;
            this.displayPanel.Dock = DockStyle.Fill;
            this.displayPanel.Margin = new Padding(13, 12, 13, 5);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Padding = new Padding(10, 5, 10, 4);
            this.displayPanel.Controls.Add(this.display);
            this.displayPanel.Controls.Add(this.expression);

            this.display.AccessibleName = "Calculator display";
            this.display.Dock = DockStyle.Fill;
            this.display.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.display.ForeColor = Color.FromArgb(51, 33, 74);
            this.display.Name = "display";
            this.display.Text = "0";
            this.display.TextAlign = ContentAlignment.MiddleRight;

            this.expression.AutoEllipsis = true;
            this.expression.Dock = DockStyle.Top;
            this.expression.ForeColor = Color.FromArgb(103, 82, 125);
            this.expression.Height = 24;
            this.expression.Name = "expression";
            this.expression.TextAlign = ContentAlignment.MiddleRight;

            // Keypad
            this.keypad.ColumnCount = 4;
            this.keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.keypad.RowCount = 6;
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            this.keypad.Dock = DockStyle.Fill;
            this.keypad.Margin = new Padding(10, 3, 10, 10);
            this.keypad.Name = "keypad";
            this.keypad.Controls.Add(this.clearButton, 0, 0);
            this.keypad.Controls.Add(this.clearEntryButton, 1, 0);
            this.keypad.Controls.Add(this.backspaceButton, 2, 0);
            this.keypad.Controls.Add(this.divideButton, 3, 0);
            this.keypad.Controls.Add(this.percentButton, 0, 1);
            this.keypad.Controls.Add(this.squareButton, 1, 1);
            this.keypad.Controls.Add(this.squareRootButton, 2, 1);
            this.keypad.Controls.Add(this.multiplyButton, 3, 1);
            this.keypad.Controls.Add(this.sevenButton, 0, 2);
            this.keypad.Controls.Add(this.eightButton, 1, 2);
            this.keypad.Controls.Add(this.nineButton, 2, 2);
            this.keypad.Controls.Add(this.subtractButton, 3, 2);
            this.keypad.Controls.Add(this.fourButton, 0, 3);
            this.keypad.Controls.Add(this.fiveButton, 1, 3);
            this.keypad.Controls.Add(this.sixButton, 2, 3);
            this.keypad.Controls.Add(this.addButton, 3, 3);
            this.keypad.Controls.Add(this.oneButton, 0, 4);
            this.keypad.Controls.Add(this.twoButton, 1, 4);
            this.keypad.Controls.Add(this.threeButton, 2, 4);
            this.keypad.Controls.Add(this.reciprocalButton, 3, 4);
            this.keypad.Controls.Add(this.signButton, 0, 5);
            this.keypad.Controls.Add(this.zeroButton, 1, 5);
            this.keypad.Controls.Add(this.decimalButton, 2, 5);
            this.keypad.Controls.Add(this.equalsButton, 3, 5);

            // clearButton
            this.clearButton.AccessibleName = "Clear";
            this.clearButton.BackColor = Color.FromArgb(235, 225, 248);
            this.clearButton.Dock = DockStyle.Fill;
            this.clearButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.clearButton.FlatStyle = FlatStyle.Flat;
            this.clearButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.clearButton.Margin = new Padding(3);
            this.clearButton.Name = "clearButton";
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // clearEntryButton
            this.clearEntryButton.AccessibleName = "Clear entry";
            this.clearEntryButton.BackColor = Color.FromArgb(235, 225, 248);
            this.clearEntryButton.Dock = DockStyle.Fill;
            this.clearEntryButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.clearEntryButton.FlatStyle = FlatStyle.Flat;
            this.clearEntryButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.clearEntryButton.Margin = new Padding(3);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.TabIndex = 1;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // backspaceButton
            this.backspaceButton.AccessibleName = "Backspace";
            this.backspaceButton.BackColor = Color.FromArgb(235, 225, 248);
            this.backspaceButton.Dock = DockStyle.Fill;
            this.backspaceButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.backspaceButton.FlatStyle = FlatStyle.Flat;
            this.backspaceButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.backspaceButton.Margin = new Padding(3);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.TabIndex = 2;
            this.backspaceButton.Text = "⌫";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // divideButton
            this.divideButton.AccessibleName = "Divide";
            this.divideButton.BackColor = Color.FromArgb(235, 225, 248);
            this.divideButton.Dock = DockStyle.Fill;
            this.divideButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.divideButton.FlatStyle = FlatStyle.Flat;
            this.divideButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.divideButton.Margin = new Padding(3);
            this.divideButton.Name = "divideButton";
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // percentButton
            this.percentButton.AccessibleName = "Percent";
            this.percentButton.BackColor = Color.FromArgb(235, 225, 248);
            this.percentButton.Dock = DockStyle.Fill;
            this.percentButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.percentButton.FlatStyle = FlatStyle.Flat;
            this.percentButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.percentButton.Margin = new Padding(3);
            this.percentButton.Name = "percentButton";
            this.percentButton.TabIndex = 4;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // squareButton
            this.squareButton.AccessibleName = "Square";
            this.squareButton.BackColor = Color.FromArgb(235, 225, 248);
            this.squareButton.Dock = DockStyle.Fill;
            this.squareButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.squareButton.FlatStyle = FlatStyle.Flat;
            this.squareButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.squareButton.Margin = new Padding(3);
            this.squareButton.Name = "squareButton";
            this.squareButton.TabIndex = 5;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // squareRootButton
            this.squareRootButton.AccessibleName = "Square root";
            this.squareRootButton.BackColor = Color.FromArgb(235, 225, 248);
            this.squareRootButton.Dock = DockStyle.Fill;
            this.squareRootButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.squareRootButton.FlatStyle = FlatStyle.Flat;
            this.squareRootButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.squareRootButton.Margin = new Padding(3);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.TabIndex = 6;
            this.squareRootButton.Text = "√x";
            this.squareRootButton.UseVisualStyleBackColor = false;
            this.squareRootButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // multiplyButton
            this.multiplyButton.AccessibleName = "Multiply";
            this.multiplyButton.BackColor = Color.FromArgb(235, 225, 248);
            this.multiplyButton.Dock = DockStyle.Fill;
            this.multiplyButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.multiplyButton.FlatStyle = FlatStyle.Flat;
            this.multiplyButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.multiplyButton.Margin = new Padding(3);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // sevenButton
            this.sevenButton.BackColor = Color.White;
            this.sevenButton.Dock = DockStyle.Fill;
            this.sevenButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.sevenButton.FlatStyle = FlatStyle.Flat;
            this.sevenButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.sevenButton.Margin = new Padding(3);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // eightButton
            this.eightButton.BackColor = Color.White;
            this.eightButton.Dock = DockStyle.Fill;
            this.eightButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.eightButton.FlatStyle = FlatStyle.Flat;
            this.eightButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.eightButton.Margin = new Padding(3);
            this.eightButton.Name = "eightButton";
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // nineButton
            this.nineButton.BackColor = Color.White;
            this.nineButton.Dock = DockStyle.Fill;
            this.nineButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.nineButton.FlatStyle = FlatStyle.Flat;
            this.nineButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.nineButton.Margin = new Padding(3);
            this.nineButton.Name = "nineButton";
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // subtractButton
            this.subtractButton.AccessibleName = "Subtract";
            this.subtractButton.BackColor = Color.FromArgb(235, 225, 248);
            this.subtractButton.Dock = DockStyle.Fill;
            this.subtractButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.subtractButton.FlatStyle = FlatStyle.Flat;
            this.subtractButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.subtractButton.Margin = new Padding(3);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Text = "−";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // fourButton
            this.fourButton.BackColor = Color.White;
            this.fourButton.Dock = DockStyle.Fill;
            this.fourButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.fourButton.FlatStyle = FlatStyle.Flat;
            this.fourButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.fourButton.Margin = new Padding(3);
            this.fourButton.Name = "fourButton";
            this.fourButton.TabIndex = 12;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // fiveButton
            this.fiveButton.BackColor = Color.White;
            this.fiveButton.Dock = DockStyle.Fill;
            this.fiveButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.fiveButton.FlatStyle = FlatStyle.Flat;
            this.fiveButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.fiveButton.Margin = new Padding(3);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.TabIndex = 13;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // sixButton
            this.sixButton.BackColor = Color.White;
            this.sixButton.Dock = DockStyle.Fill;
            this.sixButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.sixButton.FlatStyle = FlatStyle.Flat;
            this.sixButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.sixButton.Margin = new Padding(3);
            this.sixButton.Name = "sixButton";
            this.sixButton.TabIndex = 14;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // addButton
            this.addButton.AccessibleName = "Add";
            this.addButton.BackColor = Color.FromArgb(235, 225, 248);
            this.addButton.Dock = DockStyle.Fill;
            this.addButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.addButton.FlatStyle = FlatStyle.Flat;
            this.addButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.addButton.Margin = new Padding(3);
            this.addButton.Name = "addButton";
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // oneButton
            this.oneButton.BackColor = Color.White;
            this.oneButton.Dock = DockStyle.Fill;
            this.oneButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.oneButton.FlatStyle = FlatStyle.Flat;
            this.oneButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.oneButton.Margin = new Padding(3);
            this.oneButton.Name = "oneButton";
            this.oneButton.TabIndex = 16;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // twoButton
            this.twoButton.BackColor = Color.White;
            this.twoButton.Dock = DockStyle.Fill;
            this.twoButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.twoButton.FlatStyle = FlatStyle.Flat;
            this.twoButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.twoButton.Margin = new Padding(3);
            this.twoButton.Name = "twoButton";
            this.twoButton.TabIndex = 17;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // threeButton
            this.threeButton.BackColor = Color.White;
            this.threeButton.Dock = DockStyle.Fill;
            this.threeButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.threeButton.FlatStyle = FlatStyle.Flat;
            this.threeButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.threeButton.Margin = new Padding(3);
            this.threeButton.Name = "threeButton";
            this.threeButton.TabIndex = 18;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // reciprocalButton
            this.reciprocalButton.AccessibleName = "Reciprocal";
            this.reciprocalButton.BackColor = Color.FromArgb(235, 225, 248);
            this.reciprocalButton.Dock = DockStyle.Fill;
            this.reciprocalButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.reciprocalButton.FlatStyle = FlatStyle.Flat;
            this.reciprocalButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.reciprocalButton.Margin = new Padding(3);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.TabIndex = 19;
            this.reciprocalButton.Text = "1/x";
            this.reciprocalButton.UseVisualStyleBackColor = false;
            this.reciprocalButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // signButton
            this.signButton.AccessibleName = "Change sign";
            this.signButton.BackColor = Color.FromArgb(235, 225, 248);
            this.signButton.Dock = DockStyle.Fill;
            this.signButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.signButton.FlatStyle = FlatStyle.Flat;
            this.signButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.signButton.Margin = new Padding(3);
            this.signButton.Name = "signButton";
            this.signButton.TabIndex = 20;
            this.signButton.Text = "±";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // zeroButton
            this.zeroButton.BackColor = Color.White;
            this.zeroButton.Dock = DockStyle.Fill;
            this.zeroButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.zeroButton.FlatStyle = FlatStyle.Flat;
            this.zeroButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.zeroButton.Margin = new Padding(3);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.TabIndex = 21;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // decimalButton
            this.decimalButton.AccessibleName = "Decimal point";
            this.decimalButton.BackColor = Color.White;
            this.decimalButton.Dock = DockStyle.Fill;
            this.decimalButton.FlatAppearance.BorderColor = Color.FromArgb(209, 190, 230);
            this.decimalButton.FlatStyle = FlatStyle.Flat;
            this.decimalButton.ForeColor = Color.FromArgb(51, 33, 74);
            this.decimalButton.Margin = new Padding(3);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.TabIndex = 22;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // equalsButton
            this.equalsButton.AccessibleName = "Equals";
            this.equalsButton.BackColor = Color.FromArgb(101, 58, 158);
            this.equalsButton.Dock = DockStyle.Fill;
            this.equalsButton.FlatAppearance.BorderColor = Color.FromArgb(101, 58, 158);
            this.equalsButton.FlatStyle = FlatStyle.Flat;
            this.equalsButton.ForeColor = Color.White;
            this.equalsButton.Margin = new Padding(3);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.TabIndex = 23;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.KeypadButtonClick);

            // Form1
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.FromArgb(247, 241, 252);
            this.ClientSize = new Size(364, 506);
            this.Controls.Add(this.layout);
            this.Font = new Font("Segoe UI", 11F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Violet Calculator";
            this.layout.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.keypad.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
