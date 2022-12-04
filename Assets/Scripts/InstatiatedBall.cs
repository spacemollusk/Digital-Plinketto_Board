using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InstatiatedBall : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Base Floor"))
        {
            StartCoroutine(DestroyBall());
        }
    }

    private IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(2);
        gameManager.UpdateUI();
        Destroy(gameObject);
    }
}
