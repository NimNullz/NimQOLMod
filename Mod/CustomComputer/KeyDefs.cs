using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class KeyDefs : MonoBehaviour
    {
        public static KeyDefs Instance;

        public static List<GameObject> TreeRoomKeys = new List<GameObject>();
        private static GameObject TreeRoomKeysParent;

        private void Start()
        {
            TreeRoomKeysParent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys");
        }

        public static void InitTreeRoomKeys()
        {
            foreach (Transform child in TreeRoomKeysParent.transform)
            {
                if (child.gameObject.tag == "CustomKey")
                {
                    TreeRoomKeys.Add(child.gameObject);
                }
            }
        }
    }
}
