using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectRoomScreenScript : MonoBehaviour
{
    //[SerializeField] private Button homeBtn;

   
    
    

    private void Start()
    {
     
    }
    private void Update()
    {
        
    }

   



    public void OnhomeBtnClick()
    {
        Debug.Log("I am in OnHomeBtnClick");
        //UIManager.Instance.GameplayOnOffScreen(true);
        //UIManager.Instance.SelectRoomOnOffScreen(false);
        //UIManager.Instance.LastScreenStatus(UIManager.Instance.gamePlayScreen);
        Debug.Log("I am in OnHomeBtnClick 2");
    }

    public void onRoomBtnClick(int roomIndex)
    {
        UIManager.Instance.LastScreenStatus(UIManager.Instance.roomScreen);
        GameManager.Instance.roomstate = (GameManager.Roomstate)roomIndex;

       
    }

   
}
