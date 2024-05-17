using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;
public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    public int sceneIndex; //на каком лвл находимся
    public int levelComplete; //сколько лвл прошел игрок
    static int winlvl = 0;
    // Use this for initialization
    void Start()
    {
        Advertisement.Initialize("3575188", false);
        if (instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }
    public void isEndGame()
    {
        if (sceneIndex == 8)
        {
            Debug.Log("End");
            Invoke("LoadMainMenu", 1f);
            levelComplete = 7;
        }
        else
        {
            //if(levelComplete< sceneIndex)
            //{
            winlvl++;
            if (winlvl % 3 == 0)
                {
                   ShowUnityAd();
                }
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("NextLevel", 0f);
            // }
        }
    }
   public void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
   public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ShowUnityAd()
    {
        Advertisement.Show();
    }
}
