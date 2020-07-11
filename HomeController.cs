using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().simulated = false; /// отключаем гравитацию
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().simulated = true;   //// включаем по  гравитацию нажатию
            transform.SetParent(null); /// открепляем от Манипулятора
            GetComponent<SpriteRenderer>().sortingOrder = -1;
        }
    }
}
