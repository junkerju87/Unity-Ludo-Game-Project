using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class victory : MonoBehaviour
{
    private Game_Controller_Script player;

    public TextMeshProUGUI congratulationText;

    private static GameObject logo1;
    private static GameObject logo2;
    private static GameObject logo3;
    private static GameObject logo4;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindObjectOfType<Game_Controller_Script>();
    }
    void Start()
    {
        logo1 = GameObject.Find("HufflepuffLogo");
        logo2 = GameObject.Find("RavenclawLogo");
        logo3 = GameObject.Find("SlytherinLogo");
        logo4 = GameObject.Find("GryffindorLogo");
        logo1.gameObject.SetActive(false);
        logo2.gameObject.SetActive(false);
        logo3.gameObject.SetActive(false);
        logo4.gameObject.SetActive(false);
        congratulationText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Game_Controller_Script.player1win == true)
        {
            logo1.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Hufflepuff! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }
        else if (Game_Controller_Script.player2win == true)
        {
            logo2.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Ravenclaw! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }
        else if (Game_Controller_Script.player3win == true)
        {
            logo3.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Slytherin! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }
        else if (Game_Controller_Script.player4win == true)
        {
            logo4.gameObject.SetActive(true);
            congratulationText.text = "Congratulation, Gryffindor! You won the House Cup in Hogwarts Tournament of Houses!";
            congratulationText.gameObject.SetActive(true);
        }

    }
}
