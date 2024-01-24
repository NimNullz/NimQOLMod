using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class PCController : MonoBehaviour
    {
        public ComputerManager monMan;

        public bool isEnabled = false;

        void Awake()
        {
            new GameObject().AddComponent<KeyDefs>();
            KeyDefs.InitTreeRoomKeys();
        }

        public void Update()
        {
            if (Keyboard.current.f10Key.wasPressedThisFrame)
            {
                if (!isEnabled)
                {
                    isEnabled = true;
                } else if (isEnabled)
                {
                    isEnabled = false;
                }
            }
            // keyboard controller
            if (isEnabled)
            {
                switch (Keyboard.current.anyKey.name)
                {
                    case "1":
                        KeyDefs.TreeRoomKeys[0].GetComponent<CustomKeyComponent>().SimulatePress("1", "regular");
                        break;
                }
            }
        }
    }
}
