using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//find the // part and put the victory scene change command over there

public class Game_Controller_Script : MonoBehaviour
{

    public static int whosTurn = 0;
    private static GameObject player1TurnText, player2TurnText, player3TurnText, player4TurnText;
    public static int diceThrown = 0;
    public static bool NotClicked = true;
    public static int randomPiece = 0;
    public bool player1win = false;
    public bool player2win = false;
    public bool player3win = false;
    public bool player4win = false;

    private static GameObject player1_1, player1_2, player1_3, player1_4;
    private static GameObject player2_1, player2_2, player2_3, player2_4;
    private static GameObject player3_1, player3_2, player3_3, player3_4;
    private static GameObject player4_1, player4_2, player4_3, player4_4;
    private static bool player1_1OnBoard = false;
    private static bool player1_2OnBoard = false;
    private static bool player1_3OnBoard = false;
    private static bool player1_4OnBoard = false;
    private static bool player2_1OnBoard = false;
    private static bool player2_2OnBoard = false;
    private static bool player2_3OnBoard = false;
    private static bool player2_4OnBoard = false;
    private static bool player3_1OnBoard = false;
    private static bool player3_2OnBoard = false;
    private static bool player3_3OnBoard = false;
    private static bool player3_4OnBoard = false;
    private static bool player4_1OnBoard = false;
    private static bool player4_2OnBoard = false;
    private static bool player4_3OnBoard = false;
    private static bool player4_4OnBoard = false;
    private static bool player1_1Finished = false;
    private static bool player1_2Finished = false;
    private static bool player1_3Finished = false;
    private static bool player1_4Finished = false;
    private static bool player2_1Finished = false;
    private static bool player2_2Finished = false;
    private static bool player2_3Finished = false;
    private static bool player2_4Finished = false;
    private static bool player3_1Finished = false;
    private static bool player3_2Finished = false;
    private static bool player3_3Finished = false;
    private static bool player3_4Finished = false;
    private static bool player4_1Finished = false;
    private static bool player4_2Finished = false;
    private static bool player4_3Finished = false;
    private static bool player4_4Finished = false;

    void Start()
    {
        player1TurnText = GameObject.Find("Player1TurnText");
        player2TurnText = GameObject.Find("Player2TurnText");
        player3TurnText = GameObject.Find("Player3TurnText");
        player4TurnText = GameObject.Find("Player4TurnText");
        player1TurnText.gameObject.SetActive(true);
        player2TurnText.gameObject.SetActive(false);
        player3TurnText.gameObject.SetActive(false);
        player4TurnText.gameObject.SetActive(false);
        player1_1 = GameObject.Find("Hufflepuff 1");
        player1_2 = GameObject.Find("Hufflepuff 2");
        player1_3 = GameObject.Find("Hufflepuff 3");
        player1_4 = GameObject.Find("Hufflepuff 4");
        player2_1 = GameObject.Find("Ravenclaw 1");
        player2_2 = GameObject.Find("Ravenclaw 2");
        player2_3 = GameObject.Find("Ravenclaw 3");
        player2_4 = GameObject.Find("Ravenclaw 4");
        player3_1 = GameObject.Find("Slytherin 1");
        player3_2 = GameObject.Find("Slytherin 2");
        player3_3 = GameObject.Find("Slytherin 3");
        player3_4 = GameObject.Find("Slytherin 4");
        player4_1 = GameObject.Find("Gryffindor 1");
        player4_2 = GameObject.Find("Gryffindor 2");
        player4_3 = GameObject.Find("Gryffindor 3");
        player4_4 = GameObject.Find("Gryffindor 4");
    }

