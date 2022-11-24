using System;
using MidiJack;
using UnityEngine;

namespace MidiKeyGame.Scripts.Audio
{
    public class TestMSGS : MonoBehaviour
    {
        private MidiDriver _driver;
        
        private void Awake()
        {
            _driver = MidiDriver.Instance;
        }
    }
}