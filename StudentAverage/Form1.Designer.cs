namespace StudentAverage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            txtMateria1 = new TextBox();
            txtMateria2 = new TextBox();
            txtMateria3 = new TextBox();
            txtMateria4 = new TextBox();
            txtMateria5 = new TextBox();
            txtMateria6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your name, carrer and qualifications";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 43);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Carrer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 107);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Spanish";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 146);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Math";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 181);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 5;
            label6.Text = "Programation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 215);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Chemistry";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 246);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 7;
            label8.Text = "Accounting";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 282);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 8;
            label9.Text = "Physical";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(387, 42);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 10;
            // 
            // txtMateria1
            // 
            txtMateria1.Location = new Point(124, 99);
            txtMateria1.Name = "txtMateria1";
            txtMateria1.Size = new Size(100, 23);
            txtMateria1.TabIndex = 11;
            // 
            // txtMateria2
            // 
            txtMateria2.Location = new Point(124, 138);
            txtMateria2.Name = "txtMateria2";
            txtMateria2.Size = new Size(100, 23);
            txtMateria2.TabIndex = 12;
            // 
            // txtMateria3
            // 
            txtMateria3.Location = new Point(124, 173);
            txtMateria3.Name = "txtMateria3";
            txtMateria3.Size = new Size(100, 23);
            txtMateria3.TabIndex = 13;
            // 
            // txtMateria4
            // 
            txtMateria4.Location = new Point(124, 207);
            txtMateria4.Name = "txtMateria4";
            txtMateria4.Size = new Size(100, 23);
            txtMateria4.TabIndex = 14;
            // 
            // txtMateria5
            // 
            txtMateria5.Location = new Point(124, 238);
            txtMateria5.Name = "txtMateria5";
            txtMateria5.Size = new Size(100, 23);
            txtMateria5.TabIndex = 15;
            // 
            // txtMateria6
            // 
            txtMateria6.Location = new Point(124, 274);
            txtMateria6.Name = "txtMateria6";
            txtMateria6.Size = new Size(100, 23);
            txtMateria6.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(73, 356);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 17;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtMateria6);
            Controls.Add(txtMateria5);
            Controls.Add(txtMateria4);
            Controls.Add(txtMateria3);
            Controls.Add(txtMateria2);
            Controls.Add(txtMateria1);
            Controls.Add(txtCarrera);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtMateria1;
        private TextBox txtMateria2;
        private TextBox txtMateria3;
        private TextBox txtMateria4;
        private TextBox txtMateria5;
        private TextBox txtMateria6;
        private Button button1;
    }
}
