using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SimplaeCalculator
{
    public partial class Form1 : Form
    {
        int flg = 0;
        int cnt = 0;  
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void MoveCursorToLeft()
        {
            if (textBox1.SelectionStart > 0)
            {
                textBox1.SelectionStart -= 1; // Move cursor one position to the left
                textBox1.ScrollToCaret();
            }
        }

        private void MoveCursorToRight()
        {
            if (textBox1.SelectionStart < textBox1.Text.Length)
            {
                textBox1.SelectionStart += 1; // Move cursor one position to the right
                textBox1.ScrollToCaret();
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            int cursorPosition = textBox1.SelectionStart;
            // Check if left mouse button is clicked
            if ((keys == Keys.LButton) || (keys == Keys.Left))
            {
                MoveCursorToLeft();
                return true; // Indicate that the key was processed
            }
            // Check if right mouse button is clicked
            else if ((keys == Keys.RButton) || (keys == Keys.Right))
            {
                MoveCursorToRight();
                return true; // Indicate that the key was processed
            }
            else
            {
                switch (keys)
                {
                    case Keys.Return:
                        equal_to.PerformClick();
                        return true;
                    case Keys.D0:
                        zero.PerformClick();
                        return true;
                    case Keys.D1:
                        one.PerformClick();
                        return true;
                    case Keys.D2:
                        two.PerformClick();
                        return true;
                    case Keys.D3:
                        three.PerformClick();
                        return true;
                    case Keys.D4:
                        four.PerformClick();
                        return true;
                    case Keys.D5:
                        five.PerformClick();
                        return true;
                    case Keys.D6:
                        six.PerformClick();
                        return true;
                    case Keys.D7:
                        seven.PerformClick();
                        return true;
                    case Keys.D8:
                        eight.PerformClick();
                        return true;
                    case Keys.D9:
                        nine.PerformClick();
                        return true;
                    case Keys.Back:
                        Delete.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.OemPeriod:
                        full_stp.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.Oemplus:
                        add.PerformClick();
                        return true;
                    case Keys.OemMinus:
                        sub.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.D8:
                        mul.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Oem2:
                        div.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.D9:
                        opn_crly_brac.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.D0:
                        clos_crly_brac.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.D5:
                        Mod.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.Oemcomma:
                        left_shft.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    case Keys.Shift | Keys.OemPeriod:
                        right_shft.PerformClick();
                        textBox1.SelectionStart = textBox1.Text.Length;
                        return true;
                    default:
                        return true; // Indicate that the key was processed}
                }
            }
        }

        static bool IsOperator(char c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '+':
                case '-':
                case 'x':
                case '/':
                case '%':
                case '<':
                case '>':
                    return true;
                default:
                    return false;
            }
        }

        private int Precedence(char op)
        {
            switch (op)
            {
                case '/':
                case 'x':
                case '%':
                    return 3;
                case '+':
                case '-':
                    return 2;
                case '<':
                case '>':
                    return 1; // Assuming bitwise shift operators have lower precedence than arithmetic operators
                default:
                    return 0;
            }
        }

        private double ApplyOperator(char op, double operand1, double operand2)
        {
            flg = 0;
            switch (op)
            {
                case '/':
                    if (operand2 != 0)
                    {
                        double result = 0;
                        if (operand2 < 0) // Check if the denominator is negative
                        {
                            // Make the result negative if the denominator is negative
                            result = -Math.Abs(operand1) / Math.Abs(operand2);
                        }
                        else
                        {
                            result = operand1 / operand2;
                        }
                        return result;
                    }                        
                    else
                    {
                        flg = 1;
                        return -1;
                    }  
                case 'x': return operand1 * operand2;
                case '%':
                    if (operand2 != 0)
                    {
                        double result = 0;
                        result = operand1 % operand2;
                        return result;
                    }
                    else
                    {
                        flg = 1;
                        return -1;
                    }
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '<': 
                    if(operand1< 0 || operand2 < 0)
                    {
                        flg = 1;
                        return -1;
                    }
                    else if(operand2 == 0)
                    {
                        return operand1;
                    }
                    else
                    {
                        int i = Convert.ToInt32(operand1);
                        int j = Convert.ToInt32(operand2);
                        return i << j; // Bitwise left shift
                    }
                case '>':
                    if (operand1 < 0 || operand2 < 0)
                    {
                        flg = 1;
                        return -1;
                    }
                    else if (operand2 == 0)
                    {
                        return operand1;
                    }
                    else
                    {
                        int i = Convert.ToInt32(operand1);
                        int j = Convert.ToInt32(operand2);
                        return i >> j; // Bitwise right shift
                    }
                default:
                    flg = 1;
                    return -1;
            }
        }

        private int getOperatorCount(string values)
        {
            int count = 0;
            int i = 0;
            for(i=0;i<values.Length;i++)
            {
                if (IsOperator(values[i]) && !values.StartsWith("-"))
                {
                    count++;
                }
            }
            return count;
        }

        private string Calc_Substring(string values)
        {
            Stack<double> operandStack = new Stack<double>();
            Stack<char> operatorStack = new Stack<char>();
            double result = 0;

            for (int i = 0; i < values.Length; i++)
            {
                char c = values[i];
                result = 0;
                if (char.IsDigit(c) || (c == '-' && (i == 0 || !char.IsDigit(values[i - 1]))) || ((values[i - 1] == '/' || values[i - 1] == '+' || values[i - 1] == '-') && values[i] == '-') || (c == '.'))
                {
                    // Extract the entire operand
                    string operand = "";
                    while ((i < values.Length) && ((char.IsDigit(values[i]) || values[i] == '.' || (i == 0 && values[i] == '-')) || (values[i - 1] == '/' && values[i] == '-') || ((values[i - 1] == '/' || values[i - 1] == '+' || values[i - 1] == '-' || values[i - 1] == 'x') && values[i] == '-')))
                    {
                        operand += values[i];
                        i++;
                    }
                    i--; // Move back one position to process the next character correctly

                    operandStack.Push(double.Parse(operand));
                }
                else if (IsOperator(c))
                {
                    if (operatorStack.Count == 0)
                    {
                        operatorStack.Push(c);
                        continue;
                    }
                    while (operatorStack.Count > 0 && Precedence(c) <= Precedence(operatorStack.Peek()))
                    {
                        char op = operatorStack.Pop();
                        if (operandStack.Count < 2)
                        {
                            break;
                        }
                        double operand2 = operandStack.Pop();
                        double operand1 = operandStack.Pop();
                        result = ApplyOperator(op, operand1, operand2);
                        if (result == float.NaN) { textBox1.Text = "Result not defined";
                        }
                        else
                            operandStack.Push(result);
                    }
                    operatorStack.Push(c);
                }
            }

            while (operatorStack.Count > 0)
            {
                char op = operatorStack.Pop();
                double operand2 = operandStack.Pop();
                double operand1 = operandStack.Pop();
                result = ApplyOperator(op, operand1, operand2);
                if (result == double.NaN || result == -1) { return "-1"; }
                else
                    operandStack.Push(result);
            }

            
            // The result will be the only value left on the operand stack
            return operandStack.Pop().ToString();
        }

        private void Calculate(string value)
        {
            string subStr = "";
            int index = 0, h = 0;
            int fl = 0;
            Stack<int> stack = new Stack<int>();
            for (h = 0; h < value.Length; h++)
            {
                subStr = "";
                if((h+1)!=value.Length)
                {
                    if (char.IsDigit(value[h]) && value[h + 1] == '(')
                    {
                        value = value.Insert(h + 1, "x");
                        h = 0;
                    }
                    if (value[h] == ')' && char.IsDigit(value[h + 1]))
                    {
                        value = value.Insert(h + 1, "x");
                    }
                }

                if (value[h] == '(')
                {
                    if(fl == 1)
                    {
                        fl = 0;
                        value = value.Insert(h, "x");
                        continue;
                    }
                    cnt += 1;
                    stack.Push(h);
                }
                else if (value[h] == ')')
                {
                    if(stack.Count == 0)
                    {
                        textBox1.Text = "Invalid Syntax";
                        return;
                    }
                    if (stack.Count == 1)
                    {                        
                        index = stack.Peek();
                        
                        subStr = value.Substring(index + 1, h - index - 1);
                        subStr = Calc_Substring(subStr);
                        if(subStr.StartsWith("-"))
                        {
                            if (index == 0 && stack.Count == 1)
                            {
                                value = value.Remove(index, h - index + 1);
                                value = value.Insert(index, subStr);
                            }
                            else if (!char.IsDigit(value[index - 1]) && ((index-1)>=0))
                            {
                                if (getOperatorCount(subStr) == 0 && subStr.StartsWith("-"))
                                {
                                    value = value.Remove(index, h - index + 1);
                                    value = value.Insert(index, subStr);
                                }
                                else
                                {
                                    value = value.Remove(index - 1, h - index + 2);
                                    value = value.Insert(index - 1, subStr);
                                }
                            }
                            else
                            {
                                value = value.Remove(index, h - index + 1);
                                value = value.Insert(index, subStr);
                            }
                        }
                        else
                        {
                            value = value.Remove(index, h - index + 1);
                            value = value.Insert(index, subStr);
                        }
                        
                        index = stack.Pop();
                        if(stack.Count == 0)
                        {
                            h = 0;
                            if (value[h+1] == '(')
                            {
                                fl = 1;
                            }
                        }
                        else
                        {
                            h = stack.Peek();
                        }
                    }
                    else
                    {
                        index = stack.Pop();
                        subStr = value.Substring(index + 1, h - index - 1);
                        if (getOperatorCount(subStr) == 0 && subStr.StartsWith("-"))
                        {
                            value = value.Remove(index , h - index + 1);
                            value = value.Insert(index, subStr);
                        }
                        else
                        {
                            subStr = Calc_Substring(subStr);
                            value = value.Remove(index, h - index + 1);
                            value = value.Insert(index, subStr);
                        }
                        h = stack.Peek();
                    }
                    cnt -= 1;
                }
            }
            string output = "";
            if (stack.Count == 0)
            {
                output = Calc_Substring(value);
                if (output == "-1")
                {
                    textBox1.Text = "Result not defined";
                }
                else
                {
                    textBox1.Text = output;
                }
            }
            else
            {
                textBox1.Text = "Invalid Syntax";
            }
        }

        private void SetTextUserNum(string value)
        {
            int cursorPosition = textBox1.SelectionStart; // Get the current cursor position

            // Check if the cursor is at the end or if the textbox is empty
            if (cursorPosition == textBox1.Text.Length || textBox1.Text == "")
            {
                // If the textbox is empty and the value is an operator, return without inserting
                if (textBox1.Text == "" && (value == "+" || value == "-" || value == "/" || value == "x" || value == "%" || value == "<<" || value == ">>"))
                    return;

                // Otherwise, append the value at the end of the textbox
                textBox1.BeginInvoke((MethodInvoker)delegate {
                    textBox1.Text += value;
                });
            }
            else
            {
                // Insert the value at the cursor position
                textBox1.BeginInvoke((MethodInvoker)delegate {
                    textBox1.Text = textBox1.Text.Insert(cursorPosition, value);
                });
            }
        }


        private void MoveCursorToEnd()
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = textBox1.SelectionStart;
            if(cursorPosition+1 == textBox1.Text.Length && textBox1.Text.Length == 0)
            {
                MoveCursorToEnd();
                return;
            }
            else
            {
                MoveCursorToEnd();
            }
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            string userid = one.Text;
            SetTextUserNum(userid);
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void two_Click(object sender, EventArgs e)
        {
            string userid = two.Text;
            SetTextUserNum(userid);
        }

        private void three_Click(object sender, EventArgs e)
        {
            string userid = three.Text;
            SetTextUserNum(userid);
        }

        private void four_Click(object sender, EventArgs e)
        {
            string userid = four.Text;
            SetTextUserNum(userid);
        }

        private void five_Click(object sender, EventArgs e)
        {
            string userid = five.Text;
            SetTextUserNum(userid);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            string userid = seven.Text;
            SetTextUserNum(userid);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            string userid = eight.Text;
            SetTextUserNum(userid);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            string userid = nine.Text;
            SetTextUserNum(userid);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            string userid = zero.Text;
            SetTextUserNum(userid);
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Clear();
            if (string.IsNullOrEmpty(str) || str == "-")
            {
                // If so, set the textbox value to "-"
                SetTextUserNum("-");
            }
            else
            {
                if (str.StartsWith("-"))
                {
                    str = str.Substring(1);
                }
                else
                {
                    str = "-" + str;
                }

                SetTextUserNum(str);
            }
        }


        private void full_stp_Click(object sender, EventArgs e)
        {
            string st = full_stp.Text;
            if (textBox1.Text == "")
            {
                st = "0" + st;
                SetTextUserNum(st);
                return;
            }
            string text = textBox1.Text;
            int lstindex = text.Length;
            if (text.EndsWith("/") || text.EndsWith("+") || text.EndsWith("-") || text.EndsWith("%") || text.EndsWith("x") || text.EndsWith("<<") || text.EndsWith(">>"))
            {
                st = "0" + st;
                text = text.Insert(lstindex, st);
            }
            else if(text.EndsWith("."))
            {
                return;
            }
            else
            {
                text = text.Insert(lstindex, st);
            }
            textBox1.Text= text;
            //SetTextUserNum(text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                string s = "0" + "+";
                SetTextUserNum(s);
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = add.Text;
            SetTextUserNum(userid);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                string s = "0" + "-";
                SetTextUserNum(s);
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = sub.Text;
            SetTextUserNum(userid);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = mul.Text;
            SetTextUserNum(userid);
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = div.Text;
            SetTextUserNum(userid);
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = Mod.Text;
            SetTextUserNum(userid);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if(text.Length == 0)
            {
                return ;
            }
            if(text.EndsWith("<<")||text.EndsWith(">>"))
            {
                text = text.Remove(text.Length - 2);
                textBox1.Text = text;
                return;
            }
            text = text.Remove(text.Length-1);
            textBox1.Text = text;
        }

        private void equal_to_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string userid = textBox1.Text;
            if(userid.EndsWith("/") || userid.EndsWith("+") || userid.EndsWith("-") || userid.EndsWith("%") || userid.EndsWith("x") || userid.EndsWith("<<") || userid.EndsWith(">>"))
            {
                userid = userid.Remove(userid.Length - 1);
                textBox1.Text = userid;
            }
            if (userid.EndsWith("."))
            {
                userid = userid + "00";
                textBox1.Text += "00";
            }
            Calculate(userid);
        }

        private void clos_crly_brac_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x") || st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            string userid = clos_crly_brac.Text;
            SetTextUserNum(userid);
        }

        private void opn_crly_brac_Click(object sender, EventArgs e)
        {
            string userid = opn_crly_brac.Text;
            SetTextUserNum(userid);
        }

        private void right_shft_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            else if(st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 2);
                textBox1.Text = st;
            }
            string userid = right_shft.Text;
            SetTextUserNum(userid);
        }

        private void left_shft_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            string st = textBox1.Text;
            if (st.EndsWith("/") || st.EndsWith("+") || st.EndsWith("-") || st.EndsWith("%") || st.EndsWith("x"))
            {
                st = st.Remove(st.Length - 1);
                textBox1.Text = st;
            }
            else if (st.EndsWith("<<") || st.EndsWith(">>"))
            {
                st = st.Remove(st.Length - 2);
                textBox1.Text = st;
            }
            string userid = left_shft.Text;
            SetTextUserNum(userid);
        }

        private void six_Click(object sender, EventArgs e)
        {
            string userid = six.Text;
            SetTextUserNum(userid);
        }
    }
}
