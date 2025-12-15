using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;

public class AnalyticsManager : SingletonBase<AnalyticsManager>
{
    private bool _isInitialized = false;

    private async void Start()
    {
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();
        _isInitialized = true;
        Debug.Log(_isInitialized);
    }

    public void NextLevelStats(int currentLevel)
    {
        Debug.Log(_isInitialized + " nextLevel");
        if (!_isInitialized)
        {
            return;
        }

        CustomEvent myEvent = new CustomEvent("next_level")
        {
            {"level_index", currentLevel }
        };
        AnalyticsService.Instance.RecordEvent(myEvent);
        AnalyticsService.Instance.Flush();
        Debug.Log("next_level");
    }

    public void RestartLevelNewRegime(int numberDeaths)
    {
        CustomEvent myEvent = new CustomEvent("restart_level")
        {
            {"number_deaths", numberDeaths }
        };

        AnalyticsService.Instance.RecordEvent(myEvent);
        AnalyticsService.Instance.Flush();
        Debug.Log("restart_level");
    }

    public void SaveLevelStarsStats(int scene_index, int stars_count)
    {
        CustomEvent myEvent = new CustomEvent("stars_level")
        {
            {"scene_index", scene_index },
            {"stars_count", stars_count }
        };

        AnalyticsService.Instance.RecordEvent(myEvent);
        AnalyticsService.Instance.Flush();
        Debug.Log($"stars_level уровень = {scene_index} и кол-во звезд = {stars_count}");
    }
}
