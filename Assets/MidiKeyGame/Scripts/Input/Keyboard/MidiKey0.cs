using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey0 : MidiKey
    {
        public MidiKey0(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 0;

            var keys = KeyObjectManager.Keys0;
            objA = keys["A"];
            objAs = keys["A#"];
            objB = keys["B"];
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap0;
            mkm.A.started += AOnStarted;
            mkm.As.started += AsOnStarted;
            mkm.B.started += BOnStarted;
            
            mkm.A.canceled += AOnCanceled;
            mkm.As.canceled += AsOnCanceled;
            mkm.B.canceled += BOnCanceled;
        }
    }
}