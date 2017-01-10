using System;
using System.Windows.Forms;

namespace Blackjack
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int wspolczynik_gracza = 0;
        int wspolczynik_komputera = 0;
        int[] wartosci_gracza = new int[6];
        int[] wartosci_komputera = new int[6];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random losowanie = new Random();
        int rozdanie_gracza = 0;
  
            
        private void dobieranie_Click(object sender, EventArgs e)
        {
            if (rozdanie_gracza == 1)
                {

                int wynik;

                wartosci_gracza[2] = losowanie.Next(1, 14);
                wynik = wartosci_gracza[0] + wartosci_gracza[1] + wartosci_gracza[2];
                Wynik_cyfra.Text = wynik.ToString();

                // 3 KARTA GRACZA OBRAZEK
                pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[2] + ".png";

            }
            if (rozdanie_gracza == 2)
            {
                int wynik;
                wartosci_gracza[3] = losowanie.Next(1, 14);
                wynik = wartosci_gracza[0] + wartosci_gracza[1] + wartosci_gracza[2] + wartosci_gracza[3];
                Wynik_cyfra.Text = wynik.ToString();

                // 4 KARTA GRACZA
                pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[3] + ".png";

            }
            if (rozdanie_gracza == 3)
            {
                int wynik;
                wartosci_gracza[4] = losowanie.Next(1, 14);
                wynik = wartosci_gracza[0] + wartosci_gracza[1] + wartosci_gracza[2] + wartosci_gracza[3]+ wartosci_gracza[4];
                Wynik_cyfra.Text = wynik.ToString();

                // 5 KARTA GRACZA
                pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[4] + ".png";

            }
            if (rozdanie_gracza == 4)
            {
                int wynik;
                wartosci_gracza[5] = losowanie.Next(1, 14);
                wynik = wartosci_gracza[0] + wartosci_gracza[1] + wartosci_gracza[2] + wartosci_gracza[3]+ wartosci_gracza[4] + wartosci_gracza[5];
                Wynik_cyfra.Text = wynik.ToString();

                // 6 KARTA GRACZA
                pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[5] + ".png";


            }
            rozdanie_gracza++;


        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int wynik_komp = 0;
            int wynik_gracz = 0;
            for (int i =0; i<6;i++)
            wynik_gracz = wynik_gracz+ wartosci_gracza[i];

            if (wynik_gracz < 22)
            {

            wartosci_komputera[1] = losowanie.Next(1, 11);
            wynik_komp = wartosci_komputera[0] + wartosci_komputera[1];
            
            wynik_cyfra_komp.Text = wynik_komp.ToString();


                //2 KARTA KOMPUTERA
                pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[1] + ".png";


                if (wynik_komp < wynik_gracz)
                {
                    wartosci_komputera[2] = losowanie.Next(1, 11);
                    wynik_komp = wartosci_komputera[0] + wartosci_komputera[1]+ wartosci_komputera[2];

                    wynik_cyfra_komp.Text = wynik_komp.ToString();


                    //3 KARTA KOMPUTERA
                    pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[2] + ".png";

                  
                }
                if (wynik_komp < wynik_gracz)
                {
                    wartosci_komputera[3] = losowanie.Next(1, 11);
                    wynik_komp = wartosci_komputera[0] + wartosci_komputera[1] + wartosci_komputera[2] + wartosci_komputera[3];

                    wynik_cyfra_komp.Text = wynik_komp.ToString();


                    //4 KARTA KOMPUTERA
                    pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[3] + ".png";

                }
                if (wynik_komp < wynik_gracz)
                {
                    wartosci_komputera[4] = losowanie.Next(1, 11);
                    wynik_komp = wartosci_komputera[0] + wartosci_komputera[1] + wartosci_komputera[2]
                        +wartosci_komputera[3]+ wartosci_komputera[4];

                    wynik_cyfra_komp.Text = wynik_komp.ToString();


                    //5 KARTA KOMPUTERA
                    pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[4] + ".png";
                }
                if (wynik_komp < wynik_gracz)
                {
                    wartosci_komputera[5] = losowanie.Next(1, 11);
                    wynik_komp = wartosci_komputera[0] + wartosci_komputera[1] + wartosci_komputera[2]
                        +wartosci_komputera[3]+wartosci_komputera[4]+wartosci_komputera[5];

                    wynik_cyfra_komp.Text = wynik_komp.ToString();


                    //6 KARTA KOMPUTERA
                    pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[5] + ".png";
                }   
            }
            // Punktacja
            int punkty_gracza = Convert.ToInt32(Wynik_cyfra.Text);
            int punkty_komputera = Convert.ToInt32(wynik_cyfra_komp.Text);





            // Punktacja gracza

            if ((punkty_gracza > punkty_komputera) && (punkty_gracza < 22))
                {

                wspolczynik_gracza = wspolczynik_gracza + 1;
                punktacja_gracza.Text = wspolczynik_gracza.ToString();

                }
                //Punktacja dla komputera
                else if ((punkty_gracza < punkty_komputera) && (punkty_komputera < 22))
                {
                wspolczynik_komputera = wspolczynik_komputera + 1;
                label14.Text = wspolczynik_komputera.ToString();
            }
                // Punktacja dla komputera
                else if (punkty_gracza > 21)
                {
                wspolczynik_komputera = wspolczynik_komputera + 1;
                label14.Text = wspolczynik_komputera.ToString();
            }
                // Punktacja gracza

                else if (punkty_komputera > 21)
                {
                wspolczynik_gracza = wspolczynik_gracza + 1;
                punktacja_gracza.Text = wspolczynik_gracza.ToString();
            }


                // Przypadek remisu
                if (punkty_gracza == punkty_komputera)
                {

                    string zawartosc_okienka = "Wynik krupiera oraz twoj jest taki sam, nikt nie otrzyma punktów.";
                    string ramka_okienka = "Remis";

                    DialogResult result;
                    MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                    result = MessageBox.Show(zawartosc_okienka, ramka_okienka, buttons1);

                }

            }
        

        private void button_start_Click(object sender, EventArgs e)
        {
            //dwie pierwsze karty gracza
            int wynik;
            wartosci_gracza[0] = losowanie.Next(1, 14);
            wartosci_gracza[1] = losowanie.Next(1, 14);

            wynik = wartosci_gracza[0] + wartosci_gracza[1];
            Wynik_cyfra.Text = wynik.ToString();

            //pierwsza karta komputera

            int wynik_komp;
            wartosci_komputera[0] = losowanie.Next(1, 14);

            wynik_komp = wartosci_komputera[0];

            wynik_cyfra_komp.Text = wynik_komp.ToString();

  
            //OBRAZKI DO 1 KARTY KOMPUTERA
            pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_komputera[0] + ".png";

            //OBRAZKI DO 1 KARTY GRACZA
            pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[0] + ".png";

            // OBRAZEK 2 GRACZA
            pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d" + wartosci_gracza[1] + ".png";

            rozdanie_gracza++;



  
        }

        private void bReset_Click(object sender, EventArgs e)
        {
   
    
            for (int i=0; i<6;i++)
            {
                wartosci_gracza[i] = 0;
                wartosci_komputera[i] = 0;
            }
       
            wynik_cyfra_komp.Text = "0";
            Wynik_cyfra.Text = "0";

            rozdanie_gracza = 0;
        
            pictureBox1.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox2.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox3.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox4.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox5.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox6.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox7.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox8.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox9.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox10.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox11.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
            pictureBox12.ImageLocation = @"C:\Users\User\Desktop\Talia Kart\tyłkarty.jpg";
        }

        private void pictureBox11_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
   
}

