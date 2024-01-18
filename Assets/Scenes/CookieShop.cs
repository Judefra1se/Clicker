using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieShop : MonoBehaviour
{
    public Clicking Clicking;
    public int Cookies;
    public int PowerClic;

    public int ChocolateCookiePrice = 30;
    public int RainbowCookieCookiePrice = 60;

    public GameObject NatureCookie;
    public SpriteRenderer SRClickable, SRShop;
    public Sprite ChocolateCookie, RainbowCookie;

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

        }

        if (Cookies >= RainbowCookieCookiePrice && SRShop.sprite == RainbowCookie)
        {
            Cookies -= RainbowCookieCookiePrice;
            Clicking.Cookies = Cookies;
            Clicking.Score_Text.text = "Cookies : " + Cookies;
            PowerClic++;

            SRClickable.sprite = RainbowCookie;
            //SRShop.sprite = RainbowCookie;

        }
    }


}
