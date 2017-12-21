using MusicBuilder.SoundBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSoundBuilder builder = new DrumSoundBuilder(250, 20);

            builder.PlaySoundSequence();

            Console.ReadLine();
        }
    }
}
