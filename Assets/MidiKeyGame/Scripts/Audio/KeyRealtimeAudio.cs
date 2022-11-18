using MeltySynth;
using UnityEngine;

namespace MidiKeyGame.Scripts.Audio
{
    public class KeyRealtimeAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        private readonly Synthesizer _synthesizer = SynthManager.Synth;
        
        private void Update()
        {
            
        }
    }
}