using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    
    
    enum rpsElements { Rock = 1, Paper, Scissors }

    private int playerChoose = -1;
    private int botChoose = -1;

    private bool playersTurn = true;

    public GameObject WinnerText;

    public Sprite rockIMG, paperIMG, sciIMG;
    public GameObject botChooseImage;


    // Update is called once per frame
    void Update()
    {

        if (playersTurn && playerChoose == -1) return;

        else
        {
            BotChoose();
            CheckWinner();
            playerChoose = -1;
            playersTurn = true;
        }

    }

    void CheckWinner()
    {
        if(playerChoose == botChoose )
        {
            //draw
            WinnerText.GetComponent<Text>().text = "DRAW";
        }

        else if(playerChoose == (int)rpsElements.Paper && botChoose == (int)rpsElements.Rock)
        {
            // playerwin
            WinnerText.GetComponent<Text>().text = "PLAYER WIN";
        }

        else if (playerChoose == (int)rpsElements.Paper && botChoose == (int)rpsElements.Scissors)
        {
            // botwin
            WinnerText.GetComponent<Text>().text = "BOT WIN";
        }

        else if (playerChoose == (int)rpsElements.Rock && botChoose == (int)rpsElements.Paper)
        {
            //botwin
            WinnerText.GetComponent<Text>().text = "BOT WIN";
        }

        else if (playerChoose == (int)rpsElements.Rock && botChoose == (int)rpsElements.Scissors)
        {
            //player win
            WinnerText.GetComponent<Text>().text = "PLAYER WIN";
        }

        else if (playerChoose == (int)rpsElements.Scissors && botChoose == (int)rpsElements.Rock)
        {
            //bot win
            WinnerText.GetComponent<Text>().text = "BOT WIN";
        }

        else if (playerChoose == (int)rpsElements.Scissors && botChoose == (int)rpsElements.Paper)
        {
            //bot win
            WinnerText.GetComponent<Text>().text = "PLAYER WIN";
        }


    }

    public void PlayerChoose(int choose)
    {
        playerChoose = choose;
        playersTurn = false;
    }

    public void BotChoose()
    {
        botChoose = Random.Range(1, 4);
        Debug.Log(botChoose);


        if(botChoose == 1)
        {
            botChooseImage.GetComponent<Image>().sprite = rockIMG;
        }

        else if(botChoose == 2)
        {
            botChooseImage.GetComponent<Image>().sprite = paperIMG;
        }

        else
        {
            botChooseImage.GetComponent<Image>().sprite = sciIMG;
        }
    }
}
