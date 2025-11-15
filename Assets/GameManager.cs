using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
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

    private string gameId = "3575188";
    private string interstitialAd = "Android_Interstitial";
    private bool adsInitialized = false;
    private bool waitingForAd = false;
    private bool adLoaded = false;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Time.timeScale = 1;

        InitializeAds();

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

    private void InitializeAds()
    {
        Debug.Log("InitializeAds start");
        if (!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, false, this);
        }
        else
        {
            adsInitialized = true;
            Debug.Log("Загружаем рекламу после инициализации");
            Advertisement.Load(interstitialAd, this);
        }
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Ads initialization complete");
        adsInitialized = true;
        Advertisement.Load(interstitialAd, this);
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Ads initialization failed: {error} - {message}");
        adsInitialized = false;
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log($"Ad loaded: {placementId}");
        adLoaded = true;
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading ad {placementId}: {error} - {message}");
        adLoaded = false;
        // Пытаемся загрузить снова через 2 секунды
        StartCoroutine(ReloadAdAfterDelay(2f));
    }

    private IEnumerator ReloadAdAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Advertisement.Load(interstitialAd, this);
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing ad {placementId}: {error} - {message}");
        adLoaded = false;
        Advertisement.Load(interstitialAd, this);

        // Если реклама не показалась, все равно продолжаем
        if (waitingForAd)
        {
            waitingForAd = false;
            CompleteReplay();
        }
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Ad show start");
        Time.timeScale = 0; // Останавливаем игру на время показа рекламы
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Ad clicked");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Ad show complete");
        Time.timeScale = 1; // Возобновляем игру
        adLoaded = false;
        Advertisement.Load(interstitialAd, this);

        // Завершаем перезагрузку уровня после показа рекламы
        if (waitingForAd)
        {
            waitingForAd = false;
            CompleteReplay();
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

        // Проверяем, нужно ли показывать рекламу и загружена ли она
        if (numberdeaths % 2 == 0 && adLoaded)
        {
            Debug.Log("Показываем рекламу");
            waitingForAd = true;
            ShowUnityAd();
        }
        else
        {
            // Если реклама не загружена или не нужно показывать, сразу перезагружаем уровень
            CompleteReplay();
        }
    }

    private void CompleteReplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowUnityAd()
    {
        Debug.Log("ShowUnityAd");
        Advertisement.Show(interstitialAd, this);
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