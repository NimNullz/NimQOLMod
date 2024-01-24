using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace NimsQOLMod.Mod.CustomComputer
{
    public class KeyboardEdit : MonoBehaviour
    {
        public static KeyboardEdit Instance;

        public static void InitializeKeysStump(ComputerManager monMan)
        {
            // 3 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").tag = "CustomKey";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").GetComponent<CustomKeyComponent>().Key = "3";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/3").GetComponent<GorillaKeyboardButton>());
            // 4 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/4").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/4").GetComponent<CustomKeyComponent>().Key = "4";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/4").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/4").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/4").GetComponent<GorillaKeyboardButton>());
            // 5 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/5").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/5").GetComponent<CustomKeyComponent>().Key = "5";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/5").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/5").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/5").GetComponent<GorillaKeyboardButton>());
            // 6 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/6").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/6").GetComponent<CustomKeyComponent>().Key = "6";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/6").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/6").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/6").GetComponent<GorillaKeyboardButton>());
            // 7 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/7").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/7").GetComponent<CustomKeyComponent>().Key = "7";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/7").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/7").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/7").GetComponent<GorillaKeyboardButton>());
            // 8 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/8").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/8").GetComponent<CustomKeyComponent>().Key = "8";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/8").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/8").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/8").GetComponent<GorillaKeyboardButton>());
            // 9 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/9").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/9").GetComponent<CustomKeyComponent>().Key = "9";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/9").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/9").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/9").GetComponent<GorillaKeyboardButton>());
            // 0 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/0").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/0").GetComponent<CustomKeyComponent>().Key = "0";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/0").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/0").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/0").GetComponent<GorillaKeyboardButton>());
            // q key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/q").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/q").GetComponent<CustomKeyComponent>().Key = "Q";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/q").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/q").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/q").GetComponent<GorillaKeyboardButton>());
            // w key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/w").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/w").GetComponent<CustomKeyComponent>().Key = "W";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/w").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/w").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/w").GetComponent<GorillaKeyboardButton>());
            // e key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/e").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/e").GetComponent<CustomKeyComponent>().Key = "E";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/e").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/e").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/e").GetComponent<GorillaKeyboardButton>());
            // r key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/r").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/r").GetComponent<CustomKeyComponent>().Key = "R";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/r").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/r").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/r").GetComponent<GorillaKeyboardButton>());
            // t key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/t").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/t").GetComponent<CustomKeyComponent>().Key = "T";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/t").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/t").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/t").GetComponent<GorillaKeyboardButton>());
            // y key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/y").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/y").GetComponent<CustomKeyComponent>().Key = "Y";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/y").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/y").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/y").GetComponent<GorillaKeyboardButton>());
            // u key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/u").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/u").GetComponent<CustomKeyComponent>().Key = "U";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/u").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/u").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/u").GetComponent<GorillaKeyboardButton>());
            // i key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/i").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/i").GetComponent<CustomKeyComponent>().Key = "I";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/i").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/i").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/i").GetComponent<GorillaKeyboardButton>());
            // o key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/o").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/o").GetComponent<CustomKeyComponent>().Key = "O";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/o").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/o").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/o").GetComponent<GorillaKeyboardButton>());
            // p key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").GetComponent<CustomKeyComponent>().Key = "P";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").GetComponent<GorillaKeyboardButton>());
            // a key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/a").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/a").GetComponent<CustomKeyComponent>().Key = "A";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/a").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/a").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/a").GetComponent<GorillaKeyboardButton>());
            // s key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/s").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/s").GetComponent<CustomKeyComponent>().Key = "S";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/s").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/s").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/s").GetComponent<GorillaKeyboardButton>());
            // d key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/d").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/d").GetComponent<CustomKeyComponent>().Key = "D";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/d").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/d").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/d").GetComponent<GorillaKeyboardButton>());
            // f key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/f").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/f").GetComponent<CustomKeyComponent>().Key = "F";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/f").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/f").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/f").GetComponent<GorillaKeyboardButton>());
            // g key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/g").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/g").GetComponent<CustomKeyComponent>().Key = "G";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/g").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/g").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/g").GetComponent<GorillaKeyboardButton>());
            // h key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/h").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/h").GetComponent<CustomKeyComponent>().Key = "H";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/h").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/h").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/h").GetComponent<GorillaKeyboardButton>());
            // j key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/j").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/j").GetComponent<CustomKeyComponent>().Key = "J";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/j").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/j").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/j").GetComponent<GorillaKeyboardButton>());
            // k key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/k").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/k").GetComponent<CustomKeyComponent>().Key = "K";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/k").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/k").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/k").GetComponent<GorillaKeyboardButton>());
            // l key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/l").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/l").GetComponent<CustomKeyComponent>().Key = "L";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/l").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/l").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/l").GetComponent<GorillaKeyboardButton>());
            // z key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/z").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/z").GetComponent<CustomKeyComponent>().Key = "Z";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/z").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/z").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/z").GetComponent<GorillaKeyboardButton>());
            // x key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/x").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/x").GetComponent<CustomKeyComponent>().Key = "X";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/x").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/x").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/x").GetComponent<GorillaKeyboardButton>());
            // c key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/c").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/c").GetComponent<CustomKeyComponent>().Key = "C";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/c").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/c").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/c").GetComponent<GorillaKeyboardButton>());
            // v key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/v").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/v").GetComponent<CustomKeyComponent>().Key = "V";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/v").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/v").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/v").GetComponent<GorillaKeyboardButton>());
            // b key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/b").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/b").GetComponent<CustomKeyComponent>().Key = "B";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/b").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/b").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/b").GetComponent<GorillaKeyboardButton>());
            // n key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/n").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/n").GetComponent<CustomKeyComponent>().Key = "N";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/n").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/n").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/n").GetComponent<GorillaKeyboardButton>());
            // m key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/m").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/m").GetComponent<CustomKeyComponent>().Key = "M";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/m").GetComponent<CustomKeyComponent>().KeyType = "regular";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/m").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/m").GetComponent<GorillaKeyboardButton>());
            // delete key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/delete").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/delete").GetComponent<CustomKeyComponent>().Key = "backspace";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/delete").GetComponent<CustomKeyComponent>().KeyType = "special";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/delete").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/delete").GetComponent<GorillaKeyboardButton>());
            // back key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").SetActive(true);
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/roomconfig").SetActive(true);
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").GetComponent<GorillaKeyboardButton>());
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/roomconfig").GetComponent<Text>().text = "BACK";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/roomconfig").transform.localScale = new Vector3(0.0699f, 0.0727f, 0.029f);
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").GetComponent<CustomKeyComponent>().Key = "back";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/rooms").GetComponent<CustomKeyComponent>().KeyType = "special";

            // up key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/up").GetComponent<Renderer>().material = monMan.DarkMaterial;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/up").GetComponent<GorillaKeyboardButton>().enabled = false;
            // down key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/down").GetComponent<Renderer>().material = monMan.DarkMaterial;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/down").GetComponent<GorillaKeyboardButton>().enabled = false;
            // enter key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/enterkeyforest").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/enterkeyforest").GetComponent<CustomKeyComponent>().Key = "enter";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/enterkeyforest").GetComponent<CustomKeyComponent>().KeyType = "special";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/enterkeyforest").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/enterkeyforest").GetComponent<GorillaKeyboardButton>());

            // option 1 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 1").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 1").GetComponent<CustomKeyComponent>().Key = "option1";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 1").GetComponent<CustomKeyComponent>().KeyType = "special";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 1").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 1").GetComponent<GorillaKeyboardButton>());
            // option 2 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 2").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 2").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 2").GetComponent<GorillaKeyboardButton>());
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 2").GetComponent<CustomKeyComponent>().Key = "option2";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 2").GetComponent<CustomKeyComponent>().KeyType = "special";
            // option 3 key
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 3").AddComponent<CustomKeyComponent>().CompManager = monMan;
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 3").GetComponent<Renderer>().material = monMan.ReleasedMaterial;
            UnityEngine.GameObject.Destroy(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 3").GetComponent<GorillaKeyboardButton>());
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 3").GetComponent<CustomKeyComponent>().Key = "option3";
            GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/option 3").GetComponent<CustomKeyComponent>().KeyType = "special";
            // up arrow key
            GameObject UpArrow = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p"));
            UpArrow.name = "UpArrow";
            UpArrow.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys").transform;
            UpArrow.transform.position = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").transform.position;
            UpArrow.GetComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
            UpArrow.transform.localScale = new Vector3(1f, 1f, 1f);
            UpArrow.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            UpArrow.transform.localPosition = new Vector3(4.8595f, 0.2999f, 22.4175f);
            UpArrow.GetComponent<CustomKeyComponent>().Key = "Up";
            UpArrow.GetComponent<CustomKeyComponent>().KeyType = "arrow";

            GameObject UpArrowText = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/p"));
            UpArrowText.name = "UpArrowText";
            UpArrowText.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text").transform;
            UpArrowText.transform.localPosition = new Vector3(4.9595f, 0.8599f, 22.4175f);
            UpArrowText.transform.localRotation = Quaternion.Euler(90, 180, 0);
            UpArrowText.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            UpArrowText.GetComponent<Text>().text = ">";

            // down arrow key
            GameObject DownArrow = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p"));
            DownArrow.name = "DownArrow";
            DownArrow.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys").transform;
            DownArrow.transform.position = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").transform.position;
            DownArrow.GetComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
            DownArrow.transform.localPosition = new Vector3(6.8595f, 0.2999f, 22.4175f);
            DownArrow.transform.localScale = new Vector3(1f, 1f, 1f);
            DownArrow.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            DownArrow.GetComponent<CustomKeyComponent>().Key = "Down";
            DownArrow.GetComponent<CustomKeyComponent>().KeyType = "arrow";
            // DownArrow.GetComponent<CustomKeyComponent>().CompManager = monMan;

            GameObject DownArrowText = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/p"));
            DownArrowText.name = "DownArrowText";
            DownArrowText.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text").transform;
            DownArrowText.transform.localPosition = new Vector3(6.6587f, 0.8597f, 22.4168f);
            DownArrowText.transform.localRotation = Quaternion.Euler(90, 0, 0);
            DownArrowText.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            DownArrowText.GetComponent<Text>().text = ">";

            // left arrow key
            GameObject LeftArrow = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p"));
            LeftArrow.name = "LeftArrow";
            LeftArrow.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys").transform;
            LeftArrow.transform.position = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").transform.position;
            LeftArrow.GetComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
            LeftArrow.transform.localScale = new Vector3(1f, 1f, 1f);
            LeftArrow.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            LeftArrow.transform.localPosition = new Vector3(6.8595f, 0.2999f, 20.7175f);
            LeftArrow.GetComponent<CustomKeyComponent>().Key = "Left";
            LeftArrow.GetComponent<CustomKeyComponent>().KeyType = "arrow";

            GameObject LeftArrowText = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/p"));
            LeftArrowText.name = "LeftArrowText";
            LeftArrowText.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text").transform;
            LeftArrowText.transform.localPosition = new Vector3(6.7595f, 0.8599f, 20.6175f);
            LeftArrowText.transform.localRotation = Quaternion.Euler(90, -90, 0);
            LeftArrowText.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            LeftArrowText.GetComponent<Text>().text = "<";

            // right arrow key
            GameObject RightArrow = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p"));
            RightArrow.name = "RightArrow";
            RightArrow.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys").transform;
            RightArrow.transform.position = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Keys/p").transform.position;
            RightArrow.GetComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
            RightArrow.transform.localScale = new Vector3(1f, 1f, 1f);
            RightArrow.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            RightArrow.transform.localPosition = new Vector3(6.8595f, 0.2999f, 24.0175f);
            RightArrow.GetComponent<CustomKeyComponent>().Key = "Right";
            RightArrow.GetComponent<CustomKeyComponent>().KeyType = "arrow";

            GameObject RightArrowText = Instantiate(GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text/p"));
            RightArrowText.name = "RightArrowText";
            RightArrowText.transform.parent = GameObject.Find("TreeRoomInteractables/UI/-- PhysicalComputer UI --/keyboard/Buttons/Text").transform;
            RightArrowText.transform.localPosition = new Vector3(6.7595f, 0.8599f, 23.9175f);
            RightArrowText.transform.localRotation = Quaternion.Euler(90, -90, 0);
            RightArrowText.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            RightArrowText.GetComponent<Text>().text = ">";
        }
    }
}
