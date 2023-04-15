using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>(); 
        this.animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&this.rigid2D.velocity.y==0) {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("게임오버");
        SceneManager.LoadScene("Start_Scene");
    }

}
