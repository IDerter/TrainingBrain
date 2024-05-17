using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;
public class GameManager : MonoBehaviour {
    public GameObject panel;
    public GameObject gameOverCanvas;
    public GameObject Canvas;
    public GameObject exitbutton;
    public GameObject playbutton;
    public GameObject settingsbutton;
    public GameObject volume1button;
    public GameObject volume2button;
    public GameObject vkbutton;
    public GameObject levelChanger;
    public GameObject ExitPanel;
    static int numberdeaths = 0;

    public GameObject panelchooseregim;
    public Button level1B;
    public Button level2B;
    public Button level3B;
    public Button level4B;
    public Button level5B;
    public Button level6B;
    public Button level7B;
    //public Button level5B;
    public int levelComplete;
    // Use this for initialization
    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Time.timeScale = 1;
       // Advertisement.Initialize("3575188", false);
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

        level1B.interactable = false;
        level2B.interactable = false;
        level3B.interactable = false;
        level4B.interactable = false;
      //  level5B.interactable = false;
        switch (levelComplete)
        {
            case 1:
                level1B.interactable = true;
                break;
            case 2:
                level1B.interactable = true;
                level2B.interactable = true;
                break;
            case 3:
                level1B.interactable = true;
                level2B.interactable = true;
                level3B.interactable = true;
                break;
            case 4:
                level1B.interactable = true;
                level2B.interactable = true;
                level3B.interactable = true;
                level4B.interactable = true;
                break;
            case 5:
                level1B.interactable = true;
                level2B.interactable = true;
                level3B.interactable = true;
                level4B.interactable = true;
                level5B.interactable = true;
                break;
            case 6:
                level1B.interactable = true;
                level2B.interactable = true;
                level3B.interactable = true;
                level4B.interactable = true;
                level5B.interactable = true;
                level6B.interactable = true;
                break;
            case 7:
                level1B.interactable = true;
                level2B.interactable = true;
                level3B.interactable = true;
                level4B.interactable = true;
                level5B.interactable = true;
                level6B.interactable = true;
                level7B.interactable = true;
                break;
                // case 5:
                // level1B.interactable = true;
                //  level2B.interactable = true;
                //  level3B.interactable = true;
                //  level4B.interactable = true;
                //  level5B.interactable = true;
                //  break;

                /* if (Monetization.isSupported)
                 {
                     Monetization.Initialize("3575188", false);
                 }
                 */
        }
    }
        void Update()
    {
        /*
    
        if (levelChanger.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            levelChanger.SetActive(false);
            playbutton.SetActive(true);
            exitbutton.SetActive(true);
            settingsbutton.SetActive(true);
        }
        if (panelchooseregim.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            panelchooseregim.SetActive(false);
            playbutton.SetActive(true);
            exitbutton.SetActive(true);
            settingsbutton.SetActive(true);
        }
        else if (ExitPanel.activeSelf == false && Input.GetKeyDown(KeyCode.Escape)&&panel.activeSelf==false)
        {
            playbutton.SetActive(false);
            exitbutton.SetActive(false);
            settingsbutton.SetActive(false);
            ExitPanel.SetActive(true);
        }
        
        else if (Input.GetKeyDown(KeyCode.Escape) && panel.activeSelf==true && ExitPanel.activeSelf == false)
        {
            panel.SetActive(false);
            playbutton.SetActive(true);
            exitbutton.SetActive(true);
            settingsbutton.SetActive(true);
            Debug.Log("SETTINGS");
        }*/
    }
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
       // Canvas.SetActive(false);
        Time.timeScale = 0;


    }
    public void Replay()
    {
        numberdeaths++;
        gameOverCanvas.SetActive(false);
       
        if (numberdeaths % 2 == 0)
        {
            ShowUnityAd();
        }
       
        
        Application.LoadLevel(Application.loadedLevel);
    }
    public void ShowUnityAd()
    {
        Advertisement.Show();
    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel("1Lvl");
    }
    /*void HandleShowResult()
    {
        if (result == ShowResult.Finished)
        {

        }
        else if (result == ShowResult.Skipped)
        {

        }
        else if (result == ShowResult.Skipped)
        {

        }
    }
    */
    public void ChooseRegim()
    {
        panelchooseregim.SetActive(true);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        // Application.LoadLevel("1Lvl");
        GetComponent<AudioSource>().Play();

    }
    public void Play()
    {
        levelChanger.SetActive(true);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        // Application.LoadLevel("1Lvl");
        GetComponent<AudioSource>().Play();
       // if (winlvl % 3 == 0)
      //  {
        //    ShowUnityAd();
      //  }
    }
    public void PlayOldRegim()
    {
        levelChanger.SetActive(true);
        panelchooseregim.SetActive(false);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        // Application.LoadLevel("1Lvl");
        GetComponent<AudioSource>().Play();
        // if (winlvl % 3 == 0)
        //  {
        //    ShowUnityAd();
        //  }
    }
    public void NewRegim()
    {
        GetComponent<AudioSource>().Play();
        Application.LoadLevel("NewRegim");
    }
    public void Exit1Lvl()
    {

        Application.LoadLevel("Menu");
        GetComponent<AudioSource>().Play();
    }
    public void OnClickExit()
    {
        GetComponent<AudioSource>().Play();
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        ExitPanel.SetActive(true);
        //Application.Quit();
    }
    public void Settings()
    {
        GetComponent<AudioSource>().Play();
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        panel.SetActive(true);
        volume1button.SetActive(true);
        volume2button.SetActive(true);
    }
    public void ExitPanel1()
    {
        panel.SetActive(false);
        playbutton.SetActive(true);
        exitbutton.SetActive(true);
        settingsbutton.SetActive(true);

    }
    public void ExitPanelChooseRegim()
    {
        playbutton.SetActive(true);
        exitbutton.SetActive(true);
        settingsbutton.SetActive(true);
        panelchooseregim.SetActive(false);

    }
    public void Volume()
    {
        GetComponent<AudioSource>().Play();
        AudioListener.volume = 1;
    }
    public void DontVolume()
    {
        GetComponent<AudioSource>().Play();
        AudioListener.volume = 0;
    }
    public void VK()
    {
        GetComponent<AudioSource>().Play();
        Application.OpenURL("https://vk.com/public181912670");
    }
    public void OnClickNo()
    {
        playbutton.SetActive(true);
        exitbutton.SetActive(true);
        settingsbutton.SetActive(true);
        GetComponent<AudioSource>().Play();
        ExitPanel.SetActive(false);

    }
    public void OnClickYes()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
    
}
