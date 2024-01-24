using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class TurnTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui variables
        public Text CurrentTurnTypeText;
        public Text CurrentTurnSpeedText;

        public int turnSpeed = 1;
        public string turnType = "";

        public void InitTurnText()
        {
            if (PlayerPrefs.HasKey("stickTurning"))
            {
                CurrentTurnTypeText.text = "CURRENT TURN TYPE: " + PlayerPrefs.GetString("stickTurning", "NONE");
            }
            turnSpeed = PlayerPrefs.GetInt("turnFactor", 1);
            turnType = PlayerPrefs.GetString("stickTurning", "NONE");
        }

        // keys
        public void RegularKeyPress(string KeyValue)
        {
            switch (KeyValue)
            {
                case "1":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 1);
                    turnSpeed = 1;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 1";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "2":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 2);
                    turnSpeed = 2;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 2";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "3":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 3);
                    turnSpeed = 3;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 3";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "4":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 4);
                    turnSpeed = 4;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 4";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "5":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 5);
                    turnSpeed = 5;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 5";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "6":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 6);
                    turnSpeed = 6;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 6";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "7":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 7);
                    turnSpeed = 7;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 7";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "8":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 8);
                    turnSpeed = 8;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 8";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "9":
                    // saves turn speed
                    PlayerPrefs.SetInt("turnFactor", 9);
                    turnSpeed = 9;

                    // updates text
                    CurrentTurnSpeedText.text = "CURRENT TURN SPEED: 9";

                    // updates turning
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
            }
        }

        public void ArrowKeyPress(string KeyValue)
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
                    // saves turn type
                    PlayerPrefs.SetString("stickTurning", "SNAP");
                    turnType = "SNAP";

                    // updates text
                    CurrentTurnTypeText.text = "CURRENT TURN TYPE: SNAP";

                    // changes snap turn
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "option2":
                    // saves turn type
                    PlayerPrefs.SetString("stickTurning", "SMOOTH");
                    turnType = "SMOOTH";

                    // updates text
                    CurrentTurnTypeText.text = "CURRENT TURN TYPE: SMOOTH";

                    // changes snap turn
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
                case "option3":
                    // saves turn type
                    PlayerPrefs.SetString("stickTurning", "NONE");
                    turnType = "NONE";

                    // updates text
                    CurrentTurnTypeText.text = "CURRENT TURN TYPE: NONE";

                    // changes snap turn
                    GorillaTagger.Instance.GetComponent<GorillaSnapTurn>().ChangeTurnMode(turnType, turnSpeed);
                    break;
            }
        }
    }
}
