using System.Collections.Generic;
using UnityEngine;

namespace MidiKeyGame.Scripts.Object
{
    public static class KeyObjectManager
    {
        public static readonly Dictionary<string, GameObject> Keys0 = new();
        public static readonly Dictionary<string, GameObject> Keys1 = new();
        public static readonly Dictionary<string, GameObject> Keys2 = new();
        public static readonly Dictionary<string, GameObject> Keys3 = new();
        public static readonly Dictionary<string, GameObject> Keys4 = new();
        public static readonly Dictionary<string, GameObject> Keys5 = new();
        public static readonly Dictionary<string, GameObject> Keys6 = new();
        public static readonly Dictionary<string, GameObject> Keys7 = new();
        public static readonly Dictionary<string, GameObject> Keys8 = new();

        public static Material WhiteKeyNormalMaterial { get; private set; }
        public static Material BlackKeyNormalMaterial { get; private set; }
        public static Material WhiteKeyPressedMaterial { get; private set; }
        
        public static void SetWhiteKeyNormalMaterial(Material material) => WhiteKeyNormalMaterial = material;
        public static void SetBlackKeyNormalMaterial(Material material) => BlackKeyNormalMaterial = material;
        public static void SetWhiteKeyPressedMaterial(Material material) => WhiteKeyPressedMaterial = material;
    }
}