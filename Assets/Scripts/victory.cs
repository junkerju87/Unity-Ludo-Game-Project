using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    private Game_Controller_Script player;


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
        logo2 = GameObject.Find("RevenclawLogo");
        logo3 = GameObject.Find("SlytherinLogo");
        logo4 = GameObject.Find("GryffindorLogo");
        logo1.gameObject.SetActive(false);
        logo2.gameObject.SetActive(false);
        logo3.gameObject.SetActive(false);
        logo4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.player1win == true)
        {
            logo1.gameObject.SetActive(true);
        }
        else if (player.player2win == true)
        {
            logo2.gameObject.SetActive(true);
        }
        else if (player.player3win == true)
        {
            logo3.gameObject.SetActive(true);
        }
        else if (player.player4win == true)
        {
            logo4.gameObject.SetActive(true);
        }
    }
}
