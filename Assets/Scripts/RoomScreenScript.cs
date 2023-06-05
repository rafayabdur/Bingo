using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomScreenScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI roomTitleText;
    [SerializeField] private TextMeshProUGUI betCoinText;
    [SerializeField] private TextMeshProUGUI rewardCoinText;
    [SerializeField] private Button playbutton;
  
    
 


    [SerializeField] private List<Toggle> toggleList;
    private void Start()
    {
        playbutton.gameObject.SetActive(false);
    }
    private void Awake()
    {
        CheckRoomState();

    }
   
    public void OnplayBtnClick()
    {
            
            UIManager.Instance.LastScreenStatus(UIManager.Instance.gamePlayScreen);
            GameManager.Instance.isGameStarted = true;
            GameManager.Instance.SetSelectedSlotsValues();

        
    }

    private void ChectTooglelistCount()
    {
        if (GameManager.Instance.slotIndexes.Count == 0)
        {
            playbutton.interactable = false;
        }
        else
        {
            playbutton.interactable = true;
        }
    }

    public void CheckRoomState()
    {
        switch (GameManager.Instance.roomstate)
        {
            case GameManager.Roomstate.room1:
                GameManager.Instance.roomNo = 01;
                GameManager.Instance.betCoin = 01;
                GameManager.Instance.rewardCoin = 10;
                GameManager.Instance.score = 33;
                
                //UIManager.Instance.GiveValues(01, 01, 10, roomTitleText, betCoinText, rewardCoinText);
                break;
            case GameManager.Roomstate.room2:
                GameManager.Instance.roomNo = 02;
                GameManager.Instance.betCoin = 02;
                GameManager.Instance.rewardCoin = 20;
                GameManager.Instance.score = 43;
                //UIManager.Instance.GiveValues(02, 02, 20,  roomTitleText, betCoinText, rewardCoinText);
                break;
            case GameManager.Roomstate.room3:
                GameManager.Instance.roomNo = 03;
                GameManager.Instance.betCoin = 03;
                GameManager.Instance.rewardCoin = 30;
                GameManager.Instance.score = 53;
                //UIManager.Instance.GiveValues(03, 03, 30, roomTitleText, betCoinText, rewardCoinText);
                break;
            case GameManager.Roomstate.room4:
                GameManager.Instance.roomNo = 04;
                GameManager.Instance.betCoin = 04;
                GameManager.Instance.rewardCoin = 40;
                GameManager.Instance.score = 63;
                //UIManager.Instance.GiveValues(04, 04, 40, roomTitleText,betCoinText, rewardCoinText);
                break;
            default:
                break;
                
        }
        UIManager.Instance.GiveValues(GameManager.Instance.roomNo, GameManager.Instance.betCoin, GameManager.Instance.rewardCoin, roomTitleText,betCoinText,rewardCoinText);

    }



    public void OnToggleCLick(Toggle myToggle)
    {
        for (int i = 0; i < toggleList.Count; i++)
        {
           
         if (myToggle == toggleList[i])
         {
                ToggleStatus(myToggle.isOn, i);
                playbutton.gameObject.SetActive(true);
                ChectTooglelistCount();
            }
        
        }

    }

    public void ToggleStatus(bool status, int slotIndex)
    {

      if(status)
      {
        Debug.Log("heeeree!!");
        status = false;
            
        GameManager.Instance.slotIndexes.Add(slotIndex);
            
         if(GameManager.Instance.slotIndexes.Count > 4)
            {
                
                for (int i = 0; i < toggleList.Count; i++)
                {
                    if (!toggleList[i].isOn)
                    {
                        toggleList[i].interactable = false;
                    }
                }
            }
      }
      else
        {
            status = true;
            GameManager.Instance.slotIndexes.Remove(slotIndex);
           
            if (GameManager.Instance.slotIndexes.Count <= 4)
            {
                for (int i = 0; i < toggleList.Count; i++)
                {
                    if (!toggleList[i].isOn)
                    {
                        toggleList[i].interactable = true;
                    }

                }

            }

        }
        
    }
}
