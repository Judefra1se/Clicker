using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
    public Clicking Clicking;
    public int Cookies;
    public int Price;
    public int Power;

    // Start is called before the first frame update
    void Start()
    {
        Clicking = FindObjectOfType<Clicking>();
        Power += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        Cookies = Clicking.Cookies;
        Price = 10 * Power;
        Clicking.Power = Power;
    }

    private void OnMouseDown()
    {
        if (Cookies >= Price)
        {
            Cookies -= Price;
            Clicking.Cookies = Cookies;
            Power++;
            Clicking.Score_Text.text = "Cookies : " + Cookies;

        }
    }
    

}
