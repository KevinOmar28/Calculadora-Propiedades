namespace Calculadora_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            Operaciones Suma = new Operaciones();
            Suma.Num1 = double.Parse(Valor1.Text);
            Suma.Num2 = double.Parse(Valor2.Text);

            Resultado.Text = Suma.suma().ToString();
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            Operaciones resta = new Operaciones();
            resta.Num1 = double.Parse(Valor1.Text);
            resta.Num2 = double.Parse(Valor2.Text);

            Resultado.Text = resta.resta().ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            Operaciones multi = new Operaciones();
            multi.Num1 = double.Parse(Valor1.Text);
            multi.Num2 = double.Parse(Valor2.Text);

            Resultado.Text = multi.multiplicacion().ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            Operaciones division = new Operaciones();
            division.Num1 = double.Parse(Valor1.Text);
            division.Num2 = double.Parse(Valor2.Text);

            Resultado.Text = division.division().ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Valor1.Clear();
            Valor2.Clear();
            Resultado.Clear();
        }
    }
}