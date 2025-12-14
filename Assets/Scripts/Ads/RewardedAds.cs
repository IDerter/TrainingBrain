using QuizCinema;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class RewardedAds : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
	public static event Action RewardOn;

	[SerializeField] private string _androidAdUnityId = "Rewarded_Android";
	[SerializeField] private string _iosAdUnityId = "Rewarded_iOS";

	private string _adUnitId = null;

	[SerializeField] private GameObject _toDelete;

	private void Awake()
	{
#if UNITY_IOS
            _adUnitId = _iosAdUnityId;
#elif UNITY_ANDROID
		_adUnitId = _androidAdUnityId;
#endif
	}


	public void LoadRewardedAd(GameObject toDelete = null)
	{
		Advertisement.Load(_adUnitId, this);
		Debug.Log("Ad Loaded: " + _adUnitId);
	}

	public void ShowRewardedAd(GameObject toDelete = null)
	{
		_toDelete = toDelete;
		LoadRewardedAd();

		StartCoroutine(RewardedDelayShow());
	}

	#region LoadCallback
	public void OnUnityAdsAdLoaded(string placementId)
	{
		Debug.Log("Ad Loaded: ONUNITYADSLOADED " + _adUnitId);

		if (_adUnitId == placementId)
		{
			Debug.Log("Success load reward!!!");
		}
	}

	public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
	{
		Debug.Log($"Ad Failed to Load for placement {placementId}: {error.ToString()} - {message}");
		StartCoroutine(RetryLoadAd(5f));
	}
	#endregion
	public void ShowAd()
	{
		Advertisement.Show(_adUnitId, this);
	}

	#region ShowCallback


	public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
	{
		Debug.LogError($"Ad Failed to Show for placement {placementId}: {error.ToString()} - {message}");
	}

	public void OnUnityAdsShowStart(string placementId) { }

	public void OnUnityAdsShowClick(string placementId) { }

	public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
	{
		if (placementId == _adUnitId && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
		{
			Debug.Log("Ads Fully Watched .....");

			if (_toDelete != null)
				Destroy(_toDelete.gameObject, 1f);

			RewardOn?.Invoke();
			LoadRewardedAd();
		}
	}
	#endregion

	public IEnumerator RewardedDelayShow()
	{
		yield return new WaitForSeconds(2f);
		ShowAd();
	}
	private IEnumerator RetryLoadAd(float delay)
	{
		yield return new WaitForSeconds(delay);
		LoadRewardedAd();
		Debug.Log($"Retrying to load rewarded ad in {delay} seconds.");
	}
}
