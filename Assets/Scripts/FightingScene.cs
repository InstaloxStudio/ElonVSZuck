using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FightingScene : MonoBehaviour
{
    //timer until round starts
    public float _roundStartTimer = 3f;
    //timer until round ends
    public TextMeshProUGUI _roundStartText;

    public void Start()
    {
        StartCoroutine(StartRound());
    }

    IEnumerator StartRound()
    {
        //count down from 3 and display the number
        while (_roundStartTimer > 0)
        {
            _roundStartText.text = _roundStartTimer.ToString();
            yield return new WaitForSeconds(1f);
            _roundStartTimer--;
        }
        //when the timer reaches 0, display fight and start the round
        _roundStartText.text = "Fight!";
        yield return new WaitForSeconds(1f);
        _roundStartText.text = "";
        yield return new WaitForSeconds(1f);
        //start the round

        //get all characters in the scene and set their input to true
        Character[] characters = FindObjectsOfType<Character>();
        foreach (Character character in characters)
        {
            character.SetHasInput(true);
        }
        characters[1].SetHasInput(false);

    }


}
