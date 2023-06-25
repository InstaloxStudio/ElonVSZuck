using Mirror;

public class NetworkPlayer : NetworkBehaviour
{
    [SyncVar] // SyncVars are variables that are automatically synchronized from the server to all clients
    public int selectedCharacter;


    //on start local player
    public override void OnStartLocalPlayer()
    {
        //rename gameobject to LocalPlayerController
        gameObject.name = "LocalNetworkPlayer";

       

        CmdSelectCharacter(0);
    }

    // This Command is called from the client but runs on the server
    [Command]
    public void CmdSelectCharacter(int characterIndex)
    {
        selectedCharacter = characterIndex;

        //0 is elon, 1 is zuckerberg, 2 is bezos
        if (selectedCharacter == 0)
        {
            GameManager._instance._character = Characters.Elon;
        }
        else if (selectedCharacter == 1)
        {
            GameManager._instance._character = Characters.Zuckerberg;
        }
        else if (selectedCharacter == 2)
        {
            GameManager._instance._character = Characters.Bezos;
        }
    }


}
