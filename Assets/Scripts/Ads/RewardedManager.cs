using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuizCinema
{
	public class RewardedManager : MonoBehaviour
	{
		//[SerializeField] private UICoins _score;


		private void Start()
		{
			RewardedAds.RewardOn += RewardOn;
		}

		private void OnDestroy()
		{
			RewardedAds.RewardOn -= RewardOn;
		}

		private void RewardOn()
		{
			//_score.AddCoins(50);
			Debug.Log($"UPDATE SCORE : {50}");
		}
	}
}