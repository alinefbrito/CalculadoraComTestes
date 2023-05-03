namespace CalculadoraComTestes
{
    public partial class Form1 : Form
    {
        Double n1, n2, resultado;
        const int Soma = 1;
        const int Sub = 2;
        const int Mult = 3;
        const int Div = 4;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            if (ValidaNro(v1) && ValidaNro(v2))
            {
                Calcula(Soma, v1, v2);
                label1.Text = resultado.ToString();
            }
            else
            {
                label1.Text = "Digite valores Válidos";
            }
        }
        public Boolean ValidaNro(String vlr)
        {
            Double valor = 0;
            Boolean isNumber = Double.TryParse(vlr, out valor);
            if (String.IsNullOrEmpty(vlr)
                || String.IsNullOrWhiteSpace(vlr)
                || !isNumber)
            {
                return false;
            }
            return true;
        }
        public Double Calcula(int op, string str1, string str2)
        {
            n1 = Double.Parse(str1);
            n2 = Double.Parse(str2);
            switch (op)
            {
                case 1:
                    resultado = n1 + n2;
                    break;
                case 2:
                    resultado = n1 - n2;
                    break;
                case 3:
                    resultado = n1 * n2;
                    break;
                case 4:
                    resultado = n1 / n2;
                    break;
            }
            return resultado;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            if (ValidaNro(v1) && ValidaNro(v2))
            {
                Calcula(Sub, v1, v2);
                label1.Text = resultado.ToString();
            }
            else
            {
                label1.Text = "Digite valores Válidos";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            if (ValidaNro(v1) && ValidaNro(v2))
            {
                Calcula(Mult, v1, v2);
                label1.Text = resultado.ToString();
            }
            else
            {
                label1.Text = "Digite valores Válidos";
            }
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            if (ValidaNro(v1) && ValidaNro(v2))
            {
                Calcula(Div, v1, v2);
                label1.Text = resultado.ToString();
            }
            else
            {
                label1.Text = "Digite valores Válidos";
            }

        }
    }
}