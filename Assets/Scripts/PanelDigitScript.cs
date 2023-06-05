using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

[Serializable]
public class TileState
{
    public List<GameObject> checkElements = new List<GameObject>();
}
public class PanelDigitScript : MonoBehaviour
{
    public static PanelDigitScript Instance;
    //private SinglePanelScript singlePanelScript;
    //public List<TextMeshProUGUI> digitList;
    public List<SinglePanelScript> panelList;
    public List<GameObject> row1;
    public Button bingoBtn;

    //public SinglePanelScript singlePanelScript;

    public List<TileState> elementsList;
    //public TileState elementsListTest;

    private void Awake()
    {
        Instance = this;
        
    }
    private void Start()
    {
        HideBingoBtn();   
    }
    private void Update()
    {
       
    }

    //[SerializeField] private TextMeshProUGUI randomDigit;

    public bool CheckAllElements(int rowNum)
    {
        

        //******************************************************************USE THIS WHEN SLOT FUNCTIONALITY IS NOT WORKING*****************
        //for (int i = 0; i < elementsList[rowNum].checkElements.Count; i++)
        //{
        //    if (!elementsList[rowNum].checkElements[i].GetComponent<SinglePanelScript>().isReserved)
        //    {
        //        Debug.Log("IN 3");
        //        return false;
        //    }
        //}
        //Show();
        //Debug.Log("Outside loop");
        //return true;

        for (int i = 0; i < GameManager.Instance.slotIndexes.Count; i++) // Checking Users Slots
        {
            Debug.Log("IN 1:");
            if (rowNum == GameManager.Instance.slotIndexes[i]) // Verifing Place Tile row number with user's row number
            {
                Debug.Log("IN 2:" + rowNum);
                for (int j = 0; j < elementsList[rowNum].checkElements.Count; j++) // Traverse specific row, on new tile generated
                {
                    if (!elementsList[rowNum].checkElements[j].GetComponent<SinglePanelScript>().isReserved) // checking if complete row is not reserved
                    {
                        Debug.Log("IN 3");
                        return false;
                    }
                }
                ShowBingoBtn();
                GameManager.Instance.scoreText.text = ""+ GameManager.Instance.score / GameManager.Instance.slotIndexes.Count;
                Debug.Log("Outside loop");
                return true;
            }
        }
       
        return true;
    }
    public void ShowBingoBtn()
    {
        Debug.Log("Showing Bingo");
        bingoBtn.gameObject.SetActive(true);
        
    }

    public void HideBingoBtn()
    {
        bingoBtn.gameObject.SetActive(false);
    }
}
