namespace Nopanheitto2pelaajaa
{
    public partial class Form1 : Form
    {
        

        




        public void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int noppa1;

            for (int i = 1; i < 6; i++)
            {

                noppa1 = rnd.Next(1, 7);

                label1.Text =  noppa1.ToString();
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int noppa2;

            for (int i = 1; i < 6; i++)
            {
                noppa2 = rnd.Next(1, 7);

                label2.Text =  noppa2.ToString();

                
            }

            
        }

        public Form1()
        {
            InitializeComponent();


            int arvo1 = Convert.ToInt32(label1.Text);
            int arvo2 = Convert.ToInt32(label2.Text);


            if (arvo1 > arvo2)
            {
                label3.Text = "Pelaaja 1 voitti";
            }

            if (arvo2 > arvo1)
            {
                label3.Text = "Pelaaja 2 voitti";
            }




        }




        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        




    }


}