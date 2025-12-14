using UnityEngine;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using System.Collections;
using TMPro;

public class SceneAchivAndBoard : MonoBehaviour
{
    public GameObject buttonachiv;
    public GameObject buttontablelid;
    public TextMeshProUGUI statusText; // Добавляем текстовое поле для статуса

    private Coroutine fadeCoroutine;

    public void Awake()
    {
        InitializePlayGames();
    }

    private void InitializePlayGames()
    {
        try
        {
            PlayGamesPlatform.Activate();

            PlayGamesPlatform.Instance.Authenticate((status) =>
            {
                if (status == SignInStatus.Success)
                {
                    Debug.Log("Успешная аутентификация!");
                    //EnableGPSFeatures();
                }
                else
                {
                    Debug.Log("Аутентификация не удалась!");
                    //EnableGPSFeatures();
                }
            });
        }
        catch (Exception e)
        {
            Debug.LogError("Ошибка: " + e.Message);
            //EnableGPSFeatures();
        }
    }

    private void EnableGPSFeatures()
    {
        Debug.Log("Включаем GPS функции");

        if (buttontablelid != null)
            buttontablelid.SetActive(true);
        if (buttonachiv != null)
            buttonachiv.SetActive(true);
    }

    public void Gps()
    {
        PlayGamesPlatform.Activate();
    }

    public void achivOpen()
    {
        try
        {
            if (Social.localUser.authenticated)
            {
                Social.ShowAchievementsUI();
            }
            else
            {
                Debug.Log("Попытка открыть достижения без аутентификации");
                // Пытаемся аутентифицироваться при клике на кнопку
                OpenGPS();
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning("Достижения недоступны: " + e.Message);
        }
    }

    public void OpenGPS()
    {
        try
        {
            PlayGamesPlatform.Instance.ManuallyAuthenticate((status) =>
            {
                if (status == SignInStatus.Success)
                {
                    Debug.Log("Успешная ручная аутентификация!");
                }
                else
                {
                    Debug.Log("Ручная аутентификация не удалась!");
                    // Можно показать сообщение пользователю
                    ShowGPSErrorMessage();
                }
            });
        }
        catch (Exception e)
        {
            Debug.LogWarning("Ошибка ручной аутентификации: " + e.Message);
            ShowGPSErrorMessage();
        }
    }

    public void leaderboardOpen()
    {
        try
        {
            if (Social.localUser.authenticated)
            {
                Social.ShowLeaderboardUI();
            }
            else
            {
                if (statusText != null)
                {
                    ShowStatusMessage("Для просмотра таблицы лидеров требуется вход в Google Play");
                }
                Debug.Log("Попытка открыть таблицу лидеров без аутентификации");
                // Пытаемся аутентифицироваться при клике на кнопку
                OpenGPS();
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning("Таблица лидеров недоступна: " + e.Message);
        }
    }

    private void ShowStatusMessage(string message)
    {
        // Останавливаем предыдущую анимацию если она есть
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }

        statusText.enabled = true;

        // Запускаем новую анимацию
        fadeCoroutine = StartCoroutine(FadeTextCoroutine());
    }

    private IEnumerator FadeTextCoroutine()
    {
        float duration = 0.5f; // Длительность появления/исчезновения
        float displayTime = 2f; // Время отображения текста

        // Плавное появление (от 0 до 1 альфа)
        float timer = 0f;
        Color startColor = statusText.color;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, timer / duration);
            statusText.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            yield return null;
        }

        // Устанавливаем полную непрозрачность
        statusText.color = new Color(startColor.r, startColor.g, startColor.b, 1f);

        // Ждем 2 секунды
        yield return new WaitForSeconds(displayTime);

        // Плавное исчезновение (от 1 до 0 альфа)
        timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timer / duration);
            statusText.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            yield return null;
        }

        // Устанавливаем полную прозрачность и скрываем
        statusText.color = new Color(startColor.r, startColor.g, startColor.b, 0f);
        statusText.enabled = false;

        fadeCoroutine = null;
    }

    private void ShowGPSErrorMessage()
    {
        string errorMessage = "Google Play Services недоступны. Проверьте:\n" +
                 "• Подключение к интернету\n" +
                 "• Наличие Google Play Services\n" +
                 "• Вход в Google аккаунт на устройстве";

        Debug.Log(errorMessage);

        if (statusText != null)
        {
            ShowStatusMessage(errorMessage);
        }
    }

    void Update()
    {
        // Опционально: можно добавить проверку статуса аутентификации
        // и обновлять UI в реальном времени
    }

    // Останавливаем корутину при уничтожении объекта
    private void OnDestroy()
    {
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }
    }
}