using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class DortIslem : MonoBehaviour
{
    public TextMeshProUGUI ilkSayi, ikincisayi, islem, cevap, sonuc;
    int sayi1, sayi2, islemIsareti;
    int islemSonucu;
    // Start is called before the first frame update
    void Start()
    {
        YeniSoru();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void cevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonucu)
        {
            sonuc.text = "DOÐRU";
        }
        else
        {
            sonuc.text = "YANLIÞ";
        }
    }

    public void YeniSoru()
    {
        cevap.text = "";
        sonuc.text = "";
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemIsareti = Random.Range(1, 5);
        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = " * ";
                islemSonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = " /";
                islemSonucu = sayi1 / sayi2;
                break;
        }
        ilkSayi.text = sayi1 + " ";
        ikincisayi.text = sayi2 + " ";
    }
}
