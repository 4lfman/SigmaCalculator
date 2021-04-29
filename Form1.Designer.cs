
namespace SigmaCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpperBoundBox = new System.Windows.Forms.TextBox();
            this.InitValueBox = new System.Windows.Forms.TextBox();
            this.FormulaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StepsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpperBoundBox
            // 
            this.UpperBoundBox.Location = new System.Drawing.Point(51, 27);
            this.UpperBoundBox.Name = "UpperBoundBox";
            this.UpperBoundBox.Size = new System.Drawing.Size(100, 23);
            this.UpperBoundBox.TabIndex = 1;
            // 
            // InitValueBox
            // 
            this.InitValueBox.Location = new System.Drawing.Point(51, 184);
            this.InitValueBox.Name = "InitValueBox";
            this.InitValueBox.Size = new System.Drawing.Size(100, 23);
            this.InitValueBox.TabIndex = 0;
            // 
            // FormulaBox
            // 
            this.FormulaBox.Location = new System.Drawing.Point(213, 103);
            this.FormulaBox.Name = "FormulaBox";
            this.FormulaBox.Size = new System.Drawing.Size(292, 23);
            this.FormulaBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 125);
            this.label1.TabIndex = 3;
            this.label1.Text = "Σ";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(213, 262);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(13, 15);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "0";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(381, 184);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "i =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "The sum is:";
            // 
            // StepsButton
            // 
            this.StepsButton.Location = new System.Drawing.Point(381, 214);
            this.StepsButton.Name = "StepsButton";
            this.StepsButton.Size = new System.Drawing.Size(75, 23);
            this.StepsButton.TabIndex = 8;
            this.StepsButton.Text = "Show steps";
            this.StepsButton.UseVisualStyleBackColor = true;
            this.StepsButton.Click += new System.EventHandler(this.StepsButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 315);
            this.Controls.Add(this.StepsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormulaBox);
            this.Controls.Add(this.InitValueBox);
            this.Controls.Add(this.UpperBoundBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Sigma Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpperBoundBox;
        private System.Windows.Forms.TextBox InitValueBox;
        private System.Windows.Forms.TextBox FormulaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StepsButton;
    }
}

