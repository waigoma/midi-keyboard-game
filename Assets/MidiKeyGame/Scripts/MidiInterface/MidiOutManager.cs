using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MidiKeyGame.Scripts.MidiInterface
{
    public class MidiOutManager
    {
        private MidiProbe _midiProbe;
        private readonly List<MidiOutPort> _ports = new();
        
        // Does the port seem real or not?
        // This is mainly used on Linux (ALSA) to filter automatically generated
        // virtual ports.
        private static bool IsRealPort(string pname) => !pname.Contains("Through") && !pname.Contains("RtMidi");
        
        private void Initialize()
        {
            _midiProbe = new MidiProbe(MidiProbe.Mode.Out);
            
            // 初期化ポートスキャン
            DisposePorts();
            ScanPorts();
            
            // 全てのノートをオフにする
            foreach (var port in _ports) port?.SendAllOff(0);
        }

        private void UpdatePort()
        {
            if (_ports.Count == _midiProbe.PortCount) return;
            
            // ポート数が変化したら再スキャン
            DisposePorts();
            ScanPorts();
        }

        // 全てのポートをスキャンしてオープン
        private void ScanPorts()
        {
            foreach (var i in Enumerable.Range(0, _midiProbe.PortCount))
            {
                var nm = _midiProbe.GetPortName(i);
                _ports.Add(IsRealPort(nm) ? new MidiOutPort(i) : null);
                Debug.Log($"Midi-out port found: {nm}");
            }
        }
        
        // 全てのポートをクローズして破棄
        private void DisposePorts()
        {
            foreach (var p in _ports) p?.Dispose();
            _ports.Clear();
        }
    }
}