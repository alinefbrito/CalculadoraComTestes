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
            nro1 = new TextBox();
            nro2 = new TextBox();
            btn_Soma = new Button();
            lblResultado = new Label();
            btn_Sub = new Button();
            btn_Mult = new Button();
            btn_Div = new Button();
            SuspendLayout();
            // 
            // nro1
            // 
            nro1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nro1.Location = new Point(82, 74);
            nro1.MinimumSize = new Size(50, 30);
            nro1.Name = "nro1";
            nro1.Size = new Size(100, 29);
            nro1.TabIndex = 0;
            // 
            // nro2
            // 
            nro2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nro2.Location = new Point(82, 118);
            nro2.MinimumSize = new Size(50, 30);
            nro2.Name = "nro2";
            nro2.Size = new Size(100, 29);
            nro2.TabIndex = 1;
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
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(192, 0, 192);
            lblResultado.Location = new Point(82, 170);
            lblResultado.MinimumSize = new Size(50, 30);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(86, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
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
            // btn_Div
            // 
            btn_Div.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Div.Location = new Point(257, 117);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(30, 30);
            btn_Div.TabIndex = 6;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(762, 461);
            Controls.Add(btn_Div);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Sub);
            Controls.Add(lblResultado);
            Controls.Add(btn_Soma);
            Controls.Add(nro2);
            Controls.Add(nro1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nro1;
        private TextBox nro2;
        private Button btn_Soma;
        private Label lblResultado;
        private Button btn_Sub;
        private Button btn_Mult;
        private Button btn_Div;
    }
}