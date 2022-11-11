using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey8 : MidiKey
    {
        public MidiKey8(MidiKeyInputAction inputAction)
        {
            this.InputAction = inputAction;
            Octave = 8;
            
            var keys = KeyObjectManager.Keys8;
            ObjC = keys["C"];
        }
        
        public override void Initialize()
        {
            var mkm = InputAction.MidiKeyMap8;
            mkm.C.started += COnStarted;
            mkm.C.canceled += COnCanceled;
        }
    }
}