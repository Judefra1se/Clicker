using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Clicking Clicking;
    public int Cookies;
    public int Price;
    public int Power;

    // Start is called before the first frame update
    void Start()
    {
        Clicking = FindObjectOfType<Clicking>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Cookies = Clicking.Cookies;
        Price = 100 * Power;
        Clicking.Power = Power;
    }

    public void Upgrade()
    {
        if (Cookies >= Price)
        {
            Cookies -= Price;
            Clicking.Cookies = Cookies;
            Power++;
   
        }
    }
    

}
