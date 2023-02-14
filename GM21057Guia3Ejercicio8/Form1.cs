namespace GM21057Guia3Ejercicio8
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }
      
        private void dado1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            int numDado1=0;
            int numDado2 = 0;
            int numDado3 = 0;
            for (int i = 0; i <= 3; i++)
            {
                int rInt = r.Next(1, 7);
                if (i==1)
                {
                    numDado1 = rInt;
                }else if (i == 3)
                {
                    numDado2 = rInt;
                }
                else
                {
                    numDado3 = rInt;
                }
            }

            textDado1.Text = numDado1.ToString();
            textDado2.Text = numDado2.ToString();
            textDado3.Text = numDado3.ToString();

            if (numDado1==6 & numDado2 == 6 & numDado3 == 6)
            {
                textImprecion.Text = "“¡¡¡ Ganó 1,000,000 !!!”";
            }
            else if (numDado1 == 6 & numDado2 == 6|| numDado1 == 6 & numDado3 == 6|| numDado2 == 6 & numDado3 == 6)
            {
                textImprecion.Text = "¡ Ganó Tv !";
            }else if(numDado1 == 6 || numDado2 == 6 || numDado3 == 6)
            {
                textImprecion.Text = "“Continúe intentando”";
            }
            else
            {
                textImprecion.Text = "“¡¡¡Pierde todo!!!";
            }

          
            
        }

        private void textImprecion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}