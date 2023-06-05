using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GamePlayScreenScript : MonoBehaviour
{
    [SerializeField] private GameObject winUI; 
    [SerializeField] private GameObject lossUI;
    [SerializeField] private Button quitBtn;
    [SerializeField] private TextMeshProUGUI winUIBetCoinText;
    [SerializeField] private TextMeshProUGUI winUIrewardCoinText;
    [SerializeField] private TextMeshProUGUI loseUIBetCoinText;
    [SerializeField] private TextMeshProUGUI loseUIrewardCoinText;




    private void Start()
    {
        HideWinUI();
        HideLoseUI();
        
    }

    public void ShowWinUI()
    {
        //UIManager.Instance.LastScreenStatus(UIManager.Instance.winScreen);
        winUI.gameObject.SetActive(true);
        GameManager.Instance.isGameStarted = false;
        UIManager.Instance.GiveValues(GameManager.Instance.roomNo, GameManager.Instance.betCoin, GameManager.Instance.rewardCoin, null, winUIBetCoinText, winUIrewardCoinText);
    }
    public void ShowLossUI()
    {
        //UIManager.Instance.LastScreenStatus(UIManager.Instance.loseScreen);
        lossUI.gameObject.SetActive(true);
        GameManager.Instance.isGameStarted = false;
        UIManager.Instance.GiveValues(GameManager.Instance.roomNo, GameManager.Instance.betCoin, GameManager.Instance.rewardCoin, null, loseUIBetCoinText, null);
    }
    public void HideWinUI()
    {
        winUI.gameObject.SetActive(false);
        lossUI.gameObject.SetActive(true);
;    }
    public void HideLoseUI()
    {
        lossUI.gameObject.SetActive(false);
    }

    public void OnGameplayScreenBackBtnClick()
    {
        UIManager.Instance.LastScreenStatus(UIManager.Instance.selectRoomScreen);
    }
    public void OnLoseScreenbackBtnClick()
    {
        UIManager.Instance.gamePlayScreen.SetActive(true);
        UIManager.Instance.loseScreen.SetActive(false);
        GameManager.Instance.isGameStarted = true;
    }
    public void OnWinScreenRestartBtnClick()
    {
        SceneManager.LoadScene(0);
        //UIManager.Instance.LastScreenStatus(UIManager.Instance.selectRoomScreen);
        //UIManager.Instance.winScreen.SetActive(false);
        //GameManager.Instance.isGameStarted = true;

    }

    
    public void OnHomeBtnClick()
    {
        SceneManager.LoadScene(0);
        //UIManager.Instance.LastScreenStatus(UIManager.Instance.selectRoomScreen);

    }

    
  
}
