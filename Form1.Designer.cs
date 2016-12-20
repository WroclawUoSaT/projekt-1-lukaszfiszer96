namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Wynik_cyfra = new System.Windows.Forms.Label();
            this.dobieranie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.komputer_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.wynik_cyfra_komp = new System.Windows.Forms.Label();
            this.sprawdzenie = new System.Windows.Forms.Button();
            this.punktacja_gracza = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Punktacja = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wynik";
            // 
            // Wynik_cyfra
            // 
            this.Wynik_cyfra.AutoSize = true;
            this.Wynik_cyfra.Location = new System.Drawing.Point(107, 272);
            this.Wynik_cyfra.Name = "Wynik_cyfra";
            this.Wynik_cyfra.Size = new System.Drawing.Size(13, 13);
            this.Wynik_cyfra.TabIndex = 1;
            this.Wynik_cyfra.Text = "0";
            this.Wynik_cyfra.Click += new System.EventHandler(this.label2_Click);
            // 
            // dobieranie
            // 
            this.dobieranie.Location = new System.Drawing.Point(132, 272);
            this.dobieranie.Name = "dobieranie";
            this.dobieranie.Size = new System.Drawing.Size(75, 23);
            this.dobieranie.TabIndex = 2;
            this.dobieranie.Text = "dobieranie gracza";
            this.dobieranie.UseVisualStyleBackColor = true;
            this.dobieranie.Click += new System.EventHandler(this.dobieranie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // komputer_button
            // 
            this.komputer_button.Location = new System.Drawing.Point(332, 50);
            this.komputer_button.Name = "komputer_button";
            this.komputer_button.Size = new System.Drawing.Size(75, 23);
            this.komputer_button.TabIndex = 7;
            this.komputer_button.Text = "komputerdobiera";
            this.komputer_button.UseVisualStyleBackColor = true;
            this.komputer_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wynik_komp";
            // 
            // wynik_cyfra_komp
            // 
            this.wynik_cyfra_komp.AutoSize = true;
            this.wynik_cyfra_komp.Location = new System.Drawing.Point(413, 34);
            this.wynik_cyfra_komp.Name = "wynik_cyfra_komp";
            this.wynik_cyfra_komp.Size = new System.Drawing.Size(13, 13);
            this.wynik_cyfra_komp.TabIndex = 13;
            this.wynik_cyfra_komp.Text = "0";
            // 
            // sprawdzenie
            // 
            this.sprawdzenie.Location = new System.Drawing.Point(324, 191);
            this.sprawdzenie.Name = "sprawdzenie";
            this.sprawdzenie.Size = new System.Drawing.Size(102, 23);
            this.sprawdzenie.TabIndex = 14;
            this.sprawdzenie.Text = "sprawdzenie";
            this.sprawdzenie.UseVisualStyleBackColor = true;
            this.sprawdzenie.Click += new System.EventHandler(this.sprawdzenie_Click);
            // 
            // punktacja_gracza
            // 
            this.punktacja_gracza.AutoSize = true;
            this.punktacja_gracza.Location = new System.Drawing.Point(556, 34);
            this.punktacja_gracza.Name = "punktacja_gracza";
            this.punktacja_gracza.Size = new System.Drawing.Size(41, 13);
            this.punktacja_gracza.TabIndex = 15;
            this.punktacja_gracza.Text = "label11";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(230, -24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 335);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(495, -7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 335);
            this.label12.TabIndex = 17;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(509, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Gracz";
            // 
            // Punktacja
            // 
            this.Punktacja.Location = new System.Drawing.Point(524, 9);
            this.Punktacja.Name = "Punktacja";
            this.Punktacja.Size = new System.Drawing.Size(63, 13);
            this.Punktacja.TabIndex = 19;
            this.Punktacja.Text = "Punktacja";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(556, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(509, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Komputer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(599, 307);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Punktacja);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.punktacja_gracza);
            this.Controls.Add(this.sprawdzenie);
            this.Controls.Add(this.wynik_cyfra_komp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.komputer_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dobieranie);
            this.Controls.Add(this.Wynik_cyfra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Wynik_cyfra;
        private System.Windows.Forms.Button dobieranie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button komputer_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label wynik_cyfra_komp;
        private System.Windows.Forms.Button sprawdzenie;
        private System.Windows.Forms.Label punktacja_gracza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Punktacja;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

