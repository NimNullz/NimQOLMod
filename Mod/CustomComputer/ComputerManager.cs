using GorillaNetworking;
using NimsQOLMod.Mod.CustomComputer.Tabs;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class ComputerManager : MonoBehaviourPunCallbacks
    {
        public string CurrentTab = "Home"; // specifies the computer's current tab
        public bool InMenu = true; // specifies whether the computer is in the menu or not

        // game settings variables
        public int SelectedTab = 1;
        public List<Text> GSTextLabels = new List<Text>();
        public List<Text> PSTextLabels = new List<Text>();
        public GameObject PlayerSettingsObj;
        public GameObject GameSettingsObj;

        public GameObject PSHomeTabObj;

        public GameObject RoomTabObj;
        public GameObject NameTab;
        public GameObject ColorTabObj;
        public GameObject TurnTabObj;
        public GameObject MicTabObj;
        public GameObject QueueTabObj;
        public GameObject GroupTabObj;
        public GameObject VoiceTabObj;

        public Text SetRoomText;
        public Text CurrentRoomText;
        public Text SetNameText;
        public Text CurrentNameText;
        
        public string SetNameString = "";
        public string SetRoomString = "";
        public string CurrentRoomString = "";

        public ColorTabScript CTScript;

        public Material PressedMaterial = new Material(Shader.Find("GorillaTag/UberShader"));
        public Material ReleasedMaterial = new Material(Shader.Find("GorillaTag/UberShader"));
        public Material DarkMaterial = new Material(Shader.Find("GorillaTag/UberShader"));

        public GameObject PrimitiveCube;

        // cooldown
        public bool OnCooldown = false;
        public float CooldownTimer = 0.05f;
        public float Cooldown = 0.05f;


        void Start()
        {
            PressedMaterial.color = new Color32(255, 0, 0, 255);
            ReleasedMaterial.color = new Color32(255, 255, 255, 255);
            DarkMaterial.color = new Color32(0, 0, 0, 255);
            // creates primitive cube
            PrimitiveCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            UnityEngine.GameObject.Destroy(PrimitiveCube.GetComponent<Rigidbody>());
        }

        public void UpdateTexts()
        {
            // updates texts
            CurrentNameText.text = PlayerPrefs.GetString("playerName");
        }

        // leaving and joining rooms
        public override void OnJoinedRoom()
        {
            CurrentRoomText.text = PhotonNetwork.CurrentRoom.Name;
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            CurrentRoomText.text = "-NOT IN ROOM-";
        }

        public List<GameObject> CreateTabs(string[] tabNames, GameObject objectParent, bool hideOthers)
        {
            List<GameObject> tabs = new List<GameObject>();
            for (int i = 0; i < tabNames.Length; i++)
            {
                // adds an object to the list
                tabs.Add(null);
                tabs[i] = new GameObject();
                tabs[i].name = tabNames[i];
                tabs[i].transform.parent = objectParent.transform;
                tabs[i].transform.localPosition = new Vector3(0f, 0f, 0f); // ensures that the tab isn't away from the object parent
                // if "i" is over zero, then we'll simply hide them if "hideOthers" is true
                if (hideOthers && i > 0)
                {
                    tabs[i].SetActive(false);
                }
            }

            return tabs; // returns the list of gameobjects
        }

        // computer voids

        public void UpdateGSLabels()
        {
            if (CurrentTab == "Home")
            {
                switch (SelectedTab)
                {
                    case 1: // player settings
                        GSTextLabels[0].text = "> PLAYER SETTINGS";
                        GSTextLabels[1].text = "MONITOR CONFIG (NOT IMPLEMENTED)";
                        break;
                    case 2:
                        GSTextLabels[0].text = "PLAYER SETTINGS";
                        GSTextLabels[1].text = "> MONITOR CONFIG (NOT IMPLEMENTED)";
                        break;
                }
            }
        }

        public void UpdatePSLabels()
        {
            if (CurrentTab == "PSHomeTab")
            {
                switch (SelectedTab)
                {
                    case 1:
                        PSTextLabels[0].text = "> ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 2:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "> NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 3:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "> COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 4:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "> TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 5:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "> MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 6:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "> QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 7:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "> GROUP";
                        PSTextLabels[7].text = "VOICE";
                        break;
                    case 8:
                        PSTextLabels[0].text = "ROOM";
                        PSTextLabels[1].text = "NAME";
                        PSTextLabels[2].text = "COLOR";
                        PSTextLabels[3].text = "TURN";
                        PSTextLabels[4].text = "MIC";
                        PSTextLabels[5].text = "QUEUE";
                        PSTextLabels[6].text = "GROUP";
                        PSTextLabels[7].text = "> VOICE";
                        break;
                }
            }
        }

        public void KeyPressDiffer(string KeyString, string KeyTypeString)
        {
            switch (KeyTypeString)
            {
                case "regular":
                    switch (CurrentTab)
                    {
                        case "Home":
                            RegularKeyPress(KeyString);
                            break;
                        case "PSHomeTab":
                            RegularKeyPress(KeyString);
                            break;
                        case "NameTab":
                            RegularKeyPress(KeyString);
                            break;
                        case "RoomTab":
                            RegularKeyPress(KeyString);
                            break;
                        case "ColorTab":
                            CTScript.RegularKeyPress(KeyString);
                            break;
                        case "TurnTab":
                            TurnTabObj.GetComponent<TurnTabScript>().RegularKeyPress(KeyString);
                            break;
                        case "MicTab":
                            MicTabObj.GetComponent<MicTabScript>().RegularKeyPress(KeyString);
                            break;
                        case "QueueTab":
                            QueueTabObj.GetComponent<QueueTabScript>().RegularKeyPress(KeyString);
                            break;
                        case "GroupTab":
                            GroupTabObj.GetComponent<GroupTabScript>().RegularKeyPress(KeyString);
                            break;
                        case "VoiceTab":
                            VoiceTabObj.GetComponent<VoiceTabScript>().RegularKeyPress(KeyString);
                            break;
                    }
                    break;
                case "special":
                    switch (CurrentTab)
                    {
                        case "Home":
                            SpecialKeyPress(KeyString);
                            break;
                        case "PSHomeTab":
                            SpecialKeyPress(KeyString);
                            break;
                        case "NameTab":
                            SpecialKeyPress(KeyString);
                            break;
                        case "RoomTab":
                            SpecialKeyPress(KeyString);
                            break;
                        case "ColorTab":
                            CTScript.SpecialKeyPress(KeyString);
                            break;
                        case "TurnTab":
                            TurnTabObj.GetComponent<TurnTabScript>().SpecialKeyPress(KeyString);
                            break;
                        case "MicTab":
                            MicTabObj.GetComponent<MicTabScript>().SpecialKeyPress(KeyString);
                            break;
                        case "QueueTab":
                            QueueTabObj.GetComponent<QueueTabScript>().SpecialKeyPress(KeyString);
                            break;
                        case "GroupTab":
                            GroupTabObj.GetComponent<GroupTabScript>().SpecialKeyPress(KeyString);
                            break;
                        case "VoiceTab":
                            VoiceTabObj.GetComponent<VoiceTabScript>().SpecialKeyPress(KeyString);
                            break;
                    }
                    break;
                case "arrow":
                    switch (CurrentTab)
                    {
                        case "Home":
                            ArrowKeyPress(KeyString);
                            break;
                        case "PSHomeTab":
                            ArrowKeyPress(KeyString);
                            break;
                        case "NameTab":
                            ArrowKeyPress(KeyString);
                            break;
                        case "RoomTab":
                            ArrowKeyPress(KeyString);
                            break;
                        case "ColorTab":
                            CTScript.ArrowKeyPress(KeyString);
                            break;
                        case "TurnTab":
                            TurnTabObj.GetComponent<TurnTabScript>().ArrowKeyPress(KeyString);
                            break;
                        case "MicTab":
                            MicTabObj.GetComponent<MicTabScript>().ArrowKeyPress(KeyString);
                            break;
                        case "QueueTab":
                            QueueTabObj.GetComponent<QueueTabScript>().ArrowKeyPress(KeyString);
                            break;
                        case "GroupTab":
                            GroupTabObj.GetComponent<GroupTabScript>().ArrowKeyPress(KeyString);
                            break;
                        case "VoiceTab":
                            VoiceTabObj.GetComponent<VoiceTabScript>().ArrowKeyPress(KeyString);
                            break;
                    }
                    break;
            }
        }

        public void RegularKeyPress(string key)
        {
            switch (CurrentTab)
            {
                case "RoomTab":
                    if (SetRoomString.Length <= 10)
                    {
                        SetRoomString += key;
                        SetRoomText.text = SetRoomString;
                    }
                    break;
                case "NameTab":
                    if (SetNameString.Length <= 12)
                    {
                        SetNameString += key;
                        SetNameText.text = SetNameString;
                    }
                    break;
            }
        }

        public void SpecialKeyPress(string key)
        {
            switch (CurrentTab)
            {
                case "Home":
                    switch (SelectedTab)
                    {
                        case 1:
                            if (key == "enter")
                            {
                                // disables the home tab and enables the player settings tab
                                GameSettingsObj.SetActive(false);
                                PlayerSettingsObj.SetActive(true);
                                // sets the current tab variable
                                CurrentTab = "PSHomeTab";
                            }
                            break;
                    }
                    break;
                case "PSHomeTab":
                    if (key == "back")
                    {
                        // disables the PlayerSettings Object and enabled the GameSettings Obj
                        PlayerSettingsObj.SetActive(false);
                        GameSettingsObj.SetActive(true);
                        SelectedTab = 1;
                        // sets the current tab and updates the gs labels
                        CurrentTab = "Home";
                        UpdatePSLabels();
                        UpdateGSLabels();
                    } else if (key == "enter")
                    {
                        switch (SelectedTab)
                        {
                            case 1: // room tab
                                // disables the ps home tab and enables the room tab
                                PSHomeTabObj.SetActive(false);
                                RoomTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "RoomTab";
                                break;
                            case 2: // name tab
                                // disables the ps home tab and enables the name tab
                                PSHomeTabObj.SetActive(false);
                                NameTab.SetActive(true);
                                // changes the current tab
                                CurrentTab = "NameTab";
                                break;
                            case 3: // color tab
                                // disables the ps home tab and enables the color tab
                                PSHomeTabObj.SetActive(false);
                                ColorTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "ColorTab";
                                break;
                            case 4: // turn tab
                                // disables the ps home tab and enables the turn tab
                                PSHomeTabObj.SetActive(false);
                                TurnTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "TurnTab";
                                break;
                            case 5: // mic tab
                                // disables the ps home tab and enables the mic tab
                                PSHomeTabObj.SetActive(false);
                                MicTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "MicTab";
                                break;
                            case 6: // queue tab
                                // disables the ps home tab and enables the queue tab
                                PSHomeTabObj.SetActive(false);
                                QueueTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "QueueTab";
                                break;
                            case 7: // group tab
                                // disables the ps home tab and enables the group tab
                                PSHomeTabObj.SetActive(false);
                                GroupTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "GroupTab";
                                break;
                            case 8: // voice tab
                                // disables the ps home tab and enables the voice tab
                                PSHomeTabObj.SetActive(false);
                                VoiceTabObj.SetActive(true);
                                // changes the current tab
                                CurrentTab = "VoiceTab";
                                break;
                        }
                    }
                    break;

                // actual tabs
                case "RoomTab":
                    switch (key)
                    {
                        case "backspace":
                            if (SetRoomString.Length > 0)
                            {
                                SetRoomString = SetRoomString.Substring(0, SetRoomString.Length - 1);
                                SetRoomText.text = SetRoomString;
                            }
                            break;
                        case "back":
                            // hides and shows some stuff
                            RoomTabObj.SetActive(false);
                            PSHomeTabObj.SetActive(true);
                            // changes the tab
                            CurrentTab = "PSHomeTab";
                            break;
                        case "enter":
                            // joins a server
                            PhotonNetworkController.Instance.AttemptDisconnect();
                            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(SetRoomString);
                            break;
                        case "option1":
                            PhotonNetworkController.Instance.AttemptDisconnect();
                            break;
                    }
                    break;
                case "NameTab":
                    switch (key)
                    {
                        case "back":
                            // hides the name tab and shows the ps home tab
                            NameTab.SetActive(false);
                            PSHomeTabObj.SetActive(true);
                            // changes the tab
                            CurrentTab = "PSHomeTab";
                            break;
                        case "backspace":
                            if (SetNameString.Length > 0)
                            {
                                SetNameString = SetNameString.Substring(0, SetNameString.Length - 1);
                                SetNameText.text = SetNameString;
                            }
                            break;
                        case "enter":
                            if (SetNameString.Length == 0)
                            {
                                SetNameString = " ";
                                PlayerPrefs.SetString("playerName", SetNameString); // saves the username
                                CurrentNameText.text = SetNameString; // updates the current name text
                                GorillaComputer.instance.offlineVRRigNametagText.text = SetNameString;
                                GorillaComputer.instance.currentName = SetNameString;
                                GorillaComputer.instance.savedName = SetNameString;
                                if (PhotonNetwork.LocalPlayer != null)
                                {
                                    PhotonNetwork.LocalPlayer.NickName = SetNameString;
                                }
                            } else if (SetNameString.Length > 0)
                            {
                                PlayerPrefs.SetString("playerName", SetNameString); // saves the username
                                CurrentNameText.text = SetNameString; // updates the current name text
                                GorillaComputer.instance.offlineVRRigNametagText.text = SetNameString;
                                GorillaComputer.instance.currentName = SetNameString;
                                GorillaComputer.instance.savedName = SetNameString;
                                if (PhotonNetwork.LocalPlayer != null)
                                {
                                    PhotonNetwork.LocalPlayer.NickName = SetNameString;
                                }
                            }
                            break;
                    }
                    break;
                case "ColorTab":
                    switch (key)
                    {
                        case "back":
                            // hides the color tab and shows the ps home tab
                            ColorTabObj.SetActive(false);
                            PSHomeTabObj.SetActive(true);
                            // changes the tab
                            CurrentTab = "PSHomeTab";
                            break;
                    }
                    break;
            }
        }

        public void ArrowKeyPress(string key)
        {
            switch (CurrentTab)
            {
                case "Home":
                    switch (key)
                    {
                        case "Up":
                            if (SelectedTab == 1)
                            {
                                SelectedTab = 2;
                            } else if (SelectedTab == 2)
                            {
                                SelectedTab = 1;
                            }
                            // updates the gs tab labels
                            UpdateGSLabels();
                            break;
                        case "Down":
                            if (SelectedTab == 1)
                            {
                                SelectedTab = 2;
                            } else if (SelectedTab == 2)
                            {
                                SelectedTab = 1;
                            }
                            // updates the gs tab labels
                            UpdateGSLabels();
                            break;
                    }
                    break;
                case "PSHomeTab":
                    switch (key)
                    {
                        case "Up":
                            if (SelectedTab == 1)
                            {
                                SelectedTab = PSTextLabels.Count;
                            } else if (SelectedTab > 1 && SelectedTab <= PSTextLabels.Count)
                            {
                                SelectedTab -= 1;
                            }
                            // updates the selected tab
                            UpdatePSLabels();
                            break;
                        case "Down":
                            if (SelectedTab >= 1 && SelectedTab < PSTextLabels.Count)
                            {
                                SelectedTab += 1;
                            } else if (SelectedTab == PSTextLabels.Count)
                            {
                                SelectedTab = 1;
                            }
                            UpdatePSLabels();
                            break;
                    }
                    break;
            }
        }

        void Update()
        {
            if (OnCooldown) // cooldown
            {
                if (CooldownTimer > 0.0f)
                {
                    CooldownTimer -= Time.deltaTime;
                } else if (CooldownTimer <= 0.0f)
                {
                    // resets the cooldown timer and turns off the cooldown
                    CooldownTimer = Cooldown;
                    OnCooldown = false;
                }
            }
        }
    }
}
