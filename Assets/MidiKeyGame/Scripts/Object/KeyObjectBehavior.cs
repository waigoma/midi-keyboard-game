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

        [SerializeField] private Material whiteNormalMaterial;
        [SerializeField] private Material blackNormalMaterial;
        [SerializeField] private Material whitePressedMaterial;

        private void Awake()
        {
            KeyObjectManager.SetWhiteKeyNormalMaterial(whiteNormalMaterial);
            KeyObjectManager.SetBlackKeyNormalMaterial(blackNormalMaterial);
            KeyObjectManager.SetWhiteKeyPressedMaterial(whitePressedMaterial);
            
            var keys = new Dictionary<Dictionary<string, GameObject>, GameObject>
            {
                {KeyObjectManager.Keys0, key0},
                {KeyObjectManager.Keys1, key1},
                {KeyObjectManager.Keys2, key2},
                {KeyObjectManager.Keys3, key3},
                {KeyObjectManager.Keys4, key4},
                {KeyObjectManager.Keys5, key5},
                {KeyObjectManager.Keys6, key6},
                {KeyObjectManager.Keys7, key7},
                {KeyObjectManager.Keys8, key8}
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
