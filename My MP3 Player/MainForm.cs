using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_MP3_Player
{
    public partial class MainForm : Form
    {
        private MyMP3Player mp3player = new MyMP3Player();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog())
            {
                ofd.Filter="MP3 Files|*.mp3";
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    mp3player.open(ofd.FileName);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mp3player.play();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mp3player.stop();
        }

    }
}
