using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectScreen : MonoBehaviour
{
    public Button ElonBtn, ZuckBtn;

    private void Awake()
    {
        
       // ElonBtn = GetComponent<Button>();
       // ZuckBtn = GetComponent<Button>();

        ElonBtn.onClick.AddListener(()=>SelectCharacter("Elon"));
        ZuckBtn.onClick.AddListener(()=>SelectCharacter("Zuck"));
    }
    public void GoToScene(string sceneName)
    {
        var netmanager = FindObjectOfType<MyNetworkManager>();
        if (netmanager != null)
        {
            netmanager.ServerChangeScene(sceneName);
        }
        //UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void SelectCharacter(string characterName)
    {
        switch (characterName)
        {
            case "Elon":
                PlayerPrefs.SetString("Character", "Elon");
                GameManager._instance._character = Characters.Elon;
                break;
            case "Zuck":
                PlayerPrefs.SetString("Character", "Zuck");
                GameManager._instance._character = Characters.Zuckerberg;
                break;
        }
    }
}

