using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class QueueTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui vars
        public Text QueueTextMain;
        public string CurQueue = "DEFAULT";

        public void InitQueueText()
        {
            CurQueue = PlayerPrefs.GetString("CurrentQueue", "DEFAULT");
            QueueTextMain.text = "CURRENT QUEUE: " + CurQueue;
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
                    // saves option
                    PlayerPrefs.SetString("CurrentQueue", "DEFAULT");
                    CurQueue = "DEFAULT";
                    GorillaComputer.instance.currentQueue = "DEFAULT";

                    // updates text
                    QueueTextMain.text = "CURRENT QUEUE: DEFAULT";
                    break;
                case "option2":
                    // saves option
                    PlayerPrefs.SetString("CurrentQueue", "MINIGAMES");
                    CurQueue = "MINIGAMES";
                    GorillaComputer.instance.currentQueue = "MINIGAMES";

                    // updates text
                    QueueTextMain.text = "CURRENT QUEUE: MINIGAMES";
                    break;
                case "option3":
                    // saves option
                    PlayerPrefs.SetString("CurrentQueue", "COMPETITIVE");
                    CurQueue = "COMPETITIVE";
                    GorillaComputer.instance.currentQueue = "COMPETITIVE";

                    // updates text
                    QueueTextMain.text = "CURRENT QUEUE: COMPETITIVE";
                    break;
            }
        }

        public void ArrowKeyPress(string KeyValue)
        {

        }
    }
}
