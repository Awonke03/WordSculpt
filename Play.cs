using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSculpt
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }
        string[] words;
        string[] play = new string[6];
        string[] letter = new string[6];


        public void letters()
        {
            string l = "";

            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int u = 0;

            foreach (string w in play)
            {
                l = "";

                foreach (char c in alpha)
                {
                    if (w.Contains(c))
                        l = l + c;


                }

                letter[u] = l;
                u++;

            }
        }
        Random random = new Random();
        public int word_length;
        int maxAttempts = 30000; // or any other reasonable value
        int attempts = 0;
        public void generatewords()
        {
            int num = 0;
            string s = "";
            for (int i = 0; i < 6; i++)
            {
                attempts = 0;

                do
                {
                    num = random.Next(len);
                    s = words[num];
                    attempts++;
                    if (attempts >= maxAttempts)
                    {
                        //MessageBox.Show($"{attempts}");
                        break;
                    }


                } while (s.Length > word_length);
                //MessageBox.Show($"{num}");
                play[i] = words[num];
            }

            letters();


        }
        public int len = 0;
        private void Play_Load(object sender, EventArgs e)
        {
            int i = 0; int j = 0;
            if (File.Exists("Words.txt"))
            {
                words = File.ReadAllLines("Words.txt");
                foreach (string word in words)
                {
                    string cleanLine = Regex.Replace(word, "[^a-zA-Z]", " ");
                    if (cleanLine.Length > 1 && cleanLine != "")
                    {
                        words[i] = cleanLine;
                        if (cleanLine.Length > j)
                            j = cleanLine.Length;
                        i++;

                    }

                }
                // MessageBox.Show($"{j}");
                len = i;



            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rbneasy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbneasy_Click(object sender, EventArgs e)
        {
            generatewords();
            word_length = 5;
            rbneasy.Checked = true;
            rbnhard.Checked = false;
            rbnint.Checked = false;
            btnCheck.Enabled = true;
            lbl1.Text = letter[0];
            lbl2.Text = letter[1];
            lbl3.Text = letter[2];
            lbl4.Text = letter[3];
            lbl5.Text = letter[4];
            lbl6.Text = letter[5];
        }

        private void rbnint_Click(object sender, EventArgs e)
        {
            generatewords();
            word_length = 10;
            rbnint.Checked = true;
            rbnhard.Checked = false;
            rbneasy.Checked = false;
            btnCheck.Enabled = true;
            lbl1.Text = letter[0];
            lbl2.Text = letter[1];
            lbl3.Text = letter[2];
            lbl4.Text = letter[3];
            lbl5.Text = letter[4];
            lbl6.Text = letter[5];
        }

        private void rbnhard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbnhard_Click(object sender, EventArgs e)
        {
            generatewords();
            word_length = 18;
            rbnhard.Checked = true;
            rbneasy.Checked = false;
            rbnint.Checked = false;
            btnCheck.Enabled = true;
            lbl1.Text = letter[0];
            lbl2.Text = letter[1];
            lbl3.Text = letter[2];
            lbl4.Text = letter[3];
            lbl5.Text = letter[4];
            lbl6.Text = letter[5];
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txth1.Text != letter[0])
                MessageBox.Show($"word 1 is not correct");

            else if (txth2.Text != letter[1])
                MessageBox.Show($"word 2 is not correct");
            else if (txth3.Text != letter[2])
                MessageBox.Show($"word 3 is not correct");
            else if (txth4.Text != letter[3])
                MessageBox.Show($"word 4 is not correct");
            else if (txth5.Text != letter[4])
                MessageBox.Show($"word 5 is not correct");
            else if (txth6.Text != letter[5])
                MessageBox.Show($"word 1 is not correct");
            else
            {
                MessageBox.Show($"Congradulations!!!\n You have Won the game", "Win");



                if (rbnhard.Checked == true)
                {
                    word_length = 18;
                    generatewords();
                    lbl1.Text = letter[0];
                    lbl2.Text = letter[1];
                    lbl3.Text = letter[2];
                    lbl4.Text = letter[3];
                    lbl5.Text = letter[4];
                    lbl6.Text = letter[5];
                    rbneasy.Checked = false;
                    rbnint.Checked = false;
                    btnCheck.Enabled = true;

                }

                else if (rbneasy.Checked == false)
                {
                    word_length = 6;
                    generatewords();
                    lbl1.Text = letter[0];
                    lbl2.Text = letter[1];
                    lbl3.Text = letter[2];
                    lbl4.Text = letter[3];
                    lbl5.Text = letter[4];
                    lbl6.Text = letter[5];
                    rbneasy.Checked = false;
                    rbnint.Checked = false;
                    btnCheck.Enabled = true;

                }

                else if (rbnint.Checked = false)
                {
                    word_length = 11;
                    generatewords();
                    lbl1.Text = letter[0];
                    lbl2.Text = letter[1];
                    lbl3.Text = letter[2];
                    lbl4.Text = letter[3];
                    lbl5.Text = letter[4];
                    lbl6.Text = letter[5];
                    rbneasy.Checked = false;
                    rbnint.Checked = false;
                    btnCheck.Enabled = true;

                }
                else
                {
                    btnCheck.Enabled = false;
                    MessageBox.Show("Select A level of difficulty");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
