using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour

    
{
    public int Cookies = 0;
    private SpriteRenderer Renderer;
    public Sprite Right_Paw, Left_Paw;
    private bool isRight;




    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
        StartCoroutine(AutoClic());
    }

    private void Update()
    {
        print(Cookies);
    }

    private void OnMouseDown()
    {
        Cookies++;
        ChangePaw();
    }


    public IEnumerator AutoClic()
    {
        while (true)
        {
            Cookies++;
            ChangePaw();
            yield return new WaitForSeconds(10);
        }
    }

    public void ChangePaw()
    {
        isRight = !isRight;
        Renderer.sprite = isRight == true ? Right_Paw : Left_Paw;
    }



}
