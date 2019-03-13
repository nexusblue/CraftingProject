using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //go to resource script for the enum resource
    public Inventory.ResourceItem resourceType ;
    //public AudioSource pickupSound;

    public void Start()
    {

    }

    //check for player tag and if yes
    //destroy game collectable and add one to inventory 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (resourceType)
            {
                case Inventory.ResourceItem.WOOD:
                    //GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().wood++;
                    break;
                case Inventory.ResourceItem.STONE:
                    //GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().stone++;
                    break;
                case Inventory.ResourceItem.TWINE:
                    //GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().twine++;
                    break;
                case Inventory.ResourceItem.DRAGONSCALE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().dragonScale++;
                    break;
                case Inventory.ResourceItem.MAGICSTONE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().magicStone++;
                    break;
                case Inventory.ResourceItem.GECKO:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().gecko++;
                    break;

            }
            Destroy(gameObject);
        }
    }

}
