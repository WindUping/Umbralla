using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move : MonoBehaviour
{
    public Vector3 jumpForce = new Vector3(0, 35, 0);
    private Rigidbody mRigidbody;

    //private bool isGrounded = false;

    //public float groundDistance = 0.6f;
    public float moveSpeed = 5.0f;

    void Start()
    {
        this.mRigidbody = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);
        float h = Input.GetAxis("Horizontal");

        moveOn(h);

        // 当刚体静止时，按空格键跳跃才有效
        if (mRigidbody.IsSleeping() && Input.GetKeyDown(KeyCode.Space))
        {
            // 给刚体施加一个力，是其运动起来
            this.mRigidbody.AddForce(jumpForce);
        }

    }

    void moveOn(float h)
    {
        if(h>0)
        {
            this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else if(h<0)
        {
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class move : MonoBehaviour {

//    public float jumpForce = 30.0f;
//    public float moveSpeed = 5.0f;

//    private Rigidbody mRigidbody;

//    private bool isGrounded;
//    private float groundDistance = 0.6f;

//    // Use this for initialization
//    void Start() {
//        mRigidbody = GetComponent<Rigidbody>();
//    }

//    void FixedUpdate()
//    {

//    }

//    // Update is called once per frame
//    void Update() {

//        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);
//        jumpOn(isGrounded);

//        float h = Input.GetAxis("Horizontal");

//        moveOn(h);
//    }

//    void jumpOn(bool isGrounded)
//    {
//        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
//        {
//            mRigidbody.AddForce(Vector3.up*jumpForce);
//        }
//    }

//    void moveOn(float h)
//    {
//        if(h > 0)
//        {
//            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
//        }
//        else if(h < 0)
//        {
//            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
//        }
//    }
//}
