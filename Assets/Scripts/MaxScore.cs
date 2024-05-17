using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
        
        Debug.Log("Произошло сохранение числа:");

    }
	public void TOSTRING()
    {
        //GetComponent<Text>().text = PlayerPrefs.GetFloat("Score").ToString();
    }
	
}
