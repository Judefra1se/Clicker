using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour

    
{
    public int Score = 0;
    private SpriteRenderer Renderer;
    public Sprite Right_Paw, Left_Paw;
    private bool isRight;



    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        print(Score);
    }

    private void OnMouseDown()
    {
        Score++;
        ChangePaw();
    }


    public void ChangePaw()
    {
        isRight = !isRight;
        Renderer.sprite = isRight == true ? Right_Paw : Left_Paw;
    }



}