    private void Update()
    {
        if (player1_1.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player1_1Finished = true;
            
        }
        if (player1_2.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player1_2Finished = true;
            
        }
        if (player1_3.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player1_1Finished = true;
            
        }
        if (player1_4.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player1_1Finished = true;
            
        }
        if (player2_1.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player2_1Finished = true;
            
        }
        if (player2_2.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player2_2Finished = true;
            
        }
        if (player2_3.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player2_3Finished = true;
            
        }
        if (player2_4.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player2_4Finished = true;
            
        }
        if (player3_1.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player3_1Finished = true;
            
        }
        if (player3_2.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player3_2Finished = true;
            
        }
        if (player3_3.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player3_3Finished = true;
            
        }
        if (player3_4.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player3_4Finished = true;
            
        }
        if (player4_1.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player4_1Finished = true;
            
        }
        if (player4_2.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player4_2Finished = true;
            
        }
        if (player4_3.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player4_3Finished = true;
            
        }
        if (player4_4.GetComponent<Move_Script>().ReachedGoal == true)
        {
            player4_4Finished = true;
            
        }

        if (player1_1Finished == true && player1_2Finished == true && player1_3Finished == true && player1_4Finished == true)
        {
            //player 1 victory scene change
            SceneManager.LoadScene("Victory");
            player1win = true;
        }
        else if (player2_1Finished == true && player2_2Finished == true && player2_3Finished == true && player2_4Finished == true)
        {
            //player 2 victory scene change
            SceneManager.LoadScene("Victory");
            player2win = true;
        }
        else if (player3_1Finished == true && player3_2Finished == true && player3_3Finished == true && player3_4Finished == true)
        {
            //player 3 victory scene change
            SceneManager.LoadScene("Victory");
            player3win = true;
        }
        else if (player4_1Finished == true && player4_2Finished == true && player4_3Finished == true && player4_4Finished == true)
        {
            //player 4 victory scene change
            SceneManager.LoadScene("Victory");
            player4win = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                Debug.Log("turn 1");
                player1TurnText.gameObject.SetActive(false);
                player2TurnText.gameObject.SetActive(true);
                player3TurnText.gameObject.SetActive(false);
                player4TurnText.gameObject.SetActive(false);
                Player1Select();
                whosTurn = 1;
                break;
            case 2:
                Debug.Log("turn 2");
                player1TurnText.gameObject.SetActive(false);
                player2TurnText.gameObject.SetActive(false);
                player3TurnText.gameObject.SetActive(true);
                player4TurnText.gameObject.SetActive(false);
                Player2Select();
                whosTurn = 2;
                break;
            case 3:
                Debug.Log("turn 3");
                player1TurnText.gameObject.SetActive(false);
                player2TurnText.gameObject.SetActive(false);
                player3TurnText.gameObject.SetActive(false);
                player4TurnText.gameObject.SetActive(true);
                Player3Select();
                whosTurn = 3;
                break;
            case 4:
                Debug.Log("turn 4");
                player1TurnText.gameObject.SetActive(true);
                player2TurnText.gameObject.SetActive(false);
                player3TurnText.gameObject.SetActive(false);
                player4TurnText.gameObject.SetActive(false);
                Player4Select();
                whosTurn = 4;
                break;
        }
    }

