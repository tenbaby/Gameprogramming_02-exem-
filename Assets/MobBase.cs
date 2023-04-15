using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MobBase : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;
    void Start()
    {
        transform.position = StartPosition;
    }


    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * mobSpeed);

        if (transform.position.x < -8)
        {
            gameObject.SetActive(false);
        }
    }
}
