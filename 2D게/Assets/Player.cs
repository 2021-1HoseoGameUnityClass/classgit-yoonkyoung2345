using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float playerSpeed = 0.1f;
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 vector3 = new Vector3();
        float moveSpeed = h + playerSpeed * Time.deltaTime;
        vector3.x = moveSpeed;

        transform.Translate(vector3);

        if(h<0)
        {
            this.GetComponent<Animator>().SetBool("Walk", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(h==0)
        {
            this.GetComponent<Animator>().SetBool("Walk", false);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("Walk", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}

//다시 여니까 유니티 버그가 있어서
//작동이랑 움직이는 게 안 되네요..!
