using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public float health = 100.0f;


    // Start is called before the first frame update
    void Start(){
        health = 100.0f;
    }

    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "FireArea") {
            health = health -1;
        }

    }

    // Update is called once per frame
    void Update(){
        Debug.Log("Player Hp: " + health);
    }


}
