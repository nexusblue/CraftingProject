using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private GameObject redPotion;
    private GameObject bluePotion;
    private GameObject yellowPotion;

    public Inventory inventScript;

    private Animator anim ;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool haveRedPotion = inventScript.GetComponent<Inventory>().hasPotionRed;
        bool haveBluePotion = inventScript.GetComponent<Inventory>().hasPotionBlue;
        bool haveYellowPotion = inventScript.GetComponent<Inventory>().hasPotionYellow;

        //Debug.Log(haveRedPotion);
       //Debug.Log(haveRedPotion +" " + haveBluePotion + " "+  haveYellowPotion);

        if ( haveRedPotion && haveYellowPotion && haveBluePotion ) {
            anim.enabled = true;
        }
    }
}
