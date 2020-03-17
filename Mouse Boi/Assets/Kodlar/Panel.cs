using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject panelBaslangic;
    public GameObject panelOyunIci;
    public GameObject panelOyunSonu;
    private float Zaman = 0f;
    public Text Sayac;
    public Text Sonuc;
    string Dakika;
    string Saniye;
    // Start is called before the first frame update
    void Start()
    {

        Zaman = 0f;
        Time.timeScale = 0;
        panelBaslangic.SetActive(true);
        panelOyunIci.SetActive(false);
        panelOyunSonu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Zaman += Time.deltaTime;
        Dakika = Mathf.Floor(Zaman / 60).ToString("00");
        Saniye = Mathf.Floor(Zaman % 60).ToString("00");
        Sayac.text= "("+Dakika+":"+Saniye+")";
        Sonuc.text = Sayac.text;
    }
    public void Basla()
    {
        Time.timeScale = 1;
        panelBaslangic.SetActive(false);
        panelOyunSonu.SetActive(false);
        panelOyunIci.SetActive(true);
        Zaman = 0f;
    }
    public void Bitir()
    {
        panelOyunSonu.SetActive(true);
        panelBaslangic.SetActive(false);
        panelOyunIci.SetActive(false);
        Time.timeScale = 0;
    }
    public void Tekrarla()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("SampleScene");
        panelBaslangic.SetActive(true);
        panelOyunIci.SetActive(false);
        panelOyunSonu.SetActive(false);
        Zaman = 0f;
    }


}
