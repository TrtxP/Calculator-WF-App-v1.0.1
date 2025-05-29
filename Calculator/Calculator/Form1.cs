using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculatorWFApp : Form
    {
        public FormCalculatorWFApp()
        {
            InitializeComponent();
        }

        private void FormCalculatorWFApp_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            txtDisplay.Text = "0";

            txtDisplay.SelectionStart = txtDisplay.Text.Length;
            txtDisplay.SelectionLength = 0;

            this.ActiveControl = null;
        }

        private bool isInternalChange = false;
        bool criticalError = false;
        bool isResultDisplayed = false;
        double num;
        double result;

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == null) return;

            string currentText = txtDisplay.Text;
            string newChar = btn.Text;

            if (txtDisplay.Text.StartsWith("Error")) return;

            if (isResultDisplayed)
            {
                if (char.IsDigit(newChar[0]) || newChar == ".")
                {
                    txtDisplay.Text = newChar == "." ? "0." : newChar;
                    isResultDisplayed = false;
                }
                else
                {
                    isResultDisplayed = false;
                    txtDisplay.Text += newChar;
                }
                return;
            }

            if (currentText == "0" && char.IsDigit(newChar[0]))
            {
                txtDisplay.Text = newChar;
                return;
            }

            if ("+-*/.%".Contains(newChar))
            {
                if (currentText.Length > 0 && "+-*/.%".Contains(currentText[currentText.Length - 1].ToString()))
                {
                    return;
                }
            }


            if (newChar == ".")
            {
                string[] parts = currentText.Split(new char[] { '+', '-', '*', '/', '%' });
                string lastPart = parts.Length > 0 ? parts[parts.Length - 1] : "";

                if (lastPart.Contains("."))
                {
                    return;
                }
            }

            txtDisplay.Text += newChar;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out num) && num != 0)
            {
                txtDisplay.Text = (Math.Sqrt(num)).ToString();
                isResultDisplayed = true;
            }
        }


        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out num))
            {
                num = -num;
                txtDisplay.Text = num.ToString();
                isResultDisplayed = true;
            }
        }

        private void buttonOneDivideByAnotherExpression_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out num))
            {
                if (num == 0)
                {
                    txtDisplay.Text = "Error: Division by Zero";
                    criticalError = true;
                    return;
                }

                double result = 1 / num;

                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    txtDisplay.Text = "Error: Division by Zero";
                    criticalError = true;
                    return;
                }

                txtDisplay.Text = result.ToString();
                criticalError = false;
                isResultDisplayed = true;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            criticalError = false;

            try
            {
                var resultObj = new System.Data.DataTable().Compute(txtDisplay.Text, null);
                double doubleResult = Convert.ToDouble(resultObj);

                if (double.IsInfinity(doubleResult) || double.IsNaN(doubleResult))
                {
                    txtDisplay.Text = "Error: Division by Zero";
                    criticalError = true;
                }
                else
                {
                    txtDisplay.Text = resultObj.ToString();
                    isResultDisplayed = true;
                }
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Error: Division by Zero";
                criticalError = true;
            }
            catch
            {
                txtDisplay.Text = "Error: Invalid Expression";
                criticalError = true;
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("Error")) return;

            if (txtDisplay.Text == result.ToString())
            {
                return;
            }

            if (txtDisplay.Text.Length <= 1)
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void buttonClearing_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
        }

        private void CalculateExpression(string expression)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                txtDisplay.Text = result.ToString();
            }
            catch (Exception)
            {
                txtDisplay.Text = "Error: Invalid Expression";
                criticalError = true;
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (isInternalChange) return; 

            if (txtDisplay.Text.StartsWith("Error")) return;

            int cursorPos = txtDisplay.SelectionStart;

            string cleanedText = Regex.Replace(txtDisplay.Text, @"[^0-9+\-*/.%]", "");

            if (txtDisplay.Text != cleanedText)
            {
                isInternalChange = true; 

                txtDisplay.Text = cleanedText;

                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.SelectionLength = 0;

                isInternalChange = false; 
            }
            else
            {
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.SelectionLength = 0;
            }
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                criticalError = false;

                try
                {
                    var resultObj = new System.Data.DataTable().Compute(txtDisplay.Text, null);
                    double doubleResult = Convert.ToDouble(resultObj);

                    if (double.IsInfinity(doubleResult) || double.IsNaN(doubleResult))
                    {
                        txtDisplay.Text = "Error: Division by Zero";
                        criticalError = true;
                    }
                    else
                    {
                        txtDisplay.Text = doubleResult.ToString();
                        isResultDisplayed = true;

                        CalculateExpression(txtDisplay.Text);
                    }
                }
                catch (DivideByZeroException)
                {
                    txtDisplay.Text = "Error: Division by Zero";
                    criticalError = true;
                }
                catch
                {
                    txtDisplay.Text = "Error: Invalid Expression";
                    criticalError = true;
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }


            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string currentText = txtDisplay.Text;

                if (currentText == "0" || currentText.StartsWith("Error"))
                {
                    return;
                }

                if (currentText.Length <= 1)
                {
                    txtDisplay.Text = "0";
                }
                else
                {
                    txtDisplay.Text = currentText.Substring(0, currentText.Length - 1);
                }
            }
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;
            string currentText = txtDisplay.Text;

            string allowedChars = "0123456789+-*/.%\b";

            if (!allowedChars.Contains(inputChar.ToString()))
            {
                e.Handled = true;
                return;
            }

            if (isResultDisplayed && (char.IsDigit(inputChar) || inputChar == '.'))
            {
                txtDisplay.Text = inputChar == '.' ? "0." : inputChar.ToString();
                e.Handled = true;
                isResultDisplayed = false;

                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.SelectionLength = 0;

                return;
            }

            if (isResultDisplayed && "+-*/.%".Contains(inputChar.ToString()))
            {
                isResultDisplayed = false;
                txtDisplay.Text += inputChar;
                e.Handled = true;

                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.SelectionLength = 0;

                return;
            }

            if (char.IsDigit(inputChar))
            {
                if (currentText == "0" && !currentText.Contains("."))
                {
                    txtDisplay.Text = inputChar.ToString();
                    e.Handled = true;

                    txtDisplay.SelectionStart = txtDisplay.Text.Length;
                    txtDisplay.SelectionLength = 0;
                }

                return;
            }

            if ("+-*/.%".Contains(inputChar.ToString()))
            {
                if (currentText.Length > 0 && "+-*/.%".Contains(currentText[currentText.Length - 1].ToString()))
                {
                    e.Handled = true;
                    return;
                }
            }


            if (inputChar == '.')
            {
                string[] parts = currentText.Split(new char[] { '+', '-', '*', '/', '%' });
                string lastPart = parts.Length > 0 ? parts[parts.Length - 1] : "";
                if (lastPart.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
