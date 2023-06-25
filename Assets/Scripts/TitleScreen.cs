using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    public Button _playButton;
    public Button _quitButton;
    public string _playSceneName;
    public string _quitSceneName;
    public string _characterSelectSceneName;

    public void GoToScene(string sceneName)
    {
        var netmanager = FindObjectOfType<MyNetworkManager>();
        if(netmanager != null)
        {
            netmanager.ServerChangeScene(sceneName);
        }
        //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
