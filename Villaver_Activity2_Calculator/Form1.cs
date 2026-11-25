using System;
using System.Drawing;
using System.Windows.Forms;

namespace Villaver_Activity2_Calculator
{
    public partial class Form1 : Form
    {
        private readonly Calculator calculator = new Calculator();
        private readonly Font largeDisplay;
        private readonly Font mediumDisplay = new Font("Segoe UI", 18, FontStyle.Bold);
        private readonly Font smallDisplay = new Font("Segoe UI", 12, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            largeDisplay = display.Font;
            Disposed += DisposeDisplayFonts;
        }

        private void KeypadButtonClick(object sender, EventArgs e)
        {
            Press(((Button)sender).Text);
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            string key;

            switch (keyData)
            {
                case Keys.Enter: key = "="; break;
                case Keys.Escape: key = "C"; break;
                case Keys.Delete: key = "CE"; break;
                case Keys.Back: key = "⌫"; break;
                default: return base.ProcessCmdKey(ref message, keyData);
            }

            Press(key);
            return true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            string key;

            switch (e.KeyChar)
            {
                case '*': key = "×"; break;
                case '/': key = "÷"; break;
                case '-': key = "−"; break;
                case '+': case '=': case '.': case '%': key = e.KeyChar.ToString(); break;
                default:
                    if (e.KeyChar < '0' || e.KeyChar > '9')
                    {
                        base.OnKeyPress(e);
                        return;
                    }

                    key = e.KeyChar.ToString();
                    break;
            }

            Press(key);
            e.Handled = true;
        }

        private void Press(string key)
        {
            calculator.Press(key);
            expression.Text = calculator.Expression;
            display.Text = calculator.Display;
            display.Font = display.Text.Length <= 13 ? largeDisplay
                : display.Text.Length <= 23 ? mediumDisplay : smallDisplay;
        }

        private void DisposeDisplayFonts(object sender, EventArgs e)
        {
            largeDisplay.Dispose();
            mediumDisplay.Dispose();
            smallDisplay.Dispose();
        }
    }
}
