namespace Calculator
{
    partial class FormCalculatorWFApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculatorWFApp));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDecimalPoint = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonOneDivideByAnotherExpression = new System.Windows.Forms.Button();
            this.buttonClearing = new System.Windows.Forms.Button();
            this.buttonRemainder = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtDisplay, "txtDisplay");
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            this.txtDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisplay_KeyDown);
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // buttonOne
            // 
            resources.ApplyResources(this.buttonOne, "buttonOne");
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonTwo
            // 
            resources.ApplyResources(this.buttonTwo, "buttonTwo");
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonThree
            // 
            resources.ApplyResources(this.buttonThree, "buttonThree");
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonFour
            // 
            resources.ApplyResources(this.buttonFour, "buttonFour");
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonFive
            // 
            resources.ApplyResources(this.buttonFive, "buttonFive");
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonSix
            // 
            resources.ApplyResources(this.buttonSix, "buttonSix");
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonSeven
            // 
            resources.ApplyResources(this.buttonSeven, "buttonSeven");
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonEight
            // 
            resources.ApplyResources(this.buttonEight, "buttonEight");
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonNine
            // 
            resources.ApplyResources(this.buttonNine, "buttonNine");
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonZero
            // 
            resources.ApplyResources(this.buttonZero, "buttonZero");
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonEquals
            // 
            resources.ApplyResources(this.buttonEquals, "buttonEquals");
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonDecimalPoint
            // 
            resources.ApplyResources(this.buttonDecimalPoint, "buttonDecimalPoint");
            this.buttonDecimalPoint.Name = "buttonDecimalPoint";
            this.buttonDecimalPoint.UseVisualStyleBackColor = true;
            this.buttonDecimalPoint.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonPlus
            // 
            resources.ApplyResources(this.buttonPlus, "buttonPlus");
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonMinus
            // 
            resources.ApplyResources(this.buttonMinus, "buttonMinus");
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonDivision
            // 
            resources.ApplyResources(this.buttonDivision, "buttonDivision");
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonMultiplication
            // 
            resources.ApplyResources(this.buttonMultiplication, "buttonMultiplication");
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonSqrt
            // 
            resources.ApplyResources(this.buttonSqrt, "buttonSqrt");
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonOneDivideByAnotherExpression
            // 
            resources.ApplyResources(this.buttonOneDivideByAnotherExpression, "buttonOneDivideByAnotherExpression");
            this.buttonOneDivideByAnotherExpression.Name = "buttonOneDivideByAnotherExpression";
            this.buttonOneDivideByAnotherExpression.UseVisualStyleBackColor = true;
            this.buttonOneDivideByAnotherExpression.Click += new System.EventHandler(this.buttonOneDivideByAnotherExpression_Click);
            // 
            // buttonClearing
            // 
            resources.ApplyResources(this.buttonClearing, "buttonClearing");
            this.buttonClearing.Name = "buttonClearing";
            this.buttonClearing.UseVisualStyleBackColor = true;
            this.buttonClearing.Click += new System.EventHandler(this.buttonClearing_Click);
            // 
            // buttonRemainder
            // 
            resources.ApplyResources(this.buttonRemainder, "buttonRemainder");
            this.buttonRemainder.Name = "buttonRemainder";
            this.buttonRemainder.UseVisualStyleBackColor = true;
            this.buttonRemainder.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // buttonBackspace
            // 
            resources.ApplyResources(this.buttonBackspace, "buttonBackspace");
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonPlusMinus
            // 
            resources.ApplyResources(this.buttonPlusMinus, "buttonPlusMinus");
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // FormCalculatorWFApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonRemainder);
            this.Controls.Add(this.buttonClearing);
            this.Controls.Add(this.buttonOneDivideByAnotherExpression);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDecimalPoint);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.txtDisplay);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormCalculatorWFApp";
            this.Load += new System.EventHandler(this.FormCalculatorWFApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDecimalPoint;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonOneDivideByAnotherExpression;
        private System.Windows.Forms.Button buttonClearing;
        private System.Windows.Forms.Button buttonRemainder;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonPlusMinus;
    }
}

