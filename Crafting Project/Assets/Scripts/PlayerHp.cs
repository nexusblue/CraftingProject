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


    private void OnTriggerStay(Collider other ){
        if (other.gameObject.tag == "FireArea") {
            health -= 1 * Time.deltaTime;
        }
        if (other.gameObject.tag == "SafeArea" && health < 100 ){
            health +=  3 * Time.deltaTime;
        }

    }



    // Update is called once per frame
    void Update(){
        Debug.Log("Player HP:" + health);

        if (health > 100) { health = 100; }

    }


}
