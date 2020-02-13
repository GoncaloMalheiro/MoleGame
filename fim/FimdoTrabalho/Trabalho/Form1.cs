using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int Pontos = 0;
        int Total_Tiros = 0;
        int Tiros_Falhados = 0;



        void fn_shot()
        {
            Pontos++;
            label1.Text = "Pontos=" + Pontos;
            Total_Tiros++;
            label3.Text = "Total Tiros=" + Total_Tiros;

        }
        void fn_Tiros_Falhados()
        {
            Tiros_Falhados++;
            label2.Text = "Tiros Falhados=" + Tiros_Falhados;
            Total_Tiros++;
            label3.Text = "Total Tiros=" + Total_Tiros;
        }

        void reset()
        {
            Pontos = 0;
            Tiros_Falhados = 0;
            Total_Tiros = 0;
            label3.Text = "Total Tiros=" + Total_Tiros;
            label1.Text = "Pontos=" + Pontos;
            timer1.Start();
            label4.Text = "";

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 480);
            y = r.Next(200, 330);
            pictureBox1.Location = new Point(x, y);
            if (Tiros_Falhados >= 10)
            {
                timer1.Stop();
                label4.Text = "Perdes-te";
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_Tiros_Falhados();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\Resources\\help.chm");
        }
    }
}
