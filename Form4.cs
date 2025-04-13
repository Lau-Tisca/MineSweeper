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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Button[,] B = new Button[51, 51];
        int n, nrbombe, nrb;

        void nrB()
        {
            int nr;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (B[i, j].Name != "Bomb")
                    {
                        if (i == 1)
                        {
                            if (j == 1)
                            {
                                if (B[i + 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i + 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            if (j == n)
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
                        if (i == n)
                        {
                            if (j == 1)
                            {
                                if (B[i - 1, j].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i - 1, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                                if (B[i, j + 1].Name == "Bomb") { nr = Convert.ToInt32(B[i, j].Name); B[i, j].Name = (nr + 1).ToString(); }
                            }
                            else
                            if (j == n)
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
                        if (j == n)
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

        void Descopera_Cifre()
        {
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
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
                            if (j == n)
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
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                        }
                        else
                        if (i == n)
                        {
                            if (j == 1)
                            {
                                if (B[i - 1, j].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i - 1, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                                if (B[i, j + 1].Name == "0") { B[i, j].Text = B[i, j].Name; B[i, j].BackColor = Color.LightGoldenrodYellow; }
                            }
                            else
                            if (j == n)
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
                        if (j == n)
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
            label2.Text = nrbombe.ToString();
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    B[i, j].Name = "0";
                    B[i, j].Text = "";
                    B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                    B[i, j].Enabled = true;
                }
            Random R = new Random();
            for (int nr = 1; nr <= nrbombe; nr++)
            {
                int l, c;
                do
                {
                    l = R.Next(1, n + 1);
                    c = R.Next(1, n + 1);
                } while (B[l, c].Name == "Bomb");
                //label1.Text += l + " " + c + ";     ";
                B[l, c].Name = "Bomb";
            }
            nrB();
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (B[i, j].Name == "0")
                    {
                        B[i, j].Text = "";
                        B[i, j].BackColor = Color.LightGoldenrodYellow; ;
                        B[i, j].Enabled = false;
                    }
            Descopera_Cifre();
        }

        void coloreaza()
        {
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (B[i, j].Name == "Bomb")
                        B[i, j].BackColor = Color.Gray;
        }

        bool Verifica_Castig()
        {
            int verifcasute = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (B[i, j].BackColor == Color.FromArgb(255, 156, 41) || B[i, j].BackColor == Color.Gray) verifcasute++;
            return verifcasute == nrbombe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (checkBox1.Checked == true)
                if (b.BackColor != Color.Gray)
                {
                    if (b.BackColor == Color.FromArgb(255, 156, 41))
                    {
                        b.BackColor = Color.Gray;
                        nrb--;
                        label2.Text = nrb.ToString();
                        if (Verifica_Castig() == true)
                        {
                            coloreaza();
                            MessageBox.Show("You Won!!!");
                            for (int i = 1; i <= n; i++)
                                for (int j = 1; j <= n; j++)
                                    B[i, j].Enabled = false;
                        }
                    }
                }
                else if (b.BackColor == Color.Gray)
                {
                    nrb++;
                    label2.Text = nrb.ToString();
                    b.BackColor = Color.FromArgb(255, 156, 41);
                }
                else
                {
                    if (b.BackColor == Color.Gray)
                    {
                        b.BackColor = Color.FromArgb(255, 156, 41);
                        nrb++;
                        label2.Text = nrb.ToString();
                        if (Verifica_Castig() == true)
                        {
                            coloreaza();
                            MessageBox.Show("You Won!!!");
                            for (int i = 1; i <= n; i++)
                                for (int j = 1; j <= n; j++)
                                    B[i, j].Enabled = false;
                        }

                    }
                }
            else
            if (b.BackColor != Color.Gray)
            {
                if (b.Name != "Bomb")
                {
                    b.BackColor = Color.LightGoldenrodYellow;
                    b.Enabled = false;
                    b.Text = b.Name;
                    if (Verifica_Castig() == true)
                    {
                        coloreaza();
                        MessageBox.Show("You Won!!!");
                        for (int i = 1; i <= n; i++)
                            for (int j = 1; j <= n; j++)
                                B[i, j].Enabled = false;
                    }
                }
                else
                {
                    b.BackColor = Color.IndianRed;
                    b.Text = b.Name;
                    //b.BackgroundImage = Image.FromFile(@"D:\Chrome Downloads\mine.JPG");
                    MessageBox.Show("You Lost!");
                    for (int i = 1; i <= n; i++)
                        for (int j = 1; j <= n; j++)
                            B[i, j].Enabled = false;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
                for (int j = 1; j <= 30; j++)
                {
                    B[i, j] = new Button();
                    B[i, j].Name = "0";
                    B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                    B[i, j].Size = new Size(60, 60);
                    B[i, j].Location = new Point(60 * (j + 1), 60 * i);
                    B[i, j].Click += new EventHandler(button1_Click);
                    B[i, j].Font = new Font(B[i, j].Font.Name, 11, FontStyle.Bold);
                    panel1.Controls.Add(B[i, j]);
                    B[i, j].Hide();
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                bool di = false;
                try
                {
                    n = Convert.ToInt32(textBox1.Text);
                    nrbombe = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Date Incorecte");
                    di = true;
                }
                if(di==false && nrbombe>0)
                { 
                    nrb = nrbombe;
                    if (n > 30 || n<=1) MessageBox.Show("n trebuie sa fie cuprins intre 2 si 30");
                    else
                    if (nrbombe > n * n / 4) MessageBox.Show("Numarul de bombe trebuie sa fie mai mic sau egal " +
                          "decat numarul total de casute impartit la 4, " +
                          "in acest caz mai mic sau egal decat " + (n * n / 4).ToString());
                    else
                    {
                        for (int i = 1; i <= n; i++)
                            for (int j = 1; j <= n; j++)
                            {
                                B[i, j].Name = "0";
                                B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                                B[i, j].Text = "";
                                B[i, j].Enabled = true;
                                B[i, j].Show();
                            }
                        for (int i = n + 1; i <= 30; i++)
                            for (int j = 1; j <= 30; j++)
                            {
                                B[i, j].Name = "0";
                                B[j, i].Name = "0";
                                B[i, j].Text = "";
                                B[j, i].Text = "";
                                B[i, j].BackColor = Color.FromArgb(255, 156, 41);
                                B[j, i].BackColor = Color.FromArgb(255, 156, 41);
                                B[i, j].Enabled = true;
                                B[j, i].Enabled = true;
                                B[i, j].Hide() ;
                                B[j, i].Hide();
                            }
                        Random R = new Random();
                        for (int nr = 1; nr <= nrbombe; nr++)
                        {
                            int l, c;
                            do
                            {
                                l = R.Next(1, n + 1);
                                c = R.Next(1, n + 1);
                            } while (B[l, c].Name == "Bomb");
                            B[l, c].Name = "Bomb";
                        }
                        label2.Text = nrbombe.ToString();
                        nrB();
                        int ok = 0;
                        for (int i = 1; i <= n; i++)
                            for (int j = 1; j <= n; j++)
                                if (B[i, j].Name == "0")
                                {
                                    ok = 1;
                                    B[i, j].Text = "";
                                    B[i, j].BackColor = Color.LightGoldenrodYellow; ;
                                    B[i, j].Enabled = false;
                                }
                        if (ok == 1)
                        {
                            Descopera_Cifre();
                            for (int i = 1; i <= n; i++)
                                for (int j = 1; j <= n; j++)
                                    if (B[i, j].BackColor==Color.LightGoldenrodYellow)
                                        B[i, j].Enabled = false;
                        }
                        else
                        {
                            int l, c;
                            l = R.Next(2, n);
                            c = R.Next(2, n);
                            for (int i = l - 1; i <= l + 1; i++)
                                for (int j = c - 1; j <= c + 1; j++)
                                    if (B[i, j].Name != "Bomb")
                                    {
                                        B[i, j].Text = B[i, j].Name;
                                        B[i, j].BackColor = Color.LightGoldenrodYellow;
                                    }
                        }
                    }
                }
            }
        }
    }
}
