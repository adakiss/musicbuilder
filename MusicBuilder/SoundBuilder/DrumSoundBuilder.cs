using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBuilder.SoundBuilder
{
    public class DrumSoundBuilder : AbstractSoundBuilder
    {
        String[] soundFiles;

        public DrumSoundBuilder(float tempo, float length) : base(tempo, length)
        {
            soundFiles = Directory.GetFiles("sounds\\drum", "*.wav");
            Console.WriteLine(soundFiles.Length);
        }


        public override void PlaySoundSequence()
        {
            //player.SoundLocation = "sounds/drum/CYCdh_K1close_ClHat-01.wav";
            Random r = new Random();
            
            for (int i = 0; i < (int)LoopCount; i++)
            {
                player.SoundLocation = soundFiles[r.Next(soundFiles.Length)];
                Console.WriteLine(player.SoundLocation);
                player.Play();
                System.Threading.Thread.Sleep((int)(SleepSec * 1000));
            }
        }
    }
}
