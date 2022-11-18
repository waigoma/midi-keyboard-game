using MeltySynth;
using UnityEngine;

namespace MidiKeyGame.Scripts.Audio
{
    public class KeyAudio
    {
        private const string SoundFont = "./Assets/MidiKeyGame/SoundFont/Equinox_Grand_Pianos.sf2";
        private const int SampleRate = 44100;
        private const int Velocity = 100;
        private const int Length = 10;
        
        private readonly Synthesizer _synthesizer = new (SoundFont, SampleRate);

        public AudioClip CreateAudio(int noteNumber, string name)
        {
            var audioData = RenderAudio(noteNumber);
            
            var clip = AudioClip.Create(name, Length * SampleRate, 2, SampleRate, false);
            clip.SetData(audioData, 0);

            return clip;
        }

        private float[] RenderAudio(int noteNumber)
        {
            _synthesizer.NoteOn(0, noteNumber, Velocity);
            
            var left = new float[Length * SampleRate];
            var right = new float[Length * SampleRate];
            _synthesizer.Render(left, right);

            return left;
        }
    }
}