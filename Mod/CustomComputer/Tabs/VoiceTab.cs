using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class VoiceTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui vars
        public Text VoiceChatText;
        public string VoiceOn = "TRUE";

        public void InitVoiceTexts()
        {
            VoiceOn = PlayerPrefs.GetString("voiceChatOn", "TRUE");

            VoiceChatText.text = "VOIE CHAT: " + VoiceOn;
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
                    // saves stat
                    PlayerPrefs.SetString("voiceChatOn", "TRUE");
                    VoiceOn = "TRUE";
                    GorillaComputer.instance.voiceChatOn = "TRUE";

                    // updates text
                    VoiceChatText.text = "VOICE CHAT: TRUE";
                    break;
                case "option2":
                    // saves stat
                    PlayerPrefs.SetString("voiceChatOn", "FALSE");
                    VoiceOn = "FALSE";
                    GorillaComputer.instance.voiceChatOn = "FALSE";

                    // updates text
                    VoiceChatText.text = "VOICE CHAT: FALSE";
                    break;
            }
        }

        public void ArrowKeyPress(string KeyValue)
        {

        }
    }
}
