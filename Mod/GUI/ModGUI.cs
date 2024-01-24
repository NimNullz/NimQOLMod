using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using NimsQOLMod;
using UnityEngine.UI;
using System.Net.Http.Headers;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem;

namespace NimsQOLMod.ModGUI
{
    public class MainModGUI : MonoBehaviour
    {
        public static MainModGUI Instance; // mandatory.
        public static bool IsInitialized = false; // also mandatory.

        // ui variables
        public static bool IsOpen = false;
        public static bool IsHidden = false;
        // frame stuff
        public static bool PCMovementFrameOpen = false;
        public static bool PlayerSettingsFrameOpen = false;


        void OnGUI()
        {
            if (!IsHidden)
            {
                if (GUI.Button(new Rect(((Screen.width / 2) - 200), 10, 400, 20), "Toggle Nim's QOL Mod UI (F11 to hide or show)"))
                {
                    if (!IsOpen)
                    {
                        IsOpen = true;
                    } else if (IsOpen)
                    {
                        IsOpen = false;
                    }
                }
            }
            if (IsOpen)
            {
                // frame buttons
                if (GUI.Button(new Rect(((Screen.width / 2) - 485), 10, 275, 20), "QOL: PC Movement")) // pc movement frame toggle
                {
                    if (!PCMovementFrameOpen)
                    {
                        PCMovementFrameOpen = true; // shows the pc movement frame
                    } else if (PCMovementFrameOpen)
                    {
                        PCMovementFrameOpen = false; // hides the pc movement frame
                    }
                }
                if (GUI.Button(new Rect(((Screen.width / 2) - 770), 10, 275, 20), "QOL: Player Settings"))
                {
                    if (!PlayerSettingsFrameOpen)
                    {
                        PlayerSettingsFrameOpen = true; // shows the player settings frame
                    } else if (PlayerSettingsFrameOpen)
                    {
                        PlayerSettingsFrameOpen = false; // hides the player settings frame
                    }
                }
                // frames
                if (PCMovementFrameOpen) // pc movement frame
                {
                    // creates its rect
                    GUI.Box(new Rect(((Screen.width / 2) - 485), 40, 275, 350), "PC Movement");
                }
                if (PlayerSettingsFrameOpen) // player settings frame
                {
                    // creates its rect
                    GUI.Box(new Rect(((Screen.width / 2) - 770), 40, 275, 350), "Player Settings");
                    // scrolling frame
                }
            }
        }

        void Update()
        {
            if (Keyboard.current.f11Key.wasReleasedThisFrame)
            {
                if (!IsHidden)
                {
                    IsHidden = true; // hides the ui
                } else if (IsHidden)
                {
                    IsHidden = false; // shows the ui
                }
            }
        }
    }
}
