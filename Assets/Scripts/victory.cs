using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class victory : MonoBehaviour
{
    private Game_Controller_Script player;

    public TextMeshProUGUI congratulationText;
    public TextMeshProUGUI movingText;

    private static GameObject logo1;
    private static GameObject logo2;
    private static GameObject logo3;
    private static GameObject logo4;

    void Awake()
    {
        // Find an instance of the Game_Controller_Script in the scene and assign it to the 'player' variable
        player = FindObjectOfType<Game_Controller_Script>();
    }

    void Start()
    {
        // Call the 'Initialize' function when the script starts running
        Initialize();
    }

    void Initialize()
    {
        // Find the game object - houses logo in the scene with the specified names and assign them to different logos
        logo1 = GameObject.Find("HufflepuffLogo");
        logo2 = GameObject.Find("RavenclawLogo");
        logo3 = GameObject.Find("SlytherinLogo");
        logo4 = GameObject.Find("GryffindorLogo");

        // Deactivate all of the variables so that it can be set active according to different situations
        logo1.gameObject.SetActive(false);
        logo2.gameObject.SetActive(false);
        logo3.gameObject.SetActive(false);
        logo4.gameObject.SetActive(false);
        congratulationText.gameObject.SetActive(false);
        movingText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Call the 'CheckWinner' function every frame
        CheckWinner();
    }

    void CheckWinner()
    {
        // Check if Hufflepuff has won the game (variable comes from Game_Controller_Script)
        if (Game_Controller_Script.player1win == true)
        {
            Debug.Log(Game_Controller_Script.player1move);

            // Convert the total number of moves made by player 1 to a float and display it in the 'movingText' object
            float float_player1_moving = (float)Game_Controller_Script.player1move;
            movingText.text = "Total moving steps of Hufflepuff: " + float_player1_moving;
            movingText.gameObject.SetActive(true);

            // Activate the Hufflepuff logo and display the victory message for Hufflepuff
            logo1.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Hufflepuff! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }

        // Check if Ravenclaw has won the game (variable comes from Game_Controller_Script)
        else if (Game_Controller_Script.player2win == true)
        {
            Debug.Log(Game_Controller_Script.player2move);

            // Convert the total number of moves made by player 2 to a float and display it in the 'movingText' object
            float float_player2_moving = (float)Game_Controller_Script.player2move;
            movingText.text = "Total moving steps of Ravenclaw: " + float_player2_moving;
            movingText.gameObject.SetActive(true);

            // Activate the Ravenclaw logo and display the victory message for Ravenclaw
            logo2.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Ravenclaw! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }

        // Check if Slytherin has won the game (variable comes from Game_Controller_Script)
        else if (Game_Controller_Script.player3win == true)
        {
            Debug.Log(Game_Controller_Script.player3move);

            // Convert the total number of moves made by player 3 to a float and display it in the 'movingText' object
            float float_player3_moving = (float)Game_Controller_Script.player3move;
            movingText.text = "Total moving steps of Slytherin: " + float_player3_moving;

            // Activate the Slytherin logo and display the victory message for Slytherin
            movingText.gameObject.SetActive(true);
            logo3.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Slytherin! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }

        // Check if Gryffindor has won the game (variable comes from Game_Controller_Script)
        else if (Game_Controller_Script.player4win == true)
        {
            Debug.Log(Game_Controller_Script.player4move);

            // Convert the total number of moves made by player 4 to a float and display it in the 'movingText' object
            float float_player4_moving = (float)Game_Controller_Script.player4move;
            movingText.text = "Total moving steps of Gryffindor: " + float_player4_moving;
            movingText.gameObject.SetActive(true);

            // Activate the Gryffindor logo and display the victory message for Gryffindor
            logo4.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Gryffindor! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }
    }
}
