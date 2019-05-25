using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimaiton : MonoBehaviour{

    public float speed = 4;
    public float rotSpeed = 80;
    public float rotation = 0f;
    public float gravity = 8;
    public float jumpUpForce = 10f;
    public float jumpFowardForce = 2f;

    float magnitude;

    public Vector3 jumps;

    Vector3 moveDirect = Vector3.zero;

    CharacterController controller;
    Animator anim;
    Rigidbody playerRb; 

    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        jumps = new Vector3(0, jumpUpForce, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        jumping();
        //getInput();
    }

    private void jumping(){
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded){
            anim.SetTrigger("jumping");
            playerRb.AddForce(jumps * jumpUpForce,ForceMode.Impulse);
            //add force to jump player
        }
    }

    private void movement(){

        //check if controller is on the ground
        if (controller.isGrounded)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");


            Vector3 moveInput = new Vector3(horizontal, 0, vertical);
            magnitude = moveInput.magnitude;
            anim.SetFloat("magnitude", magnitude);
            if (vertical != 0) {
                moveDirect = new Vector3(0, 0, 1);
                moveDirect *= speed;
                moveDirect = transform.TransformDirection(moveDirect);
            }
            rotation += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rotation, 0);
            moveDirect.y -= gravity * Time.deltaTime;
            controller.Move(moveDirect * Time.deltaTime);
        }

    }

    void getInput(){

        if (controller.isGrounded){

        }

    }


}

/*
anim.SetBool("walking", true);
if (Input.GetKey(KeyCode.W))
{
    anim.SetInteger("condition", 1);
    moveDirect = new Vector3(0, 0, 1);
    moveDirect *= speed;
    moveDirect = transform.TransformDirection(moveDirect);


    if (anim.GetBool("throwing") == true){
        return;
    }
    else if (anim.GetBool("thowing") == false){

    }

}
if (Input.GetKeyUp(KeyCode.W))
{
    anim.SetInteger("condition", 0);
    anim.SetBool("walking", false);
    moveDirect = new Vector3(0, 0, 0) * speed;
}
*/
