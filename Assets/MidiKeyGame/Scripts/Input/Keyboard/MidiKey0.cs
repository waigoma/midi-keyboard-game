namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey0 : MidiKey
    {
        public MidiKey0(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 0;
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap0;
            mkm.A.performed += AOnPerformed;
            mkm.As.performed += AsOnPerformed;
            mkm.B.performed += BOnPerformed;
        }
    }
}