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
        List<double> terms = new List<double>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            var expr = new Expression(FormulaBox.Text);
            terms.Clear();
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
                double value = double.Parse(expr.Evaluate().ToString());
                terms.Add(value);
                total += value;
            }
            ResultLabel.Text = total.ToString();
        }

        private void StepsButton_Click(object sender, EventArgs e)
        {
            CalculateButton_Click(this, e);
            MessageBox.Show(string.Join(" + ", terms), "Steps");
        }
    }
}
