using System.Linq.Expressions;

namespace CalculadoraComTestes
{
    public partial class Form1 : Form
    {
        Double n1, n2, resultado;
        const int SOMA = 1;
        const int SUB = 2;
        const int MULT = 3;
        const int DIV = 4;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SOMA);
            }
        }
private Boolean ValidaValor(String vlr)
        {
            Double x;
            if(String.IsNullOrEmpty(vlr) 
                || String.IsNullOrWhiteSpace(vlr)
                || Double.TryParse(vlr,out x)==false)
            {
                Mensagem("Verifique os valores");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SUB);
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
               Calcula(MULT);
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(DIV);
            }
        }

        private void Calcula(int ope)
        {
            n1 = Double.Parse(nro1.Text);
            n2 = Double.Parse(nro2.Text);
            switch(ope)
            {
                case 1:
                    resultado = n1+n2;
                    break;
                case 2:
                    resultado = n1-n2;
                    break;
                case 3:
                    resultado = n1*n2;
                    break;  
                case 4:
                    if (n2 == 0)
                        Mensagem("Não existe Divisão por Zero");
                    else
                        resultado = n1 / n2;
                    break;
            }
            Mensagem(resultado.ToString()); 
        }
        private void Mensagem(String txt)
        {
            lblResultado.Text = txt;
        }
    }
}