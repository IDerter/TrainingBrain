using UnityEngine;
using UnityEngine.UI;

namespace QuizCinema
{
	public class ButtonsRewarded : MonoBehaviour
    {
        [SerializeField] private Button _buttonClickRewarded;
        [SerializeField] private bool _isDelete = true;

        public void Multiplier()
        {
            AdsManager.Instance._rewardedAds.ShowRewardedAd();

            if (_isDelete)
                Destroy(_buttonClickRewarded.gameObject, 1f);
        }
    }
}