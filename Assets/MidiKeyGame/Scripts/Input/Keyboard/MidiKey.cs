using MidiKeyGame.Scripts.Object;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public abstract class MidiKey
    {
        protected MidiKeyInputAction InputAction;
        protected int Octave;

        protected GameObject ObjC;
        protected GameObject ObjCs;
        protected GameObject ObjD;
        protected GameObject ObjDs;
        protected GameObject ObjE;
        protected GameObject ObjF;
        protected GameObject ObjFs;
        protected GameObject ObjG;
        protected GameObject ObjGs;
        protected GameObject ObjA;
        protected GameObject ObjAs;
        protected GameObject ObjB;

        public abstract void Initialize();

        private void KeyPressed(GameObject gameObject)
        {
            gameObject.GetComponent<MeshRenderer>().material = KeyObjectManager.WhiteKeyPressedMaterial;
        }

        private void WhiteKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<MeshRenderer>().material = KeyObjectManager.WhiteKeyNormalMaterial;
        }
        
        private void BlackKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<MeshRenderer>().material = KeyObjectManager.BlackKeyNormalMaterial;
        }

        // キーが押されたとき OnStarted
        protected virtual void COnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjC);
        }
        protected virtual void CsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjCs);
        }
        protected virtual void DOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjD);
        }
        protected virtual void DsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjDs);
        }
        protected virtual void EOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjE);
        }
        protected virtual void FOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjF);
        }
        protected virtual void FsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjFs);
        }
        protected virtual void GOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjG);
        }
        protected virtual void GsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjGs);
        }
        protected virtual void AOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjA);
        }
        protected virtual void AsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjAs);
        }
        protected virtual void BOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjB);
        }
        
        // キーが離されたとき OnCanceled
        protected virtual void COnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjC);
        }
        protected virtual void CsOnCanceled(InputAction.CallbackContext context)
        {
            BlackKeyReleased(ObjCs);
        }
        protected virtual void DOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjD);
        }
        protected virtual void DsOnCanceled(InputAction.CallbackContext context)
        {
            BlackKeyReleased(ObjDs);
        }
        protected virtual void EOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjE);
        }
        protected virtual void FOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjF);
        }
        protected virtual void FsOnCanceled(InputAction.CallbackContext context)
        {
            BlackKeyReleased(ObjFs);
        }
        protected virtual void GOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjG);
        }
        protected virtual void GsOnCanceled(InputAction.CallbackContext context)
        {
            BlackKeyReleased(ObjGs);
        }
        protected virtual void AOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjA);
        }
        protected virtual void AsOnCanceled(InputAction.CallbackContext context)
        {
            BlackKeyReleased(ObjAs);
        }
        protected virtual void BOnCanceled(InputAction.CallbackContext context)
        {
            WhiteKeyReleased(ObjB);
        }

        // デバッグ用 OnPerformed
        protected virtual void COnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"C{Octave}");
        }
        protected virtual void CsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Cs{Octave}");
        }
        protected virtual void DOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"D{Octave}");
        }
        protected virtual void DsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Ds{Octave}");
        }
        protected virtual void EOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"E{Octave}");
        }
        protected virtual void FOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"F{Octave}");
        }
        protected virtual void FsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Fs{Octave}");
        }
        protected virtual void GOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"G{Octave}");
        }
        protected virtual void GsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"Gs{Octave}");
        }
        protected virtual void AOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"A{Octave}");
        }
        protected virtual void AsOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"As{Octave}");
        }
        protected virtual void BOnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"B{Octave}");
        }
    }
}