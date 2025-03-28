namespace GUIA___DELA___CLASE2
{
    public partial class Form1 : Form
    {
        private int numeroSecreto;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            numeroSecreto = random.Next(1, 101); // Genera número aleatorio entre 1 y 100
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            int numeroUsuario;

            if (int.TryParse(txtNumero.Text, out numeroUsuario))
            {
                if (numeroUsuario < numeroSecreto)
                {
                    lblResultado.Text = "Demasiado bajo. Intenta de nuevo.";
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    lblResultado.Text = "Demasiado alto. Intenta de nuevo.";
                }
                else
                {
                    lblResultado.Text = "¡Felicidades! Adivinaste el número.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa un número válido.";
            }
        }
    }
}
