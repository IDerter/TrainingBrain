using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore0Lvl : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score0").ToString();
       
        Debug.Log("Произошло сохранение числа:");

    }
}
