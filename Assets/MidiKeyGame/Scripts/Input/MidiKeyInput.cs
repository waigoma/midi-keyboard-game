using UnityEngine;
using UnityEngine.InputSystem;

namespace MidiKeyGame.Scripts.Input
{
    public class MidiKeyInput : MonoBehaviour
    {
        private MidiKeyInputAction _inputAction;
        
        private void Start()
        {
            _inputAction = new MidiKeyInputAction();

            _inputAction.MidiKeyMap4.C.performed += C4OnPerformed;
            
            _inputAction.Enable();
        }

        private void C4OnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log("C4");
        }
    }

}
