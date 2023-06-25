using UnityEngine;
using Mirror;
using UnityEngine.AI;

public class PlayerController : NetworkBehaviour
{
    private PlayerCharacter _playerCharacter;

    // On start, if this is the local player, spawn the player character
    public override void OnStartLocalPlayer()
    {
        CmdSpawnPlayerCharacter();
    }

    // Command to spawn the player character
    [Command]
    private void CmdSpawnPlayerCharacter()
    {
        // Instantiate the player character and set it as a child of this controller
        var prefab = Instantiate(NetworkManager.singleton.spawnPrefabs[0], transform.position, Quaternion.identity);

        NetworkServer.Spawn(prefab, connectionToClient);

        _playerCharacter = prefab.GetComponent<PlayerCharacter>();
    }

    private void Update()
    {
        if (!isLocalPlayer || _playerCharacter == null)
            return;

        // Handle input and send commands to the player character here...
        float horizontal = Input.GetAxis("Horizontal");

        _playerCharacter.HandleInput(horizontal);
    }

    public PlayerCharacter GetPlayerCharacter()
    {
        return _playerCharacter;
    }
}
