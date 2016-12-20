using System;
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
                wartosc3 = losowanie.Next(1, 10);
                label4.Text = wartosc3.ToString();

                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + wartosc3;
                Wynik_cyfra.Text = wynik.ToString();
                
                
                }
            if (rozdanie_gracza == 2)
            {

                int wartosc4,wynik;
                wartosc4 = losowanie.Next(1, 10);
                label5.Text = wartosc4.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + wartosc4;
                Wynik_cyfra.Text = wynik.ToString();

            }
            if (rozdanie_gracza == 3)
            {

                int wartosc5, wynik;
                wartosc5 = losowanie.Next(1, 10);
                label18_gracz.Text = wartosc5.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text) + wartosc5;
                Wynik_cyfra.Text = wynik.ToString();

            }
            if (rozdanie_gracza == 4)
            {

                int wartosc6, wynik;
                wartosc6 = losowanie.Next(1, 10);
                label19_gracz.Text = wartosc6.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text) + Convert.ToInt32(label18_gracz.Text) + wartosc6;
                Wynik_cyfra.Text = wynik.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik_komp, wynik_gracz;
            wynik_gracz = Convert.ToInt32(Wynik_cyfra.Text);
            if (wynik_gracz < 22)
            {

                int wartosc2_komp = losowanie.Next(1, 10);
            label7.Text = wartosc2_komp.ToString();



            wynik_komp = Convert.ToInt32(label6.Text) + Convert.ToInt32(label7.Text);
            
            wynik_cyfra_komp.Text = wynik_komp.ToString();


                if (wynik_komp < wynik_gracz)
                {
                    int wartosc3_komp;
                    wartosc3_komp = losowanie.Next(1, 10);

                    wynik_komp = wynik_komp + wartosc3_komp;


                    label8.Text = wartosc3_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc4_komp;
                    wartosc4_komp = losowanie.Next(1, 10);

                    wynik_komp = wynik_komp + wartosc4_komp;


                    label9.Text = wartosc4_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc5_komp;
                    wartosc5_komp = losowanie.Next(1, 10);

                    wynik_komp = wynik_komp + wartosc5_komp;


                    label16_komp.Text = wartosc5_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();
                }
                if (wynik_komp < wynik_gracz)
                {
                    int wartosc6_komp;
                    wartosc6_komp = losowanie.Next(1, 10);

                    wynik_komp = wynik_komp + wartosc6_komp;


                    label17_komp.Text = wartosc6_komp.ToString();
                    wynik_cyfra_komp.Text = wynik_komp.ToString();
                }
            }
            // Punktacja
            int punkty_gracza = Convert.ToInt32(Wynik_cyfra.Text);
            int punkty_komputera = Convert.ToInt32(wynik_cyfra_komp.Text);

            // Punktacja gracza
         
                if ((punkty_gracza > punkty_komputera) && (punkty_gracza < 22))
                {
                    int i = 0;
                    i++;
                    punktacja_gracza.Text = i.ToString();

                }
                //Punktacja dla komputera
                else if ((punkty_gracza < punkty_komputera) && (punkty_komputera < 22))
                {
                    int i = 0;
                    i++;
                    label14.Text = i.ToString();
                }
                // Punktacja dla komputera
                else if (punkty_gracza > 21)
                {
                    int i = 0;
                    i++;
                    label14.Text = i.ToString();
                }
                // Punktacja gracza
                else if (punkty_komputera > 21)
                {
                    int i = 0;
                    i++;
                    punktacja_gracza.Text = i.ToString();
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
            wartosc_poczatkowa = losowanie.Next(1, 10);
            wartosc2 = losowanie.Next(1, 10);
            wynik = wartosc_poczatkowa + wartosc2;


            label2.Text = wartosc_poczatkowa.ToString();
            label3.Text = wartosc2.ToString();
            Wynik_cyfra.Text = wynik.ToString();

            int wartosc_poczatkowa_komp, wartosc2_komp, wynik_komp;
            wartosc_poczatkowa_komp = losowanie.Next(1, 10);

            wynik_komp = wartosc_poczatkowa_komp;
            label6.Text = wartosc_poczatkowa_komp.ToString();
            if (rozdanie_komputera == 1)
            {
                wynik_komp = Convert.ToInt32(label6.Text);
                wynik_cyfra_komp.Text = wynik_komp.ToString();
                rozdanie_komputera++;
            }


            rozdanie_gracza++;
        }
    }
   
}

