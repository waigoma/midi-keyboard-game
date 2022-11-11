using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey6 : MidiKey
    {
        public MidiKey6(MidiKeyInputAction inputAction)
        {
            this.InputAction = inputAction;
            Octave = 6;
            
            var keys = KeyObjectManager.Keys6;
            ObjC = keys["C"];
            ObjCs = keys["C#"];
            ObjD = keys["D"];
            ObjDs = keys["D#"];
            ObjE = keys["E"];
            ObjF = keys["F"];
            ObjFs = keys["F#"];
            ObjG = keys["G"];
            ObjGs = keys["G#"];
            ObjA = keys["A"];
            ObjAs = keys["A#"];
            ObjB = keys["B"];
        }
        
        public override void Initialize()
        {
            var mkm = InputAction.MidiKeyMap6;
            mkm.C.started += COnStarted;
            mkm.Cs.started += CsOnStarted;
            mkm.D.started += DOnStarted;
            mkm.Ds.started += DsOnStarted;
            mkm.E.started += EOnStarted;
            mkm.F.started += FOnStarted;
            mkm.Fs.started += FsOnStarted;
            mkm.G.started += GOnStarted;
            mkm.Gs.started += GsOnStarted;
            mkm.A.started += AOnStarted;
            mkm.As.started += AsOnStarted;
            mkm.B.started += BOnStarted;
            
            mkm.C.canceled += COnCanceled;
            mkm.Cs.canceled += CsOnCanceled;
            mkm.D.canceled += DOnCanceled;
            mkm.Ds.canceled += DsOnCanceled;
            mkm.E.canceled += EOnCanceled;
            mkm.F.canceled += FOnCanceled;
            mkm.Fs.canceled += FsOnCanceled;
            mkm.G.canceled += GOnCanceled;
            mkm.Gs.canceled += GsOnCanceled;
            mkm.A.canceled += AOnCanceled;
            mkm.As.canceled += AsOnCanceled;
            mkm.B.canceled += BOnCanceled;
        }
    }
}