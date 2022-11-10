using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey8 : MidiKey
    {
        public MidiKey8(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 8;
            
            var keys = KeyObjectManager.Keys8;
            objC = keys["C"];
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap8;
            mkm.C.started += COnStarted;
            mkm.C.canceled += COnCanceled;
        }
    }
}