using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject RandomNumberText;
    //public int number;
    public List<int> num = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
                                          21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,
                                          41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,
                                          61,62,63,64,65,66,67,68,69,70,71,72,73,74,75};
    private float digitGenerationTimer;
    private float digitGenerationTimerMax = 1f;

    public bool isGameStarted;

    public List<int> slotIndexes;

    [SerializeField] private TextMeshProUGUI slottext;
    [SerializeField] private GameObject slotPanel;
    [SerializeField] private Transform slotPanelParent;

    public int roomNo;
    public int betCoin;
    public int rewardCoin;
   
    
    public int score;
    public TextMeshProUGUI scoreText ;

    public enum Roomstate
    {
        room1,
        room2,
        room3,
        room4,
    }
    public Roomstate roomstate;



    private void Awake()
    {

        Instance = this;

    }

    public void Start()
    {
        isGameStarted = false;
        score = 0;
    }

    private void Update()

    {
        if (isGameStarted)
        {
            digitGenerationTimer -= Time.deltaTime;
            if (num.Count > 0)
            {
                if (digitGenerationTimer <= 0f)
                {
                    Debug.Log("TEst");
                    digitGenerationTimer = digitGenerationTimerMax;
                    RandomNumGen();
                }
            }
        }

    }
    public void RandomNumGen()
    {
        if (num.Count > 0)
        {
            int number = Random.Range(0, num.Count);
            RandomNumberText.GetComponent<TextMeshProUGUI>().text = "" + num[number];
            //Changing Color Of Panel Containing similar number 
            //PanelDigitScript.Instance.digitList[num[number] - 1].transform.parent.GetComponent<Image>().color = Color.blue;
            PanelDigitScript.Instance.panelList[num[number] - 1].isReserved = true;
            PanelDigitScript.Instance.panelList[num[number] - 1].GetComponent<Image>().color = Color.blue;
            //Debug.Log("Sending Num: " + num[number] + " Row: " + (PanelDigitScript.Instance.panelList[num[number] - 1].rowNumber));
            PanelDigitScript.Instance.CheckAllElements(PanelDigitScript.Instance.panelList[num[number] - 1].rowNumber);


            num.Remove(num[number]);

        }

    }
    public void SetSelectedSlotsValues()
    {
        Debug.Log("i am outside");
        for (int i = 0; i < GameManager.Instance.slotIndexes.Count; i++)
        {
            Debug.Log("Inside Loop");
            GameObject InstantiatedObject = Instantiate(slotPanel, slotPanelParent);
            InstantiatedObject.GetComponentInChildren<TextMeshProUGUI>().text = (slotIndexes[i]+1).ToString();
            //slottext.text = GameManager.Instance.slotIndexes[i].ToString();
        }
    }

}

