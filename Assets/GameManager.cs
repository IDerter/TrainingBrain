using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBase<GameManager>
{
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
    public int levelComplete;


    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Time.timeScale = 1;

        levelComplete = PlayerPrefs.GetInt("LevelComplete");

        if (level1B != null)
            level1B.interactable = false;
        if (level2B != null)
            level2B.interactable = false;
        if (level3B != null)
            level3B.interactable = false;
        if (level4B != null)
            level4B.interactable = false;

        switch (levelComplete)
        {
            case 1:
                if (level1B != null)
                    level1B.interactable = true;
                break;
            case 2:
                if (level1B != null)
                    level1B.interactable = true;
                if (level2B != null)
                    level2B.interactable = true;
                break;
            case 3:
                if (level1B != null)
                    level1B.interactable = true;
                if (level2B != null)
                    level2B.interactable = true;
                if (level3B != null)
                    level3B.interactable = true;
                break;
            case 4:
                if (level1B != null)
                    level1B.interactable = true;
                if (level2B != null)
                    level2B.interactable = true;
                if (level3B != null)
                    level3B.interactable = true;
                if (level4B != null)
                    level4B.interactable = true;
                break;
            case 5:
                if (level1B != null)
                    level1B.interactable = true;
                if (level1B != null)
                    level2B.interactable = true;
                if (level1B != null)
                    level3B.interactable = true;
                if (level1B != null)
                    level4B.interactable = true;
                if (level1B != null)
                    level5B.interactable = true;
                break;
            case 6:
                if (level1B != null)
                    level1B.interactable = true;
                if (level2B != null)
                    level2B.interactable = true;
                if (level3B != null)
                    level3B.interactable = true;
                if (level4B != null)
                    level4B.interactable = true;
                if (level5B != null)
                    level5B.interactable = true;
                if (level6B != null)
                    level6B.interactable = true;
                break;
            case 7:
                if (level1B != null)
                    level1B.interactable = true;
                if (level2B != null)
                    level2B.interactable = true;
                if (level3B != null)
                    level3B.interactable = true;
                if (level4B != null)
                    level4B.interactable = true;
                if (level5B != null)
                    level5B.interactable = true;
                if (level6B != null)
                    level6B.interactable = true;
                if (level7B != null)
                    level7B.interactable = true;
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        numberdeaths++;
        gameOverCanvas.SetActive(false);
        Debug.Log($"До показа рекламы {numberdeaths}");

        AnalyticsManager.Instance.RestartLevelNewRegime(numberdeaths);
        // Проверяем, нужно ли показывать рекламу
        if (numberdeaths % 2 == 0)
        {
           AdsManager.Instance._interstitialAds.ShowInterstitialAd();
        }
        else
        {
            // Если рекламу показывать не нужно, сразу перезагружаем уровень
            CompleteReplay();
        }
    }

    private void CompleteReplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("1Lvl");
    }

    // Остальные методы остаются без изменений
    public void ChooseRegim()
    {
        panelchooseregim.SetActive(true);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        GetComponent<AudioSource>().Play();
    }

    public void Play()
    {
        levelChanger.SetActive(true);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        GetComponent<AudioSource>().Play();
    }

    public void PlayOldRegim()
    {
        levelChanger.SetActive(true);
        panelchooseregim.SetActive(false);
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        GetComponent<AudioSource>().Play();
    }

    public void NewRegim()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("NewRegim");
    }

    public void Exit1Lvl()
    {
        SceneManager.LoadScene("Menu");
        GetComponent<AudioSource>().Play();
    }

    public void OnClickExit()
    {
        GetComponent<AudioSource>().Play();
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
        ExitPanel.SetActive(true);
    }

    public void Settings()
    {
        GetComponent<AudioSource>().Play();
        playbutton.SetActive(false);
        exitbutton.SetActive(false);
        settingsbutton.SetActive(false);
		panel.SetActive(true);
        if (volume1button != null)
		    volume1button?.SetActive(true);
        if (volume2button != null)
            volume2button?.SetActive(true);
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