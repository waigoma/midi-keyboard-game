using System.Collections.Generic;
using MidiPlayerTK;
using UnityEngine;

namespace MidiKeyGame.Scripts
{
    public class MidiPlayerController
    {
        private static int index = 0;
        
        private MidiFileLoader _midiLoader;
        private MidiFilePlayer _midiPlayer;
        
        public MidiPlayerController(MidiFileLoader midiLoader, MidiFilePlayer midiPlayer)
        {
            _midiLoader = midiLoader;
            _midiPlayer = midiPlayer;
        }
        
        /// <summary>
        /// index の midi ファイルの情報を読み込み、返す。
        /// </summary>
        /// <returns>index の midi ファイル情報</returns>
        public List<MPTKEvent> GetMidiEvents()
        {
            if (_midiLoader == null)
            {
                Debug.LogWarning("MidiLoader is null");
                return null;
            }

            _midiLoader.MPTK_MidiIndex = index;
            _midiLoader.MPTK_Load();

            return _midiLoader.MPTK_ReadMidiEvents();
        }

        public void PlayIndexMidi()
        {
            if (_midiPlayer == null)
            {
                Debug.LogWarning("MidiPlayer is null");
                return;
            }
         
            _midiPlayer.MPTK_MidiIndex = index;
            _midiPlayer.MPTK_Play();
        }
        
        public static void SetIndex(int newIndex)
        {
            index = newIndex;
        }
    }
}