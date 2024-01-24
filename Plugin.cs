using BepInEx;
using System;
using UnityEngine;

namespace NimsQOLMod
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // applies the harmony patches
        void Awake()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            DontDestroyOnLoad(this);
        }
    }
}
