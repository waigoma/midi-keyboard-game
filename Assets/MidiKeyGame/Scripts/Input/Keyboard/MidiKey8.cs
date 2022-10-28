namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey8 : MidiKey
    {
        public MidiKey8(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 8;
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap8;
            mkm.C.performed += COnPerformed;
        }
    }
}