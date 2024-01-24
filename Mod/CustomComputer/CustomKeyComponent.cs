using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using UnityEngine;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class CustomKeyComponent : MonoBehaviour
    {
        /// <summary>
        /// This is the component for the keys on the custom computer.
        /// </summary>

        public string Key;
        public string KeyType;
        public ComputerManager CompManager;

        private void OnTriggerEnter(Collider collider)
        {
            if (!(collider.GetComponentInParent<GorillaTriggerColliderHandIndicator>() != null))
            {
                return;
            }

            GorillaTriggerColliderHandIndicator component = collider.GetComponent<GorillaTriggerColliderHandIndicator>();
            if (component != null)
            {
                if (!CompManager.OnCooldown) // if we're not on a keyboard cooldown
                {
                    // changes the button material
                    GetComponent<Renderer>().material = CompManager.PressedMaterial;

                    // key differ function is fired here
                    CompManager.KeyPressDiffer(Key, KeyType);
                    
                    // turns on the cooldown
                    CompManager.OnCooldown = true;
                }
            }
        }

        public void SimulatePress(string Key, string KeyType)
        {
            // key differ function is fired here
            CompManager.KeyPressDiffer(Key, KeyType);
        }

        private void OnTriggerExit(Collider collider)
        {
            if (!(collider.GetComponentInParent<GorillaTriggerColliderHandIndicator>() != null))
            {
                return;
            }

            GorillaTriggerColliderHandIndicator component = collider.GetComponent<GorillaTriggerColliderHandIndicator>();
            if (component != null)
            {
                // changes the button material
                GetComponent<Renderer>().material = CompManager.ReleasedMaterial;
            }
        }
    }
}
