using UnityEngine;
using UnityEngine.InputSystem;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public abstract class MidiKey
    {
        protected MidiKeyInputAction inputAction;
        protected int octave;

        public abstract void Initialize();
        
        protected void COnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"C{octave}");
        }
        
        protected void CsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Cs{octave}");
        }
        
        protected void DOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"D{octave}");
        }
        
        protected void DsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Ds{octave}");
        }
        
        protected void EOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"E{octave}");
        }
        
        protected void FOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"F{octave}");
        }
        
        protected void FsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Fs{octave}");
        }
        
        protected void GOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"G{octave}");
        }
        
        protected void GsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Gs{octave}");
        }
        
        protected void AOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"A{octave}");
        }
        
        protected void AsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"As{octave}");
        }
        
        protected void BOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"B{octave}");
        }
    }
}