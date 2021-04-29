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
            string formula = FormulaBox.Text;
            var expr = new Expression(formula);
            List<double> terms = new List<double>();

            for (int i = int.Parse(InitValueBox.Text); i <= int.Parse(UpperBoundBox.Text); i++)
            {
                expr.Parameters["i"] = i;

                //expr.EvaluateFunction += delegate (string name, FunctionArgs args)
                //{
                //    if (name == "Factorial")
                //        args.Result = (int)args.Parameters[0].Evaluate() + (int)args.Parameters[1].Evaluate();
                //};
                //Func<int> f = expr.ToLambda<int>();
                terms.Add(double.Parse(expr.Evaluate().ToString()));
                total += double.Parse(expr.Evaluate().ToString());
            }

            //formula.IndexOf('!');
            //while (formula.Contains("!"))
            //{
            //    formula = formula.Replace("!", "factorial()");
            //}

            ResultLabel.Text = total.ToString();
        }
    }
}
