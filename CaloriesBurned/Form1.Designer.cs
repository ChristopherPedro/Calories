namespace CaloriesBurned
{
    partial class frmCalories
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.ExercisegroupBox = new System.Windows.Forms.GroupBox();
            this.rdbRowing = new System.Windows.Forms.RadioButton();
            this.rdbRunning = new System.Windows.Forms.RadioButton();
            this.rdbCycling = new System.Windows.Forms.RadioButton();
            this.btnCalories = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ExercisegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(26, 43);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(50, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight : ";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(83, 35);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 1;
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(189, 42);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(19, 13);
            this.lblKG.TabIndex = 2;
            this.lblKG.Text = "kg";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(29, 113);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(179, 251);
            this.lstOutput.TabIndex = 3;
            // 
            // ExercisegroupBox
            // 
            this.ExercisegroupBox.Controls.Add(this.rdbRowing);
            this.ExercisegroupBox.Controls.Add(this.rdbRunning);
            this.ExercisegroupBox.Controls.Add(this.rdbCycling);
            this.ExercisegroupBox.Location = new System.Drawing.Point(347, 43);
            this.ExercisegroupBox.Name = "ExercisegroupBox";
            this.ExercisegroupBox.Size = new System.Drawing.Size(109, 119);
            this.ExercisegroupBox.TabIndex = 4;
            this.ExercisegroupBox.TabStop = false;
            this.ExercisegroupBox.Text = "Exercise";
            // 
            // rdbRowing
            // 
            this.rdbRowing.AutoSize = true;
            this.rdbRowing.Location = new System.Drawing.Point(7, 79);
            this.rdbRowing.Name = "rdbRowing";
            this.rdbRowing.Size = new System.Drawing.Size(61, 17);
            this.rdbRowing.TabIndex = 2;
            this.rdbRowing.TabStop = true;
            this.rdbRowing.Text = "Rowing";
            this.rdbRowing.UseVisualStyleBackColor = true;
            this.rdbRowing.CheckedChanged += new System.EventHandler(this.rdbRowing_CheckedChanged);
            // 
            // rdbRunning
            // 
            this.rdbRunning.AutoSize = true;
            this.rdbRunning.Location = new System.Drawing.Point(7, 55);
            this.rdbRunning.Name = "rdbRunning";
            this.rdbRunning.Size = new System.Drawing.Size(65, 17);
            this.rdbRunning.TabIndex = 1;
            this.rdbRunning.TabStop = true;
            this.rdbRunning.Text = "Running";
            this.rdbRunning.UseVisualStyleBackColor = true;
            this.rdbRunning.CheckedChanged += new System.EventHandler(this.rdbRunning_CheckedChanged);
            // 
            // rdbCycling
            // 
            this.rdbCycling.AutoSize = true;
            this.rdbCycling.Location = new System.Drawing.Point(7, 31);
            this.rdbCycling.Name = "rdbCycling";
            this.rdbCycling.Size = new System.Drawing.Size(59, 17);
            this.rdbCycling.TabIndex = 0;
            this.rdbCycling.TabStop = true;
            this.rdbCycling.Text = "Cycling";
            this.rdbCycling.UseVisualStyleBackColor = true;
            this.rdbCycling.CheckedChanged += new System.EventHandler(this.rdbCycling_CheckedChanged);
            // 
            // btnCalories
            // 
            this.btnCalories.Location = new System.Drawing.Point(347, 268);
            this.btnCalories.Name = "btnCalories";
            this.btnCalories.Size = new System.Drawing.Size(109, 37);
            this.btnCalories.TabIndex = 5;
            this.btnCalories.Text = "Show Calories burned";
            this.btnCalories.UseVisualStyleBackColor = true;
            this.btnCalories.Click += new System.EventHandler(this.btnCalories_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalories);
            this.Controls.Add(this.ExercisegroupBox);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.lblWeight);
            this.Name = "frmCalories";
            this.Text = "Calories burned through exercise";
            this.Load += new System.EventHandler(this.frmCalories_Load);
            this.ExercisegroupBox.ResumeLayout(false);
            this.ExercisegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox ExercisegroupBox;
        private System.Windows.Forms.RadioButton rdbRowing;
        private System.Windows.Forms.RadioButton rdbRunning;
        private System.Windows.Forms.RadioButton rdbCycling;
        private System.Windows.Forms.Button btnCalories;
        private System.Windows.Forms.Button btnExit;
    }
}

