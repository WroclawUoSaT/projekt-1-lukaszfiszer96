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
        int rozdanie = 0;
      
        private void dobieranie_Click(object sender, EventArgs e)
        {
            rozdanie++;
            if (rozdanie == 1)
                {
                    int wartosc_poczatkowa, wartosc2, wynik;
                    wartosc_poczatkowa = losowanie.Next(1, 10);
                    wartosc2 = losowanie.Next(1, 10);
                    wynik = wartosc_poczatkowa + wartosc2;


                    label2.Text = wartosc_poczatkowa.ToString();
                    label3.Text = wartosc2.ToString();
                    Wynik_cyfra.Text = wynik.ToString();
                }

            if (rozdanie == 2)
                {

                int wartosc3,wynik;
                wartosc3 = losowanie.Next(1, 10);
                label4.Text = wartosc3.ToString();

                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + wartosc3;
                Wynik_cyfra.Text = wynik.ToString();

                }
            if (rozdanie == 3)
            {

                int wartosc4,wynik;
                wartosc4 = losowanie.Next(1, 10);
                label5.Text = wartosc4.ToString();


                wynik = Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + wartosc4;
                Wynik_cyfra.Text = wynik.ToString();

            }

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

            int wartosc_poczatkowa_komp, wartosc2_komp, wynik_komp;
            wartosc_poczatkowa_komp = losowanie.Next(1, 10);
            wartosc2_komp = losowanie.Next(1, 10);
            wynik_komp = wartosc_poczatkowa_komp + wartosc2_komp;


            label6.Text = wartosc_poczatkowa_komp.ToString();
            label7.Text = wartosc2_komp.ToString();
            wynik_cyfra_komp.Text = wynik_komp.ToString();

            if (wynik_komp<16)
            {
                int wartosc3_komp;
                wartosc3_komp = losowanie.Next(1, 10);
                
                wynik_komp = wynik_komp + wartosc3_komp;


                label8.Text = wartosc3_komp.ToString();
                wynik_cyfra_komp.Text = wynik_komp.ToString();
            }
            if (wynik_komp < 16)
            {
                int wartosc4_komp;
                wartosc4_komp = losowanie.Next(1, 10);

                wynik_komp = wynik_komp + wartosc4_komp;


                label9.Text = wartosc4_komp.ToString();
                wynik_cyfra_komp.Text = wynik_komp.ToString();
            }

        }

        private void sprawdzenie_Click(object sender, EventArgs e)
        {
            int punkty_gracza = Convert.ToInt32(Wynik_cyfra.Text);
            int punkty_komputera = Convert.ToInt32(wynik_cyfra_komp.Text);
            if ((punkty_gracza>punkty_komputera) && (punkty_gracza< 22 ))
            {
                int i = 0;
                i++;
                punktacja_gracza.Text = i.ToString();
                
            }
            if ((punkty_gracza < punkty_komputera) && (punkty_komputera < 22))
            {
                int i = 0;
                i++;
                label14.Text = i.ToString();

            }


        }
    }
   
}

