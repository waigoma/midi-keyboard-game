using System;
using UnityEngine;

namespace MidiKeyGame.Scripts.Button
{
    public class PlayButton : MonoBehaviour
    {
        private MidiPlayerBehavior _midiPlayerBehavior;
        
        private void Start()
        {
            _midiPlayerBehavior = GetComponent<MidiPlayerBehavior>();
        }

        public void OnClick()
        {
            _midiPlayerBehavior.PlayIndex();
        }
    }
}