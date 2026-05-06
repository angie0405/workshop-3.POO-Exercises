namespace First_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este es mi primer programa en C#");
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int valorNumerico = 20;
            MessageBox.Show("El valor numérico es: " + valorNumerico);
        }
    }
}
