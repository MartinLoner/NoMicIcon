using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NoMicIcon
{
    public static class BuildInfo
    {
        public const string Name = "NoMicIcon";
        public const string Author = "Ogata#0001";
        public const string Company = "null";
        public const string Version = "1.0.0";
        public const string DownloadLink = "https://github.com/ogatasaan";
        public class NoMicIconOgata : MelonMod
        {
            public override void VRChat_OnUiManagerInit()
            {
                GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent/VoiceDot").SetActive(false);
                GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent/VoiceDotDisabled").GetComponent<FadeCycleEffect>().enabled = false;
            }
        }
    }
}
