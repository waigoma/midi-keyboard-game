﻿using RtMidiDll = RtMidi.Unmanaged;

namespace MidiKeyGame.Scripts.MidiInterface
{
    public sealed unsafe class MidiOutPort : System.IDisposable
    {
        private RtMidiDll.Wrapper* _rtmidi;
        
        public int PortNumber { get; }
        public string PortName { get; }

        public MidiOutPort(int portNumber, string portName)
        {
            PortNumber = portNumber;
            PortName = portName;
            
            _rtmidi = RtMidiDll.OutCreateDefault();

            if (_rtmidi != null && _rtmidi->ok)
                RtMidiDll.OpenPort(_rtmidi, (uint)portNumber, "RtMidi Out");

            if (_rtmidi == null || !_rtmidi->ok)
                throw new System.InvalidOperationException("Failed to set up a MIDI output port.");
        }

        ~MidiOutPort()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            RtMidiDll.OutFree(_rtmidi);
        }

        public void Dispose()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            RtMidiDll.OutFree(_rtmidi);
            _rtmidi = null;

            System.GC.SuppressFinalize(this);
        }

        public void SendMessage(byte [] data)
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            fixed (byte* ptr = &data[0])
                RtMidiDll.OutSendMessage(_rtmidi, ptr, data.Length);
        }

        public void SendNoteOn(int channel, int note, int velocity)
        {
            SendMessage((byte)(0x90 + channel), (byte)note, (byte)velocity);
        }

        public void SendNoteOff(int channel, int note)
        {
            SendMessage((byte)(0x80 + channel), (byte)note, 64);
        }

        public void SendControlChange(int channel, int number, int value)
        {
            SendMessage((byte)(0xb0 + channel), (byte)number, (byte)value);
        }

        public void SendAllOff(int channel)
        {
            SendMessage((byte)(0xb0 + channel), 120, 0);
        }
        
        private void SendMessage(byte d1, byte d2, byte d3)
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            var msg = stackalloc byte [3] { d1, d2, d3 };
            RtMidiDll.OutSendMessage(_rtmidi, msg, 3);
        }
    }
}