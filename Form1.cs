using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SigmaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            var expr = new Expression(FormulaBox.Text);

            for (int i = int.Parse(InitValueBox.Text); i <= int.Parse(UpperBoundBox.Text); i++)
            {
                expr.Parameters["i"] = i;

                expr.EvaluateFunction += delegate (string name, FunctionArgs args)
                {
                    if (name == "fact")
                    {
                        BigInteger argsFactorial = 1;

                        for (int i = 2; i <= (int)args.Parameters[0].Evaluate(); i++)
                        {
                            argsFactorial *= i;
                        }
                        args.Result = argsFactorial;
                    }
                };
                total += double.Parse(expr.Evaluate().ToString());
            }
            ResultLabel.Text = total.ToString();
        }
    }
}
