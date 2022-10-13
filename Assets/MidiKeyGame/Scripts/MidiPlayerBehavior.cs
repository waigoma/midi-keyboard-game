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
        }

        public void PlayIndex()
        {
            MidiPlayerController.SetIndex(index);
            _midiPlayerController.PlayIndexMidi();
        }
        
        public void SetIndex(int idx)
        {
            index = idx;
        }
    }
}