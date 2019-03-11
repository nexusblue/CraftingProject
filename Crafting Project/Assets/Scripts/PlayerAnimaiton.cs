using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimaiton : MonoBehaviour{

    CharacterController controller;
    Animator anim;

    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        movement();
        //getInput();
    }

    private void movement(){

        //check if controller is on the ground
        if (controller.isGrounded){
            if (Input.GetKey(KeyCode.W)){
                anim.SetBool("walking", true);
                anim.SetInteger("condition", 1);

            }
            if (Input.GetKeyUp(KeyCode.W)){
                anim.SetInteger("condition", 0);
                anim.SetBool("walking", false);

            }
        }

    }

    void getInput(){

        if (controller.isGrounded){

        }

    }

    void throwing(){
        StartCoroutine(throwingRoutine());
    }

    IEnumerator throwingRoutine(){

        yield return new WaitForSeconds(1);
    }
}
