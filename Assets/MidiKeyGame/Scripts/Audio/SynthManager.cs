using MeltySynth;

namespace MidiKeyGame.Scripts.Audio
{
    public static class SynthManager
    {
        private const string SoundFont = "./Assets/MidiKeyGame/SoundFont/Equinox_Grand_Pianos.sf2";
        private const int SampleRate = 44100;
        private const int Velocity = 100;
        private const int Length = 10;
        
        public static readonly Synthesizer Synth = new (SoundFont, SampleRate);
        
        public static void NoteOn(int note)
        {
            Synth.NoteOn(0, note, Velocity);
        }
        
        public static void NoteOff(int note)
        {
            Synth.NoteOff(0, note);
        }
    }
}