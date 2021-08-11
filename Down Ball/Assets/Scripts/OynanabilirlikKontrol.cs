using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OynanabilirlikKontrol : MonoBehaviour {

    //public GameObject yenidenPanel;
    [SerializeField]
    private GameObject durdurPanel;

    public void yenidenBaslat()
    {
        Application.LoadLevel("level1");
    }
    //public void tekrarBasla()
    //{
    //    Time.timeScale = 0;
    //    yenidenPanel.SetActive(true);
    //}
    public void OyunuDurdur()
    {
        Time.timeScale = 0f;
        durdurPanel.SetActive(true);
    }
    public void OyunuSurdur()
    {
        Time.timeScale = 1f;
        durdurPanel.SetActive(false);
    }
    public void OyunuKapat()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("MainLevel");
    }
}
