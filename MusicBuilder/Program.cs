using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBuilder
{
    class Program
    {
        static System.Media.SoundPlayer player;

        static void Main(string[] args)
        {
            player = new System.Media.SoundPlayer("sounds/CYCdh_AcouKick-20.wav");

            const int tempo = 60;
            const int length = 30;

            int sleepSec = 60 / tempo;
            int loops = length / sleepSec;

            for(int i = 0;i < loops; i++)
            {
                player.Play();
                System.Threading.Thread.Sleep(sleepSec * 1000);
            }
        }
    }
}
