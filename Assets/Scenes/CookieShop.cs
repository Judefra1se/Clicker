using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CookieShop : MonoBehaviour
{
    public Clicking Clicking;
    public int Cookies;
    public int PowerClic;

    public int ChocolateCookiePrice = 100;
    public int RainbowCookiePrice = 300;
    public int ShrekCookiePrice = 550;
    public TextMeshProUGUI CookiePrice;

    public GameObject NatureCookie;
    public SpriteRenderer SRClickable, SRShop;
    public Sprite ChocolateCookie, RainbowCookie, ShrekCookie;

    public GameObject UpgradeCookieButton;

    // Start is called before the first frame update
    void Start()
    {
        Clicking = FindObjectOfType<Clicking>();

    }

    // Update is called once per frame
    void Update()
    {
        Cookies = Clicking.Cookies;
        Clicking.PowerClic = PowerClic;
    }

    private void OnMouseDown()
    {
        if (Cookies >= ChocolateCookiePrice && SRShop.sprite == ChocolateCookie)
        {
            Cookies -= ChocolateCookiePrice;
            Clicking.Cookies = Cookies;
            Clicking.Score_Text.text = "Cookies : " + Cookies;
            PowerClic++;

            SRClickable.sprite = ChocolateCookie;
            SRShop.sprite = RainbowCookie;
            CookiePrice.text = ""+RainbowCookiePrice;

        }

        if (Cookies >= RainbowCookiePrice && SRShop.sprite == RainbowCookie)
        {
            Cookies -= RainbowCookiePrice;
            Clicking.Cookies = Cookies;
            Clicking.Score_Text.text = "Cookies : " + Cookies;
            PowerClic++;

            SRClickable.sprite = RainbowCookie;
            SRShop.sprite = ShrekCookie;
            CookiePrice.text = ""+ ShrekCookiePrice;

        }

                if (Cookies >= ShrekCookiePrice && SRShop.sprite == ShrekCookie)
        {
            Cookies -= ShrekCookiePrice;
            Clicking.Cookies = Cookies;
            Clicking.Score_Text.text = "Cookies : " + Cookies;
            PowerClic++;

            SRClickable.sprite = ShrekCookie;
            Destroy (gameObject);
            Destroy(UpgradeCookieButton);
            Destroy(CookiePrice);

        }
    }


}
