using System;
using System.Collections.Generic;
using System.Linq;
using MeltySynth;
using MidiKeyGame.Scripts.Input.Keyboard;
using UnityEngine;

namespace MidiKeyGame.Scripts.Input
{
    public class MidiKeyInput : MonoBehaviour
    {
        private MidiKeyInputAction _inputAction;

        private void Start()
        {
            _inputAction = new MidiKeyInputAction();

            var mkList = new List<MidiKey>
            {
                new MidiKey0(_inputAction),
                new MidiKey1(_inputAction),
                new MidiKey2(_inputAction),
                new MidiKey3(_inputAction),
                new MidiKey4(_inputAction),
                new MidiKey5(_inputAction),
                new MidiKey6(_inputAction),
                new MidiKey7(_inputAction),
                new MidiKey8(_inputAction)
            };
            
            foreach (var mk in mkList) mk.Initialize();
            
            _inputAction.Enable();
            
            var synth = new Synthesizer("./Assets/MidiKeyGame/SoundFont/Equinox_Grand_Pianos.sf2", 44100);
            synth.NoteOn(0, 60, 50);
            
            var left = new float[3*44100];
            var right = new float[3*44100];
            
            synth.Render(left, right);
            
            synth.NoteOff(0, 60);
            Debug.Log($"left: {left}, right: {right}");
        }
    }

}
