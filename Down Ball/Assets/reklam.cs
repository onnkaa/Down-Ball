using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class reklam : MonoBehaviour
{

    private InterstitialAd inter;
    public string idAndroid = "";
    public string idIos = "";

    static reklam reklamKontrol;

    private void Start()
    {
        this.Request();
    }

    private void Request()
    {

        if (reklamKontrol == null)
        {
            DontDestroyOnLoad(gameObject);
            reklamKontrol = this;

#if UNITY_ANDROID
            string id = idAndroid;
#elif UNITY_IPHONE
        string id = idIos;
#else
        string id="unexpected_platform";
#endif
            this.inter = new InterstitialAd(id);

            this.inter.OnAdClosed += InterstitialClosed;

            AdRequest request = new AdRequest.Builder().Build();

            this.inter.LoadAd(request);
        }

        else
        {
            Destroy(gameObject);
        }

    }
    private void InterstitialClosed(object sender, EventArgs e)
    {
        this.Request();
    }

    public void reklamiGoster()
    {
        this.inter.Show();
    }
}
