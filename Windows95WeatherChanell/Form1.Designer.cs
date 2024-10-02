namespace Windows95WeatherChanell
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            wil = new Label();
            groupBox2 = new GroupBox();
            temp = new Label();
            groupBox4 = new GroupBox();
            cis = new Label();
            groupBox5 = new GroupBox();
            test = new RichTextBox();
            button1 = new Button();
            testbutton = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dzisiejsza prognoza pogody :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(wil);
            groupBox3.Location = new Point(0, 103);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 49);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "wilgotność :";
            // 
            // wil
            // 
            wil.AutoSize = true;
            wil.Location = new Point(6, 19);
            wil.Name = "wil";
            wil.Size = new Size(38, 15);
            wil.TabIndex = 1;
            wil.Text = "label2";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(temp);
            groupBox2.Location = new Point(12, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 49);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "temperatura :";
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Location = new Point(6, 19);
            temp.Name = "temp";
            temp.Size = new Size(38, 15);
            temp.TabIndex = 0;
            temp.Text = "label1";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Info;
            groupBox4.Controls.Add(cis);
            groupBox4.Location = new Point(12, 197);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 51);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "opady atmosferyczne :";
            // 
            // cis
            // 
            cis.AutoSize = true;
            cis.Location = new Point(6, 19);
            cis.Name = "cis";
            cis.Size = new Size(38, 15);
            cis.TabIndex = 2;
            cis.Text = "label3";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(test);
            groupBox5.Location = new Point(12, 355);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 308);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // test
            // 
            test.Location = new Point(6, 22);
            test.Name = "test";
            test.ReadOnly = true;
            test.Size = new Size(764, 280);
            test.TabIndex = 0;
            test.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(11, 284);
            button1.Name = "button1";
            button1.Size = new Size(777, 23);
            button1.TabIndex = 4;
            button1.Text = "odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += pogodaDisplay;
            // 
            // testbutton
            // 
            testbutton.Location = new Point(12, 321);
            testbutton.Name = "testbutton";
            testbutton.Size = new Size(777, 23);
            testbutton.TabIndex = 5;
            testbutton.Text = "Test";
            testbutton.UseVisualStyleBackColor = true;
            testbutton.Click += butttonTest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 665);
            Controls.Add(testbutton);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private Label temp;
        private GroupBox groupBox3;
        private Label wil;
        private Label cis;
        private RichTextBox test;
        private Button button1;
        private Button testbutton;


    }
}
