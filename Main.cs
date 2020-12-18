using MelonLoader;
using System;
using System.Reflection;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnhollowerRuntimeLib;
using System.Linq;
using Harmony;
using MelonLoader.Tomlyn;

namespace NoMicIcon
{
    public class MyMod : MelonMod
    {
        public override void VRChat_OnUiManagerInit()
        {
            GameObject.DestroyImmediate(GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent"));
        }
    }
}