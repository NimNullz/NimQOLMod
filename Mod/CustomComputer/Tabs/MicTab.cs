using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class MicTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui variables
        public string MicType = "ALL CHAT";
        public Text VoiceText;


        public void InitVoiceText()
        {
            MicType = PlayerPrefs.GetString("pttType", "ALL CHAT");

            VoiceText.text = "CURRENT MIC SETTING: " + MicType;
        }

        // key presses
        public void RegularKeyPress(string KeyValue)
        {

        }

        public void SpecialKeyPress(string KeyValue)
        {
            switch (KeyValue)
            {
                case "back":
                    // changes the current tab
                    monMan.CurrentTab = "PSHomeTab";
                    // shows the ps home tab and hides self
                    monMan.PSHomeTabObj.SetActive(true);
                    gameObject.SetActive(false);
                    break;
                case "option1":
                    // saves the stat
                    PlayerPrefs.SetString("pttType", "ALL CHAT");
                    GorillaComputer.instance.pttType = "ALL CHAT";
                    MicType = "ALL CHAT";

                    // updates the text
                    VoiceText.text = "CURRENT MIC SETTING: ALL CHAT";
                    break;
                case "option2":
                    // saves the stat
                    PlayerPrefs.SetString("pttType", "PUSH TO TALK");
                    GorillaComputer.instance.pttType = "PUSH TO TALK";
                    MicType = "PUSH TO TALK";

                    // updates the text
                    VoiceText.text = "CURRENT MIC SETTING: PUSH TO TALK";
                    break;
                case "option3":
                    // saves the stat
                    PlayerPrefs.SetString("pttType", "PUSH TO MUTE");
                    GorillaComputer.instance.pttType = "PUSH TO MUTE";
                    MicType = "PUSH TO MUTE";

                    // updates the text
                    VoiceText.text = "CURRENT MIC SETTING: PUSH TO MUTE";
                    break;
            }
        }

        public void ArrowKeyPress(string KeyValue)
        {

        }
    }
}
