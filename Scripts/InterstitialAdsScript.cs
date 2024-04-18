using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAdsScript : MonoBehaviour
{
    string gameId = "xxxx";
	string myPlacementId = "Interstitial_Android";
    bool testMode = true;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowInterstitialAd()
    {
        // Check if UnityAds ready before calling Show method:
        //if (Advertisement.IsReady())
        //{
        //    Advertisement.Show(myPlacementId);
        Advertisement.Show(myPlacementId);
        //}
        //else
        //{
        //    Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        //}
    }
}
