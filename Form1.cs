using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] B = new Button[11, 11];

        void nrB()
        {
            int nr;
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    if (B[i, j].Name != "Bomb")
                    {
                        if (i == 1)
                        {
                            if (j == 1)
                            {
                                if (B[i + 1, j].Name=="Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            if (j == 10)
                            {
                                if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            {
                               if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                        }
                        else
                        if (i == 10)
                        {
                            if (j == 1)
                            {
                                if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            if (j == 10)
                            {
                                if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            {
                                if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                        }
                        else
                        if (j == 1)
                        {
                            if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i - 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                        }
                        else
                        if (j == 10)
                        {
                            if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i - 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                        }
                        else
                        {
                            if (B[i - 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i - 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j - 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            if (B[i + 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                        }

                    }
        }

        int nr=10;

        void Descopera_Cifre()
        {
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    if (B[i, j].Name != "0")
                    {
                        if (i == 1)
                        {
                            if (j == 1)
                            {
                                if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; } 
                                if (B[i + 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                            else
                            if (j == 10)
                            {
                                if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i + 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                            else
                            {
                                if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i + 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i + 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow;  }
                            }
                        }
                        else
                        if (i == 10)
                        {
                            if (j == 1)
                            {
                                if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                            else
                            if (j == 10)
                            {
                                if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                            else
                            {
                                if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                        }
                        else
                        if (j == 1)
                        {
                            if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i - 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                        }
                        else
                        if (j == 10)
                        {
                            if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i - 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                        }
                        else
                        {
                            if (B[i - 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i - 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j - 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            if (B[i + 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                        }

                    }
        }

        void bombs()
        {
            label1.Text = "";
            label2.Text = "10";
            nr = 10;
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                {
                    B[i, j].Name = "0";
                    B[i, j].Text = "";
                    B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                    B[i, j].Enabled = true;
                }
            Random R = new Random();
            for (int nr = 1; nr <= 10; nr++)
            {
                int l, c;
                do
                {
                    l = R.Next(1, 11);
                    c = R.Next(1, 11);
                } while (B[l, c].Name == "Bomb");
                //label1.Text += l + " " + c + ";     ";
                B[l, c].Name = "Bomb";
            }
            nrB();
            Descopera_Cifre();
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    if (B[i, j].Name == "0")
                    {
                        B[i, j].Text = "";
                        B[i, j].BackColor = Color.LightGoldenrodYellow; ;
                        B[i, j].Enabled = false;
                    }
                    else if (B[i, j].BackColor == Color.LightGoldenrodYellow)
                        B[i, j].Enabled = false;
        }

        void  coloreaza()
        {
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    if (B[i, j].Name == "Bomb")
                        B[i, j].BackColor = Color.Gray;
        }

        bool Verifica_Castig()
        {
            int verifcasute = 0;
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                {
                    if (B[i, j].BackColor == Color.FromArgb(255, 156, 41) || B[i, j].BackColor == Color.Gray) verifcasute++;
                }
            return verifcasute == 10;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            if (e.Button == MouseButtons.Left)
            {
                // Logica pentru LEFT CLICK (descoperă celula)
                if (b.BackColor != Color.Gray)
                {
                    if (b.Name != "Bomb")
                    {
                        b.BackColor = Color.LightGoldenrodYellow;
                        b.Enabled = false;
                        b.Text = b.Name;
                        if (Verifica_Castig())
                        {
                            coloreaza();
                            MessageBox.Show("Ai câștigat!");
                            bombs();
                        }
                    }
                    else
                    {
                        b.BackColor = Color.IndianRed;
                        MessageBox.Show("Ai pierdut!");
                        bombs();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Logica pentru RIGHT CLICK (marchează bomba)
                if (b.BackColor == Color.FromArgb(255, 156, 41))
                {
                    b.BackColor = Color.Gray;
                    nr--;
                    label2.Text = nr.ToString();
                }
                else if (b.BackColor == Color.Gray)
                {
                    b.BackColor = Color.FromArgb(255, 156, 41);
                    nr++;
                    label2.Text = nr.ToString();
                }

                if (Verifica_Castig())
                {
                    coloreaza();
                    MessageBox.Show("Ai câștigat!");
                    bombs();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                {
                    B[i, j] = new Button();
                    B[i, j].Name = "0";
                    B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                    B[i, j].Size = new Size(60, 60);
                    B[i, j].Location = new Point(60 * (j + 1), 60 * i);
                    B[i, j].MouseDown += new MouseEventHandler(Button_MouseDown);
                    B[i,j].Font = new Font(B[i,j].Font.Name, 11, FontStyle.Bold);
                    panel1.Controls.Add(B[i, j]);
                }
            Random R = new Random();
            for (int nr = 1; nr <= 10; nr++)
            {
                int l, c;
                do
                {
                    l = R.Next(1, 11);
                    c = R.Next(1, 11);
                } while (B[l, c].Name == "Bomb");
                B[l, c].Name = "Bomb";
            }
            label2.Text = "10";
            nrB();
            Descopera_Cifre();
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    if (B[i, j].Name == "0")
                    {
                        B[i, j].Text = "";
                        B[i, j].BackColor = Color.LightGoldenrodYellow; ;
                        B[i, j].Enabled = false;
                    }
                    else if (B[i, j].BackColor == Color.LightGoldenrodYellow)
                        B[i, j].Enabled = false;
        }
    }
}
