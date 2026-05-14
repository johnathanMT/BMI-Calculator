namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtWeight = new Label();
            txtHeight = new Label();
            groupBox1 = new GroupBox();
            rbMetric = new RadioButton();
            rbImperial = new RadioButton();
            btnConvert = new Button();
            lblBMIResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.AutoSize = true;
            txtWeight.Location = new Point(182, 33);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(78, 15);
            txtWeight.TabIndex = 2;
            txtWeight.Text = "Enter Weight:";
            // 
            // txtHeight
            // 
            txtHeight.AutoSize = true;
            txtHeight.Location = new Point(182, 101);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(76, 15);
            txtHeight.TabIndex = 3;
            txtHeight.Text = "Enter Height:";
            txtHeight.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMetric);
            groupBox1.Controls.Add(rbImperial);
            groupBox1.Location = new Point(130, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 122);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Measure Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbMetric
            // 
            rbMetric.AutoSize = true;
            rbMetric.Location = new Point(219, 79);
            rbMetric.Name = "rbMetric";
            rbMetric.Size = new Size(54, 19);
            rbMetric.TabIndex = 1;
            rbMetric.TabStop = true;
            rbMetric.Text = "kg/m";
            rbMetric.UseVisualStyleBackColor = true;
            // 
            // rbImperial
            // 
            rbImperial.AutoSize = true;
            rbImperial.Location = new Point(219, 22);
            rbImperial.Name = "rbImperial";
            rbImperial.Size = new Size(74, 19);
            rbImperial.TabIndex = 0;
            rbImperial.TabStop = true;
            rbImperial.Text = "lb/inches";
            rbImperial.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(292, 284);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(192, 45);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // lblBMIResult
            // 
            lblBMIResult.AutoSize = true;
            lblBMIResult.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBMIResult.Location = new Point(222, 348);
            lblBMIResult.MaximumSize = new Size(400, 200);
            lblBMIResult.MinimumSize = new Size(400, 200);
            lblBMIResult.Name = "lblBMIResult";
            lblBMIResult.Size = new Size(400, 200);
            lblBMIResult.TabIndex = 6;
            lblBMIResult.Text = "Your BMI = xxx";
            lblBMIResult.TextAlign = ContentAlignment.TopCenter;
            lblBMIResult.Click += lblBMIResult_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(775, 571);
            Controls.Add(lblBMIResult);
            Controls.Add(btnConvert);
            Controls.Add(groupBox1);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "BMI Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label txtWeight;
        private Label txtHeight;
        private GroupBox groupBox1;
        private RadioButton rbMetric;
        private RadioButton rbImperial;
        private Button btnConvert;
        private Label lblBMIResult;
    }
}
