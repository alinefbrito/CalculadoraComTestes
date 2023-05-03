namespace CalculadoraComTestes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Soma = new Button();
            label1 = new Label();
            btn_Sub = new Button();
            btn_Mult = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(82, 74);
            textBox1.MinimumSize = new Size(50, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(82, 118);
            textBox2.MinimumSize = new Size(50, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 1;
            // 
            // btn_Soma
            // 
            btn_Soma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Soma.Location = new Point(221, 78);
            btn_Soma.MinimumSize = new Size(30, 30);
            btn_Soma.Name = "btn_Soma";
            btn_Soma.Size = new Size(30, 30);
            btn_Soma.TabIndex = 2;
            btn_Soma.Text = "+";
            btn_Soma.UseVisualStyleBackColor = true;
            btn_Soma.Click += btnSoma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(82, 170);
            label1.MinimumSize = new Size(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            // 
            // btn_Sub
            // 
            btn_Sub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sub.Location = new Point(257, 78);
            btn_Sub.Name = "btn_Sub";
            btn_Sub.Size = new Size(30, 30);
            btn_Sub.TabIndex = 4;
            btn_Sub.Text = "-";
            btn_Sub.UseVisualStyleBackColor = true;
            btn_Sub.Click += btnSub_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Mult.Location = new Point(221, 117);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new Size(30, 30);
            btn_Mult.TabIndex = 5;
            btn_Mult.Text = "*";
            btn_Mult.UseVisualStyleBackColor = true;
            btn_Mult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(257, 117);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(30, 30);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(762, 461);
            Controls.Add(btnDiv);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Sub);
            Controls.Add(label1);
            Controls.Add(btn_Soma);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Soma;
        private Label label1;
        private Button btn_Sub;
        private Button btn_Mult;
        private Button btnDiv;
    }
}