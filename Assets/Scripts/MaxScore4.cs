using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore4 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        GetComponent<Text>().text = PlayerPrefs.GetInt("Score4").ToString();
        Debug.Log("Произошло сохранение числа:");

    }
}
