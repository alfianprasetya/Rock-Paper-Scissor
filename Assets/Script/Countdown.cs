using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] GameObject countDown;
    [SerializeField] TMP_Text countdownText;
    public float countdown = 3f;
    public void Update() 
    {    
        countdown -= Time.deltaTime * 0.95f;
        countdownText.text = countdown.ToString("0");
        if (countdown < 1)
        {
            countDown.SetActive(false);
        }
    }
}
