using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameclear : MonoBehaviour
{
    [SerializeField] float maxTime = 60f;
    float time;
    Image timeBar;

    void Start()
    {
        timeBar = GetComponent<Image>();
        time = maxTime;
    }


    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timeBar.fillAmount = time / maxTime;
        }
        else
        {
            Debug.Log("Å¬¸®¾î!");
            SceneManager.LoadScene("Start_Scene");
        }
    }

}
