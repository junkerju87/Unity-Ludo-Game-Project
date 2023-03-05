using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        if (coroutineAllowed == true)
        {
            StartCoroutine("RollTheDice");
        }
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        Game_Controller_Script.diceThrown = 6; //randomDiceSide + 1;

        if (whosTurn == 1)
        {
            Game_Controller_Script.MovePlayer(1);
            whosTurn += 1;
        }
        else if (whosTurn == 2)
        {
            Game_Controller_Script.MovePlayer(2);
            whosTurn += 1;
        }
        else if (whosTurn == 3)
        {
            Game_Controller_Script.MovePlayer(3);
            whosTurn += 1;
        }
        else if (whosTurn == 4)
        {
            Game_Controller_Script.MovePlayer(4);
            whosTurn = 1;
        }
        coroutineAllowed = true;
    }
}
