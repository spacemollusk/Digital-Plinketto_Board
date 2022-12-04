using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI Regerences")]
    [SerializeField]
    private TMP_Text playerPointsText;
 


    private int playerPoints;
    public int PlayerPoints
    {
        get
        {
            return playerPoints;
        }
        set
        {
            playerPoints = value;
            playerPointsText.text = value.ToString();
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPoints++;
        }
    }
}