    private static void Player1Select()
    {
        Debug.Log("player 1 triggred");
        if (player1_1OnBoard == false && player1_2OnBoard == false && player1_3OnBoard == false && player1_4OnBoard == false && diceThrown != 3 && diceThrown != 6)
        {
            Debug.Log("no legal moves, pass");
        }
        else
        {
            NotClicked = true;
            while (NotClicked == true)
            {
                Debug.Log("While Loop Triggered");
                randomPiece = Random.Range(0, 4);
                if (randomPiece == 0)
                {
                    if (player1_1OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player1_1.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_1.GetComponent<Move_Script>().moveAllowed = true;
                            player1_1.GetComponent<Move_Script>().Clicked = false;
                            player1_1OnBoard = true;
                            Debug.Log("Player1_1 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player1_1OnBoard == true && player1_1Finished == false)
                    {
                        player1_1.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_1.GetComponent<Move_Script>().moveAllowed = true;
                        player1_1.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_1 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 1)
                {
                    if (player1_2OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player1_2.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_2.GetComponent<Move_Script>().moveAllowed = true;
                            player1_2.GetComponent<Move_Script>().Clicked = false;
                            player1_2OnBoard = true;
                            Debug.Log("Player1_2 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player1_2OnBoard == true && player1_2Finished == false)
                    {
                        player1_2.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_2.GetComponent<Move_Script>().moveAllowed = true;
                        player1_2.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_2 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 2)
                {
                    if (player1_3OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player1_3.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_3.GetComponent<Move_Script>().moveAllowed = true;
                            player1_3.GetComponent<Move_Script>().Clicked = false;
                            player1_3OnBoard = true;
                            Debug.Log("Player1_3 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player1_3OnBoard == true && player1_3Finished == false)
                    {
                        player1_3.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_3.GetComponent<Move_Script>().moveAllowed = true;
                        player1_3.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_3 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 3)
                {
                    if (player1_4OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player1_4.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_4.GetComponent<Move_Script>().moveAllowed = true;
                            player1_4.GetComponent<Move_Script>().Clicked = false;
                            player1_4OnBoard = true;
                            Debug.Log("Player1_4 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player1_4OnBoard == true && player1_4Finished == false)
                    {
                        player1_4.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_4.GetComponent<Move_Script>().moveAllowed = true;
                        player1_4.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_4 on moved");
                        NotClicked = false;
                    }
                }
            }
        }
    }

    private static void Player2Select()
    {
        Debug.Log("Player 2 turn triggered");
        if (player2_1OnBoard == false && player2_2OnBoard == false && player2_3OnBoard == false && player2_4OnBoard == false && diceThrown != 3 && diceThrown != 6)
        {
            Debug.Log("no legal moves, pass");
        }
        else
        {
            NotClicked = true;
            while (NotClicked == true)
            {
                Debug.Log("While Loop Triggered");
                randomPiece = Random.Range(0, 4);
                if (randomPiece == 0)
                {
                    if (player2_1OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player2_1.GetComponent<Move_Script>().waypointIndex += 1;
                            player2_1.GetComponent<Move_Script>().moveAllowed = true;
                            player2_1.GetComponent<Move_Script>().Clicked = false;
                            player2_1OnBoard = true;
                            Debug.Log("Player2_1 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player2_1OnBoard == true && player2_1Finished == false)
                    {
                        player2_1.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player2_1.GetComponent<Move_Script>().moveAllowed = true;
                        player2_1.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player2_1 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 1)
                {
                    if (player2_2OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player2_2.GetComponent<Move_Script>().waypointIndex += 1;
                            player2_2.GetComponent<Move_Script>().moveAllowed = true;
                            player2_2.GetComponent<Move_Script>().Clicked = false;
                            player2_2OnBoard = true;
                            Debug.Log("Player2_2 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player2_2OnBoard == true && player2_2Finished == false)
                    {
                        player2_2.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player2_2.GetComponent<Move_Script>().moveAllowed = true;
                        player2_2.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player2_2 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 2)
                {
                    if (player2_3OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player2_3.GetComponent<Move_Script>().waypointIndex += 1;
                            player2_3.GetComponent<Move_Script>().moveAllowed = true;
                            player2_3.GetComponent<Move_Script>().Clicked = false;
                            player2_3OnBoard = true;
                            Debug.Log("Player2_3 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player2_3OnBoard == true && player2_3Finished == false)
                    {
                        player2_3.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player2_3.GetComponent<Move_Script>().moveAllowed = true;
                        player2_3.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player2_3 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 3)
                {
                    if (player2_4OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player2_4.GetComponent<Move_Script>().waypointIndex += 1;
                            player2_4.GetComponent<Move_Script>().moveAllowed = true;
                            player2_4.GetComponent<Move_Script>().Clicked = false;
                            player2_4OnBoard = true;
                            Debug.Log("Player1_4 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player2_4OnBoard == true && player2_4Finished == false)
                    {
                        player2_4.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player2_4.GetComponent<Move_Script>().moveAllowed = true;
                        player2_4.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player2_4 on moved");
                        NotClicked = false;
                    }
                }
            }
        }
    }
    private static void Player3Select()
    {
        Debug.Log("Player 3 turn triggered");
        if (player3_1OnBoard == false && player3_2OnBoard == false && player3_3OnBoard == false && player3_4OnBoard == false && diceThrown != 3 && diceThrown != 6)
        {
            Debug.Log("no legal moves, pass");
        }
        else
        {
            NotClicked = true;
            while (NotClicked == true)
            {
                Debug.Log("While Loop Triggered");
                randomPiece = Random.Range(0, 4);
                if (randomPiece == 0)
                {
                    if (player3_1OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player3_1.GetComponent<Move_Script>().waypointIndex += 1;
                            player3_1.GetComponent<Move_Script>().moveAllowed = true;
                            player3_1.GetComponent<Move_Script>().Clicked = false;
                            player3_1OnBoard = true;
                            Debug.Log("Player3_1 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player3_1OnBoard == true && player3_1Finished == false)
                    {
                        player3_1.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player3_1.GetComponent<Move_Script>().moveAllowed = true;
                        player3_1.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player3_1 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 1)
                {
                    if (player3_2OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player3_2.GetComponent<Move_Script>().waypointIndex += 1;
                            player3_2.GetComponent<Move_Script>().moveAllowed = true;
                            player3_2.GetComponent<Move_Script>().Clicked = false;
                            player3_2OnBoard = true;
                            Debug.Log("Player3_2 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player3_2OnBoard == true && player3_2Finished == false)
                    {
                        player3_2.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player3_2.GetComponent<Move_Script>().moveAllowed = true;
                        player3_2.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player3_2 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 2)
                {
                    if (player3_3OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player3_3.GetComponent<Move_Script>().waypointIndex += 1;
                            player3_3.GetComponent<Move_Script>().moveAllowed = true;
                            player3_3.GetComponent<Move_Script>().Clicked = false;
                            player3_3OnBoard = true;
                            Debug.Log("Player3_3 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player3_3OnBoard == true && player3_3Finished == false)
                    {
                        player3_3.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player3_3.GetComponent<Move_Script>().moveAllowed = true;
                        player3_3.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player3_3 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 3)
                {
                    if (player3_4OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player3_4.GetComponent<Move_Script>().waypointIndex += 1;
                            player3_4.GetComponent<Move_Script>().moveAllowed = true;
                            player3_4.GetComponent<Move_Script>().Clicked = false;
                            player3_4OnBoard = true;
                            Debug.Log("Player3_4 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player3_4OnBoard == true && player3_4Finished == false)
                    {
                        player3_4.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player3_4.GetComponent<Move_Script>().moveAllowed = true;
                        player3_4.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player3_4 on moved");
                        NotClicked = false;
                    }
                }
            }
        }
    }
    private static void Player4Select()
    {
        Debug.Log("Player 4 turn triggered");
        if (player4_1OnBoard == false && player4_2OnBoard == false && player4_3OnBoard == false && player4_4OnBoard == false && diceThrown != 3 && diceThrown != 6)
        {
            Debug.Log("no legal moves, pass");
        }
        else
        {
            NotClicked = true;
            while (NotClicked == true)
            {
                Debug.Log("While Loop Triggered");
                randomPiece = Random.Range(0, 4);
                if (randomPiece == 0)
                {
                    if (player4_1OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player4_1.GetComponent<Move_Script>().waypointIndex += 1;
                            player4_1.GetComponent<Move_Script>().moveAllowed = true;
                            player4_1.GetComponent<Move_Script>().Clicked = false;
                            player4_1OnBoard = true;
                            Debug.Log("Player4_1 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player4_1OnBoard == true && player4_1Finished == false)
                    {
                        player4_1.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player4_1.GetComponent<Move_Script>().moveAllowed = true;
                        player4_1.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player4_1 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 1)
                {
                    if (player4_2OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player4_2.GetComponent<Move_Script>().waypointIndex += 1;
                            player4_2.GetComponent<Move_Script>().moveAllowed = true;
                            player4_2.GetComponent<Move_Script>().Clicked = false;
                            player4_2OnBoard = true;
                            Debug.Log("Player4_2 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player4_2OnBoard == true && player4_2Finished == false)
                    {
                        player4_2.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player4_2.GetComponent<Move_Script>().moveAllowed = true;
                        player4_2.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player4_2 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 2)
                {
                    if (player4_3OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player4_3.GetComponent<Move_Script>().waypointIndex += 1;
                            player4_3.GetComponent<Move_Script>().moveAllowed = true;
                            player4_3.GetComponent<Move_Script>().Clicked = false;
                            player4_3OnBoard = true;
                            Debug.Log("Player4_3 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player4_3OnBoard == true && player4_3Finished == false)
                    {
                        player4_3.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player4_3.GetComponent<Move_Script>().moveAllowed = true;
                        player4_3.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player4_3 on moved");
                        NotClicked = false;
                    }
                }
                else if (randomPiece == 3)
                {
                    if (player4_4OnBoard == false)
                    {
                        if (diceThrown == 6 || diceThrown == 3)
                        {
                            player4_4.GetComponent<Move_Script>().waypointIndex += 1;
                            player4_4.GetComponent<Move_Script>().moveAllowed = true;
                            player4_4.GetComponent<Move_Script>().Clicked = false;
                            player4_4OnBoard = true;
                            Debug.Log("Player4_4 on board");
                            NotClicked = false;
                        }
                    }
                    else if (player4_4OnBoard == true && player4_4Finished == false)
                    {
                        player4_4.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player4_4.GetComponent<Move_Script>().moveAllowed = true;
                        player4_4.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player4_4 on moved");
                        NotClicked = false;
                    }
                }
            }
        }
    }
}