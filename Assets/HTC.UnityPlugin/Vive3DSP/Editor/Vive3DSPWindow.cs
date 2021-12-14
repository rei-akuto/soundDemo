//====================== Copyright 2017-2021, HTC.Corporation. All rights reserved. ======================
/**
*   release version:    1.2.6.0
*   script version:     1.2.6.0
*/

using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace HTC.UnityPlugin.Vive3DSP
{
    public class Vive3DSPWindow : EditorWindow
    {
        [MenuItem("Window/VIVE 3DSP Audio SDK/Visit VIVE 3DSP Forum")]
        public static void OpenVive3DSPForumWebSite()
        {
            Application.OpenURL(Vive3DSPAudio.VIVE_3DSP_FORUM_URL);
        }
    }
}