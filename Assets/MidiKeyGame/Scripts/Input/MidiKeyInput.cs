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

            var mk4 = new MidiKey4(_inputAction);
            mk4.Initialize();
            
            _inputAction.Enable();
        }
    }

}
