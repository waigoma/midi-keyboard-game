using MeltySynth;
using UnityEngine;

namespace MidiKeyGame.Scripts.Audio
{
    public class KeyRealtimeAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        private readonly Synthesizer _synthesizer = SynthManager.Synth;
        
        private const float FPS = 60;
        
        private void Update()
        {
            var len = (int) (1 / FPS * _synthesizer.SampleRate);
            var left = new float[len];
            var right = new float[len];
            _synthesizer.Render(left, right);
            
            var clip = AudioClip.Create("test", len, 2, _synthesizer.SampleRate, false);
            clip.SetData(left, 0);
            
            audioSource.PlayOneShot(clip);
        }
    }
}