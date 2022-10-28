namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey6 : MidiKey
    {
        public MidiKey6(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 6;
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap6;
            mkm.C.performed += COnPerformed;
            mkm.Cs.performed += CsOnPerformed;
            mkm.D.performed += DOnPerformed;
            mkm.Ds.performed += DsOnPerformed;
            mkm.E.performed += EOnPerformed;
            mkm.F.performed += FOnPerformed;
            mkm.Fs.performed += FsOnPerformed;
            mkm.G.performed += GOnPerformed;
            mkm.Gs.performed += GsOnPerformed;
            mkm.A.performed += AOnPerformed;
            mkm.As.performed += AsOnPerformed;
            mkm.B.performed += BOnPerformed;
        }
    }
}