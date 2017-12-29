using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Resources;

namespace applause
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isplaying = false;

        private SoundPlayer player = new SoundPlayer(applause.Properties.Resources.Crowd_Applaud_Cheer_13215_Free_Loops_com);

        public void playaudio()
        {
                player.Play();
                isplaying = true;
        }

        public void stopaudio()
        {
            if (isplaying == true)
            {
                player.Stop();
                isplaying = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isplaying == false)
            {
                button1.Image = applause.Properties.Resources.applause1;
                playaudio();
            }
            else
            {
                button1.Image = applause.Properties.Resources.applause2;
                stopaudio();
            }
        }


    }
}
