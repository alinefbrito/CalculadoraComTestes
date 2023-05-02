namespace CalculadoraComTestes
{    public partial class Form1 : Form
    {
        Double n1, n2, resultado ;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            if (ValidaNro(v1) && ValidaNro(v2))
            {
               resultado = Soma(v1,v2);
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
        public Double Soma (string str1,  string str2)
        {
            n1 = Double.Parse(str1);
            n2 = Double.Parse(str2);
            return  n1+ n2;
        }
    }
}