using UnityEngine;

namespace MidiKeyGame.Scripts.Object
{
    public class KeyMaterial
    {
        public void Pressed(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.WhiteKeyPressedMaterial;
        }
        
        public void Released(GameObject gameObject)
        {
            var objName = gameObject.name;
            
            if (objName.Contains("#")) BlackKeyReleased(gameObject);
            else WhiteKeyReleased(gameObject);
        }
        
        private void WhiteKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.WhiteKeyNormalMaterial;
        }
        
        private void BlackKeyReleased(GameObject gameObject)
        {
            gameObject.GetComponent<Renderer>().material = KeyObjectManager.BlackKeyNormalMaterial;
        }
    }
}