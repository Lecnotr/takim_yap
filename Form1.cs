using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Media;
using System.Windows;

namespace takım_olustur1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "bf.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string metin = "";
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is System.Windows.Forms.CheckBox && ((System.Windows.Forms.CheckBox)kontrol).Checked)
                {
                    metin += kontrol.Text + "\n";
                }
            }
            foreach (Control kantrol in this.Controls)
            {
                if (kantrol is TextBox && !string.IsNullOrEmpty(kantrol.Text))
                {
                    metin += kantrol.Text + "\n";
                }

                label12.Text = metin;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer
            {
                SoundLocation = "defuse.wav"
            };
            ses.Play();
            {
                foreach (Control kontrol in this.Controls)
                {
                    if (kontrol is System.Windows.Forms.CheckBox)
                    {
                        ((System.Windows.Forms.CheckBox)kontrol).Checked = false;
                    }
                    else if (kontrol is TextBox)
                    {
                        kontrol.Text = "";
                    }
                }
                label12.Text = "";
            }
        }
        readonly Dictionary<string, int> powerLevels = new Dictionary<string, int>()
    {
    {"Serkan", 99},
    {"Akın", 99},
    {"Murat", 75},
    {"Doruk", 75},
    {"Deniz", 75},
    {"Gökhan", 55},
    {"İbrahim", 65},
    {"Fatih", 57},
    {"Ersin", 48},
    {"Bahadır B", 32},
    {"Bahadır D", 37},
    {"Ramazan", 44},
    {"Erdal", 31},
    {"mehmet", 52},
      };
                private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer
            {
                SoundLocation = "planted.wav"
            };
            ses.Play();
            {
                List<string> selectedPlayers = new List<string>();
                
                foreach (string playerName in label12.Text.Split('\n'))
                {
                    if (!string.IsNullOrWhiteSpace(playerName))
                    {
                        selectedPlayers.Add(playerName);
                    }
                }

                // Takım üyelerini güç seviyelerine göre sırala
                List<string> sortedPlayers = selectedPlayers.OrderByDescending(x => powerLevels.ContainsKey(x) ? powerLevels[x] : 50).ToList();

                foreach (string player in selectedPlayers)
                {
                    if (!powerLevels.ContainsKey(player))
                    {
                        // oyuncu ismi listede yoksa default gücü 50 yap

                        powerLevels[player] = 50;
                    }
                }

                // Takımları oluşturmak için
                List<string> team1 = new List<string>();
                List<string> team2 = new List<string>();

                int team1Power = 0;
                int team2Power = 0;

                for (int i = 0; i < sortedPlayers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        // Takım 1e oyuncu eklemek için
                        team1.Add(sortedPlayers[i]);
                        team1Power += powerLevels[sortedPlayers[i]];
                    }
                    else
                    {
                        // Takım 2ye oyuncu eklemek için
                        team2.Add(sortedPlayers[i]);
                        team2Power += powerLevels[sortedPlayers[i]];
                    }
                }
                
                string team1Text = "";
                foreach (string player in team1)
                {
                    team1Text += player + "\n";
                }
                
                label10.Text = team1Text;
                 
                string team2Text = "";
                foreach (string player in team2)
                {
                    team2Text += player + "\n";
                }
                label11.Text = team2Text;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            {
                this.Close(); // kapatma tuşu
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        bool mov;
        int MovX, MovY;
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov=true; MovX=e.X; MovY=e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X-MovX,MousePosition.Y-MovY); 
            
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov=false;
        }
              
    }

}