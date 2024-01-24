using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class GroupTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui variables
        public Text MapText;
        public string CurrentMap;

        // key presses
        public void RegularKeyPress(string KeyValue)
        {
            switch (KeyValue)
            {
                case "1":
                    // saves the value
                    PlayerPrefs.SetString("groupMapJoin", "FOREST");
                    PlayerPrefs.SetInt("groupMapJoinIndex", 0);
                    CurrentMap = "FOREST";

                    // updates text
                    MapText.text = "CURRENT MAP: " + CurrentMap;

                    // joining
                    GorillaComputer.instance.OnGroupJoinButtonPress(0, GorillaComputer.instance.friendJoinCollider);
                    break;
                case "2":
                    // saves the value
                    PlayerPrefs.SetString("groupMapJoin", "CAVE");
                    PlayerPrefs.SetInt("groupMapJoinIndex", 1);
                    CurrentMap = "CAVE";

                    // updates text
                    MapText.text = "CURRENT MAP: " + CurrentMap;

                    // joining
                    GorillaComputer.instance.OnGroupJoinButtonPress(1, GorillaComputer.instance.friendJoinCollider);
                    break;
                case "3":
                    // saves the value
                    PlayerPrefs.SetString("groupMapJoin", "CANYON");
                    PlayerPrefs.SetInt("groupMapJoinIndex", 2);
                    CurrentMap = "CANYON";

                    // updates text
                    MapText.text = "CURRENT MAP: " + CurrentMap;

                    // joining
                    GorillaComputer.instance.OnGroupJoinButtonPress(2, GorillaComputer.instance.friendJoinCollider);
                    break;
                case "4":
                    // saves the value
                    PlayerPrefs.SetString("groupMapJoin", "CITY");
                    PlayerPrefs.SetInt("groupMapJoinIndex", 3);
                    CurrentMap = "CITY";

                    // updates text
                    MapText.text = "CURRENT MAP: " + CurrentMap;

                    // joining
                    GorillaComputer.instance.OnGroupJoinButtonPress(3, GorillaComputer.instance.friendJoinCollider);
                    break;
            }
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
            }
        }

        public void ArrowKeyPress(string KeyValue)
        {

        }
    }
}
