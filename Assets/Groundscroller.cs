using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UIElements;

public class Groundscroller : MonoBehaviour
{
    public SpriteRenderer[] floor;
    public Sprite[] ground;
    SpriteRenderer temp;
    public float speed;
    void Start()
    {
        temp = floor[0];
    }

    void Update()
    {
        for (int i = 0; i < floor.Length; i++)
        {
            if (-8 >= floor[i].transform.position.x)
            {
                for(int q=0; q < floor.Length; q++)
                {
                    if (temp.transform.position.x < floor[q].transform.position.x)
                        temp = floor[q];
                }
                floor[i].transform.position = new Vector2((float)(temp.transform.position.x + 1.4), -1.5f);
                floor[i].sprite = ground[Random.Range(0, ground.Length)];
            }
        }
        for (int i = 0; i < floor.Length; i++)
        {
            floor[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
        }
    }
}
