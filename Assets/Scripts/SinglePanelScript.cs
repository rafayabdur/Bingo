using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SinglePanelScript : MonoBehaviour
{
    
    public int rowNumber;

    [SerializeField] private GameObject panel;
    public TextMeshProUGUI PanelNum;
   
    public bool isReserved;

    //public bool Reserved { get => isReserved; set => isReserved = value; }

    private void Start()
    {
        isReserved = false;
    }

    private void Update()
    {

        //CheckReserved();


    }
    private void CheckReserved()
    {

        if (isReserved == false)
        {

            if (panel.GetComponent<Image>().color == Color.blue)
            {
                Debug.Log("here");
                isReserved = true;
                //PanelDigitScript.Instance.CheckAllElements();

            }

        }

    }

}
