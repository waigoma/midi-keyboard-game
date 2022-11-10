using MidiKeyGame.Scripts.Object;

namespace MidiKeyGame.Scripts.Input.Keyboard
{
    public class MidiKey7 : MidiKey
    {
        public MidiKey7(MidiKeyInputAction inputAction)
        {
            this.inputAction = inputAction;
            octave = 7;
            
            var keys = KeyObjectManager.Keys7;
            objC = keys["C"];
            objCs = keys["C#"];
            objD = keys["D"];
            objDs = keys["D#"];
            objE = keys["E"];
            objF = keys["F"];
            objFs = keys["F#"];
            objG = keys["G"];
            objGs = keys["G#"];
            objA = keys["A"];
            objAs = keys["A#"];
            objB = keys["B"];
        }
        
        public override void Initialize()
        {
            var mkm = inputAction.MidiKeyMap7;
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