using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace BeikeCashier.Views.Cashier
{
    public class CashireUtil
    {
        public static bool MoneyInput(string beforeText)
        {
            bool canInput = false;
            int posDot = beforeText.IndexOf(".");
            if (beforeText.Equals("0"))
            {
                return canInput;
            }
            if (posDot <= 0)
            {
                canInput = true;
            }

            if (beforeText.Length - posDot - 1 < 2)
            {
                canInput = true;
            }

            return canInput;
        }


        public static void MoneyInput(TextBox tb, TextBox nextTb, string input)
        {
            if (input.Length == 1 && input.Equals("."))
            {
                tb.Text = "";
                return;
            }
            if (input.Length == 2 && input.IndexOf("0") == 0 && !input.Contains("."))
            {
                tb.Text = "0";
                tb.SelectionStart = tb.Text.Length;
                return;
            }

            if (input.Length > 1 && input.IndexOf(".") >= 0)
            {
                if (input.IndexOf(".", input.IndexOf(".") + 1) > 0)
                {
                    tb.Text = input.Substring(0, input.Length - 1);
                    tb.SelectionStart = tb.Text.Length;
                }
            }
            if (tb.Text.Length > 0 && double.Parse(tb.Text) > 200000)
            {
                nextTb.Focus();
                tb.Text = "200000";
                tb.SelectionStart = tb.Text.Length;
            }
            int posDot = input.IndexOf(".");
            if (posDot <= 0)
            {
                return;
            }

            if (input.Length - posDot - 1 > 2)
            {
                tb.Text = input.Substring(0, input.Length - 1);
                nextTb.Focus();
                tb.SelectionStart = tb.Text.Length;
            }
        }


        public static string Caculator(string expression)
        {
            List<string> numb = new List<string>();
            List<char> oprator = new List<char>();

            string temp = "";
            foreach (char item in expression)
            {
                if (item.Equals('x') || item.Equals('+'))
                {
                    oprator.Add(item);
                    numb.Add(temp);
                    temp = "";
                }
                else
                {
                    temp += item;
                }
            }
            if (temp != "")
            {
                numb.Add(temp);
            }
            for (int i = 0; i < oprator.Count; i++)
            {
                if (oprator[i].Equals('x'))
                {
                    double result = Double.Parse(numb[i]) * Double.Parse(numb[i + 1]);
                    numb[i + 1] = result.ToString();
                    numb[i] = "0";
                }
            }
            double result2 = 0;
            foreach (string item in numb)
            {
                result2 += Double.Parse(item);
            }

            return result2.ToString();
        }
    }
}
