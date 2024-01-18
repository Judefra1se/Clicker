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
    public int PowerAutoclic;

    // Start is called before the first frame update
    void Start()
    {
        Clicking = FindObjectOfType<Clicking>();
        PowerAutoclic += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        Cookies = Clicking.Cookies;
        Price = 10 * PowerAutoclic;
        Clicking.PowerAutoclic = PowerAutoclic;
    }

    private void OnMouseDown()
    {
        if (Cookies >= Price)
        {
            Cookies -= Price;
            Clicking.Cookies = Cookies;
            PowerAutoclic++;
            Clicking.Score_Text.text = "Cookies : " + Cookies;

        }
    }
    

}
