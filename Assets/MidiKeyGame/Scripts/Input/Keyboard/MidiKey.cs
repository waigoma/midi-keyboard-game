using MidiKeyGame.Scripts.Audio;
using MidiKeyGame.Scripts.MidiInterface;
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

        private readonly KeyAudio _keyAudio = new ();
        private readonly KeyMaterial _keyMaterial = new ();
        
        public abstract void Initialize();

        private void KeyPressed(GameObject gameObject, int pos, float value)
        {
            _keyMaterial.Pressed(gameObject);
            MidiOutBehaviour.MidiOutPort.SendNoteOn(0, pos, (int) (value * 127));
            // _keyAudio.Play(gameObject, pos);
        }
        
        private void KeyReleased(GameObject gameObject, int pos)
        {
            _keyMaterial.Released(gameObject);
            MidiOutBehaviour.MidiOutPort.SendNoteOff(0, pos);
            // _keyAudio.Stop(gameObject);
        }

        // キーが押されたとき OnStarted
        protected virtual void COnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjC, 60 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void CsOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjCs, 61 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void DOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjD, 62 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void DsOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjDs, 63 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void EOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjE, 64 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void FOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjF, 65 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void FsOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjFs, 66 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void GOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjG, 67 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void GsOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjGs, 68 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void AOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjA, 69 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void AsOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjAs, 70 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        protected virtual void BOnStarted(InputAction.CallbackContext ctx)
        {
            KeyPressed(ObjB, 71 - 12 * (4 - Octave), ctx.ReadValue<float>());
        }
        
        // キーが離されたとき OnCanceled
        protected virtual void COnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjC, 60 - 12 * (4 - Octave));
        }
        protected virtual void CsOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjCs, 61 - 12 * (4 - Octave));
        }
        protected virtual void DOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjD, 62 - 12 * (4 - Octave));
        }
        protected virtual void DsOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjDs, 63 - 12 * (4 - Octave));
        }
        protected virtual void EOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjE, 64 - 12 * (4 - Octave));
        }
        protected virtual void FOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjF, 65 - 12 * (4 - Octave));
        }
        protected virtual void FsOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjFs, 66 - 12 * (4 - Octave));
        }
        protected virtual void GOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjG, 67 - 12 * (4 - Octave));
        }
        protected virtual void GsOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjGs, 68 - 12 * (4 - Octave));
        }
        protected virtual void AOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjA, 69 - 12 * (4 - Octave));
        }
        protected virtual void AsOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjAs, 70 - 12 * (4 - Octave));
        }
        protected virtual void BOnCanceled(InputAction.CallbackContext ctx)
        {
            KeyReleased(ObjB, 71 - 12 * (4 - Octave));
        }

        // デバッグ用 OnPerformed
        protected virtual void COnPerformed(InputAction.CallbackContext ctx)
        {
            Debug.Log($"C{Octave}, {ctx.ReadValue<float>()}");
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