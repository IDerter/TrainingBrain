using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaxScoreAllLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = (((PlayerPrefs.GetInt("Score4"))+ (PlayerPrefs.GetInt("Score3"))+ (PlayerPrefs.GetInt("Score2"))+ (PlayerPrefs.GetInt("Score"))+ (PlayerPrefs.GetInt("Score0")))+ (PlayerPrefs.GetInt("Score4"))+(PlayerPrefs.GetInt("Score5"))+ (PlayerPrefs.GetInt("Score6")).ToString() + (PlayerPrefs.GetInt("Score8"))/60).ToString();
    }
	
	
}
