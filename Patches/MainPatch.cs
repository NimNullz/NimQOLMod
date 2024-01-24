using HarmonyLib;
using NimsQOLMod;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NimsQOLMod.Patches
{
    /// <summary>
    /// This is an example patch, made to demonstrate how to use Harmony. You should remove it if it is not used.
    /// </summary>
    [HarmonyPatch(typeof(GorillaTagger))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    internal class MainPatch
    {
        private static void Postfix()
        {
            // starts up the Mod
            new GameObject().AddComponent<MainMod>();
            MainMod.Initialize();
        }
    }
}
