using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2D : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Jumping();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        animator.SetFloat("Speed",Mathf.Abs(moveSpeed));
    }

    void Jumping(){
        if (Input.GetButtonDown("Jump") && isGrounded == true){
              gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,5f), ForceMode2D.Impulse);
        }
    }
}
