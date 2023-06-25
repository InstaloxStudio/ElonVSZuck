using Mirror;

public class PlayerCharacter : NetworkBehaviour
{
    public float _speed = 5f;
    public float turnSpeed = 1f;
    public PlayerController _playerController;
    public bool isLocalCharacter = false;


    private void Start()
    {
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        isLocalCharacter = true;
        gameObject.name = "LocalPlayerCharacter";
    }

    private void Update()
    {

    }

    public virtual void HandleInput(float horizontal)
    {

    }

    public PlayerController GetPlayerController()
    {
        return _playerController;
    }

    public void SetPlayerController(PlayerController playerController)
    {
        _playerController = playerController;
    }




}
