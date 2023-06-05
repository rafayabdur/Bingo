using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    //public GameObject homescreen;
    public GameObject selectRoomScreen;
    public GameObject roomScreen;
    public GameObject gamePlayScreen;

    public GameObject winScreen;
    public GameObject loseScreen;


    public GameObject activeScreen;



    private void Awake()
    {

        Instance = this;
       
    }


    private void Start()
    {
        if (activeScreen == null)
        {
            gamePlayScreen.SetActive(false);
            roomScreen.SetActive(false);
            selectRoomScreen.SetActive(true);
        }
      
    }

    //public void GameplayOnOffScreen(bool toggle)
    //{
    //    gamePlayScreen.SetActive(toggle);


    //}
    //public void SelectRoomOnOffScreen(bool toggle)
    //{
    //    if (toggle)
    //    {
    //        selectRoomScreen.SetActive(true);
    //    }
    //    else
    //    {
    //        selectRoomScreen.SetActive(false);
    //    }
    //}

    public void GiveValues(int roomNo, int betCoin, int rewardCoin,  TMPro.TextMeshProUGUI roomTitle, TMPro.TextMeshProUGUI betCoinText, TMPro.TextMeshProUGUI rewardCoinText)
    {
        if (roomTitle != null)
        {
            roomTitle.text = "ROOM : " + roomNo;

        }
        betCoinText.text = "BET :" + betCoin + " COIN (PER SLOT)";
        if (rewardCoinText != null) {
            rewardCoinText.text = "REWARD : " + rewardCoin;
        }
       


    }
    public void LastScreenStatus(GameObject NextScreen)
    {
        /*if(lastScreen == null)
        {
            lastScreen = CurrentScreen;
        }*/


        if (activeScreen != null)
        {
            activeScreen.SetActive(false);
        }

        activeScreen = NextScreen;



        NextScreen.SetActive(true);
    }

}




