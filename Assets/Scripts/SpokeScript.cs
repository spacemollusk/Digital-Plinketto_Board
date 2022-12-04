using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpokeScript : MonoBehaviour
{

    public event EventHandler OnSpokeCollided;


    private void Start()
    {
        OnSpokeCollided += Testing_OnSpokeCollided;
    }

    private void Testing_OnSpokeCollided(object sender, EventArgs e)
    {
        Debug.Log("space!");
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //REFACTORED BELOW: if(OnSpokeCollided != null) OnSpokeCollided(this, EventArgs.Empty);
            OnSpokeCollided?.Invoke(this, EventArgs.Empty);
        }
    }

}
