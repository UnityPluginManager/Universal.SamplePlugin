using UnityEngine;
using PluginManager.Plugin;

namespace SamplePlugin
{
    // You may have multiple [OnGameInit] scripts. There is no limit on how many.
    // For a plugin to actually do anything, it must have at least one script marked
    // as [OnGameInit].
    
    /// <summary>Displays the name of the active scene in the upper-left corner</summary>
    [OnGameInit] public class DisplayCurrentScene : MonoBehaviour
    {
        private void OnGUI()
        {
            // For compatibility, we use Application.loadedLevelName because
            // SceneManager.GetActiveScene().name is only for newer versions of Unity.
            // Feel free to use the latter in your own plugins, if your target game supports it.
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), Application.loadedLevelName);
        }
    }
}
