﻿using MidiKeyGame.Scripts.Audio;
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

        private void KeyPressed(GameObject gameObject, int pos)
        {
            _keyMaterial.Pressed(gameObject);
            _keyAudio.Play(gameObject, pos);
        }
        
        private void KeyReleased(GameObject gameObject)
        {
            _keyMaterial.Released(gameObject);
            _keyAudio.Stop(gameObject);
        }

        // キーが押されたとき OnStarted
        protected virtual void COnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjC, 60 - 12 * (4 - Octave));
        }
        protected virtual void CsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjCs, 61 - 12 * (4 - Octave));
        }
        protected virtual void DOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjD, 62 - 12 * (4 - Octave));
        }
        protected virtual void DsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjDs, 63 - 12 * (4 - Octave));
        }
        protected virtual void EOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjE, 64 - 12 * (4 - Octave));
        }
        protected virtual void FOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjF, 65 - 12 * (4 - Octave));
        }
        protected virtual void FsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjFs, 66 - 12 * (4 - Octave));
        }
        protected virtual void GOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjG, 67 - 12 * (4 - Octave));
        }
        protected virtual void GsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjGs, 68 - 12 * (4 - Octave));
        }
        protected virtual void AOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjA, 69 - 12 * (4 - Octave));
        }
        protected virtual void AsOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjAs, 70 - 12 * (4 - Octave));
        }
        protected virtual void BOnStarted(InputAction.CallbackContext context)
        {
            KeyPressed(ObjB, 71 - 12 * (4 - Octave));
        }
        
        // キーが離されたとき OnCanceled
        protected virtual void COnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjC);
        }
        protected virtual void CsOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjCs);
        }
        protected virtual void DOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjD);
        }
        protected virtual void DsOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjDs);
        }
        protected virtual void EOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjE);
        }
        protected virtual void FOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjF);
        }
        protected virtual void FsOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjFs);
        }
        protected virtual void GOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjG);
        }
        protected virtual void GsOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjGs);
        }
        protected virtual void AOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjA);
        }
        protected virtual void AsOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjAs);
        }
        protected virtual void BOnCanceled(InputAction.CallbackContext context)
        {
            KeyReleased(ObjB);
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