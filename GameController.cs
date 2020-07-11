using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   

    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneManager.LoadScene("Finish");
    }
    float points;

    // Update is called once per frame
    void Update()
    {
        List<GameObject> home = GameObject.FindGameObjectsWithTag("Home").ToList();
        if (home.Count > 1)
            GameStates.maxHeight = home.OrderBy(o => o.transform.position.y).ToList()[home.Count - 2].transform.position.y;
        else
            GameStates.maxHeight = 0;

        GameStates.points = home.Count; 
    }
}
