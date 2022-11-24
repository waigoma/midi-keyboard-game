using MidiJack;
using UnityEngine;

namespace MidiKeyGame.Scripts.Audio
{
    public class TestMSGS : MonoBehaviour
    {
        
        private void Awake()
        {
            MidiMaster.GetKey(MidiChannel.All, 0);
        }

        private void Update()
        {
            Debug.Log(MidiMaster.GetKey(MidiChannel.All, 60));
        }
    }
}