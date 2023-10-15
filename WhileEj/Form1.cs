namespace WhileEj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Contador 1 -> 10

            int con = 0;
            label1.Text = "";

            while (con < 10)
            {
                con++;
                label1.Text = label1.Text + "  " + con;
            }

            // Contador 10 -> 1 

            int cont2 = 10;
            label4.Text = "  ";

            while (cont2 >= 1)
            {
                label4.Text = label4.Text + "  " + cont2;
                cont2--;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int suma = 0;

            while (contador <= 100)
            {
                suma = suma + contador;
                contador++;
            }

            label5.Text = label5.Text + "  " + suma;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int suma = 0;

            while (contador <= 100)
            {
                suma = suma + contador;
                contador += 2;
            }

            label7.Text = label7.Text + "  " + suma;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text.ToUpper())
            {
                case "A":
                    label11.Text = label11.Text + "  " + "Avion";
                    break;

                case "E":
                    label11.Text = label11.Text + "  " + "Elefante";
                    break;
                case "I":
                    label11.Text = label11.Text + "  " + "Igloo";
                    break;
                case "O":
                    label11.Text = label11.Text + "  " + "Onice";
                    break;
                case "U":
                    label11.Text = label11.Text + "  " + "Urano";
                    break;
                default:
                    label11.Text = label11.Text + "  " + "Si sabes que es una vocal?";
                    break;


            }
        }
    }
}