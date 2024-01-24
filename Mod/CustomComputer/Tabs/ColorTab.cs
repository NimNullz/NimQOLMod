using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer.Tabs
{
    public class ColorTabScript : MonoBehaviour
    {
        public ComputerManager monMan;

        // ui texts
        public Text RedValueText;
        public Text GreenValueText;
        public Text BlueValueText;

        // ui variables
        public int SelectedRow = 0;
        public int SelectedColumn = 0;

        // color variables
        public int RedValueOne = 0;
        public int RedValueTwo = 0;
        public int RedValueThree = 0;

        public int GreenValueOne = 0;
        public int GreenValueTwo = 0;
        public int GreenValueThree = 0;

        public int BlueValueOne = 0;
        public int BlueValueTwo = 0;
        public int BlueValueThree = 0;

        public void UpdateSelectedColors()
        {
            // updates selected colors
            switch (SelectedRow)
            {
                case 0: // red
                    switch (SelectedColumn)
                    {
                        case 0: // value one
                            RedValueText.text = "RED:  <color=#00ebf7>" + RedValueOne.ToString() + "</color> " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                        case 1:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " <color=#00ebf7>" + RedValueTwo.ToString() + "</color> " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                        case 2:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " <color=#00ebf7>" + RedValueThree.ToString() + "</color>";
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                    }
                    break;
                case 1: // green
                    switch (SelectedColumn)
                    {
                        case 0: // value one
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  <color=#00ebf7>" + GreenValueOne.ToString() + "</color> " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                        case 1:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " <color=#00ebf7>" + GreenValueTwo.ToString() + "</color> " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                        case 2:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " <color=#00ebf7>" + GreenValueThree.ToString() + "</color>";
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                    }
                    break;
                case 2: // blue
                    switch (SelectedColumn)
                    {
                        case 0: // value one
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  <color=#00ebf7>" + BlueValueOne.ToString() + "</color> " + BlueValueTwo.ToString() + " " + BlueValueThree.ToString();
                            break;
                        case 1:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " <color=#00ebf7>" + BlueValueTwo.ToString() + "</color> " + BlueValueThree.ToString();
                            break;
                        case 2:
                            RedValueText.text = "RED:  " + RedValueOne.ToString() + " " + RedValueTwo.ToString() + " " + RedValueThree.ToString();
                            GreenValueText.text = "GREEN:  " + GreenValueOne.ToString() + " " + GreenValueTwo.ToString() + " " + GreenValueThree.ToString();
                            BlueValueText.text = "BLUE:  " + BlueValueOne.ToString() + " " + BlueValueTwo.ToString() + " <color=#00ebf7>" + BlueValueThree.ToString() + "</color>";
                            break;
                    }
                    break;
            }
        }

        public void ArrowKeyPress(string KeyName)
        {
            switch (KeyName)
            {
                case "Up":
                    if (SelectedRow == 0)
                    {
                        SelectedRow = 2;
                    } else if (SelectedRow == 2)
                    {
                        SelectedRow = 1;
                    } else if (SelectedRow == 1)
                    {
                        SelectedRow = 0;
                    }

                    // updates the selected colors
                    UpdateSelectedColors();
                    break;
                case "Down":
                    if (SelectedRow == 0)
                    {
                        SelectedRow = 1;
                    } else if (SelectedRow == 1)
                    {
                        SelectedRow = 2;
                    } else if (SelectedRow == 2)
                    {
                        SelectedRow = 0;
                    }

                    // updates the selected colors
                    UpdateSelectedColors();
                    break;
                case "Left":
                    if (SelectedColumn == 0)
                    {
                        SelectedColumn = 2;
                    } else if (SelectedColumn == 2)
                    {
                        SelectedColumn = 1;
                    } else if (SelectedColumn == 1)
                    {
                        SelectedColumn = 0;
                    }

                    // updates the selected colors
                    UpdateSelectedColors();
                    break;
                case "Right":
                    if (SelectedColumn == 0)
                    {
                        SelectedColumn = 1;
                    } else if (SelectedColumn == 1)
                    {
                        SelectedColumn = 2;
                    } else if (SelectedColumn == 2)
                    {
                        SelectedColumn = 0;
                    }

                    // updates the selected colors
                    UpdateSelectedColors();
                    break;
            }
        }

        public void InitColors()
        {
            float RedVals = PlayerPrefs.GetFloat("redValue") * 255f;
            float GreenVals = PlayerPrefs.GetFloat("greenValue") * 255f;
            float BlueVals = PlayerPrefs.GetFloat("blueValue") * 255f;

            int RedValsFloor = (int)Math.Floor(RedVals);
            int GreenValsFloor = (int)Math.Floor(GreenVals);
            int BlueValsFloor = (int)Math.Floor(BlueVals);

            string defaultVal = "000";

            char[] RedString = defaultVal.ToCharArray();

            char[] GreenString = defaultVal.ToCharArray();

            char[] BlueString = defaultVal.ToCharArray();

            // char arrays
            char[] RedCA = RedValsFloor.ToString().ToCharArray();
            char[] GreenCA = GreenValsFloor.ToString().ToCharArray();
            char[] BlueCA = BlueValsFloor.ToString().ToCharArray();

            // adds items to char arrays
            for (int i = 0; i < RedCA.Length; i++)
            {
                RedString[i] = RedCA[i];
            }
            for (int i = 0; i < GreenCA.Length; i++)
            {
                GreenString[i] = GreenCA[i];
            }
            for (int i = 0; i < BlueCA.Length; i++)
            {
                BlueString[i] = BlueCA[i];
            }

            // setting the values
            RedValueOne = int.Parse(RedString[0].ToString());
            RedValueTwo = int.Parse(RedString[1].ToString());
            RedValueThree = int.Parse(RedString[2].ToString());

            GreenValueOne = int.Parse(GreenString[0].ToString());
            GreenValueTwo = int.Parse(GreenString[1].ToString());
            GreenValueThree = int.Parse(GreenString[2].ToString());

            BlueValueOne = int.Parse(BlueString[0].ToString());
            BlueValueTwo = int.Parse(BlueString[1].ToString());
            BlueValueThree = int.Parse(BlueString[2].ToString());

            // updates
            UpdateSelectedColors();
        }

        public void RegularKeyPress(string KeyName)
        {
            int Parsed = 0;

            int.TryParse(KeyName, out Parsed);

            if (Parsed.GetType() != typeof(int))
                return;

            // continues if the value is an integer
            switch (SelectedRow)
            {
                case 0: // red
                    switch (SelectedColumn)
                    {
                        case 0:
                            if (Parsed <= 2)
                            {
                                RedValueOne = Parsed;
                            } else if (Parsed > 2)
                            {
                                RedValueOne = 2;
                            }
                            break;
                        case 1:
                            if (RedValueOne <= 1)
                            {
                                RedValueTwo = Parsed;
                            } else if (RedValueOne == 2)
                            {
                                if (Parsed <= 5)
                                {
                                    RedValueTwo = Parsed;
                                    if (RedValueThree > 5) // value correcting
                                    {
                                        RedValueThree = 5;
                                    }
                                } else if (Parsed > 5)
                                {
                                    RedValueTwo = 5;
                                    if (RedValueThree > 5) // value correcting
                                    {
                                        RedValueThree = 5;
                                    }
                                }
                            }
                            break;
                        case 2:
                            if (RedValueOne < 2)
                            {
                                RedValueThree = Parsed;
                            } else if (RedValueOne == 2)
                            {
                                if (RedValueTwo < 5)
                                {
                                    RedValueThree = Parsed;
                                } else if (RedValueTwo == 5)
                                {
                                    if (Parsed <= 5)
                                    {
                                        RedValueThree = Parsed;
                                    } else if (Parsed > 5)
                                    {
                                        RedValueThree = 5;
                                    }
                                }
                            }
                            break;
                    }
                    break;
                case 1: // green
                    switch (SelectedColumn)
                    {
                        case 0:
                            if (Parsed <= 2)
                            {
                                GreenValueOne = Parsed;
                            } else if (Parsed > 2)
                            {
                                GreenValueOne = 2;
                            }
                            break;
                        case 1:
                            if (GreenValueOne < 2)
                            {
                                GreenValueTwo = Parsed;
                            } else if (GreenValueOne >= 2)
                            {
                                if (Parsed <= 5)
                                {
                                    GreenValueTwo = Parsed;
                                    if (GreenValueThree > 5) // value correcting
                                    {
                                        GreenValueThree = 5;
                                    }
                                } else if (Parsed > 5)
                                {
                                    GreenValueTwo = 5;
                                    if (GreenValueThree > 5) // value correcting
                                    {
                                        GreenValueThree = 5;
                                    }
                                }
                            }
                            break;
                        case 2:
                            if (GreenValueOne < 2)
                            {
                                GreenValueThree = Parsed;
                            } else if (GreenValueOne >= 2)
                            {
                                if (GreenValueTwo < 5)
                                {
                                    GreenValueThree = Parsed;
                                } else if (GreenValueThree >= 5)
                                {
                                    if (Parsed > 5)
                                    {
                                        GreenValueThree = 5;
                                    }
                                    else if (Parsed <= 5)
                                    {
                                        GreenValueThree = Parsed;
                                    }
                                }
                            }
                            break;
                    }
                    break;
                case 2: // blue
                    switch (SelectedColumn)
                    {
                        case 0:
                            if (Parsed <= 2)
                            {
                                BlueValueOne = Parsed;
                            }
                            else if (Parsed > 2)
                            {
                                BlueValueOne = 2;
                            }
                            break;
                        case 1:
                            if (BlueValueOne < 2)
                            {
                                BlueValueTwo = Parsed;
                            }
                            else if (BlueValueOne >= 2)
                            {
                                if (Parsed <= 5)
                                {
                                    BlueValueTwo = Parsed;
                                    if (BlueValueThree > 5) // value correcting
                                    {
                                        BlueValueThree = 5;
                                    }
                                }
                                else if (Parsed > 5)
                                {
                                    BlueValueTwo = 5;
                                    if (BlueValueThree > 5) // value correcting
                                    {
                                        BlueValueThree = 5;
                                    }
                                }
                            }
                            break;
                        case 2:
                            if (BlueValueOne < 2)
                            {
                                BlueValueThree = Parsed;
                            }
                            else if (BlueValueOne >= 2)
                            {
                                if (BlueValueTwo < 5)
                                {
                                    BlueValueThree = Parsed;
                                } else if (BlueValueTwo >= 5)
                                {
                                    if (Parsed > 5)
                                    {
                                        BlueValueThree = 5;
                                    } else if (Parsed <= 5)
                                    {
                                        BlueValueThree = Parsed;
                                    }
                                }
                            }
                            break;
                    }
                    break;
            }

            // updates text
            UpdateSelectedColors();
        }

        public void SpecialKeyPress(string KeyName)
        {
            switch (KeyName)
            {
                case "back":
                    monMan.PSHomeTabObj.SetActive(true);
                    monMan.CurrentTab = "PSHomeTab";
                    gameObject.SetActive(false);
                    break;
                case "enter":
                    // int stuff
                    float RedVal = (RedValueOne * 100f) + (RedValueTwo * 10f) + (RedValueOne * 1f);
                    float GreenVal = (GreenValueOne * 100f) + (GreenValueTwo * 10f) + (GreenValueOne * 1f);
                    float BlueVal = (BlueValueOne * 100f) + (BlueValueTwo * 10f) + (BlueValueThree * 1f);

                    if (!PhotonNetwork.InRoom) // offline color changing
                    {
                        GorillaTagger.Instance.UpdateColor(
                            RedVal / 255f,
                            GreenVal / 255f,
                            BlueVal / 255f
                        );
                        // saves color
                        PlayerPrefs.SetFloat("redValue", RedVal / 255f);
                        PlayerPrefs.SetFloat("greenValue", GreenVal / 255f);
                        PlayerPrefs.SetFloat("blueValue", BlueVal / 255f);
                    } else if (PhotonNetwork.InRoom)
                    {
                        GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
                        {
                            RedVal / 255f,
                            GreenVal / 255f,
                            BlueVal / 255f,
                            GorillaComputer.instance.leftHanded
                        });
                        // saves color
                        PlayerPrefs.SetFloat("redValue", RedVal / 255f);
                        PlayerPrefs.SetFloat("greenValue", GreenVal / 255f);
                        PlayerPrefs.SetFloat("blueValue", BlueVal / 255f);
                    }
                    break;
            }
        }
    }
}
