using System.Collections.Generic;
using UnityEngine;

namespace MidiKeyGame.Scripts.Object
{
    public class KeyObjectBehavior : MonoBehaviour
    {
        [SerializeField] private GameObject key0;
        [SerializeField] private GameObject key1;
        [SerializeField] private GameObject key2;
        [SerializeField] private GameObject key3;
        [SerializeField] private GameObject key4;
        [SerializeField] private GameObject key5;
        [SerializeField] private GameObject key6;
        [SerializeField] private GameObject key7;
        [SerializeField] private GameObject key8;
        
        private readonly Dictionary<string, GameObject> _keys0 = new ();
        private readonly Dictionary<string, GameObject> _keys1 = new ();
        private readonly Dictionary<string, GameObject> _keys2 = new ();
        private readonly Dictionary<string, GameObject> _keys3 = new ();
        private readonly Dictionary<string, GameObject> _keys4 = new ();
        private readonly Dictionary<string, GameObject> _keys5 = new ();
        private readonly Dictionary<string, GameObject> _keys6 = new ();
        private readonly Dictionary<string, GameObject> _keys7 = new ();
        private readonly Dictionary<string, GameObject> _keys8 = new ();
        
        private void Awake()
        {
            var keys = new Dictionary<Dictionary<string, GameObject>, GameObject>
            {
                {_keys0, key0},
                {_keys1, key1},
                {_keys2, key2},
                {_keys3, key3},
                {_keys4, key4},
                {_keys5, key5},
                {_keys6, key6},
                {_keys7, key7},
                {_keys8, key8}
            };

            foreach (var (dic, key) in keys)
            {
                var children = key.GetComponentInChildren<Transform>();

                if (children.childCount == 0) 
                    return;

                foreach (Transform child in children)
                {
                    switch (child.name)
                    {
                        case "C":
                           dic["C"] = child.gameObject;
                            break;
                        case "C#":
                            dic["C#"] = child.gameObject;
                            break;
                        case "D":
                            dic["D"] = child.gameObject;
                            break;
                        case "D#":
                            dic["D#"] = child.gameObject;
                            break;
                        case "E":
                            dic["E"] = child.gameObject;
                            break;
                        case "F":
                            dic["F"] = child.gameObject;
                            break;
                        case "F#":
                            dic["F#"] = child.gameObject;
                            break;
                        case "G":
                            dic["G"] = child.gameObject;
                            break;
                        case "G#":
                            dic["G#"] = child.gameObject;
                            break;
                        case "A":
                            dic["A"] = child.gameObject;
                            break;
                        case "A#":
                            dic["A#"] = child.gameObject;
                            break;
                        case "B":
                            dic["B"] = child.gameObject;
                            break;
                    }
                }
            }
        }
    }
}
