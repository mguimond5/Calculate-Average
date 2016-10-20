namespace MarkAssignment
{
    partial class frmCalculateAverage
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMarkOne = new System.Windows.Forms.TextBox();
            this.txtMarkTwo = new System.Windows.Forms.TextBox();
            this.txtMarkThree = new System.Windows.Forms.TextBox();
            this.txtMarkFour = new System.Windows.Forms.TextBox();
            this.txtMarkFive = new System.Windows.Forms.TextBox();
            this.lblMarkOne = new System.Windows.Forms.Label();
            this.lblMarkTwo = new System.Windows.Forms.Label();
            this.llbMarkThree = new System.Windows.Forms.Label();
            this.lblMarkFour = new System.Windows.Forms.Label();
            this.lblMarkFive = new System.Windows.Forms.Label();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(58, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(172, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Please fill out the information below";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtMarkOne
            // 
            this.txtMarkOne.Location = new System.Drawing.Point(130, 25);
            this.txtMarkOne.Name = "txtMarkOne";
            this.txtMarkOne.Size = new System.Drawing.Size(100, 20);
            this.txtMarkOne.TabIndex = 1;
            // 
            // txtMarkTwo
            // 
            this.txtMarkTwo.Location = new System.Drawing.Point(130, 51);
            this.txtMarkTwo.Name = "txtMarkTwo";
            this.txtMarkTwo.Size = new System.Drawing.Size(100, 20);
            this.txtMarkTwo.TabIndex = 2;
            // 
            // txtMarkThree
            // 
            this.txtMarkThree.Location = new System.Drawing.Point(130, 77);
            this.txtMarkThree.Name = "txtMarkThree";
            this.txtMarkThree.Size = new System.Drawing.Size(100, 20);
            this.txtMarkThree.TabIndex = 3;
            // 
            // txtMarkFour
            // 
            this.txtMarkFour.Location = new System.Drawing.Point(130, 103);
            this.txtMarkFour.Name = "txtMarkFour";
            this.txtMarkFour.Size = new System.Drawing.Size(100, 20);
            this.txtMarkFour.TabIndex = 4;
            // 
            // txtMarkFive
            // 
            this.txtMarkFive.Location = new System.Drawing.Point(130, 129);
            this.txtMarkFive.Name = "txtMarkFive";
            this.txtMarkFive.Size = new System.Drawing.Size(100, 20);
            this.txtMarkFive.TabIndex = 5;
            // 
            // lblMarkOne
            // 
            this.lblMarkOne.AutoSize = true;
            this.lblMarkOne.Location = new System.Drawing.Point(64, 28);
            this.lblMarkOne.Name = "lblMarkOne";
            this.lblMarkOne.Size = new System.Drawing.Size(43, 13);
            this.lblMarkOne.TabIndex = 6;
            this.lblMarkOne.Text = "Mark 1:";
            // 
            // lblMarkTwo
            // 
            this.lblMarkTwo.AutoSize = true;
            this.lblMarkTwo.Location = new System.Drawing.Point(64, 54);
            this.lblMarkTwo.Name = "lblMarkTwo";
            this.lblMarkTwo.Size = new System.Drawing.Size(43, 13);
            this.lblMarkTwo.TabIndex = 7;
            this.lblMarkTwo.Text = "Mark 2:";
            // 
            // llbMarkThree
            // 
            this.llbMarkThree.AutoSize = true;
            this.llbMarkThree.Location = new System.Drawing.Point(64, 80);
            this.llbMarkThree.Name = "llbMarkThree";
            this.llbMarkThree.Size = new System.Drawing.Size(43, 13);
            this.llbMarkThree.TabIndex = 8;
            this.llbMarkThree.Text = "Mark 3:";
            // 
            // lblMarkFour
            // 
            this.lblMarkFour.AutoSize = true;
            this.lblMarkFour.Location = new System.Drawing.Point(64, 106);
            this.lblMarkFour.Name = "lblMarkFour";
            this.lblMarkFour.Size = new System.Drawing.Size(43, 13);
            this.lblMarkFour.TabIndex = 9;
            this.lblMarkFour.Text = "Mark 4:";
            // 
            // lblMarkFive
            // 
            this.lblMarkFive.AutoSize = true;
            this.lblMarkFive.Location = new System.Drawing.Point(64, 132);
            this.lblMarkFive.Name = "lblMarkFive";
            this.lblMarkFive.Size = new System.Drawing.Size(43, 13);
            this.lblMarkFive.TabIndex = 10;
            this.lblMarkFive.Text = "Mark 5:";
            this.lblMarkFive.Click += new System.EventHandler(this.lblMarkFive_Click);
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.AutoSize = true;
            this.btnCalculateAverage.Location = new System.Drawing.Point(89, 155);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(104, 25);
            this.btnCalculateAverage.TabIndex = 11;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 192);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(260, 146);
            this.lblDisplay.TabIndex = 12;
            // 
            // frmCalculateAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.lblMarkFive);
            this.Controls.Add(this.lblMarkFour);
            this.Controls.Add(this.llbMarkThree);
            this.Controls.Add(this.lblMarkTwo);
            this.Controls.Add(this.lblMarkOne);
            this.Controls.Add(this.txtMarkFive);
            this.Controls.Add(this.txtMarkFour);
            this.Controls.Add(this.txtMarkThree);
            this.Controls.Add(this.txtMarkTwo);
            this.Controls.Add(this.txtMarkOne);
            this.Controls.Add(this.lblResult);
            this.Name = "frmCalculateAverage";
            this.Text = "Lets Check Our Marks!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMarkOne;
        private System.Windows.Forms.TextBox txtMarkTwo;
        private System.Windows.Forms.TextBox txtMarkThree;
        private System.Windows.Forms.TextBox txtMarkFour;
        private System.Windows.Forms.TextBox txtMarkFive;
        private System.Windows.Forms.Label lblMarkOne;
        private System.Windows.Forms.Label lblMarkTwo;
        private System.Windows.Forms.Label llbMarkThree;
        private System.Windows.Forms.Label lblMarkFour;
        private System.Windows.Forms.Label lblMarkFive;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblDisplay;
    }
}

