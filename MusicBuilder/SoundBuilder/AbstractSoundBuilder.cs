using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBuilder.SoundBuilder
{
    public abstract class AbstractSoundBuilder
    {
        protected float tempo;
        protected float length;
        protected System.Media.SoundPlayer player;

        public AbstractSoundBuilder(float tempo, float length)
        {
            this.tempo = tempo;
            this.length = length;
            player = new System.Media.SoundPlayer();
        }

        protected float SleepSec
        {
            get { return 60 / tempo; }
        }

        protected float LoopCount
        {
            get { return length / SleepSec; }
        }

        public abstract void PlaySoundSequence();
    }
}
