using GorillaNetworking;
using NimsQOLMod.Mod.CustomComputer.Tabs;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class CustomComputers : MonoBehaviour
    {
        public static CustomComputers Instance;

        // creates the computers at the specified position and rotation
        public static GameObject CreateCustomComputer(Vector3 position, string ComputerName, GameObject parent, string Environment, Font generalFont)
        {
            // main object
            GameObject Computer = new GameObject();
            Computer.name = ComputerName; // sets the computer's name
            Computer.transform.position = position; // sets the computer's position
            Computer.transform.parent = parent.transform; // sets the gameobject's parent

            // adds the computer manager component
            ComputerManager MonitorManager = Computer.AddComponent<ComputerManager>();

            // creates the monitor base cube and material
            Material MonitorCaseMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            MonitorCaseMaterial.color = new Color32(20, 20, 23, 255);

            Material MonitorScreenMaterial = new Material(Shader.Find("GorillaTag/UberShader"));
            MonitorScreenMaterial.color = new Color32(0, 0, 0, 255);

            GameObject MonitorBase = GameObject.CreatePrimitive(PrimitiveType.Cube);
            MonitorBase.name = "MonitorBase";
            MonitorBase.transform.parent = Computer.transform;
            MonitorBase.transform.localScale = new Vector3(0.2f, 0.8f, 0.8f);
            MonitorBase.transform.localPosition = new Vector3(0f, 0f, 0f);
            // removes some components
            UnityEngine.GameObject.Destroy(MonitorBase.GetComponent<Rigidbody>());
            // sets the material
            MonitorBase.GetComponent<Renderer>().material = MonitorCaseMaterial;

            // creates the computer screen
            GameObject ComputerScreen = GameObject.CreatePrimitive(PrimitiveType.Plane);
            ComputerScreen.name = "ComputerScreen";
            ComputerScreen.transform.parent = MonitorBase.transform;
            // removes some components
            UnityEngine.GameObject.Destroy(ComputerScreen.GetComponent<Rigidbody>());
            // sets the material
            ComputerScreen.GetComponent<Renderer>().material = MonitorScreenMaterial;
            // sets some transform properties
            ComputerScreen.transform.localPosition = new Vector3(0.51f, 0f, 0f);
            ComputerScreen.transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
            ComputerScreen.transform.localScale = new Vector3(0.09f, 1f, 0.09f);


            // monitor canvas
            GameObject CanvasBase = new GameObject();
            CanvasBase.name = "CanvasBase";
            CanvasBase.transform.parent = ComputerScreen.transform;

            Canvas MainCanvas = CanvasBase.AddComponent<Canvas>();
            MainCanvas.renderMode = RenderMode.WorldSpace;

            CanvasScaler MainCanvasScaler = CanvasBase.AddComponent<CanvasScaler>();
            MainCanvasScaler.dynamicPixelsPerUnit = 100f;

            // gets the canvas' rect transform
            CanvasBase.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
            CanvasBase.GetComponent<RectTransform>().localPosition = new Vector3(0f, 0.02f, 0f); // ensures that the canvas stays within the computer
            CanvasBase.GetComponent<RectTransform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
            CanvasBase.GetComponent<RectTransform>().rotation = ComputerScreen.transform.rotation;
            CanvasBase.GetComponent<RectTransform>().localRotation = Quaternion.Euler(
                0f,
                0f,
                0f
                );

            // tabs
            GameObject TabsContainer = new GameObject();
            TabsContainer.name = "TabsContainer";
            TabsContainer.transform.parent = CanvasBase.transform;
            TabsContainer.transform.localPosition = new Vector3(0f, 0f, 0f); // same reason as the canvas base

            // creates the main tabs
            string[] MainTabs = new string[]
            {
                "Game Settings", // index: 0
                "Player Settings", // index: 1
                "Monitor Settings" // index: 2
            };

            List<GameObject> MainTabObjects =  MonitorManager.CreateTabs(MainTabs, TabsContainer, true); // creates the main tab objects



            // image test (use this to find the canvas)
            /*GameObject ImageTestObj = new GameObject();
            ImageTestObj.name = "ImageTestObj";
            ImageTestObj.transform.parent = MainTabObjects[0].transform;
            ImageTestObj.transform.localPosition = new Vector3(0f, 0f, 0f);

            Image ImageTestMain = ImageTestObj.AddComponent<Image>();
            ImageTestMain.sprite = ResourceUtilities.GetSprite("NimsQOLMod/Resources/Image/SquareNotRounded.png");
            ImageTestMain.color = new Color32(10, 10, 10, 255);

            ImageTestObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);*/

            // creates title for the game settings tab
            GameObject GSTitleObj = new GameObject();
            GSTitleObj.name = "GameSettingsTitleObject";
            GSTitleObj.transform.parent = MainTabObjects[0].transform;
            GSTitleObj.transform.localPosition = new Vector3(0f, 0f, 0f);

            Text GSTitleText = GSTitleObj.AddComponent<Text>();
            GSTitleText.resizeTextMinSize = 0;
            GSTitleText.resizeTextMaxSize = 100;
            GSTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            GSTitleText.resizeTextForBestFit = true;
            GSTitleText.fontStyle = FontStyle.Normal;
            GSTitleText.text = "Nim's QOL Mod: INTERFACE";
            GSTitleText.color = new Color32(150, 255, 150, 255);
            GSTitleText.font = generalFont;
            GSTitleText.alignment = TextAnchor.MiddleCenter;


            // moves the title text
            GSTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            GSTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            GSTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // player settings label
            GameObject PlayerSettingsLabelObj = new GameObject();
            PlayerSettingsLabelObj.name = "PlayerSettingsLabelObj";
            PlayerSettingsLabelObj.transform.parent = MainTabObjects[0].transform;

            Text PlayerSettingsLabelText = PlayerSettingsLabelObj.AddComponent<Text>();
            PlayerSettingsLabelText.resizeTextMinSize = 0;
            PlayerSettingsLabelText.resizeTextMaxSize = 100;
            PlayerSettingsLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            PlayerSettingsLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            PlayerSettingsLabelText.resizeTextForBestFit = true;
            PlayerSettingsLabelText.fontStyle = FontStyle.Normal;
            PlayerSettingsLabelText.text = "> PLAYER SETTINGS";
            PlayerSettingsLabelText.color = new Color32(255, 255, 255, 255);
            PlayerSettingsLabelText.font = generalFont;
            PlayerSettingsLabelText.alignment = TextAnchor.MiddleRight;

            PlayerSettingsLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 10);
            PlayerSettingsLabelObj.GetComponent<RectTransform>().localPosition = new Vector3(-15f, 27f, 0f);
            PlayerSettingsLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.GSTextLabels.Add(PlayerSettingsLabelText);

            // monitor settings label
            GameObject MonitorSettingsLabelObj = new GameObject();
            MonitorSettingsLabelObj.name = "MonitorSettingsLabelObj";
            MonitorSettingsLabelObj.transform.parent = MainTabObjects[0].transform;
            MonitorSettingsLabelObj.transform.localPosition = new Vector3(0f, 0f, 0f);

            Text MonitorSettingsLabelText = MonitorSettingsLabelObj.AddComponent<Text>();
            MonitorSettingsLabelText.resizeTextMinSize = 0;
            MonitorSettingsLabelText.resizeTextMaxSize = 100;
            MonitorSettingsLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            MonitorSettingsLabelText.horizontalOverflow = HorizontalWrapMode.Wrap;
            MonitorSettingsLabelText.resizeTextForBestFit = true;
            MonitorSettingsLabelText.fontStyle = FontStyle.Normal;
            MonitorSettingsLabelText.text = "MONITOR CONFIG (NOT IMPLEMENTED)";
            MonitorSettingsLabelText.color = new Color32(255, 255, 255, 255);
            MonitorSettingsLabelText.font = generalFont;
            MonitorSettingsLabelText.alignment = TextAnchor.MiddleRight;

            MonitorSettingsLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            MonitorSettingsLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-10, -10);
            MonitorSettingsLabelObj.GetComponent<RectTransform>().localPosition = new Vector3(-15, 15f, 0f);
            MonitorSettingsLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.GSTextLabels.Add(MonitorSettingsLabelText);

            // player settings home tab
            GameObject PSHomeTab = new GameObject();
            PSHomeTab.name = "PSHomeTab";
            PSHomeTab.transform.parent = MainTabObjects[1].transform;
            PSHomeTab.transform.localPosition = new Vector3(0f, 0f, 0f);

            MonitorManager.PSHomeTabObj = PSHomeTab;

            // room tab label
            GameObject RoomTabLabelObj = new GameObject();
            RoomTabLabelObj.name = "RoomTabLabelObj";
            RoomTabLabelObj.transform.parent = PSHomeTab.transform;
            RoomTabLabelObj.transform.localPosition = new Vector3(-13f, 33f, 0f);

            Text RoomTabLabelText = RoomTabLabelObj.AddComponent<Text>();
            RoomTabLabelText.resizeTextMinSize = 0;
            RoomTabLabelText.resizeTextMaxSize = 100;
            RoomTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            RoomTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            RoomTabLabelText.resizeTextForBestFit = true;
            RoomTabLabelText.fontStyle = FontStyle.Normal;
            RoomTabLabelText.text = "> ROOM";
            RoomTabLabelText.color = new Color32(255, 255, 255, 255);
            RoomTabLabelText.font = generalFont;
            RoomTabLabelText.alignment = TextAnchor.MiddleRight;

            RoomTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add( RoomTabLabelText );

            // name tab label
            GameObject NameTabLabelObj = new GameObject();
            NameTabLabelObj.name = "NameTabLabelObj";
            NameTabLabelObj.transform.parent = PSHomeTab.transform;
            NameTabLabelObj.transform.localPosition = new Vector3(-13f, 26f, 0f);

            Text NameTabLabelText = NameTabLabelObj.AddComponent<Text>();
            NameTabLabelText.resizeTextMinSize = 0;
            NameTabLabelText.resizeTextMaxSize = 100;
            NameTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            NameTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            NameTabLabelText.resizeTextForBestFit = true;
            NameTabLabelText.fontStyle = FontStyle.Normal;
            NameTabLabelText.text = "NAME";
            NameTabLabelText.color = new Color32(255, 255, 255, 255);
            NameTabLabelText.font = generalFont;
            NameTabLabelText.alignment = TextAnchor.MiddleRight;

            NameTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(NameTabLabelText);

            // color tab label
            GameObject ColorTabLabelObj = new GameObject();
            ColorTabLabelObj.name = "ColorTabLabelObj";
            ColorTabLabelObj.transform.parent = PSHomeTab.transform;
            ColorTabLabelObj.transform.localPosition = new Vector3(-13f, 19f, 0f);

            Text ColorTabLabelText = ColorTabLabelObj.AddComponent<Text>();
            ColorTabLabelText.resizeTextMinSize = 0;
            ColorTabLabelText.resizeTextMaxSize = 100;
            ColorTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            ColorTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            ColorTabLabelText.resizeTextForBestFit = true;
            ColorTabLabelText.fontStyle = FontStyle.Normal;
            ColorTabLabelText.text = "COLOR";
            ColorTabLabelText.color = new Color32(255, 255, 255, 255);
            ColorTabLabelText.font = generalFont;
            ColorTabLabelText.alignment = TextAnchor.MiddleRight;

            ColorTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(ColorTabLabelText);

            // turn tab label
            GameObject TurnTabLabelObj = new GameObject();
            TurnTabLabelObj.name = "TurnTabLabelObj";
            TurnTabLabelObj.transform.parent = PSHomeTab.transform;
            TurnTabLabelObj.transform.localPosition = new Vector3(-13f, 12f, 0f);

            Text TurnTabLabelText = TurnTabLabelObj.AddComponent<Text>();
            TurnTabLabelText.resizeTextMinSize = 0;
            TurnTabLabelText.resizeTextMaxSize = 100;
            TurnTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            TurnTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            TurnTabLabelText.resizeTextForBestFit = true;
            TurnTabLabelText.fontStyle = FontStyle.Normal;
            TurnTabLabelText.text = "TURN";
            TurnTabLabelText.color = new Color32(255, 255, 255, 255);
            TurnTabLabelText.font = generalFont;
            TurnTabLabelText.alignment = TextAnchor.MiddleRight;

            TurnTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(TurnTabLabelText);

            // mic tab label
            GameObject MicTabLabelObj = new GameObject();
            MicTabLabelObj.name = "MicTabLabelObj";
            MicTabLabelObj.transform.parent = PSHomeTab.transform;
            MicTabLabelObj.transform.localPosition = new Vector3(-13f, 5f, 0f);

            Text MicTabLabelText = MicTabLabelObj.AddComponent<Text>();
            MicTabLabelText.resizeTextMinSize = 0;
            MicTabLabelText.resizeTextMaxSize = 100;
            MicTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            MicTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            MicTabLabelText.resizeTextForBestFit = true;
            MicTabLabelText.fontStyle = FontStyle.Normal;
            MicTabLabelText.text = "MIC";
            MicTabLabelText.color = new Color32(255, 255, 255, 255);
            MicTabLabelText.font = generalFont;
            MicTabLabelText.alignment = TextAnchor.MiddleRight;

            MicTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(MicTabLabelText);

            // queue tab label
            GameObject QueueTabLabelObj = new GameObject();
            QueueTabLabelObj.name = "QueueTabLabelObj";
            QueueTabLabelObj.transform.parent = PSHomeTab.transform;
            QueueTabLabelObj.transform.localPosition = new Vector3(-13f, -2f, 0f);

            Text QueueTabLabelText = QueueTabLabelObj.AddComponent<Text>();
            QueueTabLabelText.resizeTextMinSize = 0;
            QueueTabLabelText.resizeTextMaxSize = 100;
            QueueTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            QueueTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            QueueTabLabelText.resizeTextForBestFit = true;
            QueueTabLabelText.fontStyle = FontStyle.Normal;
            QueueTabLabelText.text = "QUEUE";
            QueueTabLabelText.color = new Color32(255, 255, 255, 255);
            QueueTabLabelText.font = generalFont;
            QueueTabLabelText.alignment = TextAnchor.MiddleRight;

            QueueTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(QueueTabLabelText);

            // group tab label
            GameObject GroupTabLabelObj = new GameObject();
            GroupTabLabelObj.name = "GroupTabLabelObj";
            GroupTabLabelObj.transform.parent = PSHomeTab.transform;
            GroupTabLabelObj.transform.localPosition = new Vector3(-13f, -10f, 0f);

            Text GroupTabLabelText = GroupTabLabelObj.AddComponent<Text>();
            GroupTabLabelText.resizeTextMinSize = 0;
            GroupTabLabelText.resizeTextMaxSize = 100;
            GroupTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            GroupTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            GroupTabLabelText.resizeTextForBestFit = true;
            GroupTabLabelText.fontStyle = FontStyle.Normal;
            GroupTabLabelText.text = "GROUP";
            GroupTabLabelText.color = new Color32(255, 255, 255, 255);
            GroupTabLabelText.font = generalFont;
            GroupTabLabelText.alignment = TextAnchor.MiddleRight;

            GroupTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(GroupTabLabelText);

            // voice tab label
            GameObject VoiceTabLabelObj = new GameObject();
            VoiceTabLabelObj.name = "VoiceTabLabelObj";
            VoiceTabLabelObj.transform.parent = PSHomeTab.transform;
            VoiceTabLabelObj.transform.localPosition = new Vector3(-13f, -17f, 0f);

            Text VoiceTabLabelText = VoiceTabLabelObj.AddComponent<Text>();
            VoiceTabLabelText.resizeTextMinSize = 0;
            VoiceTabLabelText.resizeTextMaxSize = 100;
            VoiceTabLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            VoiceTabLabelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            VoiceTabLabelText.resizeTextForBestFit = true;
            VoiceTabLabelText.fontStyle = FontStyle.Normal;
            VoiceTabLabelText.text = "VOICE";
            VoiceTabLabelText.color = new Color32(255, 255, 255, 255);
            VoiceTabLabelText.font = generalFont;
            VoiceTabLabelText.alignment = TextAnchor.MiddleRight;

            VoiceTabLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 10);

            MonitorManager.PSTextLabels.Add(VoiceTabLabelText);


            // Room tab
            GameObject RoomTab = new GameObject();
            RoomTab.name = "Room Tab";
            RoomTab.transform.parent = MainTabObjects[1].transform;
            RoomTab.transform.localPosition = new Vector3(0f, 0f, 0f);

            // room tab title
            GameObject RoomTabTitleObj = new GameObject();
            RoomTabTitleObj.name = "RoomTabTitleObject";
            RoomTabTitleObj.transform.parent = RoomTab.transform;
            RoomTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text RoomTabTitleText = RoomTabTitleObj.AddComponent<Text>();
            RoomTabTitleText.resizeTextMinSize = 0;
            RoomTabTitleText.resizeTextMaxSize = 100;
            RoomTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            RoomTabTitleText.resizeTextForBestFit = true;
            RoomTabTitleText.fontStyle = FontStyle.Normal;
            RoomTabTitleText.text = "ROOM TAB";
            RoomTabTitleText.color = new Color32(150, 255, 150, 255);
            RoomTabTitleText.font = generalFont;
            RoomTabTitleText.alignment = TextAnchor.MiddleCenter;

            RoomTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            RoomTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            RoomTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            MonitorManager.RoomTabObj = RoomTab;

            // set room text label
            GameObject SetRoomLabelObj = new GameObject();
            SetRoomLabelObj.name = "SetRoomLabelObj";
            SetRoomLabelObj.transform.parent = RoomTab.transform;
            SetRoomLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text SetRoomLabelText = SetRoomLabelObj.AddComponent<Text>();
            SetRoomLabelText.resizeTextMinSize = 0;
            SetRoomLabelText.resizeTextMaxSize = 100;
            SetRoomLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            SetRoomLabelText.resizeTextForBestFit = true;
            SetRoomLabelText.fontStyle = FontStyle.Normal;
            SetRoomLabelText.text = "ROOM TO JOIN:";
            SetRoomLabelText.color = new Color32(255, 255, 255, 255);
            SetRoomLabelText.font = generalFont;
            SetRoomLabelText.alignment = TextAnchor.MiddleCenter;

            SetRoomLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 10);
            SetRoomLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-35, 15);
            SetRoomLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // set room text
            GameObject SetRoomTextObj = new GameObject();
            SetRoomTextObj.name = "SetRoomTextObj";
            SetRoomTextObj.transform.parent = RoomTab.transform;
            SetRoomTextObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text SetRoomTextMain = SetRoomTextObj.AddComponent<Text>();
            SetRoomTextMain.resizeTextMinSize = 0;
            SetRoomTextMain.resizeTextMaxSize = 100;
            SetRoomTextMain.verticalOverflow = VerticalWrapMode.Overflow;
            SetRoomTextMain.resizeTextForBestFit = true;
            SetRoomTextMain.fontStyle = FontStyle.Normal;
            SetRoomTextMain.text = "";
            SetRoomTextMain.color = new Color32(255, 255, 255, 255);
            SetRoomTextMain.font = generalFont;
            SetRoomTextMain.alignment = TextAnchor.MiddleLeft;

            SetRoomTextObj.GetComponent<RectTransform>().sizeDelta = new Vector2(55, 10);
            SetRoomTextObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(2, 15);
            SetRoomTextObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.SetRoomText = SetRoomTextMain;

            // current room label text
            GameObject CurRoomLabelObj = new GameObject();
            CurRoomLabelObj.name = "CurRoomLabelObj";
            CurRoomLabelObj.transform.parent = RoomTab.transform;
            CurRoomLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text CurRoomLabelText = CurRoomLabelObj.AddComponent<Text>();
            CurRoomLabelText.resizeTextMinSize = 0;
            CurRoomLabelText.resizeTextMaxSize = 100;
            CurRoomLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            CurRoomLabelText.resizeTextForBestFit = true;
            CurRoomLabelText.fontStyle = FontStyle.Normal;
            CurRoomLabelText.text = "CURRENT ROOM:";
            CurRoomLabelText.color = new Color32(255, 255, 255, 255);
            CurRoomLabelText.font = generalFont;
            CurRoomLabelText.alignment = TextAnchor.MiddleCenter;

            CurRoomLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 10);
            CurRoomLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-35, -5);
            CurRoomLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // current room main text
            GameObject CurRoomTextObj = new GameObject();
            CurRoomTextObj.name = "CurRoomTextObj";
            CurRoomTextObj.transform.parent = RoomTab.transform;
            CurRoomTextObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text CurRoomTextMain = CurRoomTextObj.AddComponent<Text>();
            CurRoomTextMain.resizeTextMinSize = 0;
            CurRoomTextMain.resizeTextMaxSize = 100;
            CurRoomTextMain.verticalOverflow = VerticalWrapMode.Overflow;
            CurRoomTextMain.resizeTextForBestFit = true;
            CurRoomTextMain.fontStyle = FontStyle.Normal;
            CurRoomTextMain.text = "-NOT IN ROOM-";
            CurRoomTextMain.color = new Color32(255, 255, 255, 255);
            CurRoomTextMain.font = generalFont;
            CurRoomTextMain.alignment = TextAnchor.MiddleLeft;

            CurRoomTextObj.GetComponent<RectTransform>().sizeDelta = new Vector2(55, 10);
            CurRoomTextObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(2, -5);
            CurRoomTextObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.CurrentRoomText = CurRoomTextMain;

            // name tab
            GameObject NameTab = new GameObject();
            NameTab.name = "Name Tab";
            NameTab.transform.parent = MainTabObjects[1].transform;
            NameTab.transform.localPosition = new Vector3(0, 0, 0);

            MonitorManager.NameTab = NameTab;

            // name tab title
            GameObject NameTabTitleObj = new GameObject();
            NameTabTitleObj.name = "NameTabTitleObject";
            NameTabTitleObj.transform.parent = NameTab.transform;
            NameTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text NameTabTitleText = NameTabTitleObj.AddComponent<Text>();
            NameTabTitleText.resizeTextMinSize = 0;
            NameTabTitleText.resizeTextMaxSize = 100;
            NameTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            NameTabTitleText.resizeTextForBestFit = true;
            NameTabTitleText.fontStyle = FontStyle.Normal;
            NameTabTitleText.text = "NAME TAB";
            NameTabTitleText.color = new Color32(150, 255, 150, 255);
            NameTabTitleText.font = generalFont;
            NameTabTitleText.alignment = TextAnchor.MiddleCenter;

            NameTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            NameTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            NameTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // set name label
            GameObject SetNameLabelObj = new GameObject();
            SetNameLabelObj.name = "SetNameLabelObj";
            SetNameLabelObj.transform.parent = NameTab.transform;
            SetNameLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text SetNameLabelText = SetNameLabelObj.AddComponent<Text>();
            SetNameLabelText.resizeTextMinSize = 0;
            SetNameLabelText.resizeTextMaxSize = 100;
            SetNameLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            SetNameLabelText.resizeTextForBestFit = true;
            SetNameLabelText.fontStyle = FontStyle.Normal;
            SetNameLabelText.text = "SET NAME:";
            SetNameLabelText.color = new Color32(255, 255, 255, 255);
            SetNameLabelText.font = generalFont;
            SetNameLabelText.alignment = TextAnchor.MiddleCenter;

            SetNameLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 10);
            SetNameLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-35, 15);
            SetNameLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // set name text
            GameObject SetNameTextObj = new GameObject();
            SetNameTextObj.name = "SetNameTextObj";
            SetNameTextObj.transform.parent = NameTab.transform;
            SetNameTextObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text SetNameTextMain = SetNameTextObj.AddComponent<Text>();
            SetNameTextMain.resizeTextMinSize = 0;
            SetNameTextMain.resizeTextMaxSize = 100;
            SetNameTextMain.verticalOverflow = VerticalWrapMode.Overflow;
            SetNameTextMain.resizeTextForBestFit = true;
            SetNameTextMain.fontStyle = FontStyle.Normal;
            SetNameTextMain.text = "";
            SetNameTextMain.color = new Color32(255, 255, 255, 255);
            SetNameTextMain.font = generalFont;
            SetNameTextMain.alignment = TextAnchor.MiddleLeft;

            SetNameTextObj.GetComponent<RectTransform>().sizeDelta = new Vector2(55, 10);
            SetNameTextObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(2, 15);
            SetNameTextObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.SetNameText = SetNameTextMain;

            // current name label
            GameObject CurNameLabelObj = new GameObject();
            CurNameLabelObj.name = "CurNameLabelObj";
            CurNameLabelObj.transform.parent = NameTab.transform;
            CurNameLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text CurNameLabelText = CurNameLabelObj.AddComponent<Text>();
            CurNameLabelText.resizeTextMinSize = 0;
            CurNameLabelText.resizeTextMaxSize = 100;
            CurNameLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            CurNameLabelText.resizeTextForBestFit = true;
            CurNameLabelText.fontStyle = FontStyle.Normal;
            CurNameLabelText.text = "CURRENT NAME:";
            CurNameLabelText.color = new Color32(255, 255, 255, 255);
            CurNameLabelText.font = generalFont;
            CurNameLabelText.alignment = TextAnchor.MiddleCenter;

            CurNameLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(40, 10);
            CurNameLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-35, -5);
            CurNameLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // current name text
            GameObject CurNameTextObj = new GameObject();
            CurNameTextObj.name = "CurNameTextObj";
            CurNameTextObj.transform.parent = NameTab.transform;
            CurNameTextObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text CurNameTextMain = CurNameTextObj.AddComponent<Text>();
            CurNameTextMain.resizeTextMinSize = 0;
            CurNameTextMain.resizeTextMaxSize = 100;
            CurNameTextMain.verticalOverflow = VerticalWrapMode.Overflow;
            CurNameTextMain.resizeTextForBestFit = true;
            CurNameTextMain.fontStyle = FontStyle.Normal;
            CurNameTextMain.text = "-INITIALIZING-";
            CurNameTextMain.color = new Color32(255, 255, 255, 255);
            CurNameTextMain.font = generalFont;
            CurNameTextMain.alignment = TextAnchor.MiddleLeft;

            CurNameTextObj.GetComponent<RectTransform>().sizeDelta = new Vector2(55, 10);
            CurNameTextObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(2, -5);
            CurNameTextObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            MonitorManager.CurrentNameText = CurNameTextMain;

            // color tab
            GameObject ColorTab = new GameObject();
            ColorTab.name = "Color Tab";
            ColorTab.transform.parent = MainTabObjects[1].transform;
            ColorTab.transform.localPosition = new Vector3(0, 0, 0);
            ColorTab.AddComponent<ColorTabScript>();
            ColorTab.GetComponent<ColorTabScript>().monMan = MonitorManager;

            // color tab title
            GameObject ColorTabTitleObj = new GameObject();
            ColorTabTitleObj.name = "ColorTabTitleObject";
            ColorTabTitleObj.transform.parent = ColorTab.transform;
            ColorTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text ColorTabTitleText = ColorTabTitleObj.AddComponent<Text>();
            ColorTabTitleText.resizeTextMinSize = 0;
            ColorTabTitleText.resizeTextMaxSize = 100;
            ColorTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            ColorTabTitleText.resizeTextForBestFit = true;
            ColorTabTitleText.fontStyle = FontStyle.Normal;
            ColorTabTitleText.text = "COLOR TAB";
            ColorTabTitleText.color = new Color32(150, 255, 150, 255);
            ColorTabTitleText.font = generalFont;
            ColorTabTitleText.alignment = TextAnchor.MiddleCenter;

            ColorTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            ColorTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            ColorTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // red value label
            GameObject RedValueLabelObj = new GameObject();
            RedValueLabelObj.name = "RedValueLabelObj";
            RedValueLabelObj.transform.parent = ColorTab.transform;
            RedValueLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text RedValueLabelText = RedValueLabelObj.AddComponent<Text>();
            RedValueLabelText.resizeTextMinSize = 0;
            RedValueLabelText.resizeTextMaxSize = 100;
            RedValueLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            RedValueLabelText.resizeTextForBestFit = true;
            RedValueLabelText.fontStyle = FontStyle.Normal;
            RedValueLabelText.text = "RED:  <color=#00ebf7>0</color> 0 0";
            RedValueLabelText.color = new Color32(255, 255, 255, 255);
            RedValueLabelText.font = generalFont;
            RedValueLabelText.alignment = TextAnchor.MiddleRight;
            RedValueLabelText.supportRichText = true;

            RedValueLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 5);
            RedValueLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-27, 10);
            RedValueLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // green value label
            GameObject GreenValueLabelObj = new GameObject();
            GreenValueLabelObj.name = "GreenValueLabelObj";
            GreenValueLabelObj.transform.parent = ColorTab.transform;
            GreenValueLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text GreenValueLabelText = GreenValueLabelObj.AddComponent<Text>();
            GreenValueLabelText.resizeTextMinSize = 0;
            GreenValueLabelText.resizeTextMaxSize = 100;
            GreenValueLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            GreenValueLabelText.resizeTextForBestFit = true;
            GreenValueLabelText.fontStyle = FontStyle.Normal;
            GreenValueLabelText.text = "GREEN:  0 0 0";
            GreenValueLabelText.color = new Color32(255, 255, 255, 255);
            GreenValueLabelText.font = generalFont;
            GreenValueLabelText.alignment = TextAnchor.MiddleRight;
            GreenValueLabelText.supportRichText = true;

            GreenValueLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 5);
            GreenValueLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-27, 0);
            GreenValueLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // blue value label
            GameObject BlueValueLabelObj = new GameObject();
            BlueValueLabelObj.name = "BlueValueLabelObj";
            BlueValueLabelObj.transform.parent = ColorTab.transform;
            BlueValueLabelObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text BlueValueLabelText = BlueValueLabelObj.AddComponent<Text>();
            BlueValueLabelText.resizeTextMinSize = 0;
            BlueValueLabelText.resizeTextMaxSize = 100;
            BlueValueLabelText.verticalOverflow = VerticalWrapMode.Overflow;
            BlueValueLabelText.resizeTextForBestFit = true;
            BlueValueLabelText.fontStyle = FontStyle.Normal;
            BlueValueLabelText.text = "BLUE:  0 0 0";
            BlueValueLabelText.color = new Color32(255, 255, 255, 255);
            BlueValueLabelText.font = generalFont;
            BlueValueLabelText.alignment = TextAnchor.MiddleRight;
            BlueValueLabelText.supportRichText = true;

            BlueValueLabelObj.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 5);
            BlueValueLabelObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-27, -10);
            BlueValueLabelObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);


            MonitorManager.ColorTabObj = ColorTab;

            // turn tab
            GameObject TurnTab = new GameObject();
            TurnTab.name = "Turn Tab";
            TurnTab.transform.parent = MainTabObjects[1].transform;
            TurnTab.transform.localPosition = new Vector3(0, 0, 0);
            TurnTab.AddComponent<TurnTabScript>();
            TurnTab.GetComponent<TurnTabScript>().monMan = MonitorManager;

            // turn tab title
            GameObject TurnTabTitleObj = new GameObject();
            TurnTabTitleObj.name = "TurnTabTitleObject";
            TurnTabTitleObj.transform.parent = TurnTab.transform;
            TurnTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text TurnTabTitleText = TurnTabTitleObj.AddComponent<Text>();
            TurnTabTitleText.resizeTextMinSize = 0;
            TurnTabTitleText.resizeTextMaxSize = 100;
            TurnTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            TurnTabTitleText.resizeTextForBestFit = true;
            TurnTabTitleText.fontStyle = FontStyle.Normal;
            TurnTabTitleText.text = "TURN TAB";
            TurnTabTitleText.color = new Color32(150, 255, 150, 255);
            TurnTabTitleText.font = generalFont;
            TurnTabTitleText.alignment = TextAnchor.MiddleCenter;

            TurnTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            TurnTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            TurnTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // current turn type text
            GameObject TurnTypeObj = new GameObject();
            TurnTypeObj.name = "TurnTypeObject";
            TurnTypeObj.transform.parent = TurnTab.transform;
            TurnTypeObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text TurnTypeText = TurnTypeObj.AddComponent<Text>();
            TurnTypeText.resizeTextMinSize = 0;
            TurnTypeText.resizeTextMaxSize = 100;
            TurnTypeText.verticalOverflow = VerticalWrapMode.Overflow;
            TurnTypeText.resizeTextForBestFit = true;
            TurnTypeText.fontStyle = FontStyle.Normal;
            TurnTypeText.text = "CURRENT TURN TYPE: NONE";
            TurnTypeText.color = new Color32(255, 255, 255, 255);
            TurnTypeText.font = generalFont;
            TurnTypeText.alignment = TextAnchor.MiddleLeft;

            TurnTypeObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            TurnTypeObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 12);
            TurnTypeObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // current turn speed text
            GameObject TurnSpeedObj = new GameObject();
            TurnSpeedObj.name = "TurnSpeedObject";
            TurnSpeedObj.transform.parent = TurnTab.transform;
            TurnSpeedObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text TurnSpeedText = TurnSpeedObj.AddComponent<Text>();
            TurnSpeedText.resizeTextMinSize = 0;
            TurnSpeedText.resizeTextMaxSize = 100;
            TurnSpeedText.verticalOverflow = VerticalWrapMode.Overflow;
            TurnSpeedText.resizeTextForBestFit = true;
            TurnSpeedText.fontStyle = FontStyle.Normal;
            TurnSpeedText.text = "CURRENT TURN SPEED: 1";
            TurnSpeedText.color = new Color32(255, 255, 255, 255);
            TurnSpeedText.font = generalFont;
            TurnSpeedText.alignment = TextAnchor.MiddleLeft;

            TurnSpeedObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            TurnSpeedObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -12);
            TurnSpeedObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // mic tab
            GameObject MicTab = new GameObject();
            MicTab.name = "Mic Tab";
            MicTab.transform.parent = MainTabObjects[1].transform;
            MicTab.transform.localPosition = new Vector3(0, 0, 0);
            MicTab.AddComponent<MicTabScript>();
            MicTab.GetComponent<MicTabScript>().monMan = MonitorManager;

            // mic type text
            GameObject MicTypeObj = new GameObject();
            MicTypeObj.name = "MicTypeObject";
            MicTypeObj.transform.parent = MicTab.transform;
            MicTypeObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text MicTypeText = MicTypeObj.AddComponent<Text>();
            MicTypeText.resizeTextMinSize = 0;
            MicTypeText.resizeTextMaxSize = 100;
            MicTypeText.verticalOverflow = VerticalWrapMode.Overflow;
            MicTypeText.resizeTextForBestFit = true;
            MicTypeText.fontStyle = FontStyle.Normal;
            MicTypeText.text = "CURRENT MIC SETTING: ALL CHAT";
            MicTypeText.color = new Color32(255, 255, 255, 255);
            MicTypeText.font = generalFont;
            MicTypeText.alignment = TextAnchor.MiddleLeft;

            MicTypeObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            MicTypeObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            MicTypeObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // mic tab title
            GameObject MicTabTitleObj = new GameObject();
            MicTabTitleObj.name = "MicTabTitleObject";
            MicTabTitleObj.transform.parent = MicTab.transform;
            MicTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text MicTabTitleText = MicTabTitleObj.AddComponent<Text>();
            MicTabTitleText.resizeTextMinSize = 0;
            MicTabTitleText.resizeTextMaxSize = 100;
            MicTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            MicTabTitleText.resizeTextForBestFit = true;
            MicTabTitleText.fontStyle = FontStyle.Normal;
            MicTabTitleText.text = "MIC TAB";
            MicTabTitleText.color = new Color32(150, 255, 150, 255);
            MicTabTitleText.font = generalFont;
            MicTabTitleText.alignment = TextAnchor.MiddleCenter;

            MicTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            MicTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            MicTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // queue tab
            GameObject QueueTab = new GameObject();
            QueueTab.name = "Queue Tab";
            QueueTab.transform.parent = MainTabObjects[1].transform;
            QueueTab.transform.localPosition = new Vector3(0, 0, 0);
            QueueTab.AddComponent<QueueTabScript>();
            QueueTab.GetComponent<QueueTabScript>().monMan = MonitorManager;

            // queue tab title
            GameObject QueueTabTitleObj = new GameObject();
            QueueTabTitleObj.name = "QueueTabTitleObject";
            QueueTabTitleObj.transform.parent = QueueTab.transform;
            QueueTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text QueueTabTitleText = QueueTabTitleObj.AddComponent<Text>();
            QueueTabTitleText.resizeTextMinSize = 0;
            QueueTabTitleText.resizeTextMaxSize = 100;
            QueueTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            QueueTabTitleText.resizeTextForBestFit = true;
            QueueTabTitleText.fontStyle = FontStyle.Normal;
            QueueTabTitleText.text = "QUEUE TAB";
            QueueTabTitleText.color = new Color32(150, 255, 150, 255);
            QueueTabTitleText.font = generalFont;
            QueueTabTitleText.alignment = TextAnchor.MiddleCenter;

            QueueTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            QueueTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            QueueTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // current Queue text
            GameObject QueueObj = new GameObject();
            QueueObj.name = "QueueObject";
            QueueObj.transform.parent = QueueTab.transform;
            QueueObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text QueueText = QueueObj.AddComponent<Text>();
            QueueText.resizeTextMinSize = 0;
            QueueText.resizeTextMaxSize = 100;
            QueueText.verticalOverflow = VerticalWrapMode.Overflow;
            QueueText.resizeTextForBestFit = true;
            QueueText.fontStyle = FontStyle.Normal;
            QueueText.text = "CURRENT QUEUE: DEFAULT";
            QueueText.color = new Color32(255, 255, 255, 255);
            QueueText.font = generalFont;
            QueueText.alignment = TextAnchor.MiddleLeft;

            QueueObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            QueueObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            QueueObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // group tab
            GameObject GroupTab = new GameObject();
            GroupTab.name = "Group Tab";
            GroupTab.transform.parent = MainTabObjects[1].transform;
            GroupTab.transform.localPosition = new Vector3(0, 0, 0);
            GroupTab.AddComponent<GroupTabScript>();
            GroupTab.GetComponent<GroupTabScript>().monMan = MonitorManager;

            // group tab title
            GameObject GroupTabTitleObj = new GameObject();
            GroupTabTitleObj.name = "GroupTabTitleObject";
            GroupTabTitleObj.transform.parent = GroupTab.transform;
            GroupTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text GroupTabTitleText = GroupTabTitleObj.AddComponent<Text>();
            GroupTabTitleText.resizeTextMinSize = 0;
            GroupTabTitleText.resizeTextMaxSize = 100;
            GroupTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            GroupTabTitleText.resizeTextForBestFit = true;
            GroupTabTitleText.fontStyle = FontStyle.Normal;
            GroupTabTitleText.text = "GROUP TAB";
            GroupTabTitleText.color = new Color32(150, 255, 150, 255);
            GroupTabTitleText.font = generalFont;
            GroupTabTitleText.alignment = TextAnchor.MiddleCenter;

            GroupTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            GroupTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            GroupTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // group map text
            GameObject GroupMapObj = new GameObject();
            GroupMapObj.name = "GroupMapObject";
            GroupMapObj.transform.parent = GroupTab.transform;
            GroupMapObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text GroupMapText = GroupMapObj.AddComponent<Text>();
            GroupMapText.resizeTextMinSize = 0;
            GroupMapText.resizeTextMaxSize = 100;
            GroupMapText.verticalOverflow = VerticalWrapMode.Overflow;
            GroupMapText.resizeTextForBestFit = true;
            GroupMapText.fontStyle = FontStyle.Normal;
            GroupMapText.text = "CURRENT MAP: FOREST";
            GroupMapText.color = new Color32(255, 255, 255, 255);
            GroupMapText.font = generalFont;
            GroupMapText.alignment = TextAnchor.MiddleLeft;

            GroupMapObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            GroupMapObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            GroupMapObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // voice tab
            GameObject VoiceTab = new GameObject();
            VoiceTab.name = "Voice Tab";
            VoiceTab.transform.parent = MainTabObjects[1].transform;
            VoiceTab.transform.localPosition = new Vector3(0, 0, 0);
            VoiceTab.AddComponent<VoiceTabScript>();
            VoiceTab.GetComponent<VoiceTabScript>().monMan = MonitorManager;

            // voice tab title
            GameObject VoiceTabTitleObj = new GameObject();
            VoiceTabTitleObj.name = "VoiceTabTitleObject";
            VoiceTabTitleObj.transform.parent = VoiceTab.transform;
            VoiceTabTitleObj.transform.localPosition = new Vector3(0f, 0.06f, 0f);

            Text VoiceTabTitleText = VoiceTabTitleObj.AddComponent<Text>();
            VoiceTabTitleText.resizeTextMinSize = 0;
            VoiceTabTitleText.resizeTextMaxSize = 100;
            VoiceTabTitleText.verticalOverflow = VerticalWrapMode.Overflow;
            VoiceTabTitleText.resizeTextForBestFit = true;
            VoiceTabTitleText.fontStyle = FontStyle.Normal;
            VoiceTabTitleText.text = "VOICE TAB";
            VoiceTabTitleText.color = new Color32(150, 255, 150, 255);
            VoiceTabTitleText.font = generalFont;
            VoiceTabTitleText.alignment = TextAnchor.MiddleCenter;

            VoiceTabTitleObj.GetComponent<RectTransform>().sizeDelta = new Vector2(115, 10);
            VoiceTabTitleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 40);
            VoiceTabTitleObj.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

            // voice text
            GameObject VoiceObj = new GameObject();
            VoiceObj.name = "VoiceObject";
            VoiceObj.transform.parent = VoiceTab.transform;
            VoiceObj.transform.localPosition = new Vector3(0f, 0.03f, 0f);

            Text VoiceText = VoiceObj.AddComponent<Text>();
            VoiceText.resizeTextMinSize = 0;
            VoiceText.resizeTextMaxSize = 100;
            VoiceText.verticalOverflow = VerticalWrapMode.Overflow;
            VoiceText.resizeTextForBestFit = true;
            VoiceText.fontStyle = FontStyle.Normal;
            VoiceText.text = "VOICE CHAT: ON";
            VoiceText.color = new Color32(255, 255, 255, 255);
            VoiceText.font = generalFont;
            VoiceText.alignment = TextAnchor.MiddleLeft;

            VoiceObj.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 10);
            VoiceObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            VoiceObj.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            // disables the other tabs. for now.
            RoomTab.SetActive(false);
            NameTab.SetActive(false);
            ColorTab.SetActive(false);
            TurnTab.SetActive(false);
            MicTab.SetActive(false);
            QueueTab.SetActive(false);
            GroupTab.SetActive(false);
            VoiceTab.SetActive(false);

            //
            //
            //

            // adds the monitor tabs to the monitor manager
            MonitorManager.PlayerSettingsObj = MainTabObjects[1];
            MonitorManager.GameSettingsObj = MainTabObjects[0];
            MonitorManager.CTScript = ColorTab.GetComponent<ColorTabScript>();
            MonitorManager.TurnTabObj = TurnTab;
            MonitorManager.MicTabObj = MicTab;
            MonitorManager.QueueTabObj = QueueTab;
            MonitorManager.GroupTabObj = GroupTab;
            MonitorManager.VoiceTabObj = VoiceTab;


            //
            //
            //

            MonitorManager.UpdateTexts(); // important

            // defining CTScript stuff
            MonitorManager.CTScript.RedValueText = RedValueLabelText;
            MonitorManager.CTScript.GreenValueText = GreenValueLabelText;
            MonitorManager.CTScript.BlueValueText = BlueValueLabelText;

            MonitorManager.CTScript.InitColors();

            TurnTab.GetComponent<TurnTabScript>().CurrentTurnSpeedText = TurnSpeedText;
            TurnTab.GetComponent<TurnTabScript>().CurrentTurnTypeText = TurnTypeText;
            TurnTab.GetComponent<TurnTabScript>().InitTurnText();

            MicTab.GetComponent<MicTabScript>().VoiceText = MicTypeText;
            MicTab.GetComponent<MicTabScript>().InitVoiceText();

            QueueTab.GetComponent<QueueTabScript>().QueueTextMain = QueueText;
            QueueTab.GetComponent<QueueTabScript>().InitQueueText();

            GroupTab.GetComponent<GroupTabScript>().MapText = GroupMapText;

            VoiceTab.GetComponent<VoiceTabScript>().VoiceChatText = VoiceText;
            VoiceTab.GetComponent<VoiceTabScript>().InitVoiceTexts();

            // pc controller
            // Computer.AddComponent<PCController>().monMan = MonitorManager;

            // changes some variables depending on the environment specified
            switch (Environment)
            {
                case "TreeRoom":
                    MonitorBase.transform.localRotation = Quaternion.Euler(0f, -20f, 0f);
                    MonitorBase.transform.localPosition = new Vector3(0.25f, 0.75f, 0.1f);
                    // changes the keys
                    // 1 key
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").AddComponent<CustomKeyComponent>().CompManager = MonitorManager;
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").tag = "CustomKey";
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").GetComponent<CustomKeyComponent>().Key = "1";
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").GetComponent<CustomKeyComponent>().KeyType = "regular";
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").GetComponent<Renderer>().material = MonitorManager.ReleasedMaterial;
                    UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/1").GetComponent<GorillaKeyboardButton>());
                    // 2 key
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/2").AddComponent<CustomKeyComponent>().CompManager = MonitorManager;
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/2").GetComponent<CustomKeyComponent>().Key = "2";
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/2").GetComponent<CustomKeyComponent>().KeyType = "regular";
                    GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/2").GetComponent<Renderer>().material = MonitorManager.ReleasedMaterial;
                    UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/2").GetComponent<GorillaKeyboardButton>());
                    break;
            }

            // ui scaling and rotation
            TabsContainer.transform.localRotation = Quaternion.Euler(90, -90, 0);
            TabsContainer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            return Computer; // returns the computer gameobject
        }
    }
}
