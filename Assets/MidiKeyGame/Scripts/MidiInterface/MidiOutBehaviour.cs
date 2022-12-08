using UnityEngine;

namespace MidiKeyGame.Scripts.MidiInterface
{
    public class MidiOutBehaviour : MonoBehaviour
    {
        private MidiOutManager _midiOutManager;
        
        public int PortNumber { get; private set; }
        
        public static MidiOutPort MidiOutPort { get; private set; }
        
        
        private void Awake()
        {
            PortNumber = 0;
            _midiOutManager = new MidiOutManager();
            SetMidiOutPort();
        }

        public void SetMidiOutPort() => MidiOutPort = _midiOutManager.GetPort(PortNumber);
    }
}