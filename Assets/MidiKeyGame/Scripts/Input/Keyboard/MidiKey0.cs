using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey0 : MidiKey
    {
        public MidiKey0(MidiKeyInputAction inputAction)
        {
            this.InputAction = inputAction;
            Octave = 0;

            var keys = KeyObjectManager.Keys0;
            ObjA = keys["A"];
            ObjAs = keys["A#"];
            ObjB = keys["B"];
        }
        
        public override void Initialize()
        {
            var mkm = InputAction.MidiKeyMap0;
            mkm.A.started += AOnStarted;
            mkm.As.started += AsOnStarted;
            mkm.B.started += BOnStarted;
            
            mkm.A.canceled += AOnCanceled;
            mkm.As.canceled += AsOnCanceled;
            mkm.B.canceled += BOnCanceled;
        }
    }
}