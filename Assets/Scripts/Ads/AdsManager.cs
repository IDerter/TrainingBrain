public class AdsManager : SingletonBase<AdsManager>
{
	public InitializeAds _initializeAds;
	public BannerAds _bannerAds;
	public InterstitialAds _interstitialAds;
	public RewardedAds _rewardedAds;


	protected override void Awake()
	{
		base.Awake();

		//_bannerAds.LoadBannerAd();
		_interstitialAds.LoadInterstitialAd();
		_rewardedAds.LoadRewardedAd();
	}

}
