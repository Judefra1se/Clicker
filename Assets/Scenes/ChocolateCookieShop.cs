using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateCookieShop : MonoBehaviour
{
    public Clicking Clicking;
    public int Cookies;
    public int Price;
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
        Price = 30;
    }

    private void OnMouseDown()
    {
        if (Cookies >= Price && SRShop.sprite == ChocolateCookie)
        {
            Cookies -= Price;
            Clicking.Cookies = Cookies;
            Clicking.Score_Text.text = "Cookies : " + Cookies;

            SRClickable.sprite = ChocolateCookie;
            SRShop.sprite = RainbowCookie;

        }
    }


}
