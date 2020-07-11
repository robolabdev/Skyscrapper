using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatorController : MonoBehaviour
{

    public GameObject homeToSpawn;
    Vector3 startPos; // cтартовое положение 
    Vector3 newPosition; // новое положение 
    float delta = 9.5f;  // ширина хода 
    float speed = 2.7f;  // скорость
    void Start()
    {
        startPos = transform.position; // стартовое положение манипулятора 
        newPosition = startPos; // создаем переменную в которой будем хранить  новое положение манипултяора
    } 
    void Update()
    { 
       newPosition.x = delta * Mathf.Sin(Time.time * speed); /// Расчет нового положения по оси X
        if (transform.position.y-6.09f - GameStates.maxHeight < 3)
            newPosition.y += 0.06f;  
       transform.position = newPosition; /// расчитываем новую позицию, слава Математике*! 
        if (transform.childCount < 2)
        { 
            StartCoroutine(GenerateNewOne());
        }
    }  

    IEnumerator GenerateNewOne()
    {
        yield return new WaitForSeconds(1);
        if(transform.childCount<2)
        { 
            Instantiate(homeToSpawn, transform);
        }
    } 


}


 