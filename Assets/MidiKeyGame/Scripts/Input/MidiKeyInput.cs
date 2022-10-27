using System.Collections.Generic;
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
                new MidiKey3(_inputAction),
                new MidiKey4(_inputAction),
                new MidiKey5(_inputAction),
            };
            
            foreach (var mk in mkList) mk.Initialize();
            
            _inputAction.Enable();
        }
    }

}
