using _300griven.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300griven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Hide();
            button3.Hide();
        }

        string result;

        private void button1_Click(object sender, EventArgs e)
        {
            Talk("Скучно... теливизора нет\n\nВот бы 300 гривен. Дашь?", "Инвалид...");
            button1.Enabled = false;
            button1.Hide();
            //_ result == "Yes" ? label1.Text = "ура" : Angry();

            if (result == "Yes")
            {
                label1.Text = "Вы готовы помочь инвалиду,\nи предлагаете взамен отжаться 10 раз\nинвалид соглашается";
                Otjim();
                button2.Show();

            }
            else
            {
                label1.Text = "Вы расстроили инвалида";
                Sad();
            }

        }

        async private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 1; i < 11; i++)
            {
                button2.Enabled = false;
                Otjim1();
                await Task.Delay(500);
                Otjim2();
                label1.Text = $"Отжимается.. {i} раз";
                await Task.Delay(300);
            }
            await Task.Delay(400);
            Otjim();
            button2.Hide();
            label1.Text = "Инвалид отжался как вы и просили";
            button3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Talk("Вы уверены что готовы дать инвалиду 300 гривен?", "Выбор");

            if (result =="Yes")
            {
                label1.Text = "Инвалид отжимался не просто так\nВсе довольны";
                Happy();
                button3.Hide();
            }
            else
            {
                label1.Text = "Вы разозлили инвалида";
                Angry();
                button3.Hide();
            }
        }

        string Talk(string ttl, string msg)
        {
            //MessageBox.Show(ttl, msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult= MessageBox.Show(ttl, msg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            return result = DialogResult.ToString();
        }

        void Angry()
        {
            pictureBox1.BackgroundImage = Resources.naeb;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Sad()
        {
            pictureBox1.BackgroundImage = Resources.angry;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Happy()
        {
            pictureBox1.BackgroundImage = Resources._300grn;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Neutral()
        {
            pictureBox1.BackgroundImage = Resources.main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Otjim()
        {
            pictureBox1.BackgroundImage = Resources.otjim1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Otjim1()
        {
            pictureBox1.BackgroundImage = Resources.ot1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void Otjim2()
        {
            pictureBox1.BackgroundImage = Resources.ot2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
