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
        }
    }

}
