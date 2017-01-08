using System;
using Punktacja;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

 


        Random losowanie = new Random();
        int rozdanie_gracza = 0;
        int rozdanie_komputera = 1;
        int start = 1;
      
        private void dobieranie_Click(object sender, EventArgs e)
        {
            
      
            if (rozdanie_gracza == 1)
                {

                int wartosc3,wynik;
                wartosc3 = losowanie.Next(1, 11);
                label4.Text = wartosc3.ToString();

                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + wartosc3;
                Wynik_cyfra.Text = wynik.ToString();

                // 3 KARTA GRACZA
                if (label4.Text == "1")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                if (label4.Text == "2")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                if (label4.Text == "3")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                if (label4.Text == "4")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                if (label4.Text == "5")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                if (label4.Text == "6")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                if (label4.Text == "7")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                if (label4.Text == "8")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                if (label4.Text == "9")
                    pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                if (label4.Text == "10")
                {
                    int wartosc_losowa;
                    wartosc_losowa = losowanie.Next(1, 5);
                    if (wartosc_losowa == 1)
                        pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                    if (wartosc_losowa == 2)
                        pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                    if (wartosc_losowa == 3)
                        pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                    if (wartosc_losowa == 4)
                        pictureBox10.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                }


            }
            if (rozdanie_gracza == 2)
            {

                int wartosc4,wynik;
                wartosc4 = losowanie.Next(1, 11);
                label5.Text = wartosc4.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + wartosc4;
                Wynik_cyfra.Text = wynik.ToString();

                // 4 KARTA GRACZA
                if (label5.Text == "1")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                if (label5.Text == "2")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                if (label5.Text == "3")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                if (label5.Text == "4")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                if (label5.Text == "5")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                if (label5.Text == "6")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                if (label5.Text == "7")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                if (label5.Text == "8")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                if (label5.Text == "9")
                    pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                if (label5.Text == "10")
                {
                    int wartosc_losowa;
                    wartosc_losowa = losowanie.Next(1, 5);
                    if (wartosc_losowa == 1)
                        pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                    if (wartosc_losowa == 2)
                        pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                    if (wartosc_losowa == 3)
                        pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                    if (wartosc_losowa == 4)
                        pictureBox9.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                }

            }
            if (rozdanie_gracza == 3)
            {

                int wartosc5, wynik;
                wartosc5 = losowanie.Next(1, 11);
                label18_gracz.Text = wartosc5.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text) + wartosc5;
                Wynik_cyfra.Text = wynik.ToString();
                //5 KARTA GRACZA
                if (label18_gracz.Text == "1")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                if (label18_gracz.Text == "2")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                if (label18_gracz.Text == "3")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                if (label18_gracz.Text == "4")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                if (label18_gracz.Text == "5")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                if (label18_gracz.Text == "6")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                if (label18_gracz.Text == "7")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                if (label18_gracz.Text == "8")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                if (label18_gracz.Text == "9")
                    pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                if (label18_gracz.Text == "10")
                {
                    int wartosc_losowa;
                    wartosc_losowa = losowanie.Next(1, 5);
                    if (wartosc_losowa == 1)
                        pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                    if (wartosc_losowa == 2)
                        pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                    if (wartosc_losowa == 3)
                        pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                    if (wartosc_losowa == 4)
                        pictureBox8.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                }

            }
            if (rozdanie_gracza == 4)
            {

                int wartosc6, wynik;
                wartosc6 = losowanie.Next(1, 11);
                label19_gracz.Text = wartosc6.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text) + Convert.ToInt32(label18_gracz.Text) + wartosc6;
                Wynik_cyfra.Text = wynik.ToString();

                //6 KARTA GRACZA                
                if (label19_gracz.Text == "1")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                if (label19_gracz.Text == "2")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                if (label19_gracz.Text == "3")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                if (label19_gracz.Text == "4")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                if (label19_gracz.Text == "5")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                if (label19_gracz.Text == "6")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                if (label19_gracz.Text == "7")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                if (label19_gracz.Text == "8")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                if (label19_gracz.Text == "9")
                    pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                if (label19_gracz.Text == "10")
                {
                    int wartosc_losowa;
                    wartosc_losowa = losowanie.Next(1, 5);
                    if (wartosc_losowa == 1)
                        pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                    if (wartosc_losowa == 2)
                        pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                    if (wartosc_losowa == 3)
                        pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                    if (wartosc_losowa == 4)
                        pictureBox7.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                }


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
            int wynik_komp, wynik_gracz;
            wynik_gracz = Convert.ToInt32(Wynik_cyfra.Text);
            if (wynik_gracz < 22)
            {

                int wartosc2_komp = losowanie.Next(1, 11);
            label7.Text = wartosc2_komp.ToString();



            wynik_komp = Convert.ToInt32(label6.Text) + Convert.ToInt32(label7.Text);
            
            wynik_cyfra_komp.Text = wynik_komp.ToString();
                //2 KARTA KOMPUTERA
                if (label7.Text == "1")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                if (label7.Text == "2")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                if (label7.Text == "3")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                if (label7.Text == "4")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                if (label7.Text == "5")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                if (label7.Text == "6")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                if (label7.Text == "7")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                if (label7.Text == "8")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                if (label7.Text == "9")
                    pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                if (label7.Text == "10")
                {
                    int wartosc_losowa;
                    wartosc_losowa = losowanie.Next(1, 5);
                    if (wartosc_losowa == 1)
                        pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                    if (wartosc_losowa == 2)
                        pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                    if (wartosc_losowa == 3)
                        pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                    if (wartosc_losowa == 4)
                        pictureBox2.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                }


                if (wynik_komp < wynik_gracz)
                {
                    int wartosc3_komp;
                    wartosc3_komp = losowanie.Next(1, 11);

                    wynik_komp = wynik_komp + wartosc3_komp;


                    label8.Text = wartosc3_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();

                    // 3 KARTA GRACZA
                    if (label8.Text == "1")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                    if (label8.Text == "2")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                    if (label8.Text == "3")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                    if (label8.Text == "4")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                    if (label8.Text == "5")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                    if (label8.Text == "6")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                    if (label8.Text == "7")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                    if (label8.Text == "8")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                    if (label8.Text == "9")
                        pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                    if (label8.Text == "10")
                    {
                        int wartosc_losowa;
                        wartosc_losowa = losowanie.Next(1, 5);
                        if (wartosc_losowa == 1)
                            pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                        if (wartosc_losowa == 2)
                            pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                        if (wartosc_losowa == 3)
                            pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                        if (wartosc_losowa == 4)
                            pictureBox3.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                    }
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc4_komp;
                    wartosc4_komp = losowanie.Next(1, 11);

                    wynik_komp = wynik_komp + wartosc4_komp;


                    label9.Text = wartosc4_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();
                    // 4 KARTA GRACZA
                    if (label9.Text == "1")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                    if (label9.Text == "2")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                    if (label9.Text == "3")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                    if (label9.Text == "4")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                    if (label9.Text == "5")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                    if (label9.Text == "6")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                    if (label9.Text == "7")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                    if (label9.Text == "8")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                    if (label9.Text == "9")
                        pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                    if (label9.Text == "10")
                    {
                        int wartosc_losowa;
                        wartosc_losowa = losowanie.Next(1, 5);
                        if (wartosc_losowa == 1)
                            pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                        if (wartosc_losowa == 2)
                            pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                        if (wartosc_losowa == 3)
                            pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                        if (wartosc_losowa == 4)
                            pictureBox4.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                    }
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc5_komp;
                    wartosc5_komp = losowanie.Next(1, 11);

                    wynik_komp = wynik_komp + wartosc5_komp;


                    label16_komp.Text = wartosc5_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();

                    // 5 KARTA GRACZA
                    if (label16_komp.Text == "1")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                    if (label16_komp.Text == "2")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                    if (label16_komp.Text == "3")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                    if (label16_komp.Text == "4")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                    if (label16_komp.Text == "5")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                    if (label16_komp.Text == "6")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                    if (label16_komp.Text == "7")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                    if (label16_komp.Text == "8")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                    if (label16_komp.Text == "9")
                        pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                    if (label16_komp.Text == "10")
                    {
                        int wartosc_losowa;
                        wartosc_losowa = losowanie.Next(1, 5);
                        if (wartosc_losowa == 1)
                            pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                        if (wartosc_losowa == 2)
                            pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                        if (wartosc_losowa == 3)
                            pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                        if (wartosc_losowa == 4)
                            pictureBox5.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                    }
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc6_komp;
                    wartosc6_komp = losowanie.Next(1, 11);

                    wynik_komp = wynik_komp + wartosc6_komp;


                    label17_komp.Text = wartosc6_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();

                    // 6 KARTA GRACZA
                    if (label17_komp.Text == "1")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

                    if (label17_komp.Text == "2")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

                    if (label17_komp.Text == "3")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

                    if (label17_komp.Text == "4")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

                    if (label17_komp.Text == "5")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

                    if (label17_komp.Text == "6")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

                    if (label17_komp.Text == "7")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

                    if (label17_komp.Text == "8")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

                    if (label17_komp.Text == "9")
                        pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


                    if (label17_komp.Text == "10")
                    {
                        int wartosc_losowa;
                        wartosc_losowa = losowanie.Next(1, 5);
                        if (wartosc_losowa == 1)
                            pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                        if (wartosc_losowa == 2)
                            pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                        if (wartosc_losowa == 3)
                            pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                        if (wartosc_losowa == 4)
                            pictureBox6.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
                    }
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
            int wartosc_poczatkowa, wartosc2, wynik;
            wartosc_poczatkowa = losowanie.Next(1, 11);
            wartosc2 = losowanie.Next(1, 11);
            wynik = wartosc_poczatkowa + wartosc2;


            label2.Text = wartosc_poczatkowa.ToString();
            label3.Text = wartosc2.ToString();
            Wynik_cyfra.Text = wynik.ToString();

            int wartosc_poczatkowa_komp, wartosc2_komp, wynik_komp;
            wartosc_poczatkowa_komp = losowanie.Next(1, 11);

            wynik_komp = wartosc_poczatkowa_komp;
            label6.Text = wartosc_poczatkowa_komp.ToString();
            wynik_cyfra_komp.Text = wynik_komp.ToString();
            if (rozdanie_komputera == 1)
            {
                wynik_komp = Convert.ToInt32(label6.Text);
                wynik_cyfra_komp.Text = wynik_komp.ToString();
                rozdanie_komputera++;
            }
            //OBRAZKI DO 1 KARTY KOMPUTERA
            if (label6.Text == "1")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

            if (label6.Text == "2")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

            if (label6.Text == "3")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

            if (label6.Text == "4")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

            if (label6.Text == "5")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

            if (label6.Text == "6")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

            if (label6.Text == "7")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

            if (label6.Text == "8")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";
            
            if (label6.Text == "9")
                pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";
            

            if (label6.Text == "10")
            {
                int wartosc_losowa;
                wartosc_losowa = losowanie.Next(1, 5);
                if (wartosc_losowa == 1)
                    pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                if (wartosc_losowa == 2)
                    pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                if (wartosc_losowa == 3)
                    pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                if (wartosc_losowa == 4)
                    pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
            }
            //OBRAZKI DO 1 KARTY GRACZA
            if (label2.Text == "1")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

            if (label2.Text == "2")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

            if (label2.Text == "3")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

            if (label2.Text == "4")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

            if (label2.Text == "5")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

            if (label2.Text == "6")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

            if (label2.Text == "7")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

            if (label2.Text == "8")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

            if (label2.Text == "9")
                pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


            if (label2.Text == "10")
            {
                int wartosc_losowa;
                wartosc_losowa = losowanie.Next(1, 5);
                if (wartosc_losowa == 1)
                    pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                if (wartosc_losowa == 2)
                    pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                if (wartosc_losowa == 3)
                    pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                if (wartosc_losowa == 4)
                    pictureBox12.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
            }
            // OBRAZEK 2 GRACZA
            if (label3.Text == "1")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d1.png";

            if (label3.Text == "2")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d2.png";

            if (label3.Text == "3")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d3.png";

            if (label3.Text == "4")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d4.png";

            if (label3.Text == "5")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d5.png";

            if (label3.Text == "6")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d6.png";

            if (label3.Text == "7")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d7.png";

            if (label3.Text == "8")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d8.png";

            if (label3.Text == "9")
                pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d9.png";


            if (label3.Text == "10")
            {
                int wartosc_losowa;
                wartosc_losowa = losowanie.Next(1, 5);
                if (wartosc_losowa == 1)
                    pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\d10.png";
                if (wartosc_losowa == 2)
                    pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dj.png";
                if (wartosc_losowa == 3)
                    pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dq.png";
                if (wartosc_losowa == 4)
                    pictureBox11.ImageLocation = "C:\\Users\\User\\Desktop\\Talia Kart\\dk.png";
            }
            rozdanie_gracza++;



  
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label16_komp.Text = "0";
            label17_komp.Text = "0";

            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label18_gracz.Text = "0";
            label19_gracz.Text = "0";

            wynik_cyfra_komp.Text = "0";
            Wynik_cyfra.Text = "0";

            rozdanie_gracza = 0;
            rozdanie_komputera = 0;

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
    }
   
}

