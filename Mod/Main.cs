// regular references
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
// Mod references
using NimsQOLMod.ModGUI;
using NimsQOLMod.Mod.CustomComputer;
using UnityEngine.Android;

namespace NimsQOLMod
{
    public class MainMod : MonoBehaviour
    {
        public static MainMod Instance;
        public static GameObject ModObject;
        public static bool IsInitialized = false;
        // 3 very important variables

        // mod variables
        public static MainModGUI Gui;
        public static List<GameObject> Computers = new List<GameObject>();

        void Awake()
        {
            Instance = this;
        }

        public static void Initialize() // Initializes the QOL Mod
        {
            // Creates the "ModObject", the object that will function as the backbone of the mod
            ModObject = new GameObject();
            ModObject.name = "NimsQOLMod";

            // sets up the mod's GUI
            ModObject.AddComponent<MainModGUI>();

            // sets up the mod computers
            // computer gameobjects
            GameObject TreeRoomComputer = GameObject.Find("TreeRoomInteractables/Static/monitor");
            GameObject TRCompMonitor = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/monitor");

            new GameObject().AddComponent<CustomComputers>();

            // creates a gameobject that'll hold all of the custom computers
            GameObject ComputerHolder = new GameObject();
            ComputerHolder.name = "ComputerHolder";
            ComputerHolder.transform.parent = ModObject.transform;

            // adds a computer to the list
            Computers.Add(null);
            Computers[0] = CustomComputers.CreateCustomComputer(
                new Vector3(
                    TreeRoomComputer.transform.position.x,
                    TreeRoomComputer.transform.position.y,
                    TreeRoomComputer.transform.position.z
                    ), // the computer's global position
                "QOLModTreeRoomComputer", // object name
                ComputerHolder,
                "TreeRoom",
                FindObjectOfType<GorillaLevelScreen>().myText.font // font: utopium
                ); // creates a computer in the tree room

            // disables the renderers on the regular computer
            TreeRoomComputer.GetComponent<Renderer>().enabled = false;
            TRCompMonitor.SetActive(false);

            // keyboard edit
            new GameObject().AddComponent<KeyboardEdit>();
            KeyboardEdit.InitializeKeysStump(Computers[0].GetComponentInChildren<ComputerManager>());

            // finally, to top things off, we'll set the "IsInitialized" bool to true
            IsInitialized = true;
        }
    }
}
