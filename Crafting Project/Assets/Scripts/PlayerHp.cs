using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHp : MonoBehaviour
{
    public float startHealth = 100.0f;
    private float health; 
    public Image HealthBar;
    public float playerDmg = 7;
    public float playerHeal = 15;

    // Start is called before the first frame update
    void Start(){
        health = startHealth;
    }

    private void OnTriggerStay(Collider other ){
        if (other.gameObject.tag == "FireArea") {
            health -= playerDmg * Time.deltaTime;
            HealthBar.fillAmount = health / startHealth;
        }
        if (other.gameObject.tag == "SafeArea" && health < 100 ){
            health += playerHeal * Time.deltaTime;
            HealthBar.fillAmount = health / startHealth;
        }

    }

    // Update is called once per frame
    void FixedUpdate(){
        //Debug.Log("Player HP:" + health);
        if (health > 100) {
        health = 100;
             
        }
        if (health <= 0) {
            Destroy(gameObject);
            SceneManager.LoadScene(0);

        }

    }


}
