using MidiKeyGame.Scripts.Object;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public abstract class MidiKey
    {
        protected MidiKeyInputAction inputAction;
        protected int octave;

        protected GameObject objC;
        protected GameObject objCs;
        protected GameObject objD;
        protected GameObject objDs;
        protected GameObject objE;
        protected GameObject objF;
        protected GameObject objFs;
        protected GameObject objG;
        protected GameObject objGs;
        protected GameObject objA;
        protected GameObject objAs;
        protected GameObject objB;

        public abstract void Initialize();

        protected void KeyPressed(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.WhiteKeyPressedMaterial;
        }

        protected void WhiteKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.WhiteKeyNormalMaterial;
        }
        
        protected void BlackKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.BlackKeyNormalMaterial;
        }

        protected virtual void COnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objC);
        }

        protected virtual void CsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objCs);
        }

        protected virtual void DOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objD);
        }

        protected virtual void DsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objDs);
        }

        protected virtual void EOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objE);
        }

        protected virtual void FOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objF);
        }

        protected virtual void FsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objFs);
        }

        protected virtual void GOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objG);
        }

        protected virtual void GsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objGs);
        }

        protected virtual void AOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objA);
        }

        protected virtual void AsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objAs);
        }

        protected virtual void BOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(objB);
        }
        
        protected virtual void COnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objC);
        }

        protected virtual void CsOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objCs);
        }

        protected virtual void DOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objD);
        }

        protected virtual void DsOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objDs);
        }

        protected virtual void EOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objE);
        }

        protected virtual void FOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objF);
        }

        protected virtual void FsOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objFs);
        }

        protected virtual void GOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objG);
        }

        protected virtual void GsOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objGs);
        }

        protected virtual void AOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objA);
        }

        protected virtual void AsOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objAs);
        }

        protected virtual void BOnCanceled(InputAction.CallbackContext context)
        {
            KeyPressed(objB);
        }

        protected virtual void COnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"C{octave}");
        }
        protected virtual void CsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Cs{octave}");
        }
        protected virtual void DOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"D{octave}");
        }
        protected virtual void DsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Ds{octave}");
        }
        protected virtual void EOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"E{octave}");
        }
        protected virtual void FOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"F{octave}");
        }
        protected virtual void FsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Fs{octave}");
        }
        protected virtual void GOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"G{octave}");
        }
        protected virtual void GsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Gs{octave}");
        }
        protected virtual void AOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"A{octave}");
        }
        protected virtual void AsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"As{octave}");
        }
        protected virtual void BOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"B{octave}");
        }
    }
}