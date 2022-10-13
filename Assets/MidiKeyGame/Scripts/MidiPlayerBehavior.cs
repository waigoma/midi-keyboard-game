using System;
using MidiPlayerTK;
using UnityEngine;

namespace MidiKeyGame.Scripts
{
    public class MidiPlayerBehavior : MonoBehaviour
    {
        [SerializeField] private int index = 90;
        
        private MidiPlayerController _midiPlayerController;
        
        private void Start()
        {
            var mfl = FindObjectOfType<MidiFileLoader>();
            var mfp = FindObjectOfType<MidiFilePlayer>();
            
            _midiPlayerController = new MidiPlayerController(mfl, mfp);
            MidiPlayerController.SetIndex(index);
        }

        public void PrintMidiEvents()
        {
            foreach (var events in _midiPlayerController.GetMidiEvents())
            {
                if (events.Command == MPTKCommand.NoteOn)
                    Debug.Log($"Note on Time:{events.RealTime} millisecond  Channel:{events.Channel}  Note:{events.Value}  Duration:{events.Duration} millisecond  Velocity:{events.Velocity}");
            }
        }

        public void PlayIndex()
        {
            _midiPlayerController.PlayIndexMidi();
        }
        
        public void SetIndex(int idx)
        {
            index = idx;
        }
    }
}