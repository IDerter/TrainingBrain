﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaxScoreNewRegim : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Scorenewregim").ToString();

        Debug.Log("Произошло сохранение числа:");

    }
}