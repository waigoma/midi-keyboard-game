using System;
using UnityEngine;

namespace MidiKeyGame.Scripts.Button
{
    public class PlayButton : MonoBehaviour
    {
        private MidiPlayerBehavior _midiPlayerBehavior;
        
        private void Start()
        {
            _midiPlayerBehavior = FindObjectOfType<MidiPlayerBehavior>();
        }

        public void OnClick()
        {
            _midiPlayerBehavior.PrintMidiEvents();
            _midiPlayerBehavior.PlayIndex();
            Debug.Log("onClick");
        }
    }
}