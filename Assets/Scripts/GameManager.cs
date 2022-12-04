using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI Regerences")]
    [SerializeField]
    private TMP_Text playerPointsText;


    [SerializeField]
    public Material[] materials;

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
  

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        PlayerPoints++;
    //    }
    //}
}
