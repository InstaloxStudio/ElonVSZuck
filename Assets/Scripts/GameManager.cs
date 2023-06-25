using UnityEngine;

public class GameManager : MonoBehaviour
{
    //singleton
    public static GameManager _instance;
    public Characters _character;

    public PlayerController _playerController;
    public NetworkPlayer MyPlayer { get; set; }

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);
    }

    public NetworkPlayer GetPlayer()
    {
        return MyPlayer;
    }

    public PlayerController GetPlayerController()
    {
        return _playerController;
    }


    public void SetPlayerController(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void SetPlayerCharacter(NetworkPlayer player)
    {
        MyPlayer = player;
    }
}

public enum Characters
{
    Elon,
    Zuckerberg,
    Bezos
}
