using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//only need to fix the clicking part and dupe the code for all 4 characters and we're done with the movements

public class Game_Controller_Script : MonoBehaviour
{

    public static int whosTurn = 0;
    private static GameObject player1TurnText, player2TurnText, player3TurnText, player4TurnText;
    public static int diceThrown = 0;
    public static bool NotClicked = true;

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
        player1_1OnBoard = false;
        player1_2OnBoard = false;
        player1_3OnBoard = false;
        player1_4OnBoard = false;
        player2_1OnBoard = false;
        player2_2OnBoard = false;
        player2_3OnBoard = false;
        player2_4OnBoard = false;
        player3_1OnBoard = false;
        player3_2OnBoard = false;
        player3_3OnBoard = false;
        player3_4OnBoard = false;
        player4_1OnBoard = false;
        player4_2OnBoard = false;
        player4_3OnBoard = false;
        player4_4OnBoard = false;
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                diceThrown = 6;
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
        if (diceThrown != 6 && player1_1OnBoard == false && player1_2OnBoard == false && player1_3OnBoard == false && player1_4OnBoard == false)
        {
            Debug.Log("no legal moves, pass");
        }
        else
        {
            NotClicked = true;
            while (NotClicked == true)
            {
                Debug.Log("While Loop Triggered");
                if (player1_1.GetComponent<Move_Script>().Clicked == true)
                {
                    if (player1_1OnBoard == false)
                    {
                        if (diceThrown == 6)
                        {
                            player1_1.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_1.GetComponent<Move_Script>().moveAllowed = true;
                            player1_1.GetComponent<Move_Script>().Clicked = false;
                            player1_1OnBoard = true;
                            Debug.Log("Player1_1 on board");
                            NotClicked = false;
                        }
                        else
                        {
                            player1_1.GetComponent<Move_Script>().Clicked = false;
                        }
                    }
                    else if (player1_1OnBoard == true)
                    {
                        player1_1.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_1.GetComponent<Move_Script>().moveAllowed = true;
                        player1_1.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_1 on moved");
                        NotClicked = false;
                    }
                }
                else if (player1_2.GetComponent<Move_Script>().Clicked == true)
                {
                    if (player1_2OnBoard == false)
                    {
                        if (diceThrown == 6)
                        {
                            player1_2.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_2.GetComponent<Move_Script>().moveAllowed = true;
                            player1_2.GetComponent<Move_Script>().Clicked = false;
                            player1_2OnBoard = true;
                            Debug.Log("Player1_2 on board");
                            NotClicked = false;
                        }
                        else
                        {
                            player1_2.GetComponent<Move_Script>().Clicked = false;
                        }
                    }
                    else if (player1_2OnBoard == true)
                    {
                        player1_2.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_2.GetComponent<Move_Script>().moveAllowed = true;
                        player1_2.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_2 on moved");
                        NotClicked = false;
                    }
                }
                else if (player1_3.GetComponent<Move_Script>().Clicked == true)
                {
                    if (player1_3OnBoard == false)
                    {
                        if (diceThrown == 6)
                        {
                            player1_3.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_3.GetComponent<Move_Script>().moveAllowed = true;
                            player1_3.GetComponent<Move_Script>().Clicked = false;
                            player1_3OnBoard = true;
                            Debug.Log("Player1_3 on board");
                            NotClicked = false;
                        }
                        else
                        {
                            player1_3.GetComponent<Move_Script>().Clicked = false;
                        }
                    }
                    else if (player1_3OnBoard == true)
                    {
                        player1_3.GetComponent<Move_Script>().waypointIndex += diceThrown;
                        player1_3.GetComponent<Move_Script>().moveAllowed = true;
                        player1_3.GetComponent<Move_Script>().Clicked = false;
                        Debug.Log("Player1_3 on moved");
                        NotClicked = false;
                    }
                }
                else if (player1_4.GetComponent<Move_Script>().Clicked == true)
                {
                    if (player1_4OnBoard == false)
                    {
                        if (diceThrown == 6)
                        {
                            player1_4.GetComponent<Move_Script>().waypointIndex += 1;
                            player1_4.GetComponent<Move_Script>().moveAllowed = true;
                            player1_4.GetComponent<Move_Script>().Clicked = false;
                            player1_4OnBoard = true;
                            Debug.Log("Player1_4 on board");
                            NotClicked = false;
                        }
                        else
                        {
                            player1_4.GetComponent<Move_Script>().Clicked = false;
                        }
                    }
                    else if (player1_4OnBoard == true)
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
    }
    private static void Player3Select()
    {
        Debug.Log("Player 3 turn triggered");
    }
    private static void Player4Select()
    {
        Debug.Log("Player 4 turn triggered");
    }
}